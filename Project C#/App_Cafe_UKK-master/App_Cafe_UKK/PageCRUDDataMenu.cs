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
    public partial class PageCRUDDataMenu : Form
    {
        //// DEKLARASI VARIABLE
        Utils util = new Utils();
        string gambarPrivt;

        public PageCRUDDataMenu()
        {
            InitializeComponent();

            tampilData();
        }

        //// MANUAL METHOD
        private void refreshInfo()
        {
            pnlMenuInfo.Enabled = false;
            lblIdMenu.Text = "#M000";
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            pbImage.Image = Properties.Resources.noImage100;
            lblMenuName.Text = "Menu Name";
            lblPrice.Text = "9999999";
        }

        private void retriveData()
        {
            //// NEXT MEMBUAT DATA YANG MENAMPILKAN DI PANEL INFO
            int baris = dgvDataMenu.CurrentCell.RowIndex;

            // ID_MENU
            string id_menu = dgvDataMenu.Rows[baris].Cells[0].Value.ToString();
            lblIdMenu.Text = "#" + id_menu;
            // NAMA_MENU
            string nama_menu = dgvDataMenu.Rows[baris].Cells[1].Value.ToString();
            lblMenuName.Text = nama_menu;
            // HARGA
            string harga = dgvDataMenu.Rows[baris].Cells[2].Value.ToString();
            lblPrice.Text = harga;
            // GAMBAR
            string gambar = dgvDataMenu.Rows[baris].Cells[3].Value.ToString();
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.ImageLocation = gambar;
            this.gambarPrivt = gambar;

            pnlMenuInfo.Enabled = true;
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

        private void dgvDataMenu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            retriveData();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            ShowImage dialogImage = new ShowImage(gambarPrivt);
            dialogImage.ShowDialog();
        }
    }
}
