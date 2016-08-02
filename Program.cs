using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PI_AF_SDK_Async_Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        //Comment here
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
