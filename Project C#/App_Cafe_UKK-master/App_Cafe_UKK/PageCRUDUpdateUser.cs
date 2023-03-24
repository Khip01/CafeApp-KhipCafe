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
    public partial class PageCRUDUpdateUser : Form
    {
        //// DEKLARASI VARIABEL
        bool invisiblePass = true, telpNumValid = false;
        string id_karyawanData, usernameData, nama;

        // Untuk mengecek apakah ada perubahan pada data atau tidak
        string usernameUpd, posisiUpd, alamatUpd, no_telpUpd, genderUpd, deskripsiUpd;
        DateTime tanggal_lahirUpd;

        // Handler/Penanganan untuk button Update click
        private EventHandler _clickHandler;
        private EventHandler _mouseEnterHandler;
        private EventHandler _mouseLeaveHandler;
        bool addEvent = true, click = true;

        Utils util = new Utils();

        public PageCRUDUpdateUser(string U)
        {
            InitializeComponent();

            this.nama = U;
            tampilData();

            txtPassword.PasswordChar = '•';
            tampilComboBox();

            // Agar button bisa mempunyai eventHandler Click dan menyimpannya di _clickHandler
            _clickHandler = btnDeleteData_Click;
        }

        //// METHOD USER 

        private void refreshData()
        {
            tampilData();
            lblDangerSearch.Visible = false;
            clearSelectedUser();
        }

        private void disableButton()
        {
            btnDeleteData.Enabled = false;
            if (click)
            {
                // Agar button tidak bisa diklik (dengan menghilangkan eventHandler)
                btnDeleteData.Click -= _clickHandler;
                click = false;
            }
        }

        private void enableButton()
        {
            btnDeleteData.Enabled = true;
            if (!click)
            {
                // Agar button bisa diklik (dengan menambahkan eventHandler kembali)
                btnDeleteData.Click += _clickHandler;
                click = true;
            }
        }

        private void showPanelDelete(Control control, bool showPanel)
        {
            if (showPanel)
            {
                _mouseEnterHandler = (sender, e) => { pnlDeleteDanger.Visible = true; };
                _mouseLeaveHandler = (sender, e) => { pnlDeleteDanger.Visible = false; };
                // Jika addEvent true maka event akan ditambah 
                if (addEvent)
                {
                    control.MouseEnter += _mouseEnterHandler;
                    control.MouseLeave += _mouseLeaveHandler;
                    this.addEvent = false;
                }
            }
            else
            {
                // Jika addEvent false maka event akan dikurangi 
                if (!addEvent)
                {
                    control.MouseEnter -= _mouseEnterHandler;
                    control.MouseLeave -= _mouseLeaveHandler;
                    this.addEvent = true;
                }

                _mouseEnterHandler = null;
                _mouseLeaveHandler = null;

                this.addEvent = true;
            }
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

        private void submitUpdate(string idKaryawan, string username, string password, string position, string address, string telpNum, DateTime dateOfBirth, string gender, string description)
        {
            //// Memastikan jika tidak ada field yang tidak diinginkan!
            // Memastikan jika nama sudah dipakai pada database (terdapat duplikat)
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(username) FROM tblKaryawan WHERE username = '" + username + "' AND id_karyawan NOT IN ('"+idKaryawan+"')", util.koneksi);
            int result = Convert.ToInt32(util.cmd.ExecuteScalar());
            util.koneksi.Close();
            long number;
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(cbPosition.Text) || !long.TryParse(txtTelpNumber.Text, out number) || this.telpNumValid == false || result > 0)
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    dangerUsername.Text = "This field is required";
                    dangerUsername.Visible = true;
                    lblAlphabetCounterUsername.Visible = false;
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
                }
                return;
            }

            DialogResult resultDialog = MessageBox.Show("Are you sure to continue?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultDialog == DialogResult.No)
            {
                return;
            }

            // Kondisi jika tidak ada field yang diupdate
            if (this.usernameUpd == txtUsername.Text && this.posisiUpd == cbPosition.SelectedItem.ToString() && string.IsNullOrEmpty(txtPassword.Text) && this.alamatUpd == txtAddress.Text && this.no_telpUpd == txtTelpNumber.Text && this.tanggal_lahirUpd == dtpDateofBirth.Value && this.genderUpd == cbGender.SelectedItem.ToString() && this.deskripsiUpd == txtDescription.Text)
            {
                MessageBox.Show("No data has changed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFieldUpdate();
                refreshData();

                pnlUpdateMain.BringToFront();
                return;
            }

            // Proses Memperbarui data
            util.koneksi.Open();
            util.cmd = new SqlCommand("UPDATE tblKaryawan SET username = @username, posisi = @position, alamat = @address, no_telp = @telpNum, tanggal_lahir = @dateOfBirth, gender = @gender, deskripsi = @description WHERE id_karyawan = @idKaryawan", util.koneksi);
            util.cmd.Parameters.AddWithValue("username", username);
            util.cmd.Parameters.AddWithValue("position", position);
            util.cmd.Parameters.AddWithValue("address", address);
            util.cmd.Parameters.AddWithValue("telpNum", "+62"+telpNum);
            util.cmd.Parameters.AddWithValue("dateOfBirth", dateOfBirth);
            util.cmd.Parameters.AddWithValue("gender", gender);
            util.cmd.Parameters.AddWithValue("description", description);
            util.cmd.Parameters.AddWithValue("idKaryawan", idKaryawan);
            util.cmd.ExecuteNonQuery();
            // Kondisi jika password baru diisi
            if (!string.IsNullOrEmpty(password))
            {
                // Sesi menyimpan password! (password hashing) MENGGUNAKAN BCRYPT.NET
                //Pendeklarasian
                string salt = BCrypt.Net.BCrypt.GenerateSalt(); //generate random salt
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, salt); //hash password with salt

                // Sesi menyimpan password ke database tblKaryawan
                util.cmd = new SqlCommand("UPDATE tblKaryawan SET password = '" + hashedPassword + "' WHERE id_karyawan = '" + idKaryawan + "'", util.koneksi);
                util.cmd.ExecuteNonQuery();

                // Sesi menyimpan salt ke database tblSaltIsSecret
                util.cmd = new SqlCommand("INSERT INTO tblSaltIsSecret (id_karyawan, saltIsSecret) VALUES ('" + idKaryawan + "', '" + salt + "')", util.koneksi);
                util.cmd.ExecuteNonQuery();
            }

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "ADMIN", "ONLINE", "Telah memperbarui data Username "+username, DateTime.Now);

            util.koneksi.Close();

            MessageBox.Show("Success, data successfully changed", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearFieldUpdate();
            refreshData();

            pnlUpdateMain.BringToFront();
        }

        private void clearFieldUpdate()
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
            dangerUsername.Visible = false;
            dangerPosition.Visible = false;
            lblAlphabetCounterTelp.Text = "12 remaining (INVALID number)";
        }

        private void tampilData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id_karyawan, username, posisi, status, alamat, no_telp, tanggal_lahir, gender, deskripsi, added_by, date_added FROM tblKaryawan", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvDataUser.DataSource = dataSet.Tables[0];
        }

        private void clearSelectedUser()
        {
            // ID_KARYAWAN
            lblId.Text = "#K000";
            // USERNAME
            lblUsername.Text = "Name";
            // POSISI
            lblPosisi.Text = "-";
            // STATUS 
            lblStatus.ForeColor = Color.OliveDrab;
            lblStatus.Text = "ONLINE";
            // ALAMAT
            lblAlamat.Text = "-";
            // NO_TELP
            lblNoTelp.Text = "-";
            // TANGGAL LAHIR
            dtpTanggalLahir.Value = DateTime.Today;
            // GENDER
            lblKelamin.Text = "-";
            // DESKRIPSI
            lblDeskripsi.Text = "-";
            // PICTURE BOX
            pbProfile.Image = null;
            // Panel menjadi disabled
            pnlSelectedUser.Enabled = false;
        }

        private void deleteData()
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("DELETE FROM tblKaryawan WHERE id_karyawan = '"+id_karyawanData+"'", util.koneksi);
            util.cmd.ExecuteNonQuery();

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "ADMIN", "ONLINE", "Telah menghapus username " + usernameData + "", DateTime.Now);
            util.koneksi.Close();
        }

        // Mengecek apakah data dari database null/terisi (Terdapat 3 method OVERLOAD label, textbox, dan combobox)
        private void checkNullInfo(string data, Label lblData)
        {
            if (data == null || string.IsNullOrEmpty(data))
            {
                lblData.Text = "*Belum diisi";
            }
            else
            {
                lblData.Text = data;
            }
        }

        private void checkNullInfo(string data, TextBox txtData)
        {
            if (data == null || string.IsNullOrEmpty(data))
            {
                txtData.Text = "";
            }
            else
            {
                txtData.Text = data;
            }
        }

        private void checkNullInfo(string data, ComboBox cbData)
        {
            if (data == null || string.IsNullOrEmpty(data))
            {
                cbData.Text = "";
            }
            else
            {
                cbData.Text = data;
            }
        }

        private void checkNullInfoTelpNum(string data, TextBox txtData)
        {
            if (data == null || string.IsNullOrEmpty(data))
            {
                txtData.Text = "";
            }
            else
            {
                string dataFilter = data.Substring(3);
                txtData.Text = dataFilter;
                this.no_telpUpd = dataFilter;
            }
        }

        private void retriveData()
        {
            //// NEXT MEMBUAT DATA YANG MENAMPILKAN DI PANEL INFO
            int baris = dgvDataUser.CurrentCell.RowIndex;

            // ID_KARYAWAN
            string id_karyawan = dgvDataUser.Rows[baris].Cells[0].Value.ToString();
            lblId.Text = "#" + id_karyawan;
            txtIdKaryawan.Text = id_karyawan;
            // USERNAME
            string username = dgvDataUser.Rows[baris].Cells[1].Value.ToString();
            lblUsername.Text = username;
            txtUsername.Text = username;
            this.usernameUpd = username;
            // POSISI
            string posisi = dgvDataUser.Rows[baris].Cells[2].Value.ToString();
            lblPosisi.Text = posisi;
            cbPosition.Text = posisi;
            this.posisiUpd = posisi;
            // STATUS 
            string status = dgvDataUser.Rows[baris].Cells[3].Value.ToString();
            if (status == "ONLINE")
            {
                lblStatus.ForeColor = Color.OliveDrab;
            }
            else if (status == "OFFLINE")
            {
                lblStatus.ForeColor = Color.Red;
            }
            lblStatus.Text = status;
            txtStatus.Text = status;
            // ALAMAT
            string alamat = dgvDataUser.Rows[baris].Cells[4].Value.ToString();
            checkNullInfo(alamat, lblAlamat);
            checkNullInfo(alamat, txtAddress); // Mengirim ke fieldUpdateData txtAddress
            this.alamatUpd = alamat;
            // NO_TELP
            string no_telp = dgvDataUser.Rows[baris].Cells[5].Value.ToString();
            // Mengambil data telpNum tanpa kode negara
            checkNullInfo(no_telp, lblNoTelp);
            checkNullInfoTelpNum(no_telp, txtTelpNumber); // Mengirim ke fieldUpdateData txtTelpNumber
            // TANGGAL LAHIR
            DateTime tglLahir;
            // Mengecek jika dgv meretrive tanggal/null
            if (DateTime.TryParse(dgvDataUser.Rows[baris].Cells[6].Value.ToString(), out tglLahir))
            {
                dtpTanggalLahir.Value = tglLahir;
                dtpDateofBirth.Value = tglLahir; // Mengirim ke fieldUpdateData dtpDateofBirth
                this.tanggal_lahirUpd = tglLahir;
            }
            else
            {
                dtpTanggalLahir.Value = DateTime.Today;
                dtpDateofBirth.Value = DateTime.Today; // Mengirim ke fieldUpdateData dtpDateofBirth
                this.tanggal_lahirUpd = DateTime.Today;
            }
            // GENDER
            string gender = dgvDataUser.Rows[baris].Cells[7].Value.ToString();
            checkNullInfo(gender, lblKelamin);
            checkNullInfo(gender, cbGender); // Mengirim ke fieldUpdateData cbGender
            this.genderUpd = gender;
            // DESKRIPSI
            string deskripsi = dgvDataUser.Rows[baris].Cells[8].Value.ToString();
            checkNullInfo(deskripsi, lblDeskripsi);
            checkNullInfo(deskripsi, txtDescription); // Mengirim ke fieldUpdateData txtDescription
            this.deskripsiUpd = deskripsi;
            // PICTURE BOX
            if (posisi == "ADMIN")
            {
                pbProfile.Image = Properties.Resources.Admin512;
            }
            else if (posisi == "MANAJER")
            {
                pbProfile.Image = Properties.Resources.Manajer512;
            }
            else if (posisi == "KASIR")
            {
                pbProfile.Image = Properties.Resources.Kasir512;
            }
            else
            {
                pbProfile.Image = null;
            }
        }

        private void searchData(string data)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id_karyawan, username, posisi, status, alamat, no_telp, tanggal_lahir, gender, deskripsi, added_by, date_added FROM tblKaryawan WHERE username LIKE '%" + data + "%' OR id_karyawan LIKE '%" + data + "%' OR posisi LIKE '%" + data + "%' OR status LIKE '%" + data + "%' OR alamat LIKE '%" + data + "%' OR no_telp LIKE '%" + data + "%' OR tanggal_lahir LIKE '%" + data + "%' OR gender LIKE '%" + data + "%' OR deskripsi LIKE '%" + data + "%' OR date_added LIKE '%" + data + "%' OR added_by LIKE '%" + data + "%'", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dgvDataUser.DataSource = dataSet.Tables[0];
        }

        //// FORM CONTROL

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                lblDangerSearch.Visible = true;
            }
            else
            {
                searchData(txtSearch.Text);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI KOLOM SEARCH MAKA BUTTON OTOMATIS TERTEKAN SEARCH
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void dgvDataUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int baris = dgvDataUser.CurrentCell.RowIndex;

            // ID_KARYAWAN
            string id_karyawan = dgvDataUser.Rows[baris].Cells[0].Value.ToString();
            string username = dgvDataUser.Rows[baris].Cells[1].Value.ToString();

            if (!string.IsNullOrEmpty(id_karyawan))
            {
                this.id_karyawanData = id_karyawan;
                this.usernameData = username;
                pnlSelectedUser.Enabled = true;
                retriveData();
                string status = dgvDataUser.Rows[baris].Cells[3].Value.ToString();
                if (status == "ONLINE")
                {
                    disableButton();
                    showPanelDelete(btnDeleteData, true);
                }
                else if (status == "OFFLINE")
                {
                    enableButton();
                    showPanelDelete(btnDeleteData, false);
                }
            }
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            deleteData();
            MessageBox.Show("Data has been successfully deleted", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearSelectedUser();
            tampilData();
            pnlSelectedUser.Enabled = false;
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update the data?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            pnlUpdateChild.BringToFront();
            //fillFieldUpdate(txtIdKaryawan.Text, txtUsername.Text, txtPassword.Text, cbPosition.Text, txtStatus.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this edit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                refreshData();
                pnlUpdateMain.BringToFront();
            }
        }

        private void pbHintId_MouseEnter(object sender, EventArgs e)
        {
            pnlHintId.Visible = true;
        }

        private void pbHintId_MouseLeave(object sender, EventArgs e)
        {
            pnlHintId.Visible = false;
        }

        private void pbHintStatus_MouseEnter(object sender, EventArgs e)
        {
            pnlHintStatus.Visible = true;
        }

        private void pbHintStatus_MouseLeave(object sender, EventArgs e)
        {
            pnlHintStatus.Visible = false;
        }

        private void pbHintTelpNum_MouseEnter(object sender, EventArgs e)
        {
            pnlHintTelp.Visible = true;
        }

        private void pbHintTelpNum_MouseLeave(object sender, EventArgs e)
        {
            pnlHintTelp.Visible = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            dangerUsername.Visible = false;

            lblAlphabetCounterUsername.Visible = true;
            alphabetCounter(txtUsername, lblAlphabetCounterUsername, 40);
        }

        private void btnVisiblePassCreate_Click(object sender, EventArgs e)
        {
            showVisiblePassCreate();
        }

        private void cbPosition_TextChanged(object sender, EventArgs e)
        {
            dangerPosition.Visible = false;
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

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            // MEMBUAT PENGHITUNG ABJAD
            alphabetCounter(txtDescription, lblAlphabetCounterDesc, 250);
        }

        private void btnSubmitUpdate_Click(object sender, EventArgs e)
        {
            submitUpdate(txtIdKaryawan.Text, txtUsername.Text, txtPassword.Text, cbPosition.Text, txtAddress.Text, txtTelpNumber.Text, dtpDateofBirth.Value, cbGender.Text, txtDescription.Text);
        }
    }
}
