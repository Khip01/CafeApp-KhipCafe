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
using System.Globalization;

namespace App_Cafe_UKK
{
    public partial class PageCatatanTransaksiManager : Form
    {
        //// DEKLARASI VARIABEL
        bool isActivepnlName = false, isActivepnlDate = false;
        bool filterNama = false, filterDate = false;
        Utils util = new Utils();
        // string command ini yang nantinya akan diteruskan ke print manager yang akan menentukan tampilan apa yang akan di print
        SqlDataAdapter sqlDataAdapterPub;

        public PageCatatanTransaksiManager()
        {
            InitializeComponent();

            tampilData(filterNama, filterDate);
            tampilComboBox();
            loadCbTahun();
        }

        //// MANUAL METHOD
        private void loadCbTahun()
        {
            // Menampilkan tahun pada cbTahun
            for (int year = 2020; year <= 2023; year++)
            {
                cbTahun.Items.Add(year.ToString());
            }

            // Menampilkan tahun pada cbTahun2
            for (int year = 2020; year <= 2023; year++)
            {
                cbTahun2.Items.Add(year.ToString());
            }
        }

        //private string getIdFromNama(string nama)
        //{
        //    util.koneksi.Open();
        //    util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '" + nama + "'", util.koneksi);
        //    string id = util.cmd.ExecuteScalar().ToString();
        //    util.koneksi.Close();
        //    return id;
        //}

        private void tampilComboBox()
        {
            // UNTUK COMBO BOX POSITION
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT DISTINCT tblOrder.added_by, tblKaryawan.username FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan", util.koneksi);
            SqlDataReader reader = util.cmd.ExecuteReader();
            while (reader.Read())
            {
                cbLstNama.Items.Add(reader["username"].ToString());
            }
            util.koneksi.Close();
        }

