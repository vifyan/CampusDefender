//CampusDefender ver1.0.0 2014/8/12

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CampusDefender
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
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
