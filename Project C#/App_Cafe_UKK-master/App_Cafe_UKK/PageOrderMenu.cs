using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_Cafe_UKK
{
    public partial class PageOrderMenu : Form
    {
        //// DEKLARASI VARIABEL
        string nama;
        Utils util = new Utils();
        // menu
        string sqlCommandAll = "SELECT * FROM tblMenu ORDER BY date_added DESC";
        string id_orderPrivt, nama_menuPrivt, id_menuPrivt, added_byPrivt;
        // cart
        int TotalInt = 0, hargaAkhirInt;
        int selectedRowCart;
        bool selectedRowCartBool = false, canOrder = false, editQtyVisible = false;
        string id_orderPrivtCart, nama_menuPrivtCart, id_menuPrivtCart, added_byPrivtCart;


        DataTable dataTableCart = new DataTable();

        public PageOrderMenu(string U)
        {
            InitializeComponent();

            // Load isi TblCart
            tblCartLoad();

            this.nama = U;

            // Load TblMenu
            tampilDataListMenu(sqlCommandAll);

            // Load Harga Total
            loadHargaTotal();

            // Load nama pelayan kasir
            tampilDataServedBy();
        }

        //// MANUAL METHOD
        private int getHargaWithIdMenu(string idMenu)
        {
            // mencari harga berdasarkan id menu
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT harga FROM tblMenu WHERE id_menu = '"+idMenu+"'", util.koneksi);
            int harga = Convert.ToInt32(util.cmd.ExecuteScalar());
            util.koneksi.Close();

            return harga;
        }

        private void editQty()
        {
            // deklarasi Variabel
            int harga = getHargaWithIdMenu(this.id_menuPrivtCart);
            int qty = Convert.ToInt32(txtEditQty.Text);

            // Proses pengalian sesuai dengan qty
            int hargaQty =  harga * qty;

            // Menghapus data Row/baris di Cart
            deleteSelectedItemCart();
            
            // Hitung total harga
            this.TotalInt = this.TotalInt + hargaQty;

            // Menambahkan data Row/baris di Cart yang telah diedit
            /* DGV SETTING */
            DataRow dataRowCart = dataTableCart.NewRow();

            dataRowCart[0] = this.id_orderPrivtCart; 
            dataRowCart[1] = this.id_menuPrivtCart; 
            dataRowCart[2] = this.nama_menuPrivtCart; 
            dataRowCart[3] = qty;
            dataRowCart[4] = hargaQty; 
            dataRowCart[5] = DateTime.Today.ToString("yyyy-MM-dd"); 
            dataRowCart[6] = this.added_byPrivtCart; 

            dataTableCart.Rows.Add(dataRowCart);

            // Load tampilan Total/Bill
            loadHargaTotal();
        }

        private void tampilDataServedBy()
        {
            lblServedBy.Text = this.nama;
        }

        private void resetForm()
        {
            // Section pnlMenu
            txtSearch.Clear();
            tampilDataListMenu(sqlCommandAll);
            // Section Order
            lblIdOrder.Text = "00000000000";
            txtIdMenu.Clear();
            txtNamaMenu.Clear();
            txtHarga.Clear();
            txtQty.Clear();
            lblHargaAkhir.Text = "0000";
            // Section Cart
            dataTableCart.Clear();
            lblSelectedItem.Text = "No Item Selected";
            lblSelectedItem.ForeColor = Color.Gray;
            // Section Payment
            lblKembali.Visible = false;
            pnlNotif.Visible = false;
            txtNominalPaid.Clear();
            lblTotal.Text = "0";

            // Other components that must be reset
            this.TotalInt = 0;
            selectedRowCartBool = false;
            canOrder = false;
        }

        private void notifDecision(bool decision)
        {
            if (decision == true)
            {
                pnlNotif.Visible = true;
                pbNotif.Image = Properties.Resources.checkmark24;
                lblNotif.Text = "Data Can be Saved, press Save All Cart again to save";
                pnlNotif.BackColor = Color.LightGreen;
            } else if (decision == false)
            {
                pnlNotif.Visible = true;
                pbNotif.Image = Properties.Resources.close24;
                lblNotif.Text = "Data Cannot Be Saved";
                pnlNotif.BackColor = Color.LightCoral;
            }
        }

        private void hitungTotal()
        {
            // Kondisi dimana kita diperbolehkan menyimpan order
            if (this.canOrder)
            {
                // Menyimpan order di tblOrder dijalankan (PROSES MENYIMPAN)
                // Deklarasi variabel
                string id_order = this.id_orderPrivt;
                int total = this.TotalInt;
                int uang_diberi = Convert.ToInt32(txtNominalPaid.Text);
                int id_meja = 1;

                // Proses menyimpan
                foreach (DataRow row in dataTableCart.Rows)
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tblOrder (id_order, id_menu, qty, harga, total, uang_diberi, id_meja, date, added_by) " +
                                                          "VALUES (@id_order, @id_menu, @qty, @harga, @total, @uang_diberi, @id_meja, @date, @added_by)", util.koneksi))
                    {
                        cmd.Parameters.AddWithValue("@id_order", id_order);
                        cmd.Parameters.AddWithValue("@id_menu", row["id_menu"]);
                        cmd.Parameters.AddWithValue("@qty", row["qty"]);
                        cmd.Parameters.AddWithValue("@harga", row["harga"]);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@uang_diberi", uang_diberi);
                        cmd.Parameters.AddWithValue("@id_meja", id_meja);
                        cmd.Parameters.AddWithValue("@date", row["date"]);
                        cmd.Parameters.AddWithValue("@added_by", row["added_by"]);

                        util.koneksi.Open();
                        cmd.ExecuteNonQuery();
                        util.koneksi.Close();
                    }
                }

                // Sesi menyimpan aktifitas ke log aktifitas
                util.koneksi.Open();
                util.saveActivity(this.nama, "KASIR", "ONLINE", "Telah menambahkan order pada order_id #" + id_order, DateTime.Now);
                util.koneksi.Close();

                // Mereset Form
                resetForm();

                // Message success
                MessageBox.Show("Data added successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            // Jika nominal paid kosong
            if (string.IsNullOrEmpty(txtNominalPaid.Text))
            {
                lblKembali.ForeColor = Color.DarkRed;
                lblKembali.Text = "The nominal paid field cannot be empty!";
                lblKembali.Visible = true;
                notifDecision(false);
                return;
            }
            // Jika field bukan nomor
            long number;
            if (!long.TryParse(txtNominalPaid.Text, out number) && !string.IsNullOrEmpty(txtNominalPaid.Text))
            {
                // Not a number
                lblKembali.ForeColor = Color.DarkRed;
                lblKembali.Text = "The content must be a number";
                lblKembali.Visible = true;
                notifDecision(false);
                return;
            }
            // Kondisi jika uang lebih dari Nominal/Kurang dari nominal
            int nominalPaid = Convert.ToInt32(txtNominalPaid.Text);
            if (nominalPaid < this.TotalInt && this.TotalInt != 0)
            {
                int kurang = this.TotalInt - nominalPaid;
                lblKembali.ForeColor = Color.DarkRed;
                lblKembali.Text = "Short " + kurang + ". Total " + this.TotalInt + ".";
                lblKembali.Visible = true;
                notifDecision(false);
                return;
            }
            else if (nominalPaid > this.TotalInt && this.TotalInt != 0)
            {
                this.canOrder = true;
                notifDecision(true);
                int lebih = nominalPaid - this.TotalInt;
                lblKembali.ForeColor = Color.OliveDrab;
                lblKembali.Text = "Change " + lebih;
                lblKembali.Visible = true;
            }
            else if (nominalPaid == this.TotalInt && this.TotalInt != 0)
            {
                this.canOrder = true;
                notifDecision(true);
                lblKembali.ForeColor = Color.OliveDrab;
                lblKembali.Text = "Amount matches. Total "+this.TotalInt+".";
                lblKembali.Visible = true;
            }
        }

        private void deleteSelectedItemCart()
        {
            if (!selectedRowCartBool) // Kondisi jika user belum menekan/memilih menu cart yang akan dihapus
            {
                lblSelectedItem.ForeColor = Color.Red;
                return;
            }

            if (this.selectedRowCart >= 0 && this.selectedRowCart < dataTableCart.Rows.Count)
            {
                // Baris yang ingin dicari valid, ambil DataRow
                DataRow row = dataTableCart.Rows[this.selectedRowCart];

                // Kolom yang ingin dicari ada di DataRow, ambil nilai
                object value = row["harga"];

                int intValue = Convert.ToInt32(value);
                this.TotalInt = TotalInt - intValue;
                loadHargaTotal();

                dgvCart.Rows.RemoveAt(this.selectedRowCart);
                // Clear label
                lblSelectedItem.Text = "No Item Selected";
                this.selectedRowCartBool = false;
                // Clear EditQTY
                txtEditQty.Clear();
                lblEditSelectedItem.Text = "No Item Selected";
                pnlEditQty.SendToBack();
                this.editQtyVisible = false;
            }
        }

        private string getIdFromNama(string nama)
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '" + nama + "'", util.koneksi);
            string id = util.cmd.ExecuteScalar().ToString();
            util.koneksi.Close();
            return id;
        }

        private void tblCartLoad()
        {
            dataTableCart.Columns.Add("id_order");
            dataTableCart.Columns.Add("id_menu");
            dataTableCart.Columns.Add("nama_menu");
            dataTableCart.Columns.Add("qty");
            dataTableCart.Columns.Add("harga");
            dataTableCart.Columns.Add("date");
            dataTableCart.Columns.Add("added_by");

            dgvCart.DataSource = dataTableCart;
        }

        private void loadHargaTotal()
        {
            lblTotal.Text = TotalInt.ToString();
        }

        private void addToCart()
        {
            this.TotalInt = TotalInt + hargaAkhirInt;
            loadHargaTotal();

            /* DGV SETTING */
            DataRow dataRowCart = dataTableCart.NewRow();

            dataRowCart[0] = id_orderPrivt;
            dataRowCart[1] = id_menuPrivt;
            dataRowCart[2] = nama_menuPrivt;
            dataRowCart[3] = txtQty.Text;
            dataRowCart[4] = hargaAkhirInt;
            dataRowCart[5] = DateTime.Today.ToString("yyyy-MM-dd");
            dataRowCart[6] = added_byPrivt;

            dataTableCart.Rows.Add(dataRowCart);

            // Clear textBox QTY
            txtQty.Clear();
        }

        private void alphabetCounter(TextBox txt, Label lbl, int limit)
        {
            // KONDISI JIKA ANGKA lebih dari sama dengan limit
            if (txt.Text.Length >= limit)
            {
                txt.Text = txt.Text.Substring(0, limit); // potong teks yang melebihi batas maksimal
                txt.SelectionStart = txt.Text.Length; // pindahkan cursor ke akhir teks
            }
            int remaining = limit - txt.Text.Length;
            lbl.Text = remaining.ToString() + " remaining";
        }

        private void hitungHargaAkhir()
        {
            // Harga x qty
            int hargaInt = Convert.ToInt32(txtHarga.Text);
            int qtyInt = Convert.ToInt32(txtQty.Text);

            int hargaAkhir = hargaInt * qtyInt;
            this.hargaAkhirInt = hargaAkhir;
            lblHargaAkhir.Text = hargaAkhir.ToString();
        }

        private void retriveData()
        {
            // Deklarasi 
            int baris = dgvLstMenu.CurrentCell.RowIndex;

            // Automatic generate id Order tahun, bulan, hari, random int/angka
            string id_order = util.idGeneratorOrder("id_order", "tblOrder");
            this.id_orderPrivt = id_order;
            lblIdOrder.Text = "#" + id_order;

            // Id_menu
            string id_menu = dgvLstMenu.Rows[baris].Cells[0].Value.ToString();
            this.id_menuPrivt = id_menu;
            txtIdMenu.Text = id_menu;

            // nama_menu
            string nama_menu = dgvLstMenu.Rows[baris].Cells[1].Value.ToString();
            this.nama_menuPrivt = nama_menu;
            txtNamaMenu.Text = nama_menu;

            // harga
            string harga = dgvLstMenu.Rows[baris].Cells[2].Value.ToString();
            txtHarga.Text = harga;

            // label Served by
            lblServedBy.Text = this.nama;
            this.added_byPrivt = getIdFromNama(this.nama);

            // Clear textBox QTY
            txtQty.Clear();
        }

        private string getSqlCommand(string textBox) // string textBox diisi txtSearch.Text
        {
            // Note : 
            // Karena jika variabel dibawah diletakkan di section DEKLARASI VARIABEL,
            // saya kesulitan mengambil data textBox menurut txtSearch,
            // maka saya buatkan method sendiri untuk mengambil textBox disini
            // dan mereturn nilai sqlCommand Itu sendiri :)
            string sqlCommandSearch = "SELECT * FROM tblMenu WHERE id_menu LIKE '%" + textBox + "%' OR nama_menu LIKE '%" + textBox + "%' OR harga LIKE '%" + textBox + "%' OR gambar LIKE '%" + textBox + "%' OR date_added LIKE '%" + textBox + "%' OR added_by LIKE '%" + textBox + "%' ORDER BY date_added DESC";

            return sqlCommandSearch;
        }

        private void tampilDataListMenu(string command)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, util.koneksi);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTableMenu = dataSet.Tables[0];
            dataTableMenu.Columns.Add("Image", typeof(Image));

            foreach (DataRow row in dataTableMenu.Rows)
            {
                //// CODING BIASA UNTUK MENGUBAH UKURAN TETAPI RASIO BERUBAH SEHINGGA GAMBAR TIDAK TERLIHAT SEPERTI ASLINYA (SEPERTI DILEBARKAN ATAU DI MENYUSUT KAN) (PLAN A)
                //// Mengambil path gambar
                //string imagePath = row["gambar"].ToString();
                //// Membuat objek baru sebagai image agar ukuran bisa diubah
                //Image image = Image.FromFile(imagePath);
                //// Merubah ukuran gambar
                //Image resizedImage = image.GetThumbnailImage(200, 200, null, IntPtr.Zero);
                //// Menampilkan hasil resize 
                //row["Image"] = resizedImage;

                //// CODING RINCI MENGENAI RASIO (PLAN B)
                try
                {
                    Image image = Image.FromFile(row["gambar"].ToString());
                    int width = image.Width;
                    int height = image.Height;
                    int newWidth = 200;
                    int newHeight = (height * newWidth) / width;

                    if (newHeight > 200)
                    {
                        newHeight = 200;
                        newWidth = (width * newHeight) / height;
                    }

                    Image resizedImage = new Bitmap(image, newWidth, newHeight);
                    row["Image"] = resizedImage;
                    // Kondisi jika gambar ditemukan
                }
                catch (System.IO.FileNotFoundException)
                {
                    // Jika lokasi gambar tidak ditemukan
                    row["Image"] = Properties.Resources.noImage24;
                }

                //// UNTUK MENGETAHUI HASIL LEBIH JELAS SILAHKAN COBA COMMENT dan UNCOMMENT SALAH SATU PLAN A/B
            }

            dataTableMenu.Columns.Remove("gambar");
            dgvLstMenu.DataSource = dataTableMenu;
            dgvLstMenu.Columns["Image"].DisplayIndex = 0;
        }

        //// FORM CONTROL
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            tampilDataListMenu(sqlCommandAll);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                tampilDataListMenu(sqlCommandAll);
            }
            else
            {
                tampilDataListMenu(getSqlCommand(txtSearch.Text));
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI KOLOM SEARCH MAKA BUTTON OTOMATIS TERTEKAN SEARCH
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI KOLOM SEARCH MAKA BUTTON OTOMATIS TERTEKAN SEARCH
            if (e.KeyCode == Keys.Enter)
            {
                btnAddToCart.PerformClick();
            }
        }

        private void btnDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            deleteSelectedItemCart();
        }

        private void txtNominalPaid_TextChanged(object sender, EventArgs e)
        {
            lblKembali.Visible = false;
            this.canOrder = false;
            pnlNotif.Visible = false;
        }

        private void btnClearAllOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to reset this order form? \nUnsaved data cannot be restored!", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                resetForm();
            }
        }

        private void txtEditQty_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI KOLOM SEARCH MAKA BUTTON OTOMATIS TERTEKAN SEARCH
            if (e.KeyCode == Keys.Enter)
            {
                btnEditQty.PerformClick();
            }
        }

        private void btnEditSelectedItem_Click(object sender, EventArgs e)
        {
            // Jika tidak ada item yang diselect 
            if (lblSelectedItem.Text == "No Item Selected")
            {
                lblSelectedItem.ForeColor = Color.Red;
                return;
            }

            // Kondisi jika panel sedang muncul/tidak
            if (editQtyVisible == true)
            {
                pnlEditQty.SendToBack();
                this.editQtyVisible = false;
                // Mereset isi dari txtEditQty
                txtEditQty.Text = dgvCart.Rows[selectedRowCart].Cells[3].Value.ToString();
            }
            else if (editQtyVisible == false)
            {
                lblEditSelectedItem.Text = lblSelectedItem.Text;
                pnlEditQty.BringToFront();
                this.editQtyVisible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlEditQty.SendToBack();
            // Mereset isi dari txtEditQty
            txtEditQty.Text = dgvCart.Rows[selectedRowCart].Cells[3].Value.ToString();
            this.editQtyVisible = false;
        }

        private void btnEditQty_Click(object sender, EventArgs e)
        {
            editQty();
        }

        private void txtEditQty_TextChanged(object sender, EventArgs e)
        {
            long number;
            if (!long.TryParse(txtEditQty.Text, out number) && !string.IsNullOrEmpty(txtEditQty.Text))
            {
                // Not a number
                lblAlphabetCounterEditQty.Text = "The content must be a number";
                lblAlphabetCounterEditQty.ForeColor = Color.Red;
            }
            else
            {
                lblAlphabetCounterEditQty.ForeColor = Color.Black;
                alphabetCounter(txtEditQty, lblAlphabetCounterEditQty, 4);
            }
        }

        private void btnSaveCart_Click(object sender, EventArgs e)
        {
            hitungTotal();
        }

        private void dgvCart_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedRowCart = dgvCart.CurrentCell.RowIndex;
            // Mengganti label dan mengisi txtEditQty
            lblSelectedItem.Text = dgvCart.Rows[selectedRowCart].Cells[2].Value.ToString();
            txtEditQty.Text = dgvCart.Rows[selectedRowCart].Cells[3].Value.ToString();
            // Untuk deklarasi proses Edit QTY
            this.id_orderPrivtCart = dgvCart.Rows[selectedRowCart].Cells[0].Value.ToString();
            this.id_menuPrivtCart = dgvCart.Rows[selectedRowCart].Cells[1].Value.ToString();
            this.nama_menuPrivtCart = dgvCart.Rows[selectedRowCart].Cells[2].Value.ToString();
            this.added_byPrivtCart = dgvCart.Rows[selectedRowCart].Cells[6].Value.ToString();
            // Mmebuat situasi sudah dipencet true/false
            this.selectedRowCartBool = true;
            lblSelectedItem.ForeColor = Color.Gray;
        }

        private void dgvLstMenu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            retriveData();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            long number;
            if (!long.TryParse(txtQty.Text, out number) && !string.IsNullOrEmpty(txtQty.Text))
            {
                // Not a number
                lblAlphabetCounterQty.Text = "The content must be a number";
                lblAlphabetCounterQty.ForeColor = Color.Red;
            }
            else
            {
                lblAlphabetCounterQty.ForeColor = Color.Black;
                alphabetCounter(txtQty, lblAlphabetCounterQty, 4);
                // Hitung total/Price
                if (string.IsNullOrEmpty(txtQty.Text))
                {
                    label9.ForeColor = Color.Black;
                    lblHargaAkhir.ForeColor = Color.Black;
                    lblHargaAkhir.Text = "0000";
                }
                else if (string.IsNullOrEmpty(txtHarga.Text))
                {
                    label9.ForeColor = Color.Red;
                    lblHargaAkhir.ForeColor = Color.Red;
                    lblHargaAkhir.Text = "Select a menu!";
                }
                else
                {
                    label9.ForeColor = Color.Black;
                    lblHargaAkhir.ForeColor = Color.Black;
                    hitungHargaAkhir();
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Pencegahan JIka terdapat inputan yang tidak diinginkan
            long number;
            if (!long.TryParse(txtQty.Text, out number) && !string.IsNullOrEmpty(txtQty.Text))
            {
                // Not a number
                MessageBox.Show("Field QTY must be a number", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtQty.Text))
            {
                // String kosong
                MessageBox.Show("QTY must be filled", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtHarga.Text))
            {
                label9.ForeColor = Color.Red;
                lblHargaAkhir.ForeColor = Color.Red;
                lblHargaAkhir.Text = "Select a menu!";
                return;
            }

            // Proses Add To Cart di jalankan
            // Cart harus mempunyai isi sbb : (id_order, id_menu, qty, harga, total, uang_diberi, id_meja, date, added_by)
            hitungHargaAkhir();
            addToCart();

            // Mereset label selected item yang berwarna merah
            lblSelectedItem.ForeColor = Color.Gray;
        }
    }
}
