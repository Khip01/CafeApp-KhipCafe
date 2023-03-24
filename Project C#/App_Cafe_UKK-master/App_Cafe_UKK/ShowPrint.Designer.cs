
namespace App_Cafe_UKK
{
    partial class ShowPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableResiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResiDataSet = new App_Cafe_UKK.ResiDataSet();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlReport = new System.Windows.Forms.Panel();
            this.reportViewerResi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableResiTableAdapter = new App_Cafe_UKK.ResiDataSetTableAdapters.dataTableResiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableResiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResiDataSet)).BeginInit();
            this.pnlTopBar.SuspendLayout();
            this.pnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableResiBindingSource
            // 
            this.dataTableResiBindingSource.DataMember = "dataTableResi";
            this.dataTableResiBindingSource.DataSource = this.ResiDataSet;
            // 
            // ResiDataSet
            // 
            this.ResiDataSet.DataSetName = "ResiDataSet";
            this.ResiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(523, 45);
            this.pnlTopBar.TabIndex = 34;
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
            this.btnClose.Location = new System.Drawing.Point(441, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlReport
            // 
            this.pnlReport.Controls.Add(this.reportViewerResi);
            this.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReport.Location = new System.Drawing.Point(0, 0);
            this.pnlReport.Name = "pnlReport";
            this.pnlReport.Size = new System.Drawing.Size(523, 806);
            this.pnlReport.TabIndex = 35;
            // 
            // reportViewerResi
            // 
            this.reportViewerResi.BackColor = System.Drawing.SystemColors.Control;
            this.reportViewerResi.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "dataSetResi";
            reportDataSource2.Value = this.dataTableResiBindingSource;
            this.reportViewerResi.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerResi.LocalReport.ReportEmbeddedResource = "App_Cafe_UKK.ReportResiKasir.rdlc";
            this.reportViewerResi.Location = new System.Drawing.Point(0, 48);
            this.reportViewerResi.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewerResi.Name = "reportViewerResi";
            this.reportViewerResi.ServerReport.BearerToken = null;
            this.reportViewerResi.Size = new System.Drawing.Size(523, 758);
            this.reportViewerResi.TabIndex = 0;
            // 
            // dataTableResiTableAdapter
            // 
            this.dataTableResiTableAdapter.ClearBeforeFill = true;
            // 
            // ShowPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 806);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPrint";
            this.Load += new System.EventHandler(this.ShowPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableResiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResiDataSet)).EndInit();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerResi;
        private System.Windows.Forms.BindingSource dataTableResiBindingSource;
        private ResiDataSet ResiDataSet;
        private ResiDataSetTableAdapters.dataTableResiTableAdapter dataTableResiTableAdapter;
    }
}