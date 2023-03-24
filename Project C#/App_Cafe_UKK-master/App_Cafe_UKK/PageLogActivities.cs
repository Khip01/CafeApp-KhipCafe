using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_Cafe_UKK
{
    public partial class PageLogActivities : Form
    {
        //// DEKLARASI VARIABEL
        Utils util = new Utils();
        string sqlComAll = "SELECT username as Username, posisi as Posisi, status as Status, action as Action, date_added as 'Date Added' FROM tblLogAktifitas ORDER BY date_added DESC";
        string sqlComKasir = "SELECT username as Username, posisi as Posisi, status as Status, action as Action, date_added as 'Date Added' FROM tblLogAktifitas WHERE posisi = 'KASIR' ORDER BY date_added DESC";
        string sqlComManager = "SELECT username as Username, posisi as Posisi, status as Status, action as Action, date_added as 'Date Added' FROM tblLogAktifitas WHERE posisi = 'MANAGER' ORDER BY date_added DESC";
        string sqlComAdmin = "SELECT username as Username, posisi as Posisi, status as Status, action as Action, date_added as 'Date Added' FROM tblLogAktifitas WHERE posisi = 'ADMIN' ORDER BY date_added DESC";
        string sqlComSistem = "SELECT username as Username, posisi as Posisi, status as Status, action as Action, date_added as 'Date Added' FROM tblLogAktifitas WHERE posisi = 'SIGN-UP' ORDER BY date_added DESC";
        Button currentButton;

        public PageLogActivities()
        {
            InitializeComponent();

            tampilData(sqlComAll);
            currentButton = btnAll;
        }

        //// MANUAL METHOD
        
        private void tampilData(string command_sql)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command_sql, util.koneksi);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];
            dataTable.Columns.Add("Profile Picture", typeof(Image));
            Image adminON = Properties.Resources.AdminON50;
            Image adminOFF = Properties.Resources.AdminOFF50;
            Image managerON = Properties.Resources.ManagerON50;
            Image managerOFF = Properties.Resources.ManagerOFF50;
            Image kasirON = Properties.Resources.KasirON50;
            Image kasirOFF = Properties.Resources.KasirOFF50;
            Image sistem = Properties.Resources.sistem50;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Status"].ToString() == "ONLINE")
                {
                    if (row["Posisi"].ToString() == "ADMIN")
                    {
                        row["Profile Picture"] = adminON;
                    }
                    else if (row["Posisi"].ToString() == "KASIR")
                    {
                        row["Profile Picture"] = kasirON;
                    }
                    else if (row["Posisi"].ToString() == "MANAGER")
                    {
                        row["Profile Picture"] = managerON;
                    }
                }
                else if (row["Status"].ToString() == "OFFLINE")
                {
                    if (row["Posisi"].ToString() == "ADMIN")
                    {
                        row["Profile Picture"] = adminOFF;
                    }
                    else if (row["Posisi"].ToString() == "KASIR")
                    {
                        row["Profile Picture"] = kasirOFF;
                    }
                    else if (row["Posisi"].ToString() == "MANAGER")
                    {
                        row["Profile Picture"] = managerOFF;
                    }
                }
                if (row["Username"].ToString() == "SISTEM")
                {
                    row["Profile Picture"] = sistem;
                }
            }


            //dataTable.Columns.Remove("status");
            dgvLogActivities.DataSource = dataTable;
            dgvLogActivities.Columns["Profile Picture"].DisplayIndex = 0;

            // Mengatur ukuran panjang/width kolom ikon 
            dgvLogActivities.Columns["Profile Picture"].Width = 100;
            dgvLogActivities.Columns["Action"].Width = 350;
            dgvLogActivities.Columns["Profile Picture"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLogActivities.Columns["Username"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLogActivities.Columns["Posisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLogActivities.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLogActivities.Columns["Action"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLogActivities.Columns["Date Added"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void changeButtonColor(object sender, EventArgs e)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Sienna; // Mengubah warna button
                currentButton.Parent.BackColor = Color.Sienna; // Mengubah warna panel
            }
            currentButton = (Button)sender;
            currentButton.BackColor = Color.Chocolate; // Mengubah warna button
            currentButton.Parent.BackColor = Color.Chocolate; // Mengubah warna panel

        }

        //// FORM CONTROL
        private void btnAll_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender, e);
            tampilData(sqlComAll);
        }

        private void btnKasir_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender, e);
            tampilData(sqlComKasir);
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender, e);
            tampilData(sqlComManager);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender, e);
            tampilData(sqlComAdmin);
        }

        private void btnSistem_Click(object sender, EventArgs e)
        {
            changeButtonColor(sender, e);
            tampilData(sqlComSistem);
        }
    }
}
