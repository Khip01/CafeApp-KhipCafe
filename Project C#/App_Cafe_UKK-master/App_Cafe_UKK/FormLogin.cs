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
using System.IO;

namespace App_Cafe_UKK
{
    public partial class FormLogin : Form
    {
        /// DECLARATION 
        // Visible button SignIn
        bool invisiblePass = true, buttonForSignIn = true;
        Utils util = new Utils();

        public FormLogin()
        {
            InitializeComponent();
            
            txtPasswordSignIn.PasswordChar = '•';
            txtPasswordSignUp.PasswordChar = '•';
        }

        //// MANUAL METHOD 
        private string getIdFromUsername(string username)
        {
            util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '" + username + "'", util.koneksi);
            string id = util.cmd.ExecuteScalar().ToString();

            return id;
        }

        private void alphabetCounter(TextBox txt, Label lbl, int limit)
        {
            // KONDISI JIKA ANGKA lebih dari sama dengan limit
            if (txt.Text.Length >= limit)
            {
                txt.Text = txt.Text.Substring(0, limit); // potong teks yang melebihi batas maksimal
                txt.SelectionStart = txt.Text.Length; // pindahkan cursor ke akhir teks
            }
            int remaining = limit - txt.Text.Length;
            lbl.Text = remaining.ToString() + " remaining";
        }

        private string checkNullSignUp(string data)
        {
            // MENGECEK APAKAH STRING YANG DIINPUT NULL/TIDAK TERDAPAT DI DATABASE
            util.cmd = new SqlCommand("SELECT " + data + " FROM tblkaryawan WHERE username = '" + txtUsernameSignUp.Text + "'", util.koneksi);
            Object notnull = util.cmd.ExecuteScalar();
            if (notnull != null)
            {
                string userData = util.cmd.ExecuteScalar().ToString();
                return userData;
            }
            else
            {
                return "";
            }
        }

        private void submitAsSignUp()
        {
            try
            {
                // ID GENERATOR
                string id = util.idGenerator("id_karyawan", "tblKaryawan", "K"); // return id generator ex: K001

                // Kondisi jika ID Generator sudah mencapai limit (999)
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Oops, looks like our employee data is full!.\nPlease contact the admin as soon as possible, this program will be closed with an error\n\n", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return; //Tidak bisa meneruskan program
                }

                // MEMBERIKAN VALIDASI DATA APAKAH NAMA USER SUDAH ADA DI DATABASE?
                util.koneksi.Open();
                
                // KONDISI JIKA USERNAME SUDAH DIPAKAI/TIDAK
                if (string.Compare(txtUsernameSignUp.Text, checkNullSignUp("username")) == 0)
                {
                    // JIKA USERNAME SUDAH PERNAH DIGUNAKAN
                    dangerUsernameSignUp.Visible = true;
                    dangerUsernameSignUp.Text = "A user with that username already exists.";
                }
                else
                {
                    // MENYIMPAN ID, USERNAME, POSISI, PASSWORD dan STATUS User

                    // Sesi menyimpan password! (password hashing) MENGGUNAKAN BCRYPT.NET
                    //Pendeklarasian
                    string password = txtPasswordSignUp.Text; //mengambil password dari textbox
                    string salt = BCrypt.Net.BCrypt.GenerateSalt(); //generate random salt
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt); //hash password with salt

                    // Sesi menyimpan data ke database tblKaryawan
                    util.cmd = new SqlCommand("INSERT INTO tblKaryawan (id_karyawan, username, posisi, password, status, date_added) VALUES (@idKaryawan, @username, @posisi, @password, @status, @dateAdded)", util.koneksi);
                    util.cmd.Parameters.AddWithValue("idKaryawan", id);
                    util.cmd.Parameters.AddWithValue("username", txtUsernameSignUp.Text);
                    util.cmd.Parameters.AddWithValue("posisi", cbPosisi.Text);
                    util.cmd.Parameters.AddWithValue("password", hashedPassword);
                    util.cmd.Parameters.AddWithValue("status", "OFFLINE");
                    util.cmd.Parameters.AddWithValue("dateAdded", DateTime.Now);
                    util.cmd.ExecuteNonQuery();

                    // Sesi menyimpan salt ke database tblSaltIsSecret
                    util.cmd = new SqlCommand("INSERT INTO tblSaltIsSecret (id_karyawan, saltIsSecret) VALUES ('"+id+"', '"+salt+"')", util.koneksi);
                    util.cmd.ExecuteNonQuery();

                    // Sesi menyimpan aktifitas ke log aktifitas
                    util.saveActivity("SISTEM", "SIGN-UP", "-", "Telah menambahkan "+txtUsernameSignUp.Text+" sebagai KASIR", DateTime.Now);

                    MessageBox.Show("Congratulations,\nData added successfully!\n\nPlease go to the login page to try the account you created", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //// HARUS CLEAR FIELD!!
                    //// FOR SIGN UP ////
                    // FOR TEXTBOX
                    txtUsernameSignUp.Clear();
                    txtPasswordSignUp.Clear();
                    // FOR PASSWORD VISIBLE
                    btnVisiblePassSignUp.Image = Properties.Resources.EyeHide24;
                    txtPasswordSignUp.PasswordChar = '*';
                    this.invisiblePass = true;
                    // CLEAR ERROR DANGER MESSAGE
                    dangerUsernameSignUp.Visible = false;
                    dangerPasswordSignUp.Visible = false;
                    //CHECKBOX SIGN UP
                    cbTerms.Checked = false;
                }
                util.koneksi.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Desc :\n"+err, "Unexpected ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                util.koneksi.Close();
            }
        }

