
namespace App_Cafe_UKK
{
    partial class ShowPrintCatatanTransaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerCatatanTransaksi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ResiDataSet = new App_Cafe_UKK.ResiDataSet();
            this.dataTableCatatanTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableCatatanTransaksiTableAdapter = new App_Cafe_UKK.ResiDataSetTableAdapters.dataTableCatatanTransaksiTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCatatanTransaksiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1041, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 45);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerCatatanTransaksi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1123, 794);
            this.panel2.TabIndex = 1;
            // 
            // reportViewerCatatanTransaksi
            // 
            this.reportViewerCatatanTransaksi.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataSetCatatanTransaksi";
            reportDataSource1.Value = this.dataTableCatatanTransaksiBindingSource;
            this.reportViewerCatatanTransaksi.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCatatanTransaksi.LocalReport.ReportEmbeddedResource = "App_Cafe_UKK.ReportCatatanTransaksi.rdlc";
            this.reportViewerCatatanTransaksi.Location = new System.Drawing.Point(0, 0);
            this.reportViewerCatatanTransaksi.Name = "reportViewerCatatanTransaksi";
            this.reportViewerCatatanTransaksi.ServerReport.BearerToken = null;
            this.reportViewerCatatanTransaksi.Size = new System.Drawing.Size(1123, 794);
            this.reportViewerCatatanTransaksi.TabIndex = 0;
            // 
            // ResiDataSet
            // 
            this.ResiDataSet.DataSetName = "ResiDataSet";
            this.ResiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableCatatanTransaksiBindingSource
            // 
            this.dataTableCatatanTransaksiBindingSource.DataMember = "dataTableCatatanTransaksi";
            this.dataTableCatatanTransaksiBindingSource.DataSource = this.ResiDataSet;
            // 
            // dataTableCatatanTransaksiTableAdapter
            // 
            this.dataTableCatatanTransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // ShowPrintCatatanTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 839);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPrintCatatanTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPrintCatatanTransaksi";
            this.Load += new System.EventHandler(this.ShowPrintCatatanTransaksi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCatatanTransaksiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCatatanTransaksi;
        private System.Windows.Forms.BindingSource dataTableCatatanTransaksiBindingSource;
        private ResiDataSet ResiDataSet;
        private ResiDataSetTableAdapters.dataTableCatatanTransaksiTableAdapter dataTableCatatanTransaksiTableAdapter;
    }
}