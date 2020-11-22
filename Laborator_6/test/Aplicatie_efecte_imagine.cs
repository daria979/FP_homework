using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace test
{
    static class Aplicatie_efecte_imagine
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
