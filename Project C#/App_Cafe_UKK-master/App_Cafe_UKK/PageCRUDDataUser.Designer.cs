
namespace App_Cafe_UKK
{
    partial class PageCRUDDataUser
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvDataUser = new System.Windows.Forms.DataGridView();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDangerSearch = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnCloseInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.lblNoTelp = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblKelamin = new System.Windows.Forms.Label();
            this.lblPosisi = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUser)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.SuspendLayout();
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
            // dgvDataUser
            // 
            this.dgvDataUser.AllowUserToAddRows = false;
            this.dgvDataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDataUser.Location = new System.Drawing.Point(59, 147);
            this.dgvDataUser.Name = "dgvDataUser";
            this.dgvDataUser.ReadOnly = true;
            this.dgvDataUser.RowHeadersWidth = 51;
            this.dgvDataUser.RowTemplate.Height = 24;
            this.dgvDataUser.Size = new System.Drawing.Size(1246, 579);
            this.dgvDataUser.TabIndex = 1;
            this.dgvDataUser.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // timerInfo
            // 
            this.timerInfo.Interval = 1;
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(59, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 34);
            this.panel3.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
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
            this.panel4.Location = new System.Drawing.Point(59, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 51);
            this.panel4.TabIndex = 6;
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
            // lblDangerSearch
            // 
            this.lblDangerSearch.AutoSize = true;
            this.lblDangerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangerSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDangerSearch.Location = new System.Drawing.Point(62, 20);
            this.lblDangerSearch.Name = "lblDangerSearch";
            this.lblDangerSearch.Size = new System.Drawing.Size(238, 17);
            this.lblDangerSearch.TabIndex = 7;
            this.lblDangerSearch.Text = "*You\'re not looking for anything";
            this.lblDangerSearch.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = global::App_Cafe_UKK.Properties.Resources.refresh24;
            this.btnRefresh.Location = new System.Drawing.Point(658, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 63);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.pnlInfo.Controls.Add(this.btnCloseInfo);
            this.pnlInfo.Controls.Add(this.label5);
            this.pnlInfo.Controls.Add(this.panel7);
            this.pnlInfo.Location = new System.Drawing.Point(1359, 66);
            this.pnlInfo.MaximumSize = new System.Drawing.Size(440, 706);
            this.pnlInfo.MinimumSize = new System.Drawing.Size(7, 706);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(10, 706);
            this.pnlInfo.TabIndex = 11;
            // 
            // btnCloseInfo
            // 
            this.btnCloseInfo.BackColor = System.Drawing.Color.Red;
            this.btnCloseInfo.FlatAppearance.BorderSize = 0;
            this.btnCloseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseInfo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseInfo.Location = new System.Drawing.Point(355, 3);
            this.btnCloseInfo.Name = "btnCloseInfo";
            this.btnCloseInfo.Size = new System.Drawing.Size(75, 33);
            this.btnCloseInfo.TabIndex = 2;
            this.btnCloseInfo.Text = "X";
            this.btnCloseInfo.UseVisualStyleBackColor = false;
            this.btnCloseInfo.Click += new System.EventHandler(this.btnCloseInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Detailed Information";
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.flowLayoutPanel1);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.dtpTanggalLahir);
            this.panel7.Controls.Add(this.lblNoTelp);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.lblStatus);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.lblKelamin);
            this.panel7.Controls.Add(this.lblPosisi);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.pbProfile);
            this.panel7.Location = new System.Drawing.Point(10, 71);
            this.panel7.Margin = new System.Windows.Forms.Padding(10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(420, 625);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.lblDeskripsi);
            this.panel8.Location = new System.Drawing.Point(27, 232);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(352, 88);
            this.panel8.TabIndex = 8;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeskripsi.Location = new System.Drawing.Point(5, 3);
            this.lblDeskripsi.Margin = new System.Windows.Forms.Padding(0);
            this.lblDeskripsi.MaximumSize = new System.Drawing.Size(290, 0);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(285, 207);
            this.lblDeskripsi.TabIndex = 1;
            this.lblDeskripsi.Text = "Saya? Knp sm \r\nsy?? HAHAHAHA\r\nHAHHHHHH\r\nHHHHHH\r\nHHHHHHHHHHHH\r\nHAAAAAAAAAAAAAAAAAA" +
    "\r\nAAAAAAAAAAAA\r\nAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHH";
            this.lblDeskripsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lblUsername);
            this.flowLayoutPanel1.Controls.Add(this.lblId);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(319, 57);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(0, 10);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblUsername.MaximumSize = new System.Drawing.Size(190, 0);
            this.lblUsername.MinimumSize = new System.Drawing.Size(190, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(190, 64);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Akhmad Aakhif A";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblId.Location = new System.Drawing.Point(190, 10);
            this.lblId.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(82, 32);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "#K000";
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(27, 650);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(370, 32);
            this.panel9.TabIndex = 7;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalLahir.Location = new System.Drawing.Point(144, 609);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(249, 27);
            this.dtpTanggalLahir.TabIndex = 6;
            // 
            // lblNoTelp
            // 
            this.lblNoTelp.AutoSize = true;
            this.lblNoTelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTelp.Location = new System.Drawing.Point(181, 572);
            this.lblNoTelp.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblNoTelp.Name = "lblNoTelp";
            this.lblNoTelp.Size = new System.Drawing.Size(139, 20);
            this.lblNoTelp.TabIndex = 4;
            this.lblNoTelp.Text = "+62 855-3636-3146";
            this.lblNoTelp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(22, 610);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Date of Birth :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(22, 567);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 25);
            this.label15.TabIndex = 5;
            this.label15.Text = "Telephone Num. :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel10
            // 
            this.panel10.AutoScroll = true;
            this.panel10.Controls.Add(this.lblAlamat);
            this.panel10.Location = new System.Drawing.Point(118, 458);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(275, 100);
            this.panel10.TabIndex = 3;
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlamat.Location = new System.Drawing.Point(3, 0);
            this.lblAlamat.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblAlamat.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(250, 60);
            this.lblAlamat.TabIndex = 1;
            this.lblAlamat.Text = "Rumdin Binajiwa 1 No. 9 RT 02 RW 11, Sumberporong, Lawang, Malang, Jawa Timur ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblStatus.Location = new System.Drawing.Point(111, 422);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 20);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "ONLINE";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(22, 458);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Address :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(22, 417);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 25);
            this.label19.TabIndex = 1;
            this.label19.Text = "Status    :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblKelamin
            // 
            this.lblKelamin.AutoSize = true;
            this.lblKelamin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelamin.Location = new System.Drawing.Point(111, 343);
            this.lblKelamin.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblKelamin.Name = "lblKelamin";
            this.lblKelamin.Size = new System.Drawing.Size(47, 20);
            this.lblKelamin.TabIndex = 1;
            this.lblKelamin.Text = "MALE";
            this.lblKelamin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPosisi
            // 
            this.lblPosisi.AutoSize = true;
            this.lblPosisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosisi.Location = new System.Drawing.Point(111, 379);
            this.lblPosisi.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPosisi.Name = "lblPosisi";
            this.lblPosisi.Size = new System.Drawing.Size(58, 20);
            this.lblPosisi.TabIndex = 1;
            this.lblPosisi.Text = "ADMIN";
            this.lblPosisi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(22, 338);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 25);
            this.label22.TabIndex = 1;
            this.label22.Text = "Gender  :";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(22, 374);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 25);
            this.label23.TabIndex = 1;
            this.label23.Text = "Position :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbProfile
            // 
            this.pbProfile.Location = new System.Drawing.Point(148, 23);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(140, 140);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 0;
            this.pbProfile.TabStop = false;
            // 
            // PageCRUDDataUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 772);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblDangerSearch);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvDataUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageCRUDDataUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUser)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvDataUser;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDangerSearch;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnCloseInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblKelamin;
        private System.Windows.Forms.Label lblPosisi;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.PictureBox pbProfile;
    }
}