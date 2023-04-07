using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyek_Riwayat_Uang
{
    public partial class App : Form
    {
        public static AppDatabase db = new AppDatabase();

        public App()
        {
            InitializeComponent();
        }

        private void AppExit(object sender, FormClosedEventArgs e)
        {
            db.TutupKoneksi();
            Application.Exit();
        }

        public void refresh()
        {
            DateTime date = new DateTime(DateTime.Now.Ticks);

            this.Text = "Simpel Manajemen Uang by rizlradFz | " + date.ToShortDateString();
            #region Tabel Riwayat
            dataGridView_riwayat.DataSource = db.read_riwayat();

            // mengatur lebar kolom untuk kolom 'uang'
            dataGridView_riwayat.Columns["uang"].Width = Convert.ToInt32(100 * 1.2);

            // mengatur lebar kolom untuk kolom 'tanggal'
            dataGridView_riwayat.Columns["tanggal"].Width = Convert.ToInt32(80 * 1);

            // mengatur lebar kolom untuk kolom 'catatan'
            dataGridView_riwayat.Columns["catatan"].Width = Convert.ToInt32(150 * 2);

            List<double> totalriwayat = db.totalRiwayat();
            box_Pendapatan.Text = "Rp. " + totalriwayat[0].ToString();
            box_Pengeluaran.Text = "Rp. " + totalriwayat[1].ToString();
            #endregion

            #region Tabel Uang
            this.box_Uang.Text = db.read_uang();

            #endregion

            if (box_Pendapatan.Text == "Rp. 0" && box_Pengeluaran.Text == "Rp. 0" && box_Uang.Text == "Rp. 0")
            {
                // jika pengeluaran, pendapatan, dan uang yang dipunya semua 0
                // tombol tambah riwayat dan hapus tidak bisa diklik sebelum atur
                // uang pengguna.
                this.btn_AddRiwayat.Enabled = false;
                this.btn_Clear.Enabled = false;
            }
            else
            {
                this.btn_AddRiwayat.Enabled = true;
                this.btn_Clear.Enabled = true;
            }
        }

        private void App_Load(object sender, EventArgs e)
        {
            try
            {
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_setUang_Click(object sender, EventArgs e)
        {
            SetUang winSU = new SetUang();
            winSU.ShowDialog();
            refresh();
        }

        private void btn_AddRiwayat_Click(object sender, EventArgs e)
        {
            TambahRiwayat winTR = new TambahRiwayat();
            winTR.ShowDialog();
            refresh();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Akan menghapus semua riwayat dan atur ulang uang menjadi 0" +
                "\nApakah anda yakin?", "Peringatan!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                db.clear_tabel();
                refresh();
            }
            else if (result == DialogResult.No)
            {
                refresh();
            }
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
