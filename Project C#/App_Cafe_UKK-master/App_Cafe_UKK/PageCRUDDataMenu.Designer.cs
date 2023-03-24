
namespace App_Cafe_UKK
{
    partial class PageCRUDDataMenu
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
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblDangerSearch = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvDataMenu = new System.Windows.Forms.DataGridView();
            this.pnlMenuInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblMenuName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIdMenu = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMenu)).BeginInit();
            this.pnlMenuInfo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timerInfo
            // 
            this.timerInfo.Interval = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "To see full details about the user, double click on the selected row!";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(60, 42);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 51);
            this.panel4.TabIndex = 12;
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
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblDangerSearch
            // 
            this.lblDangerSearch.AutoSize = true;
            this.lblDangerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangerSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDangerSearch.Location = new System.Drawing.Point(63, 22);
            this.lblDangerSearch.Name = "lblDangerSearch";
            this.lblDangerSearch.Size = new System.Drawing.Size(238, 17);
            this.lblDangerSearch.TabIndex = 13;
            this.lblDangerSearch.Text = "*You\'re not looking for anything";
            this.lblDangerSearch.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Cafe_UKK.Properties.Resources.information32;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(60, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 34);
            this.panel3.TabIndex = 11;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = global::App_Cafe_UKK.Properties.Resources.refresh24;
            this.btnRefresh.Location = new System.Drawing.Point(659, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 63);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvDataMenu
            // 
            this.dgvDataMenu.AllowUserToAddRows = false;
            this.dgvDataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataMenu.Location = new System.Drawing.Point(60, 149);
            this.dgvDataMenu.Name = "dgvDataMenu";
            this.dgvDataMenu.ReadOnly = true;
            this.dgvDataMenu.RowHeadersWidth = 51;
            this.dgvDataMenu.RowTemplate.Height = 24;
            this.dgvDataMenu.Size = new System.Drawing.Size(712, 579);
            this.dgvDataMenu.TabIndex = 8;
            this.dgvDataMenu.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataMenu_CellContentDoubleClick);
            // 
            // pnlMenuInfo
            // 
            this.pnlMenuInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.pnlMenuInfo.Controls.Add(this.label4);
            this.pnlMenuInfo.Controls.Add(this.panel7);
            this.pnlMenuInfo.Enabled = false;
            this.pnlMenuInfo.Location = new System.Drawing.Point(799, 149);
            this.pnlMenuInfo.MaximumSize = new System.Drawing.Size(506, 579);
            this.pnlMenuInfo.MinimumSize = new System.Drawing.Size(7, 0);
            this.pnlMenuInfo.Name = "pnlMenuInfo";
            this.pnlMenuInfo.Size = new System.Drawing.Size(506, 579);
            this.pnlMenuInfo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Menu information";
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.lblIdMenu);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.lblPrice);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.pbImage);
            this.panel7.Location = new System.Drawing.Point(23, 78);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(462, 482);
            this.panel7.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.AutoScroll = true;
            this.panel11.Controls.Add(this.lblMenuName);
            this.panel11.Location = new System.Drawing.Point(43, 343);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(372, 76);
            this.panel11.TabIndex = 9;
            // 
            // lblMenuName
            // 
            this.lblMenuName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuName.Location = new System.Drawing.Point(14, 10);
            this.lblMenuName.MaximumSize = new System.Drawing.Size(345, 0);
            this.lblMenuName.MinimumSize = new System.Drawing.Size(345, 38);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(345, 38);
            this.lblMenuName.TabIndex = 1;
            this.lblMenuName.Text = "Menu Name";
            this.lblMenuName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(28, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "idMenu:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIdMenu
            // 
            this.lblIdMenu.AutoSize = true;
            this.lblIdMenu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdMenu.ForeColor = System.Drawing.Color.Gray;
            this.lblIdMenu.Location = new System.Drawing.Point(104, 22);
            this.lblIdMenu.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblIdMenu.Name = "lblIdMenu";
            this.lblIdMenu.Size = new System.Drawing.Size(69, 25);
            this.lblIdMenu.TabIndex = 1;
            this.lblIdMenu.Text = "#M000";
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(33, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(370, 16);
            this.panel8.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(33, 464);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(370, 16);
            this.panel9.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(95, 434);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Rp.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrice.Location = new System.Drawing.Point(129, 434);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(73, 23);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "9999999";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(28, 432);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 25);
            this.label22.TabIndex = 1;
            this.label22.Text = "Price :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Image = global::App_Cafe_UKK.Properties.Resources.noImage100;
            this.pbImage.InitialImage = null;
            this.pbImage.Location = new System.Drawing.Point(95, 56);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(283, 283);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // PageCRUDDataMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 772);
            this.Controls.Add(this.pnlMenuInfo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDangerSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvDataMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageCRUDDataMenu";
            this.Text = "PageDataMenu";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMenu)).EndInit();
            this.pnlMenuInfo.ResumeLayout(false);
            this.pnlMenuInfo.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblDangerSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvDataMenu;
        private System.Windows.Forms.Panel pnlMenuInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIdMenu;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
    }
}