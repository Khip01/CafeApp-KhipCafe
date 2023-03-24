using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace App_Cafe_UKK
{
    class Utils
    {
        //// UNTUK KONEKSI KE DATABASE
        public SqlConnection koneksi = new SqlConnection(@"Data Source=KHIP01;Initial Catalog=db_Cafe_UKK;Integrated Security=True");
        public SqlCommand cmd;

        //// UNTUK RANDOM CODE ID_KARYAWAN (id_karyawan, tblkaryawan)
        public string idGenerator(string col, string table, string karakter)
        {
            koneksi.Open();

            for (int numInt = 1; numInt <= 999; numInt++)
            {
                // MENCOBA MENAMBAHKAN STRING 000 DAN NUMINT
                string numString = numInt.ToString("000");
                // APAKAH RESULT TERDAPAT DI DATABASE ?
                string idSementara = karakter + numString;
                cmd = new SqlCommand("SELECT COUNT(*) FROM " + table + " WHERE " + col + " = '" + idSementara + "'", koneksi);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 0)
                {
                    koneksi.Close();
                    return idSementara;
                }
            }

            koneksi.Close();
            return "";
        }

        //// UNTUK RANDOM CODE ID_ORDER (id_order, tblOrder)
        public string idGeneratorOrder(string col, string table)
        {
            koneksi.Open();

            for (int numInt = 1; numInt <= 999; numInt++)
            {
                // MENCOBA MENAMBAHKAN STRING 000 DAN NUMINT
                string numString = numInt.ToString("000");
                // Generate Automatic
                string id_order = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString() + DateTime.Today.Day.ToString() + numString;
                // APAKAH id_order TERDAPAT DI DATABASE ?
                cmd = new SqlCommand("SELECT COUNT(*) FROM " + table + " WHERE " + col + " = '" + id_order + "'", koneksi);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 0)
                {
                    koneksi.Close();
                    return id_order;
                }
            }

            koneksi.Close();
            return "";
        }

        public void saveActivity(string username, string posisi, string statusUser, string action, DateTime dateNow)
        {
            cmd = new SqlCommand("INSERT INTO tblLogAktifitas (username, posisi, status, action, date_added) VALUES (@username, @posisi, @statusUser, @action, @dateNow)", koneksi);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("posisi", posisi);
            cmd.Parameters.AddWithValue("statusUser", statusUser);
            cmd.Parameters.AddWithValue("action", action);
            cmd.Parameters.AddWithValue("dateNow", dateNow);
            cmd.ExecuteNonQuery();
        }

    }
}
