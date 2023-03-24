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
    public partial class PageDashboardManager : Form
    {
        //// DEKLARASI VARIABEL
        Utils util = new Utils();

        public PageDashboardManager()
        {
            InitializeComponent();

            // Tampildata dataGridView
            tampilData();
            // Tampil Total Transaksi
            transaksiHariIni();
            transaksiBulanIni();
            // Pendapatan Total/income
            incomeHariIni();
            incomeBulanIni();
        }

        //// MANUAL METHOD
        private void tampilData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblOrder ORDER BY date DESC, id_order DESC", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvCatatanTransaksi.DataSource = dataSet.Tables[0];
        }

        private void transaksiHariIni()
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(DISTINCT id_order) FROM tblOrder WHERE DAY(date) = " + DateTime.Today.Day, util.koneksi);
            // Mengecek jika executeScalar terdapat NULL
            object result = util.cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                int countToday = Convert.ToInt32(result);
                lblTransaksiHariIni.Text = countToday.ToString();
            }
            else
            {
                lblTransaksiHariIni.Text = "0";
            }
            util.koneksi.Close();
        }

        private void transaksiBulanIni()
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(DISTINCT id_order) FROM tblOrder WHERE MONTH(date) = " + DateTime.Now.Month, util.koneksi);
            // Mengecek jika executeScalar terdapat NULL
            object result = util.cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                int countMonth = Convert.ToInt32(result);
                lblTransaksiBlnIni.Text = countMonth.ToString();
            }
            else
            {
                lblTransaksiBlnIni.Text = "0";
            }
            util.koneksi.Close();
        }

        private void incomeHariIni()
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT SUM(total) FROM (SELECT DISTINCT id_order, total FROM tblOrder WHERE DAY(date) = '" + DateTime.Today.Day + "') AS temp", util.koneksi);
            // Mengecek jika executeScalar terdapat NULL
            object result = util.cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                int countIncomeToday = Convert.ToInt32(result);
                lblIncomeHariIni.Text = countIncomeToday.ToString();
            }
            else
            {
                lblIncomeHariIni.Text = "0";
            }
            util.koneksi.Close();
        }

        private void incomeBulanIni()
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT SUM(total) FROM (SELECT DISTINCT id_order, total FROM tblOrder WHERE MONTH(date) = " + DateTime.Now.Month + ") AS temp", util.koneksi);
            // Mengecek jika executeScalar terdapat NULL
            object result = util.cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                int countIncomeMonth = Convert.ToInt32(result);
                lblIncomeBlnIni.Text = countIncomeMonth.ToString();
            }
            else
            {
                lblIncomeBlnIni.Text = "0";
            }
            util.koneksi.Close();
        }

        //// FORM CONTROL
        /// null hehe
    }
}
