using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsLibraryBussniselayr;
using Microsoft.Win32;

namespace MyDVLDPorject.genralClasess
{

    public class ClsGeneral
    {
        public enum enApplicationType

        {
            NewLocalApplication = 1,
            RenewDrivingLicense = 2,
            ReplacementForLost = 3,
            ReplacementForDamaged = 4,
            ReleaseDetained = 5,
            NewInternationLicense = 6,
            RetakeTest = 8,
        };

        public static string DataFormat(DateTime date)
        {
            return date.ToString("dd/MMM/yyyy"); 
        }

        public enum enTestType { VisitionTest = 1, WriteTest = 2, StreetTest = 3 };
        public static enTestType TestType;
        public static enApplicationType ApplicationType;
        public enum enApplicationStatus { New = 1, cancelled = 2, completed = 3 };

        public static clsUser CurrentUser = new clsUser();
        public static clsPerson Person = new clsPerson();
    }
}
