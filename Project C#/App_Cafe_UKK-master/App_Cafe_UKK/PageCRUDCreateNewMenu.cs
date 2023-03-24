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
using System.IO;

namespace App_Cafe_UKK
{
    public partial class PageCRUDCreateNewMenu : Form
    {
        //// DEKLARASI VARIABEL 
        Utils util = new Utils();
        string nama;

        public PageCRUDCreateNewMenu(string U)
        {
            InitializeComponent();

            this.nama = U;
        }

        //// MANUAL METHOD

        private void imageOpen()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.InitialDirectory = @"C:\Pictures\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = openFileDialog.FileName;
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;
                pbImage.Image = Image.FromFile(openFileDialog.FileName);
            }
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

        private void clearFieldNewMenu()
        {
            txtMenuName.Clear();
            txtPrice.Clear();
            txtImage.Clear();
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.Image = Properties.Resources.noImage100;
            dangerMenuName.Visible = false;
            dangerImage.Visible = false;
            dangerPriceIcon.Visible = false;
            dangerPrice.Visible = false;
            lblAlphabetCounterMenuName.Visible = true;
        }

        private void submitCreate()
        {
            //// Memastikan jika tidak ada field yang tidak diinginkan!
            // Memastikan jika nama sudah dipakai pada database (terdapat duplikat)
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(nama_menu) FROM tblMenu WHERE nama_menu = '" + txtMenuName.Text + "'", util.koneksi);
            int result = Convert.ToInt32(util.cmd.ExecuteScalar());
            util.koneksi.Close();
            long number;
            if (string.IsNullOrEmpty(txtMenuName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtImage.Text) ||  result > 0 || (!long.TryParse(txtPrice.Text, out number) && !string.IsNullOrEmpty(txtPrice.Text)))
            {
                if (string.IsNullOrEmpty(txtMenuName.Text))
                {
                    dangerMenuName.Text = "This field is required";
                    dangerMenuName.Visible = true;
                    lblAlphabetCounterMenuName.Visible = false;
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    dangerPrice.Text = "This field is required";
                    dangerPriceIcon.Visible = true;
                    dangerPrice.Visible = true;
                }
                if (string.IsNullOrEmpty(txtImage.Text))
                {
                    dangerImage.Visible = true;
                }
                if (result > 0)
                {
                    // Already Taken
                    dangerMenuName.Text = "Name already taken";
                    dangerMenuName.TextAlign = ContentAlignment.MiddleRight;
                    dangerMenuName.Visible = true;
                    lblAlphabetCounterMenuName.Visible = false;
                }
                if (!long.TryParse(txtPrice.Text, out number) && !string.IsNullOrEmpty(txtPrice.Text))
                {
                    // Not a number
                    dangerPrice.Text = "The content must be a number";
                    dangerPriceIcon.Visible = true;
                    dangerPrice.Visible = true;
                }
                return;
            }
            // PROSES MENYIMPAN DATA //
            // Variabel Deklarasi 
            string id_menu = util.idGenerator("id_menu", "tblMenu", "M");
            string nama_menu = txtMenuName.Text;
            string harga = txtPrice.Text;
            string gambar = txtImage.Text;
            DateTime date_added = DateTime.Now;

            // Mencari id_karyawan berdasarkan added by
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '" + this.nama + "'", util.koneksi);
            string added_by = util.cmd.ExecuteScalar().ToString();
            util.koneksi.Close();

            // MENYIMPAN ke folder aplikasi Images/(namaGambar)
            string targetPath = Path.Combine(Application.StartupPath, @"Images\" + Path.GetFileName(gambar));
            File.Copy(gambar, targetPath, true);

            // PROSES INSERT KE TBLMENU
            util.koneksi.Open();
            util.cmd = new SqlCommand("INSERT INTO tblMenu VALUES (@id_menu, @nama_menu, @harga, @gambar, @date_added, @added_by)", util.koneksi);
            util.cmd.Parameters.AddWithValue("id_menu", id_menu);
            util.cmd.Parameters.AddWithValue("nama_menu", nama_menu);
            util.cmd.Parameters.AddWithValue("harga", harga);
            util.cmd.Parameters.AddWithValue("gambar", targetPath);
            util.cmd.Parameters.AddWithValue("date_added", date_added);
            util.cmd.Parameters.AddWithValue("added_by", added_by);
            util.cmd.ExecuteNonQuery();

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "MANAGER", "ONLINE", "Telah menambahkan menu bernama " + nama_menu, DateTime.Now);

            util.koneksi.Close();
            MessageBox.Show("Data added successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MENAMPILKAN PANEL SUKSES
            pnlSuccess.Visible = true;
            // MENGHAPUS TEXTFIELD DEFAULT
            clearFieldNewMenu();
        }

        //// FORM CONTROL
        private void pbHintId_MouseEnter(object sender, EventArgs e)
        {
            pnlHintId.Visible = true;
        }

        private void pbHintId_MouseLeave(object sender, EventArgs e)
        {
            pnlHintId.Visible = false;
        }

        private void txtMenuName_TextChanged(object sender, EventArgs e)
        {
            dangerMenuName.Visible = false;


            lblAlphabetCounterMenuName.Visible = true;
            alphabetCounter(txtMenuName, lblAlphabetCounterMenuName, 100);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            long number;
            if (!long.TryParse(txtPrice.Text, out number) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                // Not a number
                dangerPrice.Text = "The content must be a number";
                dangerPriceIcon.Visible = true;
                dangerPrice.Visible = true;
            }
            else
            {
                dangerPriceIcon.Visible = false;
                dangerPrice.Visible = false;
            }
        }

        private void txtImage_TextChanged(object sender, EventArgs e)
        {
            dangerImage.Visible = false;
        }

        private void btnImageOpen_Click(object sender, EventArgs e)
        {
            imageOpen();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFieldNewMenu();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            submitCreate();
        }

        private void btnHidePnl_Click(object sender, EventArgs e)
        {
            pnlSuccess.Visible = false;
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImage.Text))
            {
                return;
            }
            ShowImage dialogImage = new ShowImage(txtImage.Text);
            dialogImage.ShowDialog();
        }
    }
}
