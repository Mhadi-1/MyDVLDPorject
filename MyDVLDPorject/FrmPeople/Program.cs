using MyDVLDPorject.Frm_Appliciation;
using MyDVLDPorject.Frm_Appliciation.Drivers;
using MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests;
using MyDVLDPorject.Frm_Appliciation.Frms_International_Driving_License;
using MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp;
using MyDVLDPorject.genralClasess;
using MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Detainted_Licenses;
using MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Release_License_s;
using MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License;
using MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Replacement_Or_Lost_Driving_Licesne;
using MyMemeoryGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the _application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}