        private string checkNullSignInUsername(string data) // INI DIGUNAKAN UNTUK MENGECEK USERNAME AVAILABLE/NULL
        {
            // MENGECEK APAKAH STRING USERNAME YANG DIINPUT SIGNIN NULL/TIDAK TERDAPAT DI DATABASE
            util.cmd = new SqlCommand("SELECT "+data+" FROM tblkaryawan WHERE username = '" + txtUsernameSignIn.Text + "'", util.koneksi);
            Object notnull = util.cmd.ExecuteScalar();
            if (notnull != null)
            {
                string username = util.cmd.ExecuteScalar().ToString();
                return username;
            }
            else
            {
                return "";
            }
        }

        private string checkNullSignInSalt(string data) // INI DIGUNAKAN UNTUK MENGECEK SALT AVAILABLE/NULL
        {
            // MENGECEK APAKAH SALT TERDAPAT DI DATABASE
            util.cmd = new SqlCommand("SELECT "+data+" FROM tblSaltIsSecret WHERE id_karyawan = (SELECT id_karyawan FROM tblKaryawan WHERE username = '" + txtUsernameSignIn.Text + "')", util.koneksi);
            Object notnull = util.cmd.ExecuteScalar();
            if (notnull != null)
            {
                string salt = util.cmd.ExecuteScalar().ToString();
                return salt;
            }
            else
            {
                return "";
            }
        }

        private string checkNullSignInHashedPassDB(string data) // INI DIGUNAKAN UNTUK MENGECEK HashedPass AVAILABLE/NULL
        {
            // MENGECEK APAKAH SALT TERDAPAT DI DATABASE
            util.cmd = new SqlCommand("SELECT "+data+" FROM tblKaryawan WHERE username = '" + txtUsernameSignIn.Text + "'", util.koneksi);
            Object notnull = util.cmd.ExecuteScalar();
            if (notnull != null)
            {
                string hashedPasswordDB = util.cmd.ExecuteScalar().ToString();
                return hashedPasswordDB;
            }
            else
            {
                return "";
            }
        }

