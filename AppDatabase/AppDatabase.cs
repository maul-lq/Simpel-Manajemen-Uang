using MySql.Data.MySqlClient;


namespace AppDatabase
{
    public class AppDatabase
    {

        public AppDatabase(string strKoneksi)
        {
            MySqlConnection koneksi = new MySqlConnection(strKoneksi);
        }
    }
}