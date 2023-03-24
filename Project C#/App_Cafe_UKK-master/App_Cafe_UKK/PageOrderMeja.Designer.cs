
namespace App_Cafe_UKK
{
    partial class PageOrderMeja
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOrderPreview = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIdOrder = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dangerIdOrder = new System.Windows.Forms.Label();
            this.dangerNoMeja = new System.Windows.Forms.Label();
            this.lblServedBy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNoMeja = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDataMeja = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnManageMeja = new System.Windows.Forms.Button();
            this.pnlOrderMeja = new System.Windows.Forms.Panel();
            this.pnlManageMeja = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDataMeja2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOrderMeja = new System.Windows.Forms.Button();
            this.btnEmptyTable = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSelectedMeja = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMeja)).BeginInit();
            this.pnlOrderMeja.SuspendLayout();
            this.pnlManageMeja.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMeja2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedMeja)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(28, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Order :";
            // 
            // dgvOrderPreview
            // 
            this.dgvOrderPreview.AllowUserToAddRows = false;
            this.dgvOrderPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderPreview.Location = new System.Drawing.Point(36, 74);
            this.dgvOrderPreview.Name = "dgvOrderPreview";
            this.dgvOrderPreview.ReadOnly = true;
            this.dgvOrderPreview.RowHeadersWidth = 51;
            this.dgvOrderPreview.RowTemplate.Height = 24;
            this.dgvOrderPreview.Size = new System.Drawing.Size(676, 345);
            this.dgvOrderPreview.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvOrderPreview);
            this.panel1.Location = new System.Drawing.Point(535, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 452);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order Preview";
            // 
            // cbIdOrder
            // 
            this.cbIdOrder.BackColor = System.Drawing.SystemColors.Control;
            this.cbIdOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIdOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIdOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdOrder.FormattingEnabled = true;
            this.cbIdOrder.Location = new System.Drawing.Point(149, 108);
            this.cbIdOrder.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cbIdOrder.Name = "cbIdOrder";
            this.cbIdOrder.Size = new System.Drawing.Size(283, 36);
            this.cbIdOrder.TabIndex = 10;
            this.cbIdOrder.SelectedIndexChanged += new System.EventHandler(this.cbIdOrder_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dangerIdOrder);
            this.panel2.Controls.Add(this.dangerNoMeja);
            this.panel2.Controls.Add(this.lblServedBy);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnSaveCart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbNoMeja);
            this.panel2.Controls.Add(this.cbIdOrder);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(34, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(470, 452);
            this.panel2.TabIndex = 11;
            // 
            // dangerIdOrder
            // 
            this.dangerIdOrder.AutoSize = true;
            this.dangerIdOrder.ForeColor = System.Drawing.Color.Red;
            this.dangerIdOrder.Location = new System.Drawing.Point(146, 147);
            this.dangerIdOrder.Name = "dangerIdOrder";
            this.dangerIdOrder.Size = new System.Drawing.Size(167, 17);
            this.dangerIdOrder.TabIndex = 16;
            this.dangerIdOrder.Text = "ID Order must be filled in!";
            this.dangerIdOrder.Visible = false;
            // 
            // dangerNoMeja
            // 
            this.dangerNoMeja.AutoSize = true;
            this.dangerNoMeja.ForeColor = System.Drawing.Color.Red;
            this.dangerNoMeja.Location = new System.Drawing.Point(146, 211);
            this.dangerNoMeja.Name = "dangerNoMeja";
            this.dangerNoMeja.Size = new System.Drawing.Size(165, 17);
            this.dangerNoMeja.TabIndex = 16;
            this.dangerNoMeja.Text = "No Meja must be filled in!";
            this.dangerNoMeja.Visible = false;
            // 
            // lblServedBy
            // 
            this.lblServedBy.AutoSize = true;
            this.lblServedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblServedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServedBy.ForeColor = System.Drawing.Color.Gray;
            this.lblServedBy.Location = new System.Drawing.Point(103, 399);
            this.lblServedBy.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblServedBy.Name = "lblServedBy";
            this.lblServedBy.Size = new System.Drawing.Size(87, 20);
            this.lblServedBy.TabIndex = 14;
            this.lblServedBy.Text = "Anonymous";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(29, 399);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Served by";
            // 
            // btnSaveCart
            // 
            this.btnSaveCart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCart.FlatAppearance.BorderSize = 0;
            this.btnSaveCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveCart.Image = global::App_Cafe_UKK.Properties.Resources.order24;
            this.btnSaveCart.Location = new System.Drawing.Point(123, 258);
            this.btnSaveCart.Name = "btnSaveCart";
            this.btnSaveCart.Size = new System.Drawing.Size(217, 63);
            this.btnSaveCart.TabIndex = 13;
            this.btnSaveCart.Text = "Save Data Table";
            this.btnSaveCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveCart.UseVisualStyleBackColor = false;
            this.btnSaveCart.Click += new System.EventHandler(this.btnSaveDataTable_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Order Meja";
            // 
            // cbNoMeja
            // 
            this.cbNoMeja.BackColor = System.Drawing.SystemColors.Control;
            this.cbNoMeja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNoMeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoMeja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNoMeja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoMeja.FormattingEnabled = true;
            this.cbNoMeja.Location = new System.Drawing.Point(149, 172);
            this.cbNoMeja.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cbNoMeja.Name = "cbNoMeja";
            this.cbNoMeja.Size = new System.Drawing.Size(283, 36);
            this.cbNoMeja.TabIndex = 10;
            this.cbNoMeja.SelectedIndexChanged += new System.EventHandler(this.cbNoMeja_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "No Meja :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvDataMeja);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(34, 508);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 165);
            this.panel3.TabIndex = 12;
            // 
            // dgvDataMeja
            // 
            this.dgvDataMeja.AllowUserToAddRows = false;
            this.dgvDataMeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMeja.Location = new System.Drawing.Point(182, 27);
            this.dgvDataMeja.Name = "dgvDataMeja";
            this.dgvDataMeja.ReadOnly = true;
            this.dgvDataMeja.RowHeadersWidth = 51;
            this.dgvDataMeja.RowTemplate.Height = 24;
            this.dgvDataMeja.Size = new System.Drawing.Size(690, 115);
            this.dgvDataMeja.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(27, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Meja";
            // 
            // btnManageMeja
            // 
            this.btnManageMeja.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnManageMeja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageMeja.FlatAppearance.BorderSize = 0;
            this.btnManageMeja.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMeja.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManageMeja.Image = global::App_Cafe_UKK.Properties.Resources.orderTable24;
            this.btnManageMeja.Location = new System.Drawing.Point(1018, 610);
            this.btnManageMeja.Name = "btnManageMeja";
            this.btnManageMeja.Size = new System.Drawing.Size(262, 63);
            this.btnManageMeja.TabIndex = 13;
            this.btnManageMeja.Text = "Manage Meja";
            this.btnManageMeja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageMeja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageMeja.UseVisualStyleBackColor = false;
            this.btnManageMeja.Click += new System.EventHandler(this.btnManageMeja_Click);
            // 
            // pnlOrderMeja
            // 
            this.pnlOrderMeja.Controls.Add(this.panel3);
            this.pnlOrderMeja.Controls.Add(this.btnManageMeja);
            this.pnlOrderMeja.Controls.Add(this.panel1);
            this.pnlOrderMeja.Controls.Add(this.panel2);
            this.pnlOrderMeja.Location = new System.Drawing.Point(23, 28);
            this.pnlOrderMeja.Name = "pnlOrderMeja";
            this.pnlOrderMeja.Size = new System.Drawing.Size(1311, 697);
            this.pnlOrderMeja.TabIndex = 14;
            // 
            // pnlManageMeja
            // 
            this.pnlManageMeja.Controls.Add(this.panel5);
            this.pnlManageMeja.Controls.Add(this.panel4);
            this.pnlManageMeja.Location = new System.Drawing.Point(23, 28);
            this.pnlManageMeja.Name = "pnlManageMeja";
            this.pnlManageMeja.Size = new System.Drawing.Size(1311, 697);
            this.pnlManageMeja.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dgvDataMeja2);
            this.panel5.Location = new System.Drawing.Point(54, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1214, 363);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightCoral;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(36, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(321, 34);
            this.panel6.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Cafe_UKK.Properties.Resources.warning16;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(41, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Double click to select data table";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(30, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Table Data";
            // 
            // dgvDataMeja2
            // 
            this.dgvDataMeja2.AllowUserToAddRows = false;
            this.dgvDataMeja2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataMeja2.Location = new System.Drawing.Point(36, 98);
            this.dgvDataMeja2.Name = "dgvDataMeja2";
            this.dgvDataMeja2.ReadOnly = true;
            this.dgvDataMeja2.RowHeadersWidth = 51;
            this.dgvDataMeja2.RowTemplate.Height = 24;
            this.dgvDataMeja2.Size = new System.Drawing.Size(1142, 234);
            this.dgvDataMeja2.TabIndex = 0;
            this.dgvDataMeja2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataMeja2_CellContentDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnOrderMeja);
            this.panel4.Controls.Add(this.btnEmptyTable);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.dgvSelectedMeja);
            this.panel4.Location = new System.Drawing.Point(54, 427);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1214, 226);
            this.panel4.TabIndex = 0;
            // 
            // btnOrderMeja
            // 
            this.btnOrderMeja.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnOrderMeja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderMeja.FlatAppearance.BorderSize = 0;
            this.btnOrderMeja.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderMeja.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOrderMeja.Image = global::App_Cafe_UKK.Properties.Resources.order24;
            this.btnOrderMeja.Location = new System.Drawing.Point(916, 144);
            this.btnOrderMeja.Name = "btnOrderMeja";
            this.btnOrderMeja.Size = new System.Drawing.Size(262, 63);
            this.btnOrderMeja.TabIndex = 14;
            this.btnOrderMeja.Text = "Back To Order Meja";
            this.btnOrderMeja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderMeja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderMeja.UseVisualStyleBackColor = false;
            this.btnOrderMeja.Click += new System.EventHandler(this.btnOrderMeja_Click);
            // 
            // btnEmptyTable
            // 
            this.btnEmptyTable.BackColor = System.Drawing.Color.Red;
            this.btnEmptyTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmptyTable.FlatAppearance.BorderSize = 0;
            this.btnEmptyTable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyTable.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEmptyTable.Image = global::App_Cafe_UKK.Properties.Resources.orderTable24;
            this.btnEmptyTable.Location = new System.Drawing.Point(36, 144);
            this.btnEmptyTable.Name = "btnEmptyTable";
            this.btnEmptyTable.Size = new System.Drawing.Size(225, 63);
            this.btnEmptyTable.TabIndex = 14;
            this.btnEmptyTable.Text = "Empty the Table";
            this.btnEmptyTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmptyTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmptyTable.UseVisualStyleBackColor = false;
            this.btnEmptyTable.Click += new System.EventHandler(this.btnEmptyTable_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(30, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Selected Table";
            // 
            // dgvSelectedMeja
            // 
            this.dgvSelectedMeja.AllowUserToAddRows = false;
            this.dgvSelectedMeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedMeja.Location = new System.Drawing.Point(36, 66);
            this.dgvSelectedMeja.Name = "dgvSelectedMeja";
            this.dgvSelectedMeja.ReadOnly = true;
            this.dgvSelectedMeja.RowHeadersWidth = 51;
            this.dgvSelectedMeja.RowTemplate.Height = 24;
            this.dgvSelectedMeja.Size = new System.Drawing.Size(1142, 66);
            this.dgvSelectedMeja.TabIndex = 0;
            // 
            // PageOrderMeja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 753);
            this.Controls.Add(this.pnlOrderMeja);
            this.Controls.Add(this.pnlManageMeja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageOrderMeja";
            this.Text = "PageOrderMeja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMeja)).EndInit();
            this.pnlOrderMeja.ResumeLayout(false);
            this.pnlManageMeja.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataMeja2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedMeja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrderPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbIdOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNoMeja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveCart;
        private System.Windows.Forms.Label lblServedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDataMeja;
        private System.Windows.Forms.Button btnManageMeja;
        private System.Windows.Forms.Panel pnlOrderMeja;
        private System.Windows.Forms.Panel pnlManageMeja;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDataMeja2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSelectedMeja;
        private System.Windows.Forms.Button btnEmptyTable;
        private System.Windows.Forms.Button btnOrderMeja;
        private System.Windows.Forms.Label dangerIdOrder;
        private System.Windows.Forms.Label dangerNoMeja;
    }
}