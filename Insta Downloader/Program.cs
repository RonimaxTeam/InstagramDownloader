using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;

namespace Insta_Downloader
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string startupPath3 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            

            if (!File.Exists(startupPath3 + "\\Cookie.txt"))
            {
                Application.Run(new HelpForm());
            }
            else
            {
                Application.Run(new Form1());
            }

        }
        

    }
}
