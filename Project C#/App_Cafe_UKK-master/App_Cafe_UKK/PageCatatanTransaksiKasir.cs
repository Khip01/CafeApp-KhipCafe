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
using System.Drawing.Printing;

namespace App_Cafe_UKK
{
    public partial class PageCatatanTransaksiKasir : Form
    {
        //// DEKLARASI VARIABEL
        bool info = true;
        Utils util = new Utils();
        string nama, idOrder;

        public PageCatatanTransaksiKasir(string U)
        {
            InitializeComponent();

            this.nama = U;
            tampilData();
        }


        //// FORM METHOD USER
        private string getIdFromNama(string nama)
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '" + nama + "'", util.koneksi);
            string id = util.cmd.ExecuteScalar().ToString();
            util.koneksi.Close();
            return id;
        }

        private void retriveData()
        {
            //// NEXT MEMBUAT DATA YANG MENAMPILKAN DI PANEL INFO
            int baris = dgvCatatanTransaksi.CurrentCell.RowIndex;

            // ID_ORDER
            string id_order = dgvCatatanTransaksi.Rows[baris].Cells[0].Value.ToString();
            this.idOrder = id_order;
            lblId.Text = "#" + id_order;
            // SERVED BY
            string served_by = dgvCatatanTransaksi.Rows[baris].Cells[8].Value.ToString();
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT username FROM tblKaryawan WHERE id_karyawan = '" + served_by + "'", util.koneksi);
            string username = util.cmd.ExecuteScalar().ToString();
            util.koneksi.Close();
            lblServedBy.Text = username;
            // HARGA
            int hargaTotal = Convert.ToInt32(dgvCatatanTransaksi.Rows[baris].Cells[4].Value.ToString());
            lblHargaTotal.Text = hargaTotal.ToString() ;
            // NOMINAL DIBAYAR
            int nominal_dibayar = Convert.ToInt32(dgvCatatanTransaksi.Rows[baris].Cells[5].Value.ToString());
            lblNominalDibayar.Text = nominal_dibayar.ToString();;
            // UANG KEMBALI
            int uang_kembali = nominal_dibayar - hargaTotal;
            lblUangKembali.Text = uang_kembali.ToString();
            // DATE
            string date = dgvCatatanTransaksi.Rows[baris].Cells[7].Value.ToString();
            DateTime dateTime = DateTime.Parse(date);
            lblDate.Text = dateTime.ToString("dd/MM/yyyy"); // ganti format tanggal
            // DGVMENU
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblMenu.nama_menu, tblOrder.qty, tblOrder.harga FROM tblOrder INNER JOIN tblMenu ON tblOrder.id_menu = tblMenu.id_menu WHERE tblOrder.id_order = '" + id_order + "'", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dgvMenu.DataSource = dataSet.Tables[0];
        }

        private void searchData(string data, string idKaryawan)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, " +
                                                                "tblMenu.nama_menu, " +
                                                                "tblOrder.qty, " +
                                                                "tblOrder.harga, " +
                                                                "tblOrder.total, " +
                                                                "tblOrder.uang_diberi, " +
                                                                "tblOrder.id_meja, " +
                                                                "tblOrder.date, " +
                                                                "tblOrder.added_by " +
                                                                "FROM " +
                                                                "tblOrder INNER JOIN tblMenu ON tblOrder.id_menu = tblMenu.id_menu " +
                                                                "WHERE " +
                                                                "tblOrder.added_by = '"+idKaryawan+"' AND (" +
                                                                "tblMenu.nama_menu LIKE '%" + data + "%' OR " +
                                                                "tblOrder.qty LIKE '%" + data + "%' OR " +
                                                                "tblOrder.harga LIKE '%" + data + "%' OR " +
                                                                "tblOrder.total LIKE '%" + data + "%' OR " +
                                                                "tblOrder.uang_diberi LIKE '%" + data + "%' OR " +
                                                                "tblOrder.id_meja LIKE '%" + data + "%' OR " +
                                                                "tblOrder.date LIKE '%" + data + "%')"
                                                                //"SELECT tblOrder.id_order, tblMenu.nama_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.id_meja, tblOrder.date, tblOrder.added_by FROM tblOrder INNER JOIN tblMenu ON tblOrder.id_menu = tblMenu.id_menu WHERE tblOrder.added_by = '"+idKaryawan+"' AND(tblMenu.nama_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblOrder.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%')"
                                                                , util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvCatatanTransaksi.DataSource = dataSet.Tables[0];
        }

        private void tampilData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblMenu.nama_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.id_meja, tblOrder.date, tblOrder.added_by FROM tblOrder INNER JOIN tblMenu ON tblOrder.id_menu = tblMenu.id_menu WHERE tblOrder.added_by = '"+getIdFromNama(this.nama)+"' ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvCatatanTransaksi.DataSource = dataSet.Tables[0];
        }


        //// FORM CONTROL
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                lblDangerSearch.Visible = true;
            }
            else
            {
                searchData(txtSearch.Text, getIdFromNama(this.nama));
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lblDangerSearch.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampilData();
            lblDangerSearch.Visible = false;
        }

        private void dgvCatatanTransaksi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.info == true)
            {
                timerInfo.Start();
            }
            retriveData();
        }

        private void btnCloseInfo_Click(object sender, EventArgs e)
        {
            timerInfo.Start();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Membuat objek baru dari PrintDocument
            //PrintDocument printDoc = new PrintDocument();

            //// Memberikan event handler untuk event PrintPage
            //printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

            //// Memunculkan dialog print
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = printDoc;
            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
            //    printDoc.Print();
            //}

            // MENGGUNAKAN RDLC 
            ShowPrint showPrint = new ShowPrint(this.idOrder);
            showPrint.ShowDialog();
        }

        //private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    // Membuat variabel untuk menyimpan posisi awal penulisan teks
        //    float yPos = 50;

        //    // Membuat objek baru dari Font
        //    Font font = new Font("Arial", 12);

        //    // Menggambar teks untuk judul kolom
        //    for (int i = 0; i < dgvMenu.Columns.Count; i++)
        //    {
        //        e.Graphics.DrawString(dgvMenu.Columns[i].HeaderText, font, Brushes.Black, new PointF(dgvMenu.Columns[i].HeaderCell.ContentBounds.Left, yPos));
        //    }

        //    // Menggambar isi dari DataGridView
        //    yPos += dgvMenu.ColumnHeadersHeight;
        //    for (int i = 0; i < dgvMenu.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < dgvMenu.Columns.Count; j++)
        //        {
        //            e.Graphics.DrawString(dgvMenu.Rows[i].Cells[j].FormattedValue.ToString(), font, Brushes.Black, new PointF(dgvMenu.Columns[j].HeaderCell.ContentBounds.Left, yPos));
        //        }
        //        yPos += dgvMenu.Rows[i].Height;
        //    }
        //}


    }
}
