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
    public partial class PageCRUDDataUser : Form
    {
        //// DEKLARASI VARIABEL
        bool info = true;
        Utils util = new Utils();

        public PageCRUDDataUser()
        {
            InitializeComponent();
            tampilData();
        }

        //// FORM METHOD USER
        
        private void checkNullInfo(string data, Label lblData)
        {
            if (data == null || string.IsNullOrEmpty(data))
            {
                lblData.Text = "*Belum diisi";
            }
            else
            {
                lblData.Text = data;
            }
        }

        private void retriveData()
        {
            //// NEXT MEMBUAT DATA YANG MENAMPILKAN DI PANEL INFO
            int baris = dgvDataUser.CurrentCell.RowIndex;

            // ID_KARYAWAN
            string id_karyawan = dgvDataUser.Rows[baris].Cells[0].Value.ToString();
            lblId.Text = "#" + id_karyawan;
            // USERNAME
            string username = dgvDataUser.Rows[baris].Cells[1].Value.ToString();
            lblUsername.Text = username;
            // POSISI
            string posisi = dgvDataUser.Rows[baris].Cells[2].Value.ToString();
            lblPosisi.Text = posisi;
            // STATUS 
            string status = dgvDataUser.Rows[baris].Cells[3].Value.ToString();
            if (status == "ONLINE")
            {
                lblStatus.ForeColor = Color.OliveDrab;
            }
            else if (status == "OFFLINE")
            {
                lblStatus.ForeColor = Color.Red;
            }
            lblStatus.Text = status;
            // ALAMAT
            string alamat = dgvDataUser.Rows[baris].Cells[4].Value.ToString();
            checkNullInfo(alamat, lblAlamat);
            // NO_TELP
            string no_telp = dgvDataUser.Rows[baris].Cells[5].Value.ToString();
            checkNullInfo(no_telp, lblNoTelp);
            // TANGGAL LAHIR
            DateTime tglLahir;
            if (DateTime.TryParse(dgvDataUser.Rows[baris].Cells[6].Value.ToString(), out tglLahir))
            {
                dtpTanggalLahir.Value = tglLahir;
            }
            else
            {
                dtpTanggalLahir.Value = DateTime.Today;
            }
            // GENDER
            string gender = dgvDataUser.Rows[baris].Cells[7].Value.ToString();
            checkNullInfo(gender, lblKelamin);
            // DESKRIPSI
            string deskripsi = dgvDataUser.Rows[baris].Cells[8].Value.ToString();
            checkNullInfo(deskripsi, lblDeskripsi);
            // PICTURE BOX
            if (posisi == "ADMIN")
            {
                pbProfile.Image = Properties.Resources.Admin512;
            }
            else if (posisi == "MANAJER")
            {
                pbProfile.Image = Properties.Resources.Manajer512;
            }
            else if (posisi == "KASIR")
            {
                pbProfile.Image = Properties.Resources.Kasir512;
            }
            else
            {
                pbProfile.Image = null;
            }
        }

        private void searchData(string data)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id_karyawan, username, posisi, status, alamat, no_telp, tanggal_lahir, gender, deskripsi, added_by, date_added FROM tblKaryawan WHERE username LIKE '%" + data + "%' OR id_karyawan LIKE '%" + data + "%' OR posisi LIKE '%" + data + "%' OR status LIKE '%" + data + "%' OR alamat LIKE '%" + data + "%' OR no_telp LIKE '%" + data + "%' OR tanggal_lahir LIKE '%" + data + "%' OR gender LIKE '%" + data + "%' OR deskripsi LIKE '%" + data + "%' OR date_added LIKE '%" + data + "%' OR added_by LIKE '%" + data + "%'", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvDataUser.DataSource = dataSet.Tables[0];
        }

        private void tampilData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id_karyawan, username, posisi, status, alamat, no_telp, tanggal_lahir, gender, deskripsi, added_by, date_added FROM tblKaryawan", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvDataUser.DataSource = dataSet.Tables[0];
        }

        //// FORM CONTROL
        private void button1_Click(object sender, EventArgs e)
        {
            timerInfo.Start();
        }

        private void timerInfo_Tick(object sender, EventArgs e)
        {
            if (info)
            {
                pnlInfo.Width += 40;
                pnlInfo.Left -= 40;
                if (pnlInfo.Location.X <= 710)
                {
                    timerInfo.Stop();
                    this.info = false;
                }
            }
            else
            {
                pnlInfo.Left += 40;
                pnlInfo.Width -= 40;

                if (pnlInfo.Width == pnlInfo.MinimumSize.Width)
                {
                    timerInfo.Stop();
                    this.info = true;
                }
            }
        }

        private void btnCloseInfo_Click(object sender, EventArgs e)
        {
            timerInfo.Start();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.info == true)
            {
                timerInfo.Start();
            }
            retriveData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampilData();
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblDangerSearch.Visible = false;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI KOLOM SEARCH MAKA BUTTON OTOMATIS TERTEKAN SEARCH
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
