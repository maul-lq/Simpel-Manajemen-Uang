using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Proyek_Riwayat_Uang
{
    public class AppDatabase
    {
        MySqlConnection _koneksi;
        MySqlCommand _perintah;
        MySqlDataAdapter _data;
        MySqlDataReader _dataR;
        StringBuilder strKoneksiRiwayat;
        StringBuilder query;

        public AppDatabase()
        {
            strKoneksiRiwayat = new StringBuilder();
            strKoneksiRiwayat.Append("server=127.0.0.1;uid=root;pwd=;database=db_manajemen_uang");

            _koneksi = new MySqlConnection(strKoneksiRiwayat.ToString());
            this.BukaKoneksi();
        }

        public void BukaKoneksi()
        {
            _koneksi.Open();
        }

        public void TutupKoneksi()
        {
            _koneksi.Close();
        }

        // menghitun semua pengeluaran dan penghasilan dari tabel riwayat
        public List<double> totalRiwayat()
        {
            double pendapatan = 0;
            double pengeluaran = 0;
            List<double> statUang = new List<double>();

            query = new StringBuilder("SELECT `uang` FROM `riwayat`;");

            _perintah = new MySqlCommand(query.ToString(), _koneksi);
            _dataR = _perintah.ExecuteReader();

            while (_dataR.Read())
            {
                double uang = _dataR.GetDouble(0);
                if (uang >= 0)
                {
                    pendapatan += uang;
                }
                else
                {
                    pengeluaran += uang;
                }
            }

            _dataR.Close();

            statUang.Insert(0, pendapatan);
            statUang.Insert(1, pengeluaran);

            return statUang;
        }

        // baca tabel riwayat kemudian taru di data tabel
        public DataTable read_riwayat()
        {
            DataTable data = new DataTable();

            query = new StringBuilder("SELECT * FROM `riwayat`;");
            _data = new MySqlDataAdapter(query.ToString(), _koneksi);

            _data.Fill(data);

            return data;
        }

        // hampir sama bedanya dia tabel saldo dan cuman baca saldonya saja
        public string read_uang()
        {
            string result = "";

            query = new StringBuilder("SELECT `saldo` FROM `saldo` WHERE `id`='1';");
            _data = new MySqlDataAdapter(query.ToString(), _koneksi);

            DataTable data = new DataTable();
            _data.Fill(data);

            result = data.Rows[0].ItemArray[0].ToString();

            return "Rp. " + result; // tambah nama mata uang
        }

        public void update_uang(string uang)
        {
            query = new StringBuilder("UPDATE `saldo` SET `saldo`='$uang' WHERE `id`='1';")
                .Replace("$uang", uang);

            _perintah = new MySqlCommand(query.ToString(), _koneksi);
            _perintah.ExecuteNonQuery();
        }

        public void tambah_riwayat(string uang, string date, string catatan)
        {
            query = new StringBuilder("INSERT INTO `riwayat`(`uang`, `tanggal`, `catatan`) " +
                "VALUES ('$1','$2','$3');");

            query.Replace("$1", uang);
            query.Replace("$2", date.ToString());
            query.Replace("$3", catatan);

            _perintah = new MySqlCommand(query.ToString(),_koneksi);
            _perintah.ExecuteNonQuery();
            query.Clear();

            // setiap tambah riwayat uang dari tabel saldo akan mengurang/menambah tergantung
            // pilihan pendapatan atau pengeluaran yang ada di aplikasi.
            query = new StringBuilder("UPDATE `saldo` SET `saldo`=saldo+'$1' WHERE `id`='1'");
            query.Replace("$1", uang);
            _perintah = new MySqlCommand(query.ToString(), _koneksi);
            _perintah.ExecuteNonQuery();
        }

        public void clear_tabel()
        {
            query = new StringBuilder("DELETE FROM `riwayat`");
            _perintah = new MySqlCommand(query.ToString(), _koneksi);
            _perintah.ExecuteNonQuery();

            query = new StringBuilder("UPDATE `saldo` SET `saldo`='0' WHERE `id`='1'");
            _perintah = new MySqlCommand(query.ToString(), _koneksi);
            _perintah.ExecuteNonQuery();
        }
    }
}
