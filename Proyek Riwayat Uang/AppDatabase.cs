using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Proyek_Riwayat_Uang
{
    public class AppDatabase
    {
        MySqlConnection _koneksi;

        public AppDatabase(string strKoneksi) 
        {
            _koneksi = new MySqlConnection(strKoneksi);
        }
    }
}
