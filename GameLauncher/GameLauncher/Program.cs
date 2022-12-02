using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    static class Program
    {

        static public Login_Form frm1;
        static public Warning frm2;
        static public Launcher frm3;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm1 = new Login_Form();
            frm2 = new Warning();
            frm3 = new Launcher();
            Application.Run(frm1);
        }

    }
}
