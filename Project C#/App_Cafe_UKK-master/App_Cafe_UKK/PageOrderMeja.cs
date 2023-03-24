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
    public partial class PageOrderMeja : Form
    {
        //// DEKLARASI VARIABEL
        Utils util = new Utils();
        DataTable dataTableSelectedMeja = new DataTable();
        string nama;

        public PageOrderMeja(string U)
        {
            InitializeComponent();

            this.nama = U;
            tampilComboBox();
            tampilDataMeja();
            tampilDataMeja2();
            dataTable2Load();
            tampilDataServedBy();
        }

        //// MANUAL METHOD
        private string getIdFromNama(string nama)
        {
            util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '" + nama + "'", util.koneksi);
            string id = util.cmd.ExecuteScalar().ToString();
            return id;
        }

        private void clearDgvPreview()
        {
            while (dgvOrderPreview.Rows.Count > 0)
            {
                dgvOrderPreview.Rows.RemoveAt(0);
            }
        }

        private void tampilDataServedBy()
        {
            lblServedBy.Text = this.nama;
        }

        private void emptyTheTable()
        {
            // JIka kondisi dataTable kosong/tidak ada isinya
            if (dataTableSelectedMeja.Rows.Count == 0)
            {
                MessageBox.Show("No tables cleared", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Deklarasi var
            string id_meja = dgvSelectedMeja.Rows[0].Cells[0].Value.ToString();
            string status = dgvSelectedMeja.Rows[0].Cells[2].Value.ToString();
            string id_order = dgvSelectedMeja.Rows[0].Cells[3].Value.ToString();

            // Update data meja yang sedang digunakan menjadi dikosongkan
            util.koneksi.Open();
            util.cmd = new SqlCommand("UPDATE tblMeja SET status = 'KOSONG' WHERE id_meja = '" + id_meja + "'", util.koneksi);
            
            // Jika status meja yang dipilih memang sudah kosong
            if (status == "KOSONG")
            {
                MessageBox.Show("This table is already empty.\n\nNothing changed", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                util.koneksi.Close();
                return;
            }
            
            util.cmd.ExecuteNonQuery();
            MessageBox.Show("The table was successfully cleared.\n\nNow the table can be used.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Proses update order yang menggunakan meja akan dikosongkan
            util.cmd = new SqlCommand("UPDATE tblOrder SET id_meja = '1' WHERE id_order = '" + id_order + "'", util.koneksi);
            util.cmd.ExecuteNonQuery();

            util.koneksi.Close();
        }

        private void retriveDataTable()
        {
            int baris = dgvDataMeja2.CurrentCell.RowIndex;
            DataRow dataRowTable = dataTableSelectedMeja.NewRow();

            // Clear dataTable dulu
            dataTableSelectedMeja.Clear();

            // Lalu menambahkan data
            for (int i = 0; i < dgvDataMeja2.Columns.Count; i++)
            {
                if (dgvDataMeja2.Rows[baris].Cells[i].Value != null)
                {
                    dataRowTable[i] = dgvDataMeja2.Rows[baris].Cells[i].Value.ToString();
                }
                else
                {
                    dataRowTable[i] = DBNull.Value; // Menambahkan nilai null jika data kosong
                }
            }

            dataTableSelectedMeja.Rows.Add(dataRowTable); // Menambahkan DataRow ke DataTable
        }

        private void dataTable2Load()
        {
            dataTableSelectedMeja.Columns.Add("id_meja");
            dataTableSelectedMeja.Columns.Add("no_meja");
            dataTableSelectedMeja.Columns.Add("status");
            dataTableSelectedMeja.Columns.Add("id_order");
            dataTableSelectedMeja.Columns.Add("total");
            dataTableSelectedMeja.Columns.Add("added_by");
            dataTableSelectedMeja.Columns.Add("username");
            dataTableSelectedMeja.Columns.Add("date_added");

            dgvSelectedMeja.DataSource = dataTableSelectedMeja;
        }

        private void tampilDataMeja2()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT DISTINCT tblMeja.id_meja, tblMeja.no_meja, tblMeja.status, tblOrder.id_order, tblOrder.total, tblOrder.added_by, tblKaryawan.username as username, tblOrder.date as date_added FROM tblMeja LEFT JOIN tblOrder ON tblMeja.id_meja = tblOrder.id_meja LEFT JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan WHERE tblMeja.status = 'DIGUNAKAN' OR tblMeja.status = 'KOSONG'", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dgvDataMeja2.DataSource = dataSet.Tables[0];
        }

        private void tampilOrderPreview()
        {
            if (string.IsNullOrEmpty(cbIdOrder.Text))
            {
                return;
            }

            // Deklarasi var
            string id_order = cbIdOrder.Text;

            string sqlCommand = "SELECT tblOrder.id_menu, tblMenu.nama_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.id_meja, tblOrder.date, tblOrder.added_by, tblMenu.gambar FROM tblOrder INNER JOIN tblMenu ON tblOrder.id_menu = tblMenu.id_menu WHERE id_order = '" + id_order+"'";
            tampilDataIdOrder(sqlCommand);
        }

        private void tampilDataIdOrder(string command)
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
            dgvOrderPreview.DataSource = dataTableMenu;
            dgvOrderPreview.Columns["Image"].DisplayIndex = 0;
        }

        private void tampilDataMeja()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblMeja", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dgvDataMeja.DataSource = dataSet.Tables[0];
        }

        private void saveDataTable()
        {
            if (string.IsNullOrEmpty(cbIdOrder.Text) || string.IsNullOrEmpty(cbNoMeja.Text))
            {
                if (string.IsNullOrEmpty(cbIdOrder.Text))
                {
                    dangerIdOrder.Visible = true;
                }
                if (string.IsNullOrEmpty(cbNoMeja.Text))
                {
                    dangerNoMeja.Visible = true;
                }

                return;
            }

            // Deklarasi variabel 
            // ID ORDER
            string id_order = cbIdOrder.Text;
            // ID MEJA
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT id_meja FROM tblMeja WHERE no_meja = '"+cbNoMeja.Text+"'", util.koneksi);
            int id_meja = Convert.ToInt32(util.cmd.ExecuteScalar());
            util.koneksi.Close();

            // Proses pengubahan/update meja di id_order
            util.koneksi.Open();
            util.cmd = new SqlCommand("UPDATE tblOrder SET id_meja = '"+id_meja+"' WHERE id_order = '"+id_order+"'", util.koneksi);
            util.cmd.ExecuteNonQuery();
            util.koneksi.Close();

            // Proses update status meja
            util.koneksi.Open();
            util.cmd = new SqlCommand("UPDATE tblMeja SET status = 'DIGUNAKAN' WHERE id_meja = '"+id_meja+"'", util.koneksi);
            util.cmd.ExecuteNonQuery();
            util.koneksi.Close();

            // Refresh page
            tampilComboBox();
            tampilDataMeja();

            MessageBox.Show("The table has been saved to the selected order data.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void tampilComboBox()
        {
            // UNTUK COMBO BOX ID ORDER
            // Clear ComboBox Terlebih dahulu
            cbIdOrder.Items.Clear();
            // Proses penampilan data
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT DISTINCT id_order, date FROM tblOrder WHERE added_by = '" + getIdFromNama(this.nama) + "' ORDER BY date DESC, id_order DESC", util.koneksi);;
            SqlDataReader reader = util.cmd.ExecuteReader();
            while (reader.Read())
            {
                cbIdOrder.Items.Add(reader["id_order"].ToString());
            }

            // MENUTUP READER UNTUK MEMBUAT READER BARU
            reader.Dispose();

            // UNTUK COMBO BOX NO MEJA
            // Clear ComboBox Terlebih dahulu
            cbNoMeja.Items.Clear();
            // Proses penampilan data
            util.cmd = new SqlCommand("SELECT no_meja FROM tblMeja WHERE status = 'KOSONG'", util.koneksi);
            reader = util.cmd.ExecuteReader();
            while (reader.Read())
            {
                cbNoMeja.Items.Add(reader["no_meja"].ToString());
            }
            util.koneksi.Close();
        }

        //// FORM CONTROL
        private void btnManageMeja_Click(object sender, EventArgs e)
        {
            tampilDataMeja2();
            pnlManageMeja.BringToFront();
        }

        private void btnOrderMeja_Click(object sender, EventArgs e)
        {
            tampilDataMeja();
            tampilComboBox();
            pnlOrderMeja.BringToFront();
            clearDgvPreview();
        }

        private void btnSaveDataTable_Click(object sender, EventArgs e)
        {
            saveDataTable();
            clearDgvPreview();
        }

        private void cbIdOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            dangerIdOrder.Visible = false;
            tampilOrderPreview();
        }

        private void cbNoMeja_SelectedIndexChanged(object sender, EventArgs e)
        {
            dangerNoMeja.Visible = false;
        }

        private void dgvDataMeja2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            retriveDataTable();
        }

        private void btnEmptyTable_Click(object sender, EventArgs e)
        {
            // Apakah anda yakin?
            DialogResult result = MessageBox.Show("Are you sure you want to delete the order from this table?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            emptyTheTable();
            tampilDataMeja2();
            dataTableSelectedMeja.Clear();
        }
    }
}
