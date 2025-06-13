using ClsLibraryBussniselayr;
using MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp;
using MyDVLDPorject.genralClasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frm_Appliciation.Frms_International_Driving_License
{
    public partial class FrmIssueInternationalDrivingLicenes : DevExpress.XtraEditors.XtraForm
    {

        private ClsLicenses _Currentlicense = new ClsLicenses();
        private ClsInternationalLicense _internationalLicense = new ClsInternationalLicense();

        private delegate void OninternationalLicenseCreated(int LicenseID);
        OninternationalLicenseCreated oninternationalLicensecreated; 

        private bool LocalLicenseWithInClassType_3()
        {
            return _Currentlicense != null && _Currentlicense.LicenseClass == 3; 
        }
        private bool HasActiveInternationlLicense()
        {
            return (ClsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(_Currentlicense.DriverID) > 0 ); 
        }

        private bool NewInternationalLicenseIssued()
        {
            if (LocalLicenseWithInClassType_3() && !HasActiveInternationlLicense())
            {
               _internationalLicense.DriverID = _Currentlicense.DriverInfo.DriverID.Value;
               _internationalLicense.ApplicationID = _Currentlicense.ApplicationID;
               _internationalLicense.IssuedUsingLocalLicenseID = _Currentlicense.LicenseID;
               _internationalLicense.IssueDate = DateTime.Now;
               _internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
               _internationalLicense.CreatedUserID = 1;
               return _internationalLicense.Save(); 
            }
                return false; 

        }

        public FrmIssueInternationalDrivingLicenes()
        {
            InitializeComponent();
            oninternationalLicensecreated += ctrlDrivingLiceseInfoWithFilter1.LoadLicenseInfo;
        }

        private void ctrlDrivingLiceseInfoWithFilter1_OnLicenseFound(object sender, ClsLibraryBussniselayr.ClsLicenses e)
        {
            _Currentlicense = e; 
            btnIssueLicense.Enabled = true;
            llShowLicenseHistory.Enabled = true; 
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to issued new international license", 
                "internation license", MessageBoxButtons.YesNo , MessageBoxIcon.Information) == DialogResult.No) { return;  }

            if (NewInternationalLicenseIssued())
            {
                MessageBox.Show($"Issued New International License Successfully By ID = {_internationalLicense.InternationalLicenseID}",
                  "internation license", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llShowLicenseInfo.Enabled = true;
                oninternationalLicensecreated.Invoke(_Currentlicense.LicenseID); 
                return; 
            }
            MessageBox.Show($"Issued New International License Filed Beacuse License Is Not From Class-3",
                 "internation license", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClsLocalDrivingLiceneseApplication localDrivingLicenese =
                ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicenseApplication(_Currentlicense.ApplicationID);
            if (localDrivingLicenese != null)
            {
                FrmLicenseHistory licenseHistory = new FrmLicenseHistory(localDrivingLicenese.LocalDrivingLicenseApplicationID);
                licenseHistory.ShowDialog(); 
            }
            else
                MessageBox.Show($"Show License History Was Filed No History to Show",
                " license", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; 
        }
    }
}
