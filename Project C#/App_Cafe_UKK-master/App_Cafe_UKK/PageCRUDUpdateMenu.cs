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
    public partial class PageCRUDUpdateMenu : Form
    {
        //// DEKLARASI VARIABEL
        Utils util = new Utils();
        string nama, gambarDelete, id_menuPrivt, nama_menuPrivt, hargaPrivt;

        public PageCRUDUpdateMenu(string U)
        {
            InitializeComponent();

            tampilData();
            this.nama = U;
        }

        //// MANUAL METHOD
        private void deleteData()
        {
            // MENGHAPUS di database
            util.koneksi.Open();
            util.cmd = new SqlCommand("DELETE FROM tblMenu WHERE id_menu = '" + id_menuPrivt + "'", util.koneksi);
            util.cmd.ExecuteNonQuery();

            // MENGHAPUS GAMBAR SEBELUMNYA yang sudah ada
            string targetPathDelete = Path.Combine(Application.StartupPath, @"Images\" + Path.GetFileName(gambarDelete));
            File.Delete(targetPathDelete);

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "MANAGER", "ONLINE", "Telah menghapus data Menu " + nama_menuPrivt + "", DateTime.Now);
            util.koneksi.Close();
        }

        private void clearFieldUpdate()
        {

            txtIdMenu.Text = "Auto Generated";
            txtMenuName.Clear();
            txtPrice.Clear();
            txtImage.Clear();
            pbImageUpdate.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImageUpdate.Image = Properties.Resources.noImage100;
            dangerMenuName.Visible = false;
            dangerPriceIcon.Visible = false;
            dangerPrice.Visible = false;
            dangerImage.Visible = false;
        }

        private void submitUpdate(string id_menu, string nama_menu, string harga, string gambarUpdate)
        {
            //// Memastikan jika tidak ada field yang tidak diinginkan!
            // Memastikan jika nama sudah dipakai pada database (terdapat duplikat)
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(nama_menu) FROM tblMenu WHERE nama_menu = '" + nama_menu + "' AND id_menu NOT IN ('" + id_menu + "')", util.koneksi);
            int result = Convert.ToInt32(util.cmd.ExecuteScalar());
            util.koneksi.Close();

            if (string.IsNullOrEmpty(nama_menu) || string.IsNullOrEmpty(harga) || string.IsNullOrEmpty(gambarUpdate) || result > 0)
            {
                if (string.IsNullOrEmpty(nama_menu))
                {
                    dangerMenuName.Text = "This field is required";
                    dangerMenuName.Visible = true;
                    lblAlphabetCounterMenuName.Visible = false;
                }
                if (string.IsNullOrEmpty(harga))
                {
                    dangerPriceIcon.Visible = true;
                    dangerPrice.Visible = true;
                }
                if (string.IsNullOrEmpty(gambarUpdate))
                {
                    dangerImage.Visible = true;
                }
                if (result > 0)
                {
                    dangerMenuName.Text = "Name already taken";
                    dangerMenuName.TextAlign = ContentAlignment.MiddleRight;
                    lblAlphabetCounterMenuName.Visible = false;
                    dangerMenuName.Visible = true;
                }
                return;
            }

            DialogResult resultDialog = MessageBox.Show("Are you sure to continue?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultDialog == DialogResult.No)
            {
                return;
            }

            // Jika semua data tidak ada perubahan
            if (this.id_menuPrivt == txtIdMenu.Text && this.nama_menuPrivt == txtMenuName.Text && this.hargaPrivt == txtPrice.Text && this.gambarDelete == txtImage.Text)
            {
                MessageBox.Show("No data has changed", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFieldUpdate();
                refreshInfo();
                tampilData();

                pnlUpdateMain.BringToFront();
                return;
            }

            // MENGHAPUS GAMBAR SEBELUMNYA yang sudah ada
            string targetPathDelete = Path.Combine(Application.StartupPath, @"Images\" + Path.GetFileName(gambarDelete));

            // Jika file sebelumnya tidak ditemukan maka tidak ada yang dihapus
            if (File.Exists(targetPathDelete))
            {
                // Jika gambar ditemukan 
                File.Delete(targetPathDelete);
            }

            // MENYIMPAN ke folder aplikasi Images/(namaGambar)
            string targetPathUpdate = Path.Combine(Application.StartupPath, @"Images\" + Path.GetFileName(gambarUpdate));
            File.Copy(gambarUpdate, targetPathUpdate, true);

            // Proses Memperbarui data
            util.koneksi.Open();
            util.cmd = new SqlCommand("UPDATE tblMenu SET nama_menu = @nama_menu, harga = @harga, gambar = @gambar WHERE id_menu = @id_menu", util.koneksi);
            util.cmd.Parameters.AddWithValue("nama_menu", nama_menu);
            util.cmd.Parameters.AddWithValue("harga", harga);
            util.cmd.Parameters.AddWithValue("gambar", targetPathUpdate);
            util.cmd.Parameters.AddWithValue("id_menu", id_menu);
            util.cmd.ExecuteNonQuery();

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "MANAGER", "ONLINE", "Telah memperbarui data Menu " + nama_menu, DateTime.Now);

            util.koneksi.Close();

            MessageBox.Show("Success, data successfully changed", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearFieldUpdate();
            refreshInfo();
            tampilData();

            pnlUpdateMain.BringToFront();
        }

        private void imageOpen()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.InitialDirectory = @"C:\Pictures\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = openFileDialog.FileName;
                pbImageUpdate.SizeMode = PictureBoxSizeMode.Zoom;
                pbImageUpdate.Image = Image.FromFile(openFileDialog.FileName);
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

        private void refreshInfo()
        {
            pnlSelectedItem.Enabled = false;
            lblIdMenu.Text = "M000";
            pbImageMain.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImageUpdate.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImageMain.Image = Properties.Resources.noImage100;
            pbImageUpdate.Image = Properties.Resources.noImage100;
            lblMenuName.Text = "Menu Name";
            lblPrice.Text = "9999999";
        }

        private void retriveData()
        {
            //// NEXT MEMBUAT DATA YANG MENAMPILKAN DI PANEL INFO
            int baris = dgvDataMenu.CurrentCell.RowIndex;

            // PANEL MAIN //
            // ID_MENU
            string id_menu = dgvDataMenu.Rows[baris].Cells[0].Value.ToString();
            lblIdMenu.Text = "#" + id_menu;
            this.id_menuPrivt = id_menu;
            // NAMA_MENU
            string nama_menu = dgvDataMenu.Rows[baris].Cells[1].Value.ToString();
            lblMenuName.Text = nama_menu;
            this.nama_menuPrivt = nama_menu;
            // HARGA
            string harga = dgvDataMenu.Rows[baris].Cells[2].Value.ToString();
            lblPrice.Text = harga;
            this.hargaPrivt = harga;
            // GAMBAR
            string gambar = dgvDataMenu.Rows[baris].Cells[3].Value.ToString();
            pbImageMain.SizeMode = PictureBoxSizeMode.Zoom;
            pbImageMain.ImageLocation = gambar;

            // PANEL UPDATE //
            // ID_MENU
            txtIdMenu.Text = id_menu;
            // NAMA_MENU
            txtMenuName.Text = nama_menu;
            // HARGA
            txtPrice.Text = harga;
            // GAMBAR
            txtImage.Text = gambar;
            pbImageUpdate.SizeMode = PictureBoxSizeMode.Zoom;
            pbImageUpdate.ImageLocation = gambar;

            // Menyimpan gambar yang nantinya akan dihapus pada saat mengupdate data
            this.gambarDelete = gambar;

            
            pnlSelectedItem.Enabled = true;
        }

        private void searchData(string data)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblMenu WHERE id_menu LIKE '%" + data + "%' OR nama_menu LIKE '%" + data + "%' OR harga LIKE '%" + data + "%' OR gambar LIKE '%" + data + "%' OR date_added LIKE '%" + data + "%' OR added_by LIKE '%" + data + "%'", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvDataMenu.DataSource = dataSet.Tables[0];
        }

        private void tampilData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblMenu", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvDataMenu.DataSource = dataSet.Tables[0];

        }

        //// FORM CONTROL
        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            pnlUpdateChild.BringToFront();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this edit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                refreshInfo();
                pnlUpdateMain.BringToFront();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblDangerSearch.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                lblDangerSearch.Visible = true;
            }
            else
            {
                searchData(txtSearch.Text);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampilData();
            refreshInfo();
            lblDangerSearch.Visible = false;
        }

        private void dgvDataUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            retriveData();
        }

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

        private void pbImageUpdate_Click(object sender, EventArgs e)
        {
            ShowImage image = new ShowImage(txtImage.Text);
            image.ShowDialog();
        }

        private void btnImageOpen_Click(object sender, EventArgs e)
        {
            imageOpen();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            deleteData();
            MessageBox.Show("Data has been successfully deleted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshInfo();
            tampilData();
            pnlSelectedItem.Enabled = false;
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            submitUpdate(txtIdMenu.Text, txtMenuName.Text, txtPrice.Text, txtImage.Text);
        }
    }
}
