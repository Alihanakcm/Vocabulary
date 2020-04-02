using DevExpress.UserSkins;
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraExport.Helpers;

namespace Vocabulary.MainUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new MainForm());
        }
    }
}
