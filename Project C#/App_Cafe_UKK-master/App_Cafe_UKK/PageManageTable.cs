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
    public partial class PageManageTable : Form
    {
        //// DEKLARASI VARIABEL
        Button currentButton;
        Utils util = new Utils();
        string nama, no_mejaPrivt;
        int id_mejaPrivt;


        public PageManageTable(string U)
        {
            InitializeComponent();

            tampilData();
            currentButton = btnDataTable;
            this.nama = U;
        }

        //// MANUAL METHOD
        private void clearFieldUpdate()
        {

            txtNoMejaUpdate.Clear();
            dangerNoMejaUpdate.Visible = false;
            txtStatusUpdate.Text = "KOSONG";
        }

        private void submitUpdate(string no_meja, string status)
        {
            //// Memastikan jika tidak ada field yang tidak diinginkan!
            // Memastikan jika nama sudah dipakai pada database (terdapat duplikat)
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(no_meja) FROM tblMeja WHERE no_meja = '" + no_meja + "' AND no_meja NOT IN ('" + id_mejaPrivt + "')", util.koneksi);
            int result = Convert.ToInt32(util.cmd.ExecuteScalar());
            util.koneksi.Close();

            if (string.IsNullOrEmpty(no_meja) || result > 0)
            {
                if (string.IsNullOrEmpty(txtNoMeja.Text))
                {
                    dangerNoMejaUpdate.Text = "This field is required";
                    dangerNoMejaUpdate.Visible = true;
                    lblAlphabetCounterNoMejaUpdate.Visible = false;
                }
                if (result > 0)
                {
                    dangerNoMejaUpdate.Text = "Name already taken";
                    dangerNoMejaUpdate.TextAlign = ContentAlignment.MiddleRight;
                    dangerNoMejaUpdate.Visible = true;
                    lblAlphabetCounterNoMejaUpdate.Visible = false;
                }
                return;
            }

            DialogResult resultDialog = MessageBox.Show("Are you sure to continue?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultDialog == DialogResult.No)
            {
                return;
            }

            // Proses Memperbarui data
            util.koneksi.Open();
            util.cmd = new SqlCommand("UPDATE tblMeja SET no_meja = @no_meja, status = @status WHERE id_meja = @id_meja", util.koneksi);
            util.cmd.Parameters.AddWithValue("no_meja", no_meja);
            util.cmd.Parameters.AddWithValue("status", status);
            util.cmd.Parameters.AddWithValue("id_meja", id_mejaPrivt);
            util.cmd.ExecuteNonQuery();

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "MANAGER", "ONLINE", "Telah memperbarui data Table/Meja " + no_meja, DateTime.Now);

            util.koneksi.Close();

            MessageBox.Show("Success, data successfully changed", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearFieldUpdate();
            clearFieldDataTable();
            tampilData();

            pnlDataTable.BringToFront();
        }

        private void retriveData()
        {
            //// NEXT MEMBUAT DATA YANG MENAMPILKAN DI PANEL INFO
            int baris = dgvDataTable.CurrentCell.RowIndex;

            // PANEL DATA TABLE //
            // ID_MEJA
            int id_meja = Convert.ToInt32(dgvDataTable.Rows[baris].Cells[0].Value.ToString());
            this.id_mejaPrivt = id_meja;

            // NO_MEJA
            string no_meja = dgvDataTable.Rows[baris].Cells[1].Value.ToString();
            lblNoMeja.Text = no_meja;
            this.no_mejaPrivt = no_meja;
            // STATUS
            string status = dgvDataTable.Rows[baris].Cells[2].Value.ToString();
            lblStatus.Text = status;

            // PANEL UPDATE //
            // NO_MEJA
            txtNoMejaUpdate.Text = no_meja;
            // STATUS
            txtStatusUpdate.Text = status;

            btnUpdateData.Enabled = true;
            btnDeleteData.Enabled = true;
        }

        private void deleteData()
        {
            // MENGHAPUS di database
            util.koneksi.Open();
            util.cmd = new SqlCommand("DELETE FROM tblMeja WHERE no_meja = '" + no_mejaPrivt + "'", util.koneksi);
            util.cmd.ExecuteNonQuery();

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "MANAGER", "ONLINE", "Telah menghapus data Table " + no_mejaPrivt + "", DateTime.Now);
            util.koneksi.Close();
        }

        private void clearFieldDataTable()
        {
            btnUpdateData.Enabled = false;
            btnDeleteData.Enabled = false;
            lblNoMeja.Text = "No Meja";
            lblStatus.Text = "Kosong";
        }

        private void tampilData()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM tblMeja", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dgvDataTable.DataSource = dataSet.Tables[0];
            dgvCreateDataTable.DataSource = dataSet.Tables[0];
            dgvUpdateDataTable.DataSource = dataSet.Tables[0];
        }

        private void clearFieldNewTable()
        {
            txtNoMeja.Clear();
            dangerNoMeja.Visible = false;
        }

        private void submitCreate()
        {
            //// Memastikan jika tidak ada field yang tidak diinginkan!
            // Memastikan jika nama sudah dipakai pada database (terdapat duplikat)
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(no_meja) FROM tblMeja WHERE no_meja = '" + txtNoMeja.Text + "'", util.koneksi);
            int result = Convert.ToInt32(util.cmd.ExecuteScalar());
            util.koneksi.Close();
            if (string.IsNullOrEmpty(txtNoMeja.Text) ||  result > 0)
            {
                if (string.IsNullOrEmpty(txtNoMeja.Text))
                {
                    dangerNoMeja.Text = "This field is required";
                    dangerNoMeja.Visible = true;
                    lblAlphabetCounterNoMeja.Visible = false;
                }
                if (result > 0)
                {
                    dangerNoMeja.Text = "Name already taken";
                    dangerNoMeja.TextAlign = ContentAlignment.MiddleRight;
                    dangerNoMeja.Visible = true;
                    lblAlphabetCounterNoMeja.Visible = false;
                }
                return;
            }
            // PROSES MENYIMPAN DATA //
            // Variabel Deklarasi 
            string no_meja = txtNoMeja.Text;
            string status = txtStatus.Text;
            DateTime date_added = DateTime.Now;

            // Mencari id_karyawan berdasarkan added by
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '" + this.nama + "'", util.koneksi);
            string added_by = util.cmd.ExecuteScalar().ToString();
            util.koneksi.Close();

            // PROSES INSERT KE TBLMEJA
            util.koneksi.Open();
            util.cmd = new SqlCommand("INSERT INTO tblMeja VALUES (@no_meja, @status, @date_added, @added_by)", util.koneksi);
            util.cmd.Parameters.AddWithValue("no_meja", no_meja);
            util.cmd.Parameters.AddWithValue("status", status);
            util.cmd.Parameters.AddWithValue("date_added", date_added);
            util.cmd.Parameters.AddWithValue("added_by", added_by);
            util.cmd.ExecuteNonQuery();

            // Sesi menyimpan aktifitas ke log aktifitas
            util.saveActivity(this.nama, "MANAGER", "ONLINE", "Telah menambahkan Table/Meja baru bernama " + no_meja, DateTime.Now);

            util.koneksi.Close();
            MessageBox.Show("Table Data added successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // MENGHAPUS TEXTFIELD DEFAULT
            clearFieldNewTable();
            tampilData();
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

        private void changeButtonColor(object sender, EventArgs e)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.Sienna; // Mengubah warna button
                currentButton.Parent.BackColor = Color.Sienna; // Mengubah warna panel
            }
            currentButton = (Button)sender;
            currentButton.BackColor = Color.Chocolate; // Mengubah warna button
            currentButton.Parent.BackColor = Color.Chocolate; // Mengubah warna 
        }


        //// FORM CONTROL
        private void btnDataTable_Click(object sender, EventArgs e)
        {
            pnlDataTable.BringToFront();
            clearFieldDataTable();
            changeButtonColor(sender, e);
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            pnlCreateTable.BringToFront();
            clearFieldNewTable();
            changeButtonColor(sender, e);
        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            pnlUpdateTable.BringToFront();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this edit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                clearFieldDataTable();
                clearFieldUpdate();
                pnlDataTable.BringToFront();
            }
        }

        private void pbHintNoMeja_MouseEnter(object sender, EventArgs e)
        {
            pnlHintNoMeja.BringToFront();
            pnlHintNoMeja.Visible = true;
        }

        private void pbHintNoMeja_MouseLeave(object sender, EventArgs e)
        {
            pnlHintNoMeja.Visible = false;
        }

        private void pbHintStatus_MouseEnter(object sender, EventArgs e)
        {
            pnlHintStatus.Visible = true;
        }

        private void pbHintStatus_MouseLeave(object sender, EventArgs e)
        {
            pnlHintStatus.Visible = false;
        }

        private void txtNoMeja_TextChanged(object sender, EventArgs e)
        {
            dangerNoMeja.Visible = false;

            lblAlphabetCounterNoMeja.Visible = true;
            alphabetCounter(txtNoMeja, lblAlphabetCounterNoMeja, 11);
        }

        private void btnCreateNewtable_Click(object sender, EventArgs e)
        {
            submitCreate();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tampilData();
            clearFieldDataTable();
        }

        private void dgvDataTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            retriveData();
        }

        private void pbHintNoMejaUpdate_MouseEnter(object sender, EventArgs e)
        {
            pnlHintNoMejaUpdate.BringToFront();
            pnlHintNoMejaUpdate.Visible = true;
        }

        private void pbHintNoMejaUpdate_MouseLeave(object sender, EventArgs e)
        {
            pnlHintNoMejaUpdate.Visible = false;
        }

        private void pbHintStatusUpdate_MouseEnter(object sender, EventArgs e)
        {
            pnlHintStatusUpdate.Visible = true;
        }

        private void pbHintStatusUpdate_MouseLeave(object sender, EventArgs e)
        {
            pnlHintStatusUpdate.Visible = false;
        }

        private void btnUpdateDataUpdate_Click(object sender, EventArgs e)
        {
            submitUpdate(txtNoMejaUpdate.Text, txtStatusUpdate.Text);
        }

        private void txtNoMejaUpdate_TextChanged(object sender, EventArgs e)
        {
            dangerNoMejaUpdate.Visible = false;

            lblAlphabetCounterNoMejaUpdate.Visible = true;
            alphabetCounter(txtNoMejaUpdate, lblAlphabetCounterNoMejaUpdate, 11);
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
            clearFieldDataTable();
            tampilData();
        }
    }
}
