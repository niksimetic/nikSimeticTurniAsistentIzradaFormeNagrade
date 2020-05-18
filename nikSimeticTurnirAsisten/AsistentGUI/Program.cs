using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsistentGUI
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
            //initionalize the database  connections 
            nikSimeticTurnirAsisten.GlobalConfig.InitializeConnections(true, true);
            Application.Run(new KreiranjeNagrade());  
            //Application.Run(new KreiranjeTima());
        }
    }
}
