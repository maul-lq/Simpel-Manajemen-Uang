using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyek_Riwayat_Uang
{
    public class AppDatabase
    {
        MySqlConnection _koneksi;
        MySqlCommand _perintah;
        MySqlDataAdapter _data;
        StringBuilder strKoneksiRiwayat;

        public AppDatabase() 
        {
            strKoneksiRiwayat = new StringBuilder();
            strKoneksiRiwayat.Append("server=127.0.0.1;uid=root;pwd=;database=db_riwayat_uang");

            _koneksi = new MySqlConnection(strKoneksiRiwayat.ToString());
        }

        public void BukaKoneksi()
        {
            _koneksi.Open();
        }

        public void TutupKoneksi()
        {
            _koneksi.Close();
        }

        public DataTable read_riwayat()
        {
            DataTable data = new DataTable();

            string query = "SELECT * FROM `riwayat`";
            _perintah = new MySqlCommand(query, _koneksi);
            _data = new MySqlDataAdapter(query, _koneksi);

            _data.Fill(data);

            return data;
        }
    }
}
