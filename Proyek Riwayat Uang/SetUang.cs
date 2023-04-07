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
    public partial class SetUang : Form
    {
        bool mousePress;
        Point point;

        public SetUang()
        {
            InitializeComponent();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePress = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePress)
            {
                Point offset = PointToScreen(e.Location);
                Location = new Point(offset.X - point.X, offset.Y - point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousePress = false;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                double uang = Convert.ToDouble(this.box_uang.Text);

                App.db.update_uang(Convert.ToString(uang));
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
