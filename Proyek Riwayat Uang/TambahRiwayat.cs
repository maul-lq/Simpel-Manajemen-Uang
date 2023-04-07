using System;
using System.Windows.Forms;

namespace Proyek_Riwayat_Uang
{
    public partial class TambahRiwayat : Form
    {
        public TambahRiwayat()
        {
            InitializeComponent();
        }

        private void clear()
        {
            box_uang.Clear();
            pendapatan.Checked = false;
            pengeluaran.Checked = false;
            note.Clear();
        }

        private void TambahRiwayat_Load(object sender, EventArgs e)
        {
            this.tanggal.Format = DateTimePickerFormat.Short;
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                string uang = box_uang.Text;
                string date = tanggal.Value.ToShortDateString();
                string catatan = note.Text.ToString();

                if (this.pendapatan.Checked)
                {
                    uang = "" + uang;
                }
                else if (this.pengeluaran.Checked)
                {
                    uang = "-" + uang;
                }

                try
                {
                    App.db.tambah_riwayat(uang, date, catatan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                if (riwayatlebihdari1.Checked)
                {
                    clear();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
