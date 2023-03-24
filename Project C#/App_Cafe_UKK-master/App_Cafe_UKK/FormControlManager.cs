﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace App_Cafe_UKK
{
    public partial class FormControlManager : Form
    {
        //// DEKLARASI VARIABEL
        bool navBar = true, crud = true; //true = navbar posisi kecil, //false = navbar posisi besar
        Utils util = new Utils();
        string nama;
        Button currentButton;

        public FormControlManager(string U, string I)
        {
            InitializeComponent();
            // Menampilkan Nama User
            lblWelcome.Text = "Welcome to MANAGER, " + U + " (#" + I + ")";
            this.nama = U;
            // Halaman yang akan diload/ditampilkan
            loadPage(new PageDashboardManager(), "DASHBOARD");
            currentButton = btnDashboard;
        }

        //// USER METHOD MANUAL
        private void showAboutPanel()
        {
            if (pnlAbout.Visible)
            {
                pnlAbout.Visible = false;
            }
            else
            {
                pnlAbout.Visible = true;
            }
        }

        private void loadPage(object Form, string Title)
        {
            // MENGECEK APAKAH panel dalam keadaan kosong/tidak, jika tidak hapus form...
            if (this.pnlPage.Controls.Count > 0)
            {
                this.pnlPage.Controls.RemoveAt(0);
            }

            // MEMBUAT/MENAMBAHKAN PANEL YANG DIINPUT PADA PARAMETER FORM
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlPage.Controls.Add(f);
            this.pnlPage.Tag = f;
            f.Show();

            // MENGGANTI lblTitle MENJADI NAMA Navbar
            lblTitle.Text = Title;
        }

        private void changeButtonColor(object sender, EventArgs e)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Transparent; // Mengubah warna button
                currentButton.Parent.BackColor = Color.Transparent; // Mengubah warna panel
            }
            currentButton = (Button)sender;
            currentButton.BackColor = Color.FromArgb(143, 73, 73); // Mengubah warna button
            currentButton.Parent.BackColor = Color.FromArgb(143, 73, 73); // Mengubah warna panel

            // Update warna button menjadi transparan
            btnCRUD.BackColor = Color.Transparent;
            btnDataMenu.BackColor = Color.Transparent;
            btnCreateMenu.BackColor = Color.Transparent;
            btnUpdateMenu.BackColor = Color.Transparent;
        }

        // SETTING LOGOUT
        private void logoutSetUser()
        {
            util.koneksi.Open();
            // set logout/status OFFLINE di tblKaryawan
            util.cmd = new SqlCommand("UPDATE tblKaryawan SET status = 'OFFLINE' WHERE id_karyawan = (SELECT id_karyawan WHERE username = '" + nama + "')", util.koneksi);
            util.cmd.ExecuteNonQuery();

            // set logout/status OFFLINE di tblLogAktifitas
            util.cmd = new SqlCommand("UPDATE tblLogAktifitas SET status = 'OFFLINE' WHERE username = '" + nama + "'", util.koneksi);
            util.cmd.ExecuteNonQuery();
            util.koneksi.Close();
        }


        //// ANIMATION NAVBAR
        private void timerFlpMain1_Tick(object sender, EventArgs e)
        {
            // NAVBAR EXPAND
            if (navBar)
            {
                flpMain.Width += 20;

                if (flpMain.Width == flpMain.MaximumSize.Width)
                {
                    timerFlpMain1.Stop();
                    this.navBar = false;
                    btnDetails.Image = Properties.Resources.menuBarsVertical24;
                }
            }
            // NAVBAR AND CRUD COLUMN COLLAPSE (if CRUD COLUMN is Active)
            else if (navBar == false && crud == false)
            {
                flpMain.Width -= 20;

                timerCRUD1.Start();

                if (flpMain.Width == flpMain.MinimumSize.Width)
                {
                    timerFlpMain1.Stop();
                    this.navBar = true;
                    btnDetails.Image = Properties.Resources.menuDotsVertical24;
                }
            }
            // NAVBAR ONLY COLLAPSE
            else
            {
                flpMain.Width -= 20;

                if (flpMain.Width == flpMain.MinimumSize.Width)
                {
                    timerFlpMain1.Stop();
                    this.navBar = true;
                    btnDetails.Image = Properties.Resources.menuDotsVertical24;
                }
            }
        }

        private void timerCRUD1_Tick(object sender, EventArgs e)
        {
            // CRUD COLUMN AND NAVBAR EXPAND
            if (crud && navBar)
            {
                panelCRUD.Height += 10;

                timerFlpMain1.Start();

                if (panelCRUD.Height == panelCRUD.MaximumSize.Height)
                {
                    timerCRUD1.Stop();
                    this.crud = false;
                }
            }
            // CRUD COLUMN ONLY EXPAND
            else if (crud)
            {
                panelCRUD.Height += 10;

                if (panelCRUD.Height == panelCRUD.MaximumSize.Height)
                {
                    timerCRUD1.Stop();
                    this.crud = false;
                }
            }
            // CRUD COLUMN COLLAPSE
            else
            {
                panelCRUD.Height -= 10;

                if (panelCRUD.Height == panelCRUD.MinimumSize.Height)
                {
                    timerCRUD1.Stop();
                    this.crud = true;
                }
            }
        }

        //// FORM CONTROL 

        private void btnDetails_Click(object sender, EventArgs e)
        {
            timerFlpMain1.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            loadPage(new PageDashboardManager(), "DASHBOARD");
            changeButtonColor(sender, e);
        }

        private void btnDataMenu_Click(object sender, EventArgs e)
        {
            loadPage(new PageCRUDDataMenu(), "DATA MENU");
            changeButtonColor(sender, e);
        }

        private void btnCreateMenu_Click(object sender, EventArgs e)
        {
            loadPage(new PageCRUDCreateNewMenu(this.nama), "CREATE MENU");
            changeButtonColor(sender, e);
        }

        private void btnUpdateMenu_Click(object sender, EventArgs e)
        {
            loadPage(new PageCRUDUpdateMenu(this.nama), "UPDATE MENU");
            changeButtonColor(sender, e);
        }

        private void btnManageTable_Click(object sender, EventArgs e)
        {
            loadPage(new PageManageTable(this.nama), "MANAGE TABLE");
            changeButtonColor(sender, e);
        }

        private void btnCatatanTransaksi_Click(object sender, EventArgs e)
        {
            loadPage(new PageCatatanTransaksiManager(), "TRANSACTION RECORDS");
            changeButtonColor(sender, e);
        }

        private void btnLogActivities_Click(object sender, EventArgs e)
        {
            loadPage(new PageLogActivities(), "LOG ACTIVITIES");
            changeButtonColor(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to logout?\n\nYou will be asked to login again to view this Manager Panel", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                logoutSetUser();
                this.Hide();
                FormLogin login = new FormLogin();
                login.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to logout?\n\nYou will be asked to login again to view this Manager Panel", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                logoutSetUser();
                this.Hide();
                FormLogin login = new FormLogin();
                login.Show();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormControlManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            // CHECK JIKA FORM TERTUTUP
            if (this.Name == "FormControlManager")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to close the application?\n\nYou will be asked to login again to view this Manager Panel", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    logoutSetUser();
                    this.Hide();
                    FormLogin login = new FormLogin();
                    login.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnAboutApp_Click(object sender, EventArgs e)
        {
            showAboutPanel();
        }
        private void lblLinkGithub_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/Khip01",
                UseShellExecute = true
            };
            Process.Start(sInfo);
        }

        private void lblLinkProject_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/Khip01?tab=repositories",
                UseShellExecute = true
            };
            Process.Start(sInfo);
        }

        private void lblShowChangeLog_Click(object sender, EventArgs e)
        {
            ShowChangeLog changeLog = new ShowChangeLog();
            changeLog.ShowDialog();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            timerCRUD1.Start();
        }
    }
}
