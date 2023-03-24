
namespace App_Cafe_UKK
{
    partial class ShowChangeLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowChangeLog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseDialog = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtxtChangeLog = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCloseDialog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 1;
            // 
            // btnCloseDialog
            // 
            this.btnCloseDialog.BackColor = System.Drawing.Color.Red;
            this.btnCloseDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseDialog.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCloseDialog.FlatAppearance.BorderSize = 0;
            this.btnCloseDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDialog.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCloseDialog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseDialog.Location = new System.Drawing.Point(748, 0);
            this.btnCloseDialog.Name = "btnCloseDialog";
            this.btnCloseDialog.Size = new System.Drawing.Size(52, 35);
            this.btnCloseDialog.TabIndex = 3;
            this.btnCloseDialog.Text = "X";
            this.btnCloseDialog.UseVisualStyleBackColor = false;
            this.btnCloseDialog.Click += new System.EventHandler(this.btnCloseDialog_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtxtChangeLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 415);
            this.panel2.TabIndex = 2;
            // 
            // rtxtChangeLog
            // 
            this.rtxtChangeLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtChangeLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtChangeLog.Location = new System.Drawing.Point(0, 0);
            this.rtxtChangeLog.Name = "rtxtChangeLog";
            this.rtxtChangeLog.Size = new System.Drawing.Size(800, 415);
            this.rtxtChangeLog.TabIndex = 0;
            this.rtxtChangeLog.Text = resources.GetString("rtxtChangeLog.Text");
            // 
            // ShowChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowChangeLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowChangeLog";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtxtChangeLog;
    }
}