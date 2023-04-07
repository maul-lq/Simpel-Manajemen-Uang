using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyek_Riwayat_Uang
{
    public partial class App : Form
    {
        AppDatabase AppDB;


        public App()
        {
            InitializeComponent();
        }

        private void AppExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void App_Load(object sender, EventArgs e)
        {
            try
            {
                AppDB = new AppDatabase();
                AppDB.BukaKoneksi();

                dataGridView_riwayat.DataSource = AppDB.read_riwayat();

                // mengatur lebar kolom untuk kolom 'id'
                dataGridView_riwayat.Columns["id"].Width = 50;

                // mengatur lebar kolom untuk kolom 'uang'
                dataGridView_riwayat.Columns["uang"].Width = Convert.ToInt32(100*1.2);

                // mengatur lebar kolom untuk kolom 'tanggal'
                dataGridView_riwayat.Columns["tanggal"].Width = Convert.ToInt32(80 * 1);

                // mengatur lebar kolom untuk kolom 'catatan'
                dataGridView_riwayat.Columns["catatan"].Width = Convert.ToInt32(150 * 2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
