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
    public partial class PageDashboardAdmin : Form
    {
        bool card1 = true, card2 = true, card3 = true;
        Utils util = new Utils();
        string TotalUser, TotalOnline;
        string sqlComAll = "SELECT username as Username, action as Action, date_added as 'Date Added' FROM tblLogAktifitas ORDER BY date_added DESC";

        public PageDashboardAdmin()
        {
            InitializeComponent();
            statsUpdate();
            tampilData(sqlComAll);
        }

        //// USER METHOD MANUAL 

        //// LAST ACTIVITY
        private void tampilData(string command_sql)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command_sql, util.koneksi);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            dgvLastActivity.DataSource = dataTable;
            dgvLastActivity.Columns["Action"].Width = 300;
        }

        //// STATISTIC
        private void statsUpdate()
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(*) FROM tblKaryawan", util.koneksi);
            this.TotalUser = util.cmd.ExecuteScalar().ToString();
            util.cmd = new SqlCommand("SELECT COUNT(*) FROM tblKaryawan WHERE status = 'ONLINE'", util.koneksi);
            this.TotalOnline = util.cmd.ExecuteScalar().ToString();
            util.koneksi.Close();

            lblTotalUser.Text = TotalUser;
            lblTotalOnline.Text = TotalOnline + " / " + TotalUser;
        }

        //// FORM ANIMATION
        private void cardAnimation1(PictureBox pbCard, Timer timerCard)
        {
            if (card1)
            {
                pbCard.Top -= 15;

                if (pbCard.Location.Y <= 320)
                {
                    timerCard.Stop();
                    card1 = false;
                }
            }
            else
            {
                pbCard.Top += 15;

                if (pbCard.Location.Y >= 355)
                {
                    timerCard.Stop();
                    card1 = true;
                }
            }
        }

        private void cardAnimation2(PictureBox pbCard, Timer timerCard)
        {
            if (card2)
            {
                pbCard.Top -= 15;

                if (pbCard.Location.Y <= 320)
                {
                    timerCard.Stop();
                    card2 = false;
                }
            }
            else
            {
                pbCard.Top += 15;

                if (pbCard.Location.Y >= 355)
                {
                    timerCard.Stop();
                    card2 = true;
                }
            }
        }

        private void cardAnimation3(PictureBox pbCard, Timer timerCard)
        {
            if (card3)
            {
                pbCard.Top -= 15;

                if (pbCard.Location.Y <= 320)
                {
                    timerCard.Stop();
                    card3 = false;
                }
            }
            else
            {
                pbCard.Top += 15;

                if (pbCard.Location.Y >= 355)
                {
                    timerCard.Stop();
                    card3 = true;
                }
            }
        }

        //// FORM ANIMATION 
        private void timerAllUser1_Tick(object sender, EventArgs e)
        {
            cardAnimation1(pbAllUser, timerAllUser1);
        }


        private void timerCreateUser1_Tick(object sender, EventArgs e)
        {
            cardAnimation2(pbCreateUser, timerCreateUser1);
        }


        private void timerUpdate1_Tick(object sender, EventArgs e)
        {
            cardAnimation3(pbUpdate, timerUpdate1);
        }


        //// FORM CONTROL
        ///
        private void btnAllUser_MouseEnter(object sender, EventArgs e)
        {
            timerAllUser1.Start();
            btnAllUser.BackColor = Color.LightGreen;
            btnAllUser.ForeColor = Color.White;
        }

        private void btnAllUser_MouseLeave(object sender, EventArgs e)
        {
            timerAllUser1.Start();
            btnAllUser.BackColor = Color.White;
            btnAllUser.ForeColor = Color.Black;
        }


        private void btnCreateUser_MouseEnter(object sender, EventArgs e)
        {
            timerCreateUser1.Start();
            btnCreateUser.BackColor = Color.LightGreen;
            btnCreateUser.ForeColor = Color.White;
        }

        private void btnCreateUser_MouseLeave(object sender, EventArgs e)
        {
            timerCreateUser1.Start();
            btnCreateUser.BackColor = Color.White;
            btnCreateUser.ForeColor = Color.Black;
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            timerUpdate1.Start();
            btnUpdate.BackColor = Color.LightGreen;
            btnUpdate.ForeColor = Color.White;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            timerUpdate1.Start();
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
        }
    }
}
