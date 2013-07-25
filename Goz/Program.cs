using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//character set=WIN1254;data source=192.168.2.10;initial catalog=D:\GOZ\DATA\GOZ.FDB;user id=sysdba;password=masterkey
namespace Goz
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
            Application.Run(new HTForm());
        }
    }
}
