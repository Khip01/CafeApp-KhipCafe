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
using Microsoft.Reporting.WinForms;

namespace App_Cafe_UKK
{
    public partial class ShowPrint : Form
    {
        //// DEKLARASI VARIABEL 
        Utils util = new Utils();
        string idOrder;

        public ShowPrint(string id)
        {
            InitializeComponent();

            this.idOrder = id;
        }

        //// FORM CONTROL 
        private void ShowPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ResiDataSet.dataTableResi' table. You can move, or remove it, as needed.
            this.dataTableResiTableAdapter.Fill(this.ResiDataSet.dataTableResi);

            // Deklarasi Var
            ResiDataSet resiDataSet = new ResiDataSet();
            string command = @"SELECT tblOrder.id_order, tblKaryawan.username, tblMenu.nama_menu, tblOrder.qty, tblOrder.harga, tblOrder.total, tblOrder.uang_diberi, tblOrder.date FROM tblOrder INNER JOIN tblMenu ON tblOrder.id_menu = tblMenu.id_menu INNER JOIN tblKaryawan ON tblOrder.added_by = tblKaryawan.id_karyawan WHERE id_order = '" + idOrder + "'";

            // Memasukkan hasil command ke resiDataSet dalam bentuk tabel
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, util.koneksi);
            sqlDataAdapter.Fill(resiDataSet, resiDataSet.Tables[0].TableName);

            // Menampilkan Report dari dataset KE reportViewer
            ReportDataSource reportDataSource = new ReportDataSource("dataSetResi", resiDataSet.Tables[0]);
            this.reportViewerResi.LocalReport.DataSources.Clear();
            this.reportViewerResi.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerResi.LocalReport.Refresh();
            
            // Syntax otomatis dari VS saat ReportViewer ditambahkan 
            this.reportViewerResi.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
