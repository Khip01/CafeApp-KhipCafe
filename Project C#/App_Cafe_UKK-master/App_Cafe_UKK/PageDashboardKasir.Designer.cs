
namespace App_Cafe_UKK
{
    partial class PageDashboardKasir
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
            this.dgvListMenu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCatatanTransaksi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalTransaksi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalMeja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTransaksiHariIni = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMejaYangTersedia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatatanTransaksi)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListMenu
            // 
            this.dgvListMenu.AllowUserToAddRows = false;
            this.dgvListMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMenu.Location = new System.Drawing.Point(30, 88);
            this.dgvListMenu.Name = "dgvListMenu";
            this.dgvListMenu.ReadOnly = true;
            this.dgvListMenu.RowHeadersWidth = 51;
            this.dgvListMenu.RowTemplate.Height = 210;
            this.dgvListMenu.Size = new System.Drawing.Size(733, 574);
            this.dgvListMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dgvListMenu);
            this.panel1.Location = new System.Drawing.Point(49, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 682);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Location = new System.Drawing.Point(235, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(528, 51);
            this.panel6.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(397, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 51);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::App_Cafe_UKK.Properties.Resources.search32;
            this.pictureBox2.Location = new System.Drawing.Point(15, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(58, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(24, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(30, 30, 30, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 34);
            this.label7.TabIndex = 1;
            this.label7.Text = "Menu List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvCatatanTransaksi);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(873, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 316);
            this.panel2.TabIndex = 2;
            // 
            // dgvCatatanTransaksi
            // 
            this.dgvCatatanTransaksi.AllowUserToAddRows = false;
            this.dgvCatatanTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatatanTransaksi.Location = new System.Drawing.Point(30, 88);
            this.dgvCatatanTransaksi.Name = "dgvCatatanTransaksi";
            this.dgvCatatanTransaksi.ReadOnly = true;
            this.dgvCatatanTransaksi.RowHeadersWidth = 51;
            this.dgvCatatanTransaksi.RowTemplate.Height = 24;
            this.dgvCatatanTransaksi.Size = new System.Drawing.Size(393, 197);
            this.dgvCatatanTransaksi.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(24, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Transaction Records";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(873, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 342);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(86)))), ((int)(((byte)(68)))));
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lblTotalTransaksi);
            this.panel5.Location = new System.Drawing.Point(38, 59);
            this.panel5.Margin = new System.Windows.Forms.Padding(30, 10, 30, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 96);
            this.panel5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(101, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Totals";
            // 
            // lblTotalTransaksi
            // 
            this.lblTotalTransaksi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalTransaksi.AutoSize = true;
            this.lblTotalTransaksi.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalTransaksi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalTransaksi.Location = new System.Drawing.Point(52, 11);
            this.lblTotalTransaksi.Name = "lblTotalTransaksi";
            this.lblTotalTransaksi.Size = new System.Drawing.Size(46, 54);
            this.lblTotalTransaksi.TabIndex = 1;
            this.lblTotalTransaksi.Text = "1";
            this.lblTotalTransaksi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(86)))), ((int)(((byte)(68)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblTotalMeja);
            this.panel4.Location = new System.Drawing.Point(253, 59);
            this.panel4.Margin = new System.Windows.Forms.Padding(30, 10, 30, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(172, 96);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables";
            // 
            // lblTotalMeja
            // 
            this.lblTotalMeja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalMeja.AutoSize = true;
            this.lblTotalMeja.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalMeja.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalMeja.Location = new System.Drawing.Point(52, 11);
            this.lblTotalMeja.Name = "lblTotalMeja";
            this.lblTotalMeja.Size = new System.Drawing.Size(46, 54);
            this.lblTotalMeja.TabIndex = 1;
            this.lblTotalMeja.Text = "1";
            this.lblTotalMeja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(249, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Table Totals";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(86)))), ((int)(((byte)(68)))));
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.lblTransaksiHariIni);
            this.panel7.Location = new System.Drawing.Point(38, 219);
            this.panel7.Margin = new System.Windows.Forms.Padding(30, 10, 30, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 96);
            this.panel7.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(101, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Today";
            // 
            // lblTransaksiHariIni
            // 
            this.lblTransaksiHariIni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransaksiHariIni.AutoSize = true;
            this.lblTransaksiHariIni.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTransaksiHariIni.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTransaksiHariIni.Location = new System.Drawing.Point(52, 11);
            this.lblTransaksiHariIni.Name = "lblTransaksiHariIni";
            this.lblTransaksiHariIni.Size = new System.Drawing.Size(46, 54);
            this.lblTransaksiHariIni.TabIndex = 1;
            this.lblTransaksiHariIni.Text = "1";
            this.lblTransaksiHariIni.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(249, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "Available table";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(30, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 39);
            this.label10.TabIndex = 0;
            this.label10.Text = "Transaction";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(86)))), ((int)(((byte)(68)))));
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.lblMejaYangTersedia);
            this.panel8.Location = new System.Drawing.Point(253, 219);
            this.panel8.Margin = new System.Windows.Forms.Padding(30, 10, 30, 30);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(172, 96);
            this.panel8.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(57, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Empty Table";
            // 
            // lblMejaYangTersedia
            // 
            this.lblMejaYangTersedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMejaYangTersedia.AutoSize = true;
            this.lblMejaYangTersedia.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMejaYangTersedia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMejaYangTersedia.Location = new System.Drawing.Point(52, 11);
            this.lblMejaYangTersedia.Name = "lblMejaYangTersedia";
            this.lblMejaYangTersedia.Size = new System.Drawing.Size(46, 54);
            this.lblMejaYangTersedia.TabIndex = 1;
            this.lblMejaYangTersedia.Text = "1";
            this.lblMejaYangTersedia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PageDashboardKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageDashboardKasir";
            this.Text = "PageDashboardKasir";
            this.Load += new System.EventHandler(this.PageDashboardKasir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatatanTransaksi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalMeja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCatatanTransaksi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalTransaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTransaksiHariIni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMejaYangTersedia;
    }
}