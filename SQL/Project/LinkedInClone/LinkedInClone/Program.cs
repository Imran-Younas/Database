using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedInClone
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
            //while (true)
           // {
                Application.Run(new Login());
                Application.Run(new SignUp());
                Application.Run(new Homepage());
                Application.Run(new UserProfile());
                //}
        }
    }
}
