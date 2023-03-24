
namespace App_Cafe_UKK
{
    partial class FormLogin
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
            this.timerNavSignIn2 = new System.Windows.Forms.Timer(this.components);
            this.timerNavSignUp2 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtUsernameSignUp = new System.Windows.Forms.TextBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.dangerPasswordSignIn = new System.Windows.Forms.Label();
            this.dangerUsernameSignIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsernameSignIn = new System.Windows.Forms.TextBox();
            this.txtPasswordSignIn = new System.Windows.Forms.TextBox();
            this.btnVisiblePassSignIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelParent = new System.Windows.Forms.Panel();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.lblAlphabetCounterUsername = new System.Windows.Forms.Label();
            this.panelAsk = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbAsk = new System.Windows.Forms.PictureBox();
            this.dangerPasswordSignUp = new System.Windows.Forms.Label();
            this.dangerUsernameSignUp = new System.Windows.Forms.Label();
            this.cbTerms = new System.Windows.Forms.CheckBox();
            this.cbPosisi = new System.Windows.Forms.ComboBox();
            this.btnVisiblePassSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timerNavSignIn = new System.Windows.Forms.Timer(this.components);
            this.timerNavSignUp = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.timerPageSignInBtn = new System.Windows.Forms.Timer(this.components);
            this.timerPageSignUpBtn = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelSignIn.SuspendLayout();
            this.panelParent.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            this.panelAsk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerNavSignIn2
            // 
            this.timerNavSignIn2.Interval = 1;
            this.timerNavSignIn2.Tick += new System.EventHandler(this.timerNavSignIn2_Tick);
            // 
            // timerNavSignUp2
            // 
            this.timerNavSignUp2.Interval = 1;
            this.timerNavSignUp2.Tick += new System.EventHandler(this.timerNavSignUp2_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.label6.Location = new System.Drawing.Point(14, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Location = new System.Drawing.Point(149, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 37);
            this.panel1.TabIndex = 12;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Enabled = false;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(-8, -15);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(176, 66);
            this.btnSignIn.TabIndex = 9;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.txtPasswordSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.txtPasswordSignUp.Location = new System.Drawing.Point(13, 130);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.Size = new System.Drawing.Size(370, 34);
            this.txtPasswordSignUp.TabIndex = 1;
            this.txtPasswordSignUp.TextChanged += new System.EventHandler(this.txtPasswordSignUp_TextChanged);
            this.txtPasswordSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordSignUp_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSignUp);
            this.panel2.Location = new System.Drawing.Point(300, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 37);
            this.panel2.TabIndex = 13;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(-13, -16);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(176, 66);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameSignUp.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsernameSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.txtUsernameSignUp.Location = new System.Drawing.Point(13, 40);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.Size = new System.Drawing.Size(413, 34);
            this.txtUsernameSignUp.TabIndex = 1;
            this.txtUsernameSignUp.TextChanged += new System.EventHandler(this.txtUsernameSignUp_TextChanged);
            this.txtUsernameSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsernameSignUp_KeyDown);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.panelNav.Location = new System.Drawing.Point(149, 264);
            this.panelNav.MaximumSize = new System.Drawing.Size(300, 10);
            this.panelNav.MinimumSize = new System.Drawing.Size(149, 10);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(149, 10);
            this.panelNav.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.label5.Location = new System.Drawing.Point(14, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // panelSignIn
            // 
            this.panelSignIn.Controls.Add(this.dangerPasswordSignIn);
            this.panelSignIn.Controls.Add(this.dangerUsernameSignIn);
            this.panelSignIn.Controls.Add(this.label2);
            this.panelSignIn.Controls.Add(this.txtUsernameSignIn);
            this.panelSignIn.Controls.Add(this.txtPasswordSignIn);
            this.panelSignIn.Controls.Add(this.btnVisiblePassSignIn);
            this.panelSignIn.Controls.Add(this.label3);
            this.panelSignIn.Location = new System.Drawing.Point(22, 32);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(442, 252);
            this.panelSignIn.TabIndex = 15;
            // 
            // dangerPasswordSignIn
            // 
            this.dangerPasswordSignIn.AutoSize = true;
            this.dangerPasswordSignIn.ForeColor = System.Drawing.Color.Red;
            this.dangerPasswordSignIn.Location = new System.Drawing.Point(15, 192);
            this.dangerPasswordSignIn.Name = "dangerPasswordSignIn";
            this.dangerPasswordSignIn.Size = new System.Drawing.Size(174, 17);
            this.dangerPasswordSignIn.TabIndex = 6;
            this.dangerPasswordSignIn.Text = "Password must be filled in!";
            this.dangerPasswordSignIn.Visible = false;
            // 
            // dangerUsernameSignIn
            // 
            this.dangerUsernameSignIn.AutoSize = true;
            this.dangerUsernameSignIn.ForeColor = System.Drawing.Color.Red;
            this.dangerUsernameSignIn.Location = new System.Drawing.Point(15, 95);
            this.dangerUsernameSignIn.Name = "dangerUsernameSignIn";
            this.dangerUsernameSignIn.Size = new System.Drawing.Size(178, 17);
            this.dangerUsernameSignIn.TabIndex = 6;
            this.dangerUsernameSignIn.Text = "Username must be filled in!";
            this.dangerUsernameSignIn.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // txtUsernameSignIn
            // 
            this.txtUsernameSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsernameSignIn.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsernameSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsernameSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameSignIn.ForeColor = System.Drawing.Color.Black;
            this.txtUsernameSignIn.Location = new System.Drawing.Point(18, 58);
            this.txtUsernameSignIn.Name = "txtUsernameSignIn";
            this.txtUsernameSignIn.Size = new System.Drawing.Size(413, 34);
            this.txtUsernameSignIn.TabIndex = 1;
            this.txtUsernameSignIn.TextChanged += new System.EventHandler(this.txtUsernameSignIn_TextChanged);
            this.txtUsernameSignIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsernameSignIn_KeyDown);
            // 
            // txtPasswordSignIn
            // 
            this.txtPasswordSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPasswordSignIn.BackColor = System.Drawing.SystemColors.Control;
            this.txtPasswordSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordSignIn.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordSignIn.Location = new System.Drawing.Point(18, 155);
            this.txtPasswordSignIn.Name = "txtPasswordSignIn";
            this.txtPasswordSignIn.Size = new System.Drawing.Size(370, 34);
            this.txtPasswordSignIn.TabIndex = 1;
            this.txtPasswordSignIn.TextChanged += new System.EventHandler(this.txtPasswordSignIn_TextChanged);
            this.txtPasswordSignIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPasswordSignIn_KeyDown);
            // 
            // btnVisiblePassSignIn
            // 
            this.btnVisiblePassSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisiblePassSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisiblePassSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisiblePassSignIn.Image = global::App_Cafe_UKK.Properties.Resources.EyeHide24;
            this.btnVisiblePassSignIn.Location = new System.Drawing.Point(394, 155);
            this.btnVisiblePassSignIn.Name = "btnVisiblePassSignIn";
            this.btnVisiblePassSignIn.Size = new System.Drawing.Size(39, 36);
            this.btnVisiblePassSignIn.TabIndex = 5;
            this.btnVisiblePassSignIn.UseVisualStyleBackColor = true;
            this.btnVisiblePassSignIn.Click += new System.EventHandler(this.btnVisiblePass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // panelParent
            // 
            this.panelParent.Controls.Add(this.panelSignUp);
            this.panelParent.Controls.Add(this.panelSignIn);
            this.panelParent.Location = new System.Drawing.Point(58, 290);
            this.panelParent.Name = "panelParent";
            this.panelParent.Size = new System.Drawing.Size(485, 330);
            this.panelParent.TabIndex = 17;
            // 
            // panelSignUp
            // 
            this.panelSignUp.Controls.Add(this.lblAlphabetCounterUsername);
            this.panelSignUp.Controls.Add(this.panelAsk);
            this.panelSignUp.Controls.Add(this.pbAsk);
            this.panelSignUp.Controls.Add(this.dangerPasswordSignUp);
            this.panelSignUp.Controls.Add(this.dangerUsernameSignUp);
            this.panelSignUp.Controls.Add(this.cbTerms);
            this.panelSignUp.Controls.Add(this.cbPosisi);
            this.panelSignUp.Controls.Add(this.label5);
            this.panelSignUp.Controls.Add(this.txtUsernameSignUp);
            this.panelSignUp.Controls.Add(this.txtPasswordSignUp);
            this.panelSignUp.Controls.Add(this.btnVisiblePassSignUp);
            this.panelSignUp.Controls.Add(this.label1);
            this.panelSignUp.Controls.Add(this.label6);
            this.panelSignUp.Location = new System.Drawing.Point(500, 3);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(442, 317);
            this.panelSignUp.TabIndex = 16;
            // 
            // lblAlphabetCounterUsername
            // 
            this.lblAlphabetCounterUsername.AutoSize = true;
            this.lblAlphabetCounterUsername.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphabetCounterUsername.Location = new System.Drawing.Point(336, 78);
            this.lblAlphabetCounterUsername.Name = "lblAlphabetCounterUsername";
            this.lblAlphabetCounterUsername.Size = new System.Drawing.Size(90, 19);
            this.lblAlphabetCounterUsername.TabIndex = 11;
            this.lblAlphabetCounterUsername.Text = "40 remaining";
            // 
            // panelAsk
            // 
            this.panelAsk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAsk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAsk.Controls.Add(this.label4);
            this.panelAsk.Location = new System.Drawing.Point(195, 167);
            this.panelAsk.Name = "panelAsk";
            this.panelAsk.Size = new System.Drawing.Size(226, 47);
            this.panelAsk.TabIndex = 10;
            this.panelAsk.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.label4.Location = new System.Drawing.Point(5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ask the admin to add users such \r\nas MANAGER and ADMIN";
            // 
            // pbAsk
            // 
            this.pbAsk.Image = global::App_Cafe_UKK.Properties.Resources.askQuestion24;
            this.pbAsk.Location = new System.Drawing.Point(397, 221);
            this.pbAsk.Name = "pbAsk";
            this.pbAsk.Size = new System.Drawing.Size(24, 24);
            this.pbAsk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAsk.TabIndex = 9;
            this.pbAsk.TabStop = false;
            this.pbAsk.MouseLeave += new System.EventHandler(this.pbAsk_MouseLeave);
            this.pbAsk.MouseHover += new System.EventHandler(this.pbAsk_MouseHover);
            // 
            // dangerPasswordSignUp
            // 
            this.dangerPasswordSignUp.AutoSize = true;
            this.dangerPasswordSignUp.ForeColor = System.Drawing.Color.Red;
            this.dangerPasswordSignUp.Location = new System.Drawing.Point(15, 167);
            this.dangerPasswordSignUp.Name = "dangerPasswordSignUp";
            this.dangerPasswordSignUp.Size = new System.Drawing.Size(174, 17);
            this.dangerPasswordSignUp.TabIndex = 8;
            this.dangerPasswordSignUp.Text = "Password must be filled in!";
            this.dangerPasswordSignUp.Visible = false;
            // 
            // dangerUsernameSignUp
            // 
            this.dangerUsernameSignUp.AutoSize = true;
            this.dangerUsernameSignUp.ForeColor = System.Drawing.Color.Red;
            this.dangerUsernameSignUp.Location = new System.Drawing.Point(15, 78);
            this.dangerUsernameSignUp.Name = "dangerUsernameSignUp";
            this.dangerUsernameSignUp.Size = new System.Drawing.Size(178, 17);
            this.dangerUsernameSignUp.TabIndex = 8;
            this.dangerUsernameSignUp.Text = "Username must be filled in!";
            this.dangerUsernameSignUp.Visible = false;
            // 
            // cbTerms
            // 
            this.cbTerms.AutoSize = true;
            this.cbTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTerms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.cbTerms.Location = new System.Drawing.Point(21, 272);
            this.cbTerms.Name = "cbTerms";
            this.cbTerms.Size = new System.Drawing.Size(253, 27);
            this.cbTerms.TabIndex = 7;
            this.cbTerms.Text = "I Agree Terms and Conditions";
            this.cbTerms.UseVisualStyleBackColor = true;
            this.cbTerms.CheckedChanged += new System.EventHandler(this.cbTerms_CheckedChanged);
            this.cbTerms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTerms_KeyDown);
            // 
            // cbPosisi
            // 
            this.cbPosisi.Enabled = false;
            this.cbPosisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPosisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPosisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.cbPosisi.FormattingEnabled = true;
            this.cbPosisi.Location = new System.Drawing.Point(16, 220);
            this.cbPosisi.Name = "cbPosisi";
            this.cbPosisi.Size = new System.Drawing.Size(370, 36);
            this.cbPosisi.TabIndex = 6;
            this.cbPosisi.Text = "KASIR";
            // 
            // btnVisiblePassSignUp
            // 
            this.btnVisiblePassSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisiblePassSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisiblePassSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisiblePassSignUp.Image = global::App_Cafe_UKK.Properties.Resources.EyeHide24;
            this.btnVisiblePassSignUp.Location = new System.Drawing.Point(389, 130);
            this.btnVisiblePassSignUp.Name = "btnVisiblePassSignUp";
            this.btnVisiblePassSignUp.Size = new System.Drawing.Size(39, 36);
            this.btnVisiblePassSignUp.TabIndex = 5;
            this.btnVisiblePassSignUp.UseVisualStyleBackColor = true;
            this.btnVisiblePassSignUp.Click += new System.EventHandler(this.btnVisiblePassSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(45)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(17, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Position";
            // 
            // timerNavSignIn
            // 
            this.timerNavSignIn.Interval = 1;
            this.timerNavSignIn.Tick += new System.EventHandler(this.timerNavSignIn_Tick);
            // 
            // timerNavSignUp
            // 
            this.timerNavSignUp.Interval = 1;
            this.timerNavSignUp.Tick += new System.EventHandler(this.timerNavSignUp_Tick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.btnSubmit.Location = new System.Drawing.Point(239, 626);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 50);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "LOGIN";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // timerPageSignInBtn
            // 
            this.timerPageSignInBtn.Interval = 1;
            this.timerPageSignInBtn.Tick += new System.EventHandler(this.timerPageSignInBtn_Tick);
            // 
            // timerPageSignUpBtn
            // 
            this.timerPageSignUpBtn.Interval = 1;
            this.timerPageSignUpBtn.Tick += new System.EventHandler(this.timerPageSignUpBtn_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Cafe_UKK.Properties.Resources.Khip_s_Cafe_Down_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(197, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(34)))), ((int)(((byte)(15)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(527, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.LightGray;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.Location = new System.Drawing.Point(453, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 45);
            this.btnMinimize.TabIndex = 20;
            this.btnMinimize.Text = "🗕";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 750);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNav);
            this.Controls.Add(this.panelParent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.panelParent.ResumeLayout(false);
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.panelAsk.ResumeLayout(false);
            this.panelAsk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAsk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerNavSignIn2;
        private System.Windows.Forms.Timer timerNavSignUp2;
        private System.Windows.Forms.Button btnVisiblePassSignUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtUsernameSignUp;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernameSignIn;
        private System.Windows.Forms.TextBox txtPasswordSignIn;
        private System.Windows.Forms.Button btnVisiblePassSignIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelParent;
        private System.Windows.Forms.Panel panelSignUp;
        private System.Windows.Forms.Timer timerNavSignIn;
        private System.Windows.Forms.Timer timerNavSignUp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Timer timerPageSignInBtn;
        private System.Windows.Forms.Timer timerPageSignUpBtn;
        private System.Windows.Forms.ComboBox cbPosisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbTerms;
        private System.Windows.Forms.Label dangerPasswordSignIn;
        private System.Windows.Forms.Label dangerUsernameSignIn;
        private System.Windows.Forms.Label dangerPasswordSignUp;
        private System.Windows.Forms.Label dangerUsernameSignUp;
        private System.Windows.Forms.PictureBox pbAsk;
        private System.Windows.Forms.Panel panelAsk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblAlphabetCounterUsername;
    }
}