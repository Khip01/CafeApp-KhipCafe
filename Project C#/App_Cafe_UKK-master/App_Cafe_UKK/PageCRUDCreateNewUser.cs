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
    public partial class PageCRUDCreateNewUser : Form
    {
        //// DEKLARASI VARIABEL
        bool invisiblePass = true, telpNumValid = false;
        Utils util = new Utils();
        string nama;

        public PageCRUDCreateNewUser(string U)
        {
            InitializeComponent();

            this.nama = U;
            txtPassword.PasswordChar = '•';
            tampilComboBox();
        }

        //// USER MANUAL METHOD 

        private void clearFieldNewUser()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            invisiblePass = true;
            showVisiblePassCreate();
            cbPosition.SelectedItem = null;
            txtAddress.Clear();
            txtTelpNumber.Clear();
            dtpDateofBirth.Value = DateTime.Now;
            cbGender.SelectedItem = null;
            txtDescription.Clear();
        }

        private void showVisiblePassCreate()
        {
            if (invisiblePass)
            {
                btnVisiblePassCreate.Image = Properties.Resources.EyeOpen24;

                txtPassword.PasswordChar = '\0';
                this.invisiblePass = false;
            }
            else
            {
                btnVisiblePassCreate.Image = Properties.Resources.EyeHide24;

                txtPassword.PasswordChar = '•';
                this.invisiblePass = true;
            }
        }

        private void submitCreate()
        {
            //// Memastikan jika tidak ada field yang tidak diinginkan!
            // Memastikan jika nama sudah dipakai pada database (terdapat duplikat)
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(username) FROM tblKaryawan WHERE username = '" + txtUsername.Text + "'", util.koneksi);
            int result = Convert.ToInt32(util.cmd.ExecuteScalar());
            util.koneksi.Close();
            long number;
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(cbPosition.Text) || !long.TryParse(txtTelpNumber.Text, out number) || this.telpNumValid == false || result > 0)
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    dangerUsername.Text = "This field is required";
                    dangerUsername.Visible = true;
                    lblAlphabetCounterUsername.Visible = false;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    dangerPassword.Visible = true;
                }
                if (string.IsNullOrEmpty(cbPosition.Text))
                {
                    dangerPosition.Visible = true;
                }
                if (this.telpNumValid == false)
                {
                    lblAlphabetCounterTelp.ForeColor = Color.Red;
                }
                if (result > 0)
                {
                    dangerUsername.Text = "Name already taken";
                    dangerUsername.TextAlign = ContentAlignment.MiddleRight;
                    dangerUsername.Visible = true;
                    lblAlphabetCounterUsername.Visible = false;
                }
                return;
            }
            // PROSES MENYIMPAN DATA //
            // Variabel Deklarasi 
            string id_karyawan = util.idGenerator("id_karyawan", "tblkaryawan", "K");
            string username = txtUsername.Text;
            string posisi = cbPosition.Text;

            // Password Genereate Hash (Create New User)
            // Sesi menyimpan password! (password hashing) MENGGUNAKAN BCRYPT.NET
            //Pendeklarasian 
            string password = txtPassword.Text; //mengambil password dari textbox
            string salt = BCrypt.Net.BCrypt.GenerateSalt(); //generate random salt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt); //hash password with salt
            // End session hashing password

            string status = txtStatus.Text;
            string alamat = txtAddress.Text;
            string no_telp = "+62"+txtTelpNumber.Text;
            DateTime tanggal_lahir = dtpDateofBirth.Value;
            string gender = cbGender.Text;
            string deskripsi = txtDescription.Text;
            DateTime dateAdded = DateTime.Now;

            // Mencari id_karyawan berdasarkan added by
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '"+this.nama+"'", util.koneksi);
            string addedById = util.cmd.ExecuteScalar().ToString();
            util.koneksi.Close();
            string added_by = addedById;

            // PROSES INSERT KE TBLKARYAWAN
            util.koneksi.Open();
            util.cmd = new SqlCommand("INSERT INTO tblKaryawan VALUES (@id_karyawan, @username, @posisi, @password, @status, @alamat, @no_telp, @tanggal_lahir, @gender, @deskripsi, @date_added, @added_by)", util.koneksi);
            util.cmd.Parameters.AddWithValue("id_karyawan", id_karyawan);
            util.cmd.Parameters.AddWithValue("username", username);
            util.cmd.Parameters.AddWithValue("posisi", posisi);
            util.cmd.Parameters.AddWithValue("password", hashedPassword);
            util.cmd.Parameters.AddWithValue("status", status);
            util.cmd.Parameters.AddWithValue("alamat", alamat);
            util.cmd.Parameters.AddWithValue("no_telp", no_telp);
            util.cmd.Parameters.AddWithValue("tanggal_lahir", tanggal_lahir);
            util.cmd.Parameters.AddWithValue("gender", gender);
            util.cmd.Parameters.AddWithValue("deskripsi", deskripsi);
            util.cmd.Parameters.AddWithValue("date_added", dateAdded);
            util.cmd.Parameters.AddWithValue("added_by", added_by);
            util.cmd.ExecuteNonQuery();

            // Sesi menyimpan salt ke database tblSaltIsSecret
            util.cmd = new SqlCommand("INSERT INTO tblSaltIsSecret (id_karyawan, saltIsSecret) VALUES ('" + id_karyawan + "', '" + salt + "')", util.koneksi);
            util.cmd.ExecuteNonQuery();

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "ADMIN", "ONLINE", "Telah menambahkan "+username+" sebagai "+posisi, DateTime.Now);

            util.koneksi.Close();
            // MENAMPILKAN PANEL SUKSES
            pnlSuccess.Visible = true;
            // MENGHAPUS TEXTFIELD DEFAULT
            clearFieldNewUser();
        }

        private void tampilComboBox()
        {
            // UNTUK COMBO BOX POSITION
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT posisi FROM tblPosisi", util.koneksi);
            SqlDataReader reader = util.cmd.ExecuteReader();
            while (reader.Read())
            {
                cbPosition.Items.Add(reader["posisi"].ToString());
            }

            // MENUTUP READER UNTUK MEMBUAT READER BARU
            reader.Dispose();

            // UNTUK COMBO BOX GENDER
            util.cmd = new SqlCommand("SELECT gender FROM tblGender", util.koneksi);
            reader = util.cmd.ExecuteReader();
            while (reader.Read())
            {
                cbGender.Items.Add(reader["gender"].ToString());
            }
            util.koneksi.Close();
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

        private void alphabetCounterNoTelp(TextBox txt, Label lbl, int limit)
        {
            // KONDISI JIKA ANGKA lebih dari sama dengan limit
            if (txt.Text.Length >= limit)
            {
                txt.Text = txt.Text.Substring(0, limit); // potong teks yang melebihi batas maksimal
                txt.SelectionStart = txt.Text.Length; // pindahkan cursor ke akhir teks
            }
            int remaining = limit - txt.Text.Length;
            if (remaining > 2)
            {
                lbl.Text = remaining.ToString() + " remaining (INVALID number)";
                this.telpNumValid = false;
            }
            else
            {
                lbl.Text = remaining.ToString() + " remaining (VALID number)";
                this.telpNumValid = true;
            }
        }

        //// FORM CONTROL

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            // MEMBUAT PENGHITUNG ABJAD
            alphabetCounter(txtDescription, lblAlphabetCounterDesc, 250);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            alphabetCounter(txtAddress, lblAlphabetCounterAddr, 250);
        }

        private void txtTelpNumber_TextChanged(object sender, EventArgs e)
        {
            long number;
            if (!long.TryParse(txtTelpNumber.Text, out number) && !string.IsNullOrEmpty(txtTelpNumber.Text))
            {
                // Not a number
                lblAlphabetCounterTelp.Text = "The content must be a number";
                lblAlphabetCounterTelp.ForeColor = Color.Red;
            }
            else
            {
                lblAlphabetCounterTelp.ForeColor = Color.Black;
                alphabetCounterNoTelp(txtTelpNumber, lblAlphabetCounterTelp, 12);
            }
        }

        private void btnVisiblePassCreate_Click(object sender, EventArgs e)
        {
            showVisiblePassCreate();
        }

        private void pbHintTelpNum_MouseEnter(object sender, EventArgs e)
        {
            pnlHintTelp.Visible = true;
        }

        private void pbHintTelpNum_MouseLeave(object sender, EventArgs e)
        {
            pnlHintTelp.Visible = false;
        }

        private void pbHintStatus_MouseEnter(object sender, EventArgs e)
        {
            pnlHintStatus.Visible = true;
        }

        private void pbHintStatus_MouseLeave(object sender, EventArgs e)
        {
            pnlHintStatus.Visible = false;
        }

        private void pbHintId_MouseEnter(object sender, EventArgs e)
        {
            pnlHintId.Visible = true;
        }

        private void pbHintId_MouseLeave(object sender, EventArgs e)
        {
            pnlHintId.Visible = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            dangerUsername.Visible = false;

            lblAlphabetCounterUsername.Visible = true;
            alphabetCounter(txtUsername, lblAlphabetCounterUsername, 40);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            dangerPassword.Visible = false;
        }

        private void cbPosition_TextChanged(object sender, EventArgs e)
        {
            dangerPosition.Visible = false;
        }

        private void btnHidePnl_Click(object sender, EventArgs e)
        {
            pnlSuccess.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFieldNewUser();
            dangerUsername.Visible = false;
            dangerPassword.Visible = false;
            dangerPosition.Visible = false;
            lblAlphabetCounterTelp.Text = "12 remaining (INVALID number)";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            submitCreate();
        }
    }
}
