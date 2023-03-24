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
    public partial class ShowPrintCatatanTransaksi : Form
    {
        //// DEKLARASI VARIABEL
        SqlDataAdapter sqlDataAdapterPub;
        
        public ShowPrintCatatanTransaksi(SqlDataAdapter sqlDataAdapter)
        {
            InitializeComponent();

            this.sqlDataAdapterPub = sqlDataAdapter;
        }


        //// FORM CONTROL
        private void ShowPrintCatatanTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ResiDataSet.dataTableCatatanTransaksi' table. You can move, or remove it, as needed.
            this.dataTableCatatanTransaksiTableAdapter.Fill(this.ResiDataSet.dataTableCatatanTransaksi);
            // Deklarasi Var
            ResiDataSet dataSetManager = new ResiDataSet();

            // Mengatasi error 
            // System.Data.ConstraintException: 'Failed to enable constraints. One or more rows contain values violating non-null, unique, or foreign-key constraints.'
            dataSetManager.EnforceConstraints = false;

            // Memasukkan hasil command ke resiDataSet dalam bentuk tabel
            this.sqlDataAdapterPub.Fill(dataSetManager, dataSetManager.Tables[0].TableName);

            // Menampilkan Report dari dataset KE reportViewer
            ReportDataSource reportDataSource = new ReportDataSource("dataSetCatatanTransaksi", dataSetManager.Tables[0]);
            this.reportViewerCatatanTransaksi.LocalReport.DataSources.Clear();
            this.reportViewerCatatanTransaksi.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewerCatatanTransaksi.LocalReport.Refresh();

            // Syntax otomatis dari VS saat ReportViewer ditambahkan 
            this.reportViewerCatatanTransaksi.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
