using ClsLibraryBussniselayr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls
{
    public partial class ctrlApplicationBasicProccessInfo : UserControl
    {
        public void LoadLocalApplicationInfo(int LDLAPPID)
        {
            ClsLocalDrivingLiceneseApplication LocalLicese = ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicense(LDLAPPID);
            
            if (LocalLicese != null)
            {
                ClsLicenseClass LicenseClass = ClsLicenseClass.GetLicenseClass(LocalLicese.LicenseClassID);
                lblApplicationID.Text = LocalLicese.LocalDrivingLicenseApplicationID.ToString();
                lblApplicantLicense.Text = LicenseClass.ClassName;
                lblPassedTest.Text = ClsTests.GetTestPassedCount(LocalLicese.LocalDrivingLicenseApplicationID).ToString() + "/3"; 
                
            }
        }
        public ctrlApplicationBasicProccessInfo()
        {
            InitializeComponent();
        }

       
    }
}
