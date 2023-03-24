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
    public partial class PageDashboardKasir : Form
    {
        //// DEKLARASI VARIABEL
        Utils util = new Utils();
        string sqlCommandAll = "SELECT * FROM tblMenu ORDER BY date_added DESC";
        string nama;

        public PageDashboardKasir(string U)
        {
            InitializeComponent();

            this.nama = U;
            tampilTotalTransaksi();
            tampilTotalMeja();
            tampilCatatanTransaksi();
            tampilDataListMenu(sqlCommandAll);
            tampilDataMejaYangTersedia();
            tampilTotalTransaksiHariIni();
        }

        //// USER MANUAL METHOD
        private void tampilTotalTransaksiHariIni()
        {
            string id = getIdFromNama(this.nama);
            string today = DateTime.Today.ToString("yyyy-MM-dd");

            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(DISTINCT id_order) FROM tblOrder WHERE added_by = '" + id + "' AND date = '" + today + "'", util.koneksi);
            int totalTransaksiHariIni = Convert.ToInt32(util.cmd.ExecuteScalar());
            lblTransaksiHariIni.Text = totalTransaksiHariIni.ToString();
            util.koneksi.Close();
        }

        private void tampilDataMejaYangTersedia()
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(*) FROM tblMeja WHERE status = 'KOSONG'", util.koneksi);
            int availableTable = Convert.ToInt32(util.cmd.ExecuteScalar());
            lblMejaYangTersedia.Text = availableTable.ToString();
            util.koneksi.Close();
        }

        private string getIdFromNama(string nama)
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT id_karyawan FROM tblKaryawan WHERE username = '"+nama+"'", util.koneksi);
            string id = util.cmd.ExecuteScalar().ToString();
            util.koneksi.Close();
            return id;
        }

        private string getSqlCommand(string textBox) // string textBox diisi txtSearch.Text
        {
            // Note : 
            // Karena jika variabel dibawah diletakkan di section DEKLARASI VARIABEL,
            // saya kesulitan mengambil data textBox menurut txtSearch,
            // maka saya buatkan method sendiri untuk mengambil textBox disini
            // dan mereturn nilai sqlCommand Itu sendiri :)
            string sqlCommandSearch = "SELECT * FROM tblMenu WHERE id_menu LIKE '%" + textBox + "%' OR nama_menu LIKE '%" + textBox + "%' OR harga LIKE '%" + textBox + "%' OR gambar LIKE '%" + textBox + "%' OR date_added LIKE '%" + textBox + "%' OR added_by LIKE '%" + textBox + "%' ORDER BY date_added DESC";

            return sqlCommandSearch;
        }

        private void tampilDataListMenu(string command)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, util.koneksi);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];
            dataTable.Columns.Add("Image", typeof(Image));

            foreach (DataRow row in dataTable.Rows)
            {
                //// CODING BIASA UNTUK MENGUBAH UKURAN TETAPI RASIO BERUBAH SEHINGGA GAMBAR TIDAK TERLIHAT SEPERTI ASLINYA (SEPERTI DILEBARKAN ATAU DI MENYUSUT KAN) (PLAN A)
                //// Mengambil path gambar
                //string imagePath = row["gambar"].ToString();
                //// Membuat objek baru sebagai image agar ukuran bisa diubah
                //Image image = Image.FromFile(imagePath);
                //// Merubah ukuran gambar
                //Image resizedImage = image.GetThumbnailImage(200, 200, null, IntPtr.Zero);
                //// Menampilkan hasil resize 
                //row["Image"] = resizedImage;

                //// CODING RINCI MENGENAI RASIO (PLAN B)
                try
                {
                    Image image = Image.FromFile(row["gambar"].ToString());
                    int width = image.Width;
                    int height = image.Height;
                    int newWidth = 200;
                    int newHeight = (height * newWidth) / width;

                    if (newHeight > 200)
                    {
                        newHeight = 200;
                        newWidth = (width * newHeight) / height;
                    }

                    Image resizedImage = new Bitmap(image, newWidth, newHeight);
                    row["Image"] = resizedImage;
                    // Kondisi jika gambar ditemukan
                }
                catch (System.IO.FileNotFoundException)
                {
                    // Jika lokasi gambar tidak ditemukan
                    row["Image"] = Properties.Resources.noImage24;
                }

                //// UNTUK MENGETAHUI HASIL LEBIH JELAS SILAHKAN COBA COMMENT dan UNCOMMENT SALAH SATU PLAN A/B
            }

            dataTable.Columns.Remove("gambar");
            dgvListMenu.DataSource = dataTable;
            dgvListMenu.Columns["Image"].DisplayIndex = 0;
        }

        private void tampilCatatanTransaksi()
        {
            string id = getIdFromNama(this.nama);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT id_order, id_menu, qty, total, id_meja, added_by, date FROM tblOrder WHERE added_by = '" + id + "' ORDER BY date DESC, id_order DESC", util.koneksi);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            dgvCatatanTransaksi.DataSource = dataSet.Tables[0];
        }

        private void tampilTotalTransaksi()
        {
            string id = getIdFromNama(this.nama);

            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(DISTINCT id_order) FROM tblOrder WHERE added_by = '" + id + "'", util.koneksi);
            int totalTransaksi = Convert.ToInt32(util.cmd.ExecuteScalar());
            lblTotalTransaksi.Text = totalTransaksi.ToString();
            util.koneksi.Close();
        }

        private void tampilTotalMeja()
        {
            util.koneksi.Open();
            util.cmd = new SqlCommand("SELECT COUNT(*) FROM tblMeja", util.koneksi);
            int totalMeja = Convert.ToInt32(util.cmd.ExecuteScalar()) - 1;
            lblTotalMeja.Text = totalMeja.ToString();
            util.koneksi.Close();
        }


        //// FORM CONTROL
        private void PageDashboardKasir_Load(object sender, EventArgs e)
        {
            // Menentukan ukuran kolom Image
            dgvListMenu.Columns["Image"].Width = 210;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                tampilDataListMenu(sqlCommandAll);
            }
            else
            {
                tampilDataListMenu(getSqlCommand(txtSearch.Text));
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // JIKA ENTER DITEKAN DISAAT MENGISI KOLOM SEARCH MAKA BUTTON OTOMATIS TERTEKAN SEARCH
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