        private void searchData(string data, bool nama, bool date)
        {
            // Jika filter nama dan filter date digunakan
            if (nama == true && date == true)
            {
                // Deklarasi variabel
                string sortByNama = cbLstNama.Text;
                //string sortByDate = dtpDate.Value.ToString("yyyy-MM-dd");

                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblKaryawan.username = '" + sortByNama + "' AND tblOrder.date = '"+sortByDate+"' AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblkaryawan.username LIKE '%" + data + "%')", util.koneksi);

                //// Memasukkan sqlDataAdapter ke public
                //this.sqlDataAdapterPub = sqlDataAdapter;

                //DataSet dataSet = new DataSet();
                //sqlDataAdapter.Fill(dataSet);
                //dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                // Jika tabControl yang dipilih Day
                if (tabControlDate.SelectedTab.Text == "Day")
                {
                    // Deklarasi variabel
                    string sortByDate = dtpDate.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') AND date = '" + sortByDate + "' " +
                        "AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblkaryawan.username LIKE '%" + data + "%')", util.koneksi);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + dtpDate.Value.ToString("yyyy-MM-dd");
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Month
                else if (tabControlDate.SelectedTab.Text == "Month")
                {
                    // mengambil nilai bulan yang dipilih dari comboBox
                    string namaBulan = cbBulan.SelectedItem.ToString();

                    // mengonversi nama bulan menjadi angka bulan
                    DateTimeFormatInfo dtfi = new DateTimeFormatInfo();

                    // Deklarasi variabel
                    int bulan = dtfi.MonthNames.ToList().IndexOf(namaBulan) + 1;
                    string tahun = cbTahun2.SelectedItem.ToString();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') AND MONTH(date) = @bulan AND YEAR(date) = @tahun " +
                        "AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblkaryawan.username LIKE '%" + data + "%')", util.koneksi);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@bulan", bulan);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tahun", tahun);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + namaBulan + ", " + tahun;
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Year
                else if (tabControlDate.SelectedTab.Text == "Year")
                {
                    // Deklarasi variabel
                    string tahun = cbTahun.SelectedItem.ToString();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') AND YEAR(date) = '" + tahun + "' " +
                        "AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblkaryawan.username LIKE '%" + data + "%')", util.koneksi);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + tahun;
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Custom
                else if (tabControlDate.SelectedTab.Text == "Custom")
                {
                    // Deklarasi variabel
                    string tglAwal = dtpCustomFirst.Value.ToString("yyyy-MM-dd");
                    string tglAkhir = dtpCustomSecond.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') AND date BETWEEN @tglAwal AND @tglAkhir " +
                        "AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblkaryawan.username LIKE '%" + data + "%')", util.koneksi);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tglAwal", tglAwal);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tglAkhir", tglAkhir);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : '" + tglAwal + "' - '" + tglAkhir + "'";
                    lblSortByDate.Visible = true;
                }
                return;
            }

            // Jika hanya filter nama yang digunakan
            if (nama == true && date == false)
            {
                // Deklarasi variabel
                string sortByNama = cbLstNama.Text;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblKaryawan.username = '" + sortByNama + "' AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblKaryawan.username LIKE '%" + data + "%')", util.koneksi);

                // Memasukkan sqlDataAdapter ke public
                this.sqlDataAdapterPub = sqlDataAdapter;

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dgvCatatanTransaksi.DataSource = dataSet.Tables[0];
            }

            // Jika hanya filter date yang digunakan 
            if (nama == false && date == true)
            {
                //// Deklarasi variabel
                //string sortByDate = dtpDate.Value.ToString("yyyy-MM-dd");

                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE date = '"+sortByDate+"' AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblKaryawan.username LIKE '%" + data + "%')", util.koneksi);

                //// Memasukkan sqlDataAdapter ke public
                //this.sqlDataAdapterPub = sqlDataAdapter;

                //DataSet dataSet = new DataSet();
                //sqlDataAdapter.Fill(dataSet);
                //dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //// Kondisi untuk Date
                /// saya ingin menampilkan kondisi jika date == day/month/year/custom

                // Jika tabControl yang dipilih Day
                if (tabControlDate.SelectedTab.Text == "Day")
                {
                    // Deklarasi variabel
                    string sortByDate = dtpDate.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE date = '" + sortByDate + "' " +
                        "AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblKaryawan.username LIKE '%" + data + "%')", util.koneksi);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + dtpDate.Value.ToString("yyyy-MM-dd");
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Month
                else if (tabControlDate.SelectedTab.Text == "Month")
                {
                    // mengambil nilai bulan yang dipilih dari comboBox
                    string namaBulan = cbBulan.SelectedItem.ToString();

                    // mengonversi nama bulan menjadi angka bulan
                    DateTimeFormatInfo dtfi = new DateTimeFormatInfo();

                    // Deklarasi variabel
                    int bulan = dtfi.MonthNames.ToList().IndexOf(namaBulan) + 1;
                    string tahun = cbTahun2.SelectedItem.ToString();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE MONTH(date) = @bulan AND YEAR(date) = @tahun " +
                        "AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblKaryawan.username LIKE '%" + data + "%')", util.koneksi);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@bulan", bulan);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tahun", tahun);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + namaBulan + ", " + tahun;
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Year
                else if (tabControlDate.SelectedTab.Text == "Year")
                {
                    // Deklarasi variabel
                    string tahun = cbTahun.SelectedItem.ToString();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE YEAR(date) = '" + tahun + "' " +
                        "AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblKaryawan.username LIKE '%" + data + "%')", util.koneksi);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + tahun;
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Custom
                else if (tabControlDate.SelectedTab.Text == "Custom")
                {
                    // Deklarasi variabel
                    string tglAwal = dtpCustomFirst.Value.ToString("yyyy-MM-dd");
                    string tglAkhir = dtpCustomSecond.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE date BETWEEN @tglAwal AND @tglAkhir " +
                        "AND (tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblKaryawan.username LIKE '%" + data + "%')", util.koneksi);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tglAwal", tglAwal);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tglAkhir", tglAkhir);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : '" + tglAwal + "' - '" + tglAkhir + "'";
                    lblSortByDate.Visible = true;
                }
                return;
            }

            // Jika kedua filter tidak digunakan
            if (nama == false && date == false)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.id_order LIKE '%" + data + "%' OR tblOrder.id_menu LIKE '%" + data + "%' OR tblOrder.qty LIKE '%" + data + "%' OR tblOrder.harga LIKE '%" + data + "%' OR tblOrder.total LIKE '%" + data + "%' OR tblOrder.uang_diberi LIKE '%" + data + "%' OR tblMeja.id_meja LIKE '%" + data + "%' OR tblOrder.date LIKE '%" + data + "%' OR tblKaryawan.username LIKE '%" + data + "%'", util.koneksi);

                // Memasukkan sqlDataAdapter ke public
                this.sqlDataAdapterPub = sqlDataAdapter;

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                return;
            }
        }

        private void tampilData(bool nama, bool date) // Jika filter sesuai nama, maka parameter nama tampilData diberi true
        {
            // Jika filter nama dan filter date digunakan
            if (nama == true && date == true)
            {
                // Deklarasi variabel
                string sortByNama = cbLstNama.Text;

                // Jika tabControl yang dipilih Day
                if (tabControlDate.SelectedTab.Text == "Day")
                {
                    // Deklarasi variabel
                    string sortByDate = dtpDate.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') AND date = '" + sortByDate + "' ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + dtpDate.Value.ToString("yyyy-MM-dd");
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Month
                else if (tabControlDate.SelectedTab.Text == "Month")
                {
                    // mengambil nilai bulan yang dipilih dari comboBox
                    string namaBulan = cbBulan.SelectedItem.ToString();

                    // mengonversi nama bulan menjadi angka bulan
                    DateTimeFormatInfo dtfi = new DateTimeFormatInfo();

                    // Deklarasi variabel
                    int bulan = dtfi.MonthNames.ToList().IndexOf(namaBulan) + 1;
                    string tahun = cbTahun2.SelectedItem.ToString();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') AND MONTH(date) = @bulan AND YEAR(date) = @tahun ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@bulan", bulan);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tahun", tahun);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + namaBulan + ", " + tahun;
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Year
                else if (tabControlDate.SelectedTab.Text == "Year")
                {
                    // Deklarasi variabel
                    string tahun = cbTahun.SelectedItem.ToString();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') AND YEAR(date) = '" + tahun + "' ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + tahun;
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Custom
                else if (tabControlDate.SelectedTab.Text == "Custom")
                {
                    // Deklarasi variabel
                    string tglAwal = dtpCustomFirst.Value.ToString("yyyy-MM-dd");
                    string tglAkhir = dtpCustomSecond.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') AND date BETWEEN @tglAwal AND @tglAkhir ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tglAwal", tglAwal);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tglAkhir", tglAkhir);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : '" + tglAwal + "' - '" + tglAkhir + "'";
                    lblSortByDate.Visible = true;
                }
                return;
            }

            // Jika hanya filter nama yang digunakan
            if (nama == true && date == false)
            {
                // Deklarasi variabel
                string sortByNama = cbLstNama.Text;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE tblOrder.added_by = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + sortByNama + "') ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);

                // Memasukkan sqlDataAdapter ke public
                this.sqlDataAdapterPub = sqlDataAdapter;

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                dgvCatatanTransaksi.DataSource = dataSet.Tables[0];
                return;
            }

            // Jika hanya filter date yang digunakan 
            if (nama ==  false && date == true)
            {
                //// Kondisi untuk Date
                /// saya ingin menampilkan kondisi jika date == day/month/year/custom

                // Jika tabControl yang dipilih Day
                if (tabControlDate.SelectedTab.Text == "Day")
                {
                    // Deklarasi variabel
                    string sortByDate = dtpDate.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE date = '" + sortByDate + "' ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + dtpDate.Value.ToString("yyyy-MM-dd");
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Month
                else if (tabControlDate.SelectedTab.Text == "Month")
                {
                    // mengambil nilai bulan yang dipilih dari comboBox
                    string namaBulan = cbBulan.SelectedItem.ToString();

                    // mengonversi nama bulan menjadi angka bulan
                    DateTimeFormatInfo dtfi = new DateTimeFormatInfo();

                    // Deklarasi variabel
                    int bulan = dtfi.MonthNames.ToList().IndexOf(namaBulan) + 1;
                    string tahun = cbTahun2.SelectedItem.ToString();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE MONTH(date) = @bulan AND YEAR(date) = @tahun ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@bulan", bulan);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tahun", tahun);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + namaBulan + ", "+tahun;
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Year
                else if (tabControlDate.SelectedTab.Text == "Year")
                {
                    // Deklarasi variabel
                    string tahun = cbTahun.SelectedItem.ToString();

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE YEAR(date) = '" + tahun + "' ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : " + tahun;
                    lblSortByDate.Visible = true;
                }
                // Jika tabControl yang dipilih Custom
                else if (tabControlDate.SelectedTab.Text == "Custom")
                {
                    // Deklarasi variabel
                    string tglAwal = dtpCustomFirst.Value.ToString("yyyy-MM-dd");
                    string tglAkhir = dtpCustomSecond.Value.ToString("yyyy-MM-dd");

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja WHERE date BETWEEN @tglAwal AND @tglAkhir ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tglAwal", tglAwal);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@tglAkhir", tglAkhir);

                    // Memasukkan sqlDataAdapter ke public
                    this.sqlDataAdapterPub = sqlDataAdapter;

                    DataSet dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    dgvCatatanTransaksi.DataSource = dataSet.Tables[0];

                    // Memunculkan label sortby
                    lblSortByDate.Text = "Date : '" + tglAwal + "' - '" + tglAkhir + "'";
                    lblSortByDate.Visible = true;
                }
                return;
            }

            // Jika kedua filter tidak digunakan
            if (nama == false && date == false)
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT tblOrder.id_order, tblOrder.id_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date, tblMeja.no_meja, tblKaryawan.username AS added_by FROM tblOrder INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan INNER JOIN tblMeja ON tblOrder.id_meja = tblMeja.id_meja ORDER BY tblOrder.date DESC, tblOrder.id_order DESC", util.koneksi);

                // Memasukkan sqlDataAdapter ke public
                this.sqlDataAdapterPub = sqlDataAdapter;

                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                dgvCatatanTransaksi.DataSource = dataSet.Tables[0];
                return;
            }
        }


        //// FORM CONTROL
        private void btnSubmitSortByDate_Click(object sender, EventArgs e)
        {
            // Jika field comboBox Kosong
            if (tabControlDate.SelectedTab.Text == "Month" && (cbBulan.SelectedItem == null || cbTahun2.SelectedItem == null))
            {
                if (cbBulan.SelectedItem == null && cbTahun2.SelectedItem == null)
                {
                    MessageBox.Show("Field Month dan Year TIDAK BOLEH KOSONG!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbBulan.SelectedItem == null)
                {
                    MessageBox.Show("Field Month TIDAK BOLEH KOSONG!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbTahun2.SelectedItem == null)
                {
                    MessageBox.Show("Field Year TIDAK BOLEH KOSONG!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else if (tabControlDate.SelectedTab.Text == "Year" && cbTahun.SelectedItem == null)
            {
                MessageBox.Show("Field Year TIDAK BOLEH KOSONG!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filter dimulai
            if (filterDate == false)
            {
                // Menjadikan kondisi button terpencet true
                this.filterDate = true;
                // Tampil data dgv
                tampilData(filterNama, filterDate);
                // Button Sort By
                btnSubmitSortByDate.BackColor = Color.Red;
                btnSubmitSortByDate.Image = Properties.Resources.close24;
                // Disabled Field
                tabControlDate.Enabled = false;
            }
            else if (filterDate == true)
            {
                // Menjadikan kondisi button terpencet false
                this.filterDate = false;
                // Tampil data dgv
                tampilData(filterNama, filterDate);
                // Menghilangkan label sortby
                lblSortByDate.Text = "NONE";
                lblSortByDate.Visible = false;
                // Button Sort By
                btnSubmitSortByDate.BackColor = Color.LightGreen;
                btnSubmitSortByDate.Image = Properties.Resources.checkmark24;
                // Clear Field
                dtpDate.Value = DateTime.Now;
                dtpCustomFirst.Value = DateTime.Now;
                dtpCustomSecond.Value = DateTime.Now;
                // Enabled Field
                tabControlDate.Enabled = true;
            }

            // Kondisi untuk menghilangkan label NONE
            if (filterDate == true || filterNama == true)
            {
                lblSortByNone.Visible = false;
            }
            else
            {
                lblSortByNone.Visible = true;
            }
        }

        private void btnSubmitSortByName_Click(object sender, EventArgs e)
        {
            // Jika field comboBox Kosong
            if (cbLstNama.SelectedItem == null)
            {
                MessageBox.Show("Field Sort By Nama TIDAK BOLEH KOSONG!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Filter dimulai
            if (filterNama == false)
            {
                this.filterNama = true;
                // Tampil data dgv
                tampilData(filterNama, filterDate);
                // Memunculkan label sortby
                lblSortByName.Text = "Served by : " + cbLstNama.SelectedItem.ToString();
                lblSortByName.Visible = true;
                // BUtton Sort By
                btnSubmitSortByName.BackColor = Color.Red;
                btnSubmitSortByName.Image = Properties.Resources.close24;
                // Disabled Field
                cbLstNama.Enabled = false;
            }
            else if (filterNama == true)
            {
                this.filterNama = false;
                // Tampil data dgv
                tampilData(filterNama, filterDate);
                // Menghilangkan label sortby
                lblSortByName.Text = "NONE";
                lblSortByName.Visible = false;
                // Button Sort By
                btnSubmitSortByName.BackColor = Color.LightGreen;
                btnSubmitSortByName.Image = Properties.Resources.checkmark24;
                // Clear Field
                cbLstNama.SelectedItem = null;
                // Enabled Field
                cbLstNama.Enabled = true;
            }

            // Kondisi untuk menghilangkan label NULL
            if (filterDate == true || filterNama == true)
            {
                lblSortByNone.Visible = false;
            }
            else
            {
                lblSortByNone.Visible = true;
            }
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            // Jika Panel Date Aktif maka tutuplah
            if (isActivepnlDate == true)
            {
                pnlDate.Visible = false;
                this.isActivepnlDate = false;
            }
            // Kondisi unutk membuka dan menutup panel Name
            if (isActivepnlName == false)
            {
                pnlNama.BringToFront();
                pnlNama.Visible = true;
                this.isActivepnlName = true;
            }
            else
            {
                pnlNama.Visible = false;
                this.isActivepnlName = false;
            }
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            // Jika Panel Nama Aktif maka tutuplah
            if (isActivepnlName == true)
            {
                pnlNama.Visible = false;
                this.isActivepnlName = false;
            }
            // Kondisi untuk membuka dan menutup panel Date
            if (isActivepnlDate == false)
            {
                pnlDate.BringToFront();
                pnlDate.Visible = true;
                this.isActivepnlDate = true;
            }
            else
            {
                pnlDate.Visible = false;
                this.isActivepnlDate = false;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ShowPrintCatatanTransaksi print = new ShowPrintCatatanTransaksi(this.sqlDataAdapterPub);
            print.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampilData(filterNama, filterDate);
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
                searchData(txtSearch.Text, filterNama, filterDate);
            }
        }
    }
}
