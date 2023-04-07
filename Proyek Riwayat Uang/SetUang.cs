using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyek_Riwayat_Uang
{
    public partial class SetUang : Form
    {
        public SetUang()
        {
            InitializeComponent();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Akan menghapus riwayat dan uang anda\n" +
                "Apakah anda yakin?", "Info",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (hasil == DialogResult.Yes)
            {
                try
                {
                    double uang = Convert.ToDouble(this.box_uang.Text);

                    App.db.clear_tabel();
                    App.db.update_uang(Convert.ToString(uang));
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (hasil == DialogResult.No)
            {

            }

        }
    }
}
