using System;
using System.Windows.Forms;

namespace Proyek_Riwayat_Uang
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            (new App()).Show();
            Application.Run();
        }
    }
}