        private void setStatusUser()
        {
            util.cmd = new SqlCommand("UPDATE tblKaryawan SET status = 'ONLINE' WHERE id_karyawan = (SELECT id_karyawan FROM tblkaryawan WHERE username = '"+txtUsernameSignIn.Text+"')", util.koneksi);
            util.cmd.ExecuteNonQuery();

            util.cmd = new SqlCommand("UPDATE tblLogAktifitas SET status = 'ONLINE' WHERE username = '" + txtUsernameSignIn.Text + "'", util.koneksi);
            util.cmd.ExecuteNonQuery();
        }

        private void submitAsSignIn()
        {
            try
            {
                //// OLD LOGIN METHOD

                //util.cmd = new SqlCommand("SELECT COUNT(*) FROM tblKaryawan WHERE username = '"+txtUsernameSignIn.Text+"' AND password = '"+txtPasswordSignIn.Text+"'", util.koneksi);
                //int result = Convert.ToInt32(util.cmd.ExecuteScalar());
                //if (result <= 0)
                //{
                //    MessageBox.Show("Username with Password is not found\nCheck again maybe there is a misspelling", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else if (result > 1)
                //{
                //    MessageBox.Show("There seems to be duplication in the data, \nContact admin to fix it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //    MessageBox.Show("Successful login, welcome " + txtUsernameSignIn.Text, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    FormControlAdmin admin = new FormControlAdmin(txtUsernameSignIn.Text);
                //    admin.Show();
                //}

                //// NEW  LOGIN METHOD
                util.koneksi.Open();

                // Login HashedPassword CHECK NULL || AVAILABLE
                string username = checkNullSignInUsername("username"); // Ada dua kondisi jika username DITEMUKAN || NULL
                string salt = checkNullSignInSalt("saltIsSecret"); // Ada dua kondisi jika salt DITEMUKAN || NULL
                string hashedPasswordDB = checkNullSignInHashedPassDB("password"); // Ada dua kondisi jika hashedPass DITEMUKAN || NULL  

                // Kondisi error jika username || salt || hashedPasswordDB == NULL, atau tidak terdapat di database. Maka dia akan menghentikan proses
                if (username == "" || salt == "" || hashedPasswordDB == "")
                {
                    MessageBox.Show("Username with that password not found\nCheck again maybe there is a misspelling", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    util.koneksi.Close();
                    return;
                }

                string password = txtPasswordSignIn.Text; //Mengambil password dari textbox
                bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, hashedPasswordDB);

                // MEMBANDINGKAN TXTBOX == TXTDATABASE [string.Compare(txtUsernameSignIn.Text, checkNullSignIn("username")) == 0 && ]
                if (string.Compare(txtUsernameSignIn.Text, username) == 0 && isPasswordValid)
                {
                    MessageBox.Show("Successful login, welcome " + txtUsernameSignIn.Text, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setStatusUser(); // Mengubah status User menjadi ONLINE

                    // Mengecek kondisi user apakah dia ADMIN/KASIR/MANAGER
                    util.cmd = new SqlCommand("SELECT posisi FROM tblKaryawan WHERE username = '"+txtUsernameSignIn.Text+"'", util.koneksi);
                    string posisi = util.cmd.ExecuteScalar().ToString();
                    if (posisi == "ADMIN")
                    {
                        FormControlAdmin admin = new FormControlAdmin(txtUsernameSignIn.Text, getIdFromUsername(txtUsernameSignIn.Text));
                        admin.Show();
                        this.Hide();
                    }
                    else if (posisi == "KASIR")
                    {
                        FormControlKasir kasir = new FormControlKasir(txtUsernameSignIn.Text, getIdFromUsername(txtUsernameSignIn.Text));
                        kasir.Show();
                        this.Hide();
                    }
                    else if (posisi == "MANAJER")
                    {
                        FormControlManager manager = new FormControlManager(txtUsernameSignIn.Text, getIdFromUsername(txtUsernameSignIn.Text));
                        manager.Show();
                        this.Hide();
                    }

                    //// HARUS CLEAR FIELD
                    //// FOR SIGN IN ////
                    // FOR TEXTBOX
                    txtUsernameSignIn.Clear();
                    txtPasswordSignIn.Clear();
                    // FOR PASSWORD VISIBLE
                    btnVisiblePassSignIn.Image = Properties.Resources.EyeHide24;
                    txtPasswordSignIn.PasswordChar = '*';
                    this.invisiblePass = true;
                    // CLEAR ERROR DANGER MESSAGE
                    dangerUsernameSignIn.Visible = false;
                    dangerPasswordSignIn.Visible = false;
                }
                else
                {
                    MessageBox.Show("Username with that password not found\nCheck again maybe there is a misspelling", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                util.koneksi.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Desc :\n"+err, "Unexpected ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                util.koneksi.Close();
            }
        }

        private void clearSignInField()
        {
            //// FOR SIGN IN ////
            // FOR TEXTBOX
            txtUsernameSignIn.Clear();
            txtPasswordSignIn.Clear();
            // FOR PASSWORD VISIBLE
            btnVisiblePassSignIn.Image = Properties.Resources.EyeHide24;
            txtPasswordSignIn.PasswordChar = '*';
            this.invisiblePass = true;
            // CLEAR ERROR DANGER MESSAGE
            dangerUsernameSignIn.Visible = false;
            dangerPasswordSignIn.Visible = false;
            //SUBMIT SIGN UP BUTTON ACTIVATE
            buttonForSignIn = false;
        }

        private void clearSignUpField()
        {
            //// FOR SIGN UP ////
            // FOR TEXTBOX
            txtUsernameSignUp.Clear();
            txtPasswordSignUp.Clear();
            // FOR PASSWORD VISIBLE
            btnVisiblePassSignUp.Image = Properties.Resources.EyeHide24;
            txtPasswordSignUp.PasswordChar = '*';
            this.invisiblePass = true;
            // CLEAR ERROR DANGER MESSAGE
            dangerUsernameSignUp.Visible = false;
            dangerPasswordSignUp.Visible = false;
            //SUBMIT SIGN IN BUTTON ACTIVATE
            buttonForSignIn = true;
            //CHECKBOX SIGN UP
            cbTerms.Checked = false;
        }
        //// END MANUAL METHOD

        //// ANIMATION SETTING!! (BY TIMER)
        private void timerNavSignUp_Tick(object sender, EventArgs e)
        {
            if (panelNav.Location.X == panel1.Location.X)
            {
                panelNav.Width += 10;
                if (panelNav.Width == panelNav.MaximumSize.Width)
                {
                    timerNavSignUp2.Start();
                    timerNavSignUp.Stop();
                }
            }
            else
            {
                timerNavSignUp.Stop();
            }
        }
        private void timerNavSignUp2_Tick(object sender, EventArgs e)
        {
            panelNav.Width -= 10;
            panelNav.Left += 10;

            //Mengecek agar penambahan panelNav.Left tidak offside (jadi pas)
            int check = panelNav.Location.X + 10;
            int sisa = panel2.Location.X - check;
            if (sisa <= 10 && panelNav.Width == panelNav.MinimumSize.Width)
            {
                panelNav.Left = panelNav.Left + 10 + sisa;
                timerNavSignUp2.Stop();
                btnSignIn.Enabled = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //BTN ACTION!!
            clearSignInField();
            btnSignIn.Enabled = false;
            btnSignUp.Enabled = false;
            timerNavSignUp.Start();
            timerPageSignUpBtn.Start();
            btnSubmit.Text = "SIGN UP";
            btnSubmit.Enabled = false;
        }


        private void timerNavSignIn_Tick(object sender, EventArgs e)
        {
            if (panelNav.Right == panel2.Right)
            {
                panelNav.Width += 10;
                panelNav.Left -= 10;

                //Mengecek agar pengurangan panelNav.Left tidak offside (jadi pas)
                int check = panelNav.Location.X - 10;
                int sisa = check - panel1.Location.X;
                if (sisa < 10 && panelNav.Width == panelNav.MaximumSize.Width)
                {
                    panelNav.Left = panelNav.Left - (10 + sisa);
                    timerNavSignIn2.Start();
                    timerNavSignIn.Stop();
                }
            }
            else
            {
                timerNavSignIn.Stop();
            }
        }

        private void timerNavSignIn2_Tick(object sender, EventArgs e)
        {
            panelNav.Width -= 10;
            if (panelNav.Width == panelNav.MinimumSize.Width)
            {
                timerNavSignIn2.Stop();
                btnSignUp.Enabled = true;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // BTN ACTION!!!
            clearSignUpField();
            btnSignUp.Enabled = false;
            btnSignIn.Enabled = false;
            timerNavSignIn.Start();
            timerPageSignInBtn.Start();
            btnSubmit.Text = "LOGIN";
            btnSubmit.Enabled = true;
        }

        private void timerPageSignInBtn_Tick(object sender, EventArgs e)
        {
            panelSignIn.Left += 20;
            panelSignUp.Left += 20;

            //Mengecek agar letak pas
            int check = panelSignIn.Location.X + 20;
            int sisa = 17 - check;
            //panelSignIn.Left >= 19
            if (sisa < 20)
            {
                panelSignIn.Left = panelSignIn.Left + 20 + sisa;
                panelSignUp.Left = panelSignUp.Left + 20 + sisa;
                timerPageSignInBtn.Stop();
            }
        }

        private void timerPageSignUpBtn_Tick(object sender, EventArgs e)
        {
            panelSignUp.Left -= 20;
            panelSignIn.Left -= 20;

            // Mengecek agar letak pas
            int check = panelSignUp.Location.X - 20;
            int sisa = check - 20;
            //panelSignUp.Left <= 19
            if (sisa <= 20)
            {
                panelSignUp.Left = panelSignUp.Left - (20 + sisa);
                panelSignIn.Left = panelSignIn.Left - (20 + sisa);
                timerPageSignUpBtn.Stop();
            }
        }

        //// ANIMATION SETTING END !!!
        
        //// BUTTON SUBMIT ACTION !!!! IMPORTANT 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Decide SUBMIT button for SIGN UP/SIGN IN form
            if (buttonForSignIn)
            {
                //LOGIN SUBMIT BUTTON SIGN IN
                if (string.IsNullOrEmpty(txtUsernameSignIn.Text) && string.IsNullOrEmpty(txtPasswordSignIn.Text))
                {
                    dangerUsernameSignIn.Visible = true;
                    dangerPasswordSignIn.Visible = true;
                }
                else if (string.IsNullOrEmpty(txtUsernameSignIn.Text))
                {
                    dangerUsernameSignIn.Visible = true;
                }
                else if (string.IsNullOrEmpty(txtPasswordSignIn.Text))
                {
                    dangerPasswordSignIn.Visible = true;
                }
                else
                {
                    submitAsSignIn();
                }
            }
            else
            {
                //LOGIN SUBMIT BUTTON SIGN UP
                if (string.IsNullOrEmpty(txtUsernameSignUp.Text) && string.IsNullOrEmpty(txtPasswordSignUp.Text))
                {
                    dangerUsernameSignUp.Visible = true;
                    dangerPasswordSignUp.Visible = true;
                }
                else if (string.IsNullOrEmpty(txtUsernameSignUp.Text))
                {
                    dangerUsernameSignUp.Visible = true;
                }
                else if (string.IsNullOrEmpty(txtPasswordSignUp.Text))
                {
                    dangerPasswordSignUp.Visible = true;
                }
                else
                {
                    submitAsSignUp();
                }
            }

        }
        //// END FOR BUTTON SUBMIT ACTION !!!

        //// SETTING FOR SIGN IN PAGE

        private void txtUsernameSignIn_TextChanged(object sender, EventArgs e)
        {
            dangerUsernameSignIn.Visible = false;
        }

        private void txtPasswordSignIn_TextChanged(object sender, EventArgs e)
        {
            dangerPasswordSignIn.Visible = false;
        }

        private void btnVisiblePass_Click(object sender, EventArgs e)
        {
            if (invisiblePass)
            {
                btnVisiblePassSignIn.Image = Properties.Resources.EyeOpen24;

                txtPasswordSignIn.PasswordChar = '\0';
                this.invisiblePass = false;
            }
            else
            {
                btnVisiblePassSignIn.Image = Properties.Resources.EyeHide24;

                txtPasswordSignIn.PasswordChar = '•';
                this.invisiblePass = true;
            }
        }

        private void txtUsernameSignIn_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI FORM USERNAME MAKA BUTTON OTOMATIS TERTEKAN SIGN IN
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void txtPasswordSignIn_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI FORM PASSWORD MAKA BUTTON OTOMATIS TERTEKAN SIGN IN
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        //// END SETTING SIGN IN PAGE


        //// SETTING FOR SIGN UP PAGE
        private void cbTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTerms.Checked)
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }
        }
        private void txtUsernameSignUp_TextChanged(object sender, EventArgs e)
        {
            dangerUsernameSignUp.Visible = false;
            dangerUsernameSignUp.Text = "Username must be filled in!";
            // Alphabet counter txtUsernameSignUp
            alphabetCounter(txtUsernameSignUp, lblAlphabetCounterUsername, 40);
        }


        private void txtPasswordSignUp_TextChanged(object sender, EventArgs e)
        {
            dangerPasswordSignUp.Visible = false;
        }

        private void btnVisiblePassSignUp_Click(object sender, EventArgs e)
        {
            if (invisiblePass)
            {
                btnVisiblePassSignUp.Image = Properties.Resources.EyeOpen24;

                txtPasswordSignUp.PasswordChar = '\0';
                this.invisiblePass = false;
            }
            else
            {
                btnVisiblePassSignUp.Image = Properties.Resources.EyeHide24;

                txtPasswordSignUp.PasswordChar = '*';
                this.invisiblePass = true;
            }
        }

        private void pbAsk_MouseHover(object sender, EventArgs e)
        {
            panelAsk.Visible = true;
        }

        private void pbAsk_MouseLeave(object sender, EventArgs e)
        {
            panelAsk.Visible = false;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // CHECK JIKA FORM TERTUTUP
            if (this.Name == "FormLogin")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to close the application?\n\nThis will close all applications running in the background", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.ExitThread();
                }
            }
        }

        private void txtUsernameSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI FORM USERNAME MAKA BUTTON OTOMATIS TERTEKAN SIGN UP
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void txtPasswordSignUp_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI FORM PASSWORD MAKA BUTTON OTOMATIS TERTEKAN SIGN UP
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void cbTerms_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENEKAN PERMISSION MAKA BUTTON OTOMATIS TERTEKAN SIGN UP
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        //// END SETTING  SIGN UP PAGE

        //// MINIMIZE BUTTON

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // MENGECEK APAKAH TERDAPAT FOLDER IMAGES DI APPLICATION STARTUP //
            string imageFolderPath = Path.Combine(Application.StartupPath, "Images");

            // Mengecek apakah direktori Images sudah ada atau belum
            if (!Directory.Exists(imageFolderPath))
            {
                // Membuat direktori Images jika belum ada
                Directory.CreateDirectory(imageFolderPath);
            }
        }

        //// EXIT BUTTON
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to close the application?\n\nThis will close all applications running in the background", "WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }
    }
}
