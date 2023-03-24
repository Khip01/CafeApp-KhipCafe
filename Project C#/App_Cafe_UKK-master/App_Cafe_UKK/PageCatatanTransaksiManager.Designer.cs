
namespace App_Cafe_UKK
{
    partial class PageCatatanTransaksiManager
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
            this.dgvCatatanTransaksi = new System.Windows.Forms.DataGridView();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDangerSearch = new System.Windows.Forms.Label();
            this.pnlNama = new System.Windows.Forms.Panel();
            this.cbLstNama = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.tabControlDate = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTahun2 = new System.Windows.Forms.ComboBox();
            this.cbBulan = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTahun = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpCustomSecond = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCustomFirst = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSortByName = new System.Windows.Forms.Label();
            this.lblSortByDate = new System.Windows.Forms.Label();
            this.lblSortByNone = new System.Windows.Forms.Label();
            this.pnlSortBy = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSubmitSortByDate = new System.Windows.Forms.Button();
            this.btnSubmitSortByName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatatanTransaksi)).BeginInit();
            this.panel4.SuspendLayout();
            this.pnlNama.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.tabControlDate.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlSortBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatatanTransaksi
            // 
            this.dgvCatatanTransaksi.AllowUserToAddRows = false;
            this.dgvCatatanTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatatanTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCatatanTransaksi.Location = new System.Drawing.Point(60, 215);
            this.dgvCatatanTransaksi.Name = "dgvCatatanTransaksi";
            this.dgvCatatanTransaksi.ReadOnly = true;
            this.dgvCatatanTransaksi.RowHeadersWidth = 51;
            this.dgvCatatanTransaksi.RowTemplate.Height = 24;
            this.dgvCatatanTransaksi.Size = new System.Drawing.Size(1245, 438);
            this.dgvCatatanTransaksi.TabIndex = 14;
            // 
            // timerInfo
            // 
            this.timerInfo.Interval = 1;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(60, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 51);
            this.panel4.TabIndex = 19;
            // 
            // lblDangerSearch
            // 
            this.lblDangerSearch.AutoSize = true;
            this.lblDangerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangerSearch.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDangerSearch.Location = new System.Drawing.Point(63, 23);
            this.lblDangerSearch.Name = "lblDangerSearch";
            this.lblDangerSearch.Size = new System.Drawing.Size(238, 17);
            this.lblDangerSearch.TabIndex = 20;
            this.lblDangerSearch.Text = "*You\'re not looking for anything";
            this.lblDangerSearch.Visible = false;
            // 
            // pnlNama
            // 
            this.pnlNama.BackColor = System.Drawing.Color.White;
            this.pnlNama.Controls.Add(this.btnSubmitSortByName);
            this.pnlNama.Controls.Add(this.cbLstNama);
            this.pnlNama.Location = new System.Drawing.Point(697, 103);
            this.pnlNama.Name = "pnlNama";
            this.pnlNama.Size = new System.Drawing.Size(307, 42);
            this.pnlNama.TabIndex = 21;
            this.pnlNama.Visible = false;
            // 
            // cbLstNama
            // 
            this.cbLstNama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLstNama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLstNama.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLstNama.FormattingEnabled = true;
            this.cbLstNama.Location = new System.Drawing.Point(3, 4);
            this.cbLstNama.Name = "cbLstNama";
            this.cbLstNama.Size = new System.Drawing.Size(260, 33);
            this.cbLstNama.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sort By :";
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.Color.White;
            this.pnlDate.Controls.Add(this.btnSubmitSortByDate);
            this.pnlDate.Controls.Add(this.tabControlDate);
            this.pnlDate.Location = new System.Drawing.Point(697, 103);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(307, 106);
            this.pnlDate.TabIndex = 1;
            this.pnlDate.Visible = false;
            // 
            // tabControlDate
            // 
            this.tabControlDate.Controls.Add(this.tabPage3);
            this.tabControlDate.Controls.Add(this.tabPage4);
            this.tabControlDate.Controls.Add(this.tabPage5);
            this.tabControlDate.Controls.Add(this.tabPage6);
            this.tabControlDate.Location = new System.Drawing.Point(4, 5);
            this.tabControlDate.Name = "tabControlDate";
            this.tabControlDate.SelectedIndex = 0;
            this.tabControlDate.Size = new System.Drawing.Size(259, 97);
            this.tabControlDate.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dtpDate);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(251, 68);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Day";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Day";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(4, 40);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(241, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.cbTahun2);
            this.tabPage4.Controls.Add(this.cbBulan);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(251, 68);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Month";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Month";
            // 
            // cbTahun2
            // 
            this.cbTahun2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTahun2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTahun2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTahun2.FormattingEnabled = true;
            this.cbTahun2.Location = new System.Drawing.Point(150, 30);
            this.cbTahun2.Name = "cbTahun2";
            this.cbTahun2.Size = new System.Drawing.Size(94, 33);
            this.cbTahun2.TabIndex = 1;
            // 
            // cbBulan
            // 
            this.cbBulan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBulan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBulan.FormattingEnabled = true;
            this.cbBulan.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cbBulan.Location = new System.Drawing.Point(6, 30);
            this.cbBulan.Name = "cbBulan";
            this.cbBulan.Size = new System.Drawing.Size(138, 33);
            this.cbBulan.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.cbTahun);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(251, 68);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Year";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Year";
            // 
            // cbTahun
            // 
            this.cbTahun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTahun.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTahun.FormattingEnabled = true;
            this.cbTahun.Location = new System.Drawing.Point(6, 32);
            this.cbTahun.Name = "cbTahun";
            this.cbTahun.Size = new System.Drawing.Size(238, 33);
            this.cbTahun.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.dtpCustomSecond);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.dtpCustomFirst);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(251, 68);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Custom";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Custom (date - date)";
            // 
            // dtpCustomSecond
            // 
            this.dtpCustomSecond.CalendarFont = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCustomSecond.Location = new System.Drawing.Point(145, 40);
            this.dtpCustomSecond.Name = "dtpCustomSecond";
            this.dtpCustomSecond.Size = new System.Drawing.Size(101, 22);
            this.dtpCustomSecond.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "to";
            this.label1.Visible = false;
            // 
            // dtpCustomFirst
            // 
            this.dtpCustomFirst.CalendarFont = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCustomFirst.Location = new System.Drawing.Point(6, 40);
            this.dtpCustomFirst.Name = "dtpCustomFirst";
            this.dtpCustomFirst.Size = new System.Drawing.Size(100, 22);
            this.dtpCustomFirst.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblSortByName);
            this.flowLayoutPanel1.Controls.Add(this.lblSortByDate);
            this.flowLayoutPanel1.Controls.Add(this.lblSortByNone);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(89, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1142, 30);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // lblSortByName
            // 
            this.lblSortByName.AutoSize = true;
            this.lblSortByName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortByName.Location = new System.Drawing.Point(3, 0);
            this.lblSortByName.Name = "lblSortByName";
            this.lblSortByName.Size = new System.Drawing.Size(62, 25);
            this.lblSortByName.TabIndex = 22;
            this.lblSortByName.Text = "Name";
            this.lblSortByName.Visible = false;
            // 
            // lblSortByDate
            // 
            this.lblSortByDate.AutoSize = true;
            this.lblSortByDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortByDate.Location = new System.Drawing.Point(71, 0);
            this.lblSortByDate.Name = "lblSortByDate";
            this.lblSortByDate.Size = new System.Drawing.Size(51, 25);
            this.lblSortByDate.TabIndex = 22;
            this.lblSortByDate.Text = "Date";
            this.lblSortByDate.Visible = false;
            // 
            // lblSortByNone
            // 
            this.lblSortByNone.AutoSize = true;
            this.lblSortByNone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortByNone.Location = new System.Drawing.Point(128, 0);
            this.lblSortByNone.Name = "lblSortByNone";
            this.lblSortByNone.Size = new System.Drawing.Size(64, 25);
            this.lblSortByNone.TabIndex = 22;
            this.lblSortByNone.Text = "NONE";
            // 
            // pnlSortBy
            // 
            this.pnlSortBy.Controls.Add(this.flowLayoutPanel1);
            this.pnlSortBy.Controls.Add(this.label7);
            this.pnlSortBy.Location = new System.Drawing.Point(60, 159);
            this.pnlSortBy.Name = "pnlSortBy";
            this.pnlSortBy.Size = new System.Drawing.Size(1245, 50);
            this.pnlSortBy.TabIndex = 24;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(582, 671);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(199, 50);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "Print All Transaction";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.BackColor = System.Drawing.Color.Peru;
            this.btnSortByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortByDate.FlatAppearance.BorderSize = 0;
            this.btnSortByDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByDate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSortByDate.Image = global::App_Cafe_UKK.Properties.Resources.calendar24;
            this.btnSortByDate.Location = new System.Drawing.Point(850, 37);
            this.btnSortByDate.Margin = new System.Windows.Forms.Padding(0);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(153, 63);
            this.btnSortByDate.TabIndex = 15;
            this.btnSortByDate.Text = "Date";
            this.btnSortByDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortByDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortByDate.UseVisualStyleBackColor = false;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.BackColor = System.Drawing.Color.Peru;
            this.btnSortByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortByName.FlatAppearance.BorderSize = 0;
            this.btnSortByName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortByName.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSortByName.Image = global::App_Cafe_UKK.Properties.Resources.userSimpleWhite24;
            this.btnSortByName.Location = new System.Drawing.Point(697, 37);
            this.btnSortByName.Margin = new System.Windows.Forms.Padding(0);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(153, 63);
            this.btnSortByName.TabIndex = 15;
            this.btnSortByName.Text = "Name";
            this.btnSortByName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortByName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortByName.UseVisualStyleBackColor = false;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Image = global::App_Cafe_UKK.Properties.Resources.refresh24;
            this.btnRefresh.Location = new System.Drawing.Point(1152, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 60);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // btnSubmitSortByDate
            // 
            this.btnSubmitSortByDate.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmitSortByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitSortByDate.FlatAppearance.BorderSize = 0;
            this.btnSubmitSortByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitSortByDate.Image = global::App_Cafe_UKK.Properties.Resources.checkmark24;
            this.btnSubmitSortByDate.Location = new System.Drawing.Point(265, 6);
            this.btnSubmitSortByDate.Name = "btnSubmitSortByDate";
            this.btnSubmitSortByDate.Size = new System.Drawing.Size(36, 96);
            this.btnSubmitSortByDate.TabIndex = 2;
            this.btnSubmitSortByDate.UseVisualStyleBackColor = false;
            this.btnSubmitSortByDate.Click += new System.EventHandler(this.btnSubmitSortByDate_Click);
            // 
            // btnSubmitSortByName
            // 
            this.btnSubmitSortByName.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmitSortByName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitSortByName.FlatAppearance.BorderSize = 0;
            this.btnSubmitSortByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitSortByName.Image = global::App_Cafe_UKK.Properties.Resources.checkmark24;
            this.btnSubmitSortByName.Location = new System.Drawing.Point(266, 3);
            this.btnSubmitSortByName.Name = "btnSubmitSortByName";
            this.btnSubmitSortByName.Size = new System.Drawing.Size(36, 36);
            this.btnSubmitSortByName.TabIndex = 2;
            this.btnSubmitSortByName.UseVisualStyleBackColor = false;
            this.btnSubmitSortByName.Click += new System.EventHandler(this.btnSubmitSortByName_Click);
            // 
            // PageCatatanTransaksiManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 753);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSortByDate);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvCatatanTransaksi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblDangerSearch);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.pnlNama);
            this.Controls.Add(this.pnlSortBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageCatatanTransaksiManager";
            this.Text = "PageCatatanTransaksiManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatatanTransaksi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlNama.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.tabControlDate.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnlSortBy.ResumeLayout(false);
            this.pnlSortBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvCatatanTransaksi;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblDangerSearch;
        private System.Windows.Forms.Panel pnlNama;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.ComboBox cbLstNama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnSubmitSortByName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSortByName;
        private System.Windows.Forms.Label lblSortByDate;
        private System.Windows.Forms.Panel pnlSortBy;
        private System.Windows.Forms.Label lblSortByNone;
        private System.Windows.Forms.TabControl tabControlDate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cbBulan;
        private System.Windows.Forms.Button btnSubmitSortByDate;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox cbTahun;
        private System.Windows.Forms.DateTimePicker dtpCustomSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCustomFirst;
        private System.Windows.Forms.ComboBox cbTahun2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
    }
}