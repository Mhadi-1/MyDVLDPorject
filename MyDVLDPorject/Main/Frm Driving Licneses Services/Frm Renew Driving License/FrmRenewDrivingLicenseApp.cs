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

namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License
{
    public partial class FrmRenewDrivingLicenseApp : DevExpress.XtraEditors.XtraForm
    {
        private ClsLicenses _currentLicense = new ClsLicenses();

        private ClsLocalDrivingLiceneseApplication _localDrivingLiceneseApplication =
            new ClsLocalDrivingLiceneseApplication();

        private void _RewnewLicense()
        {
            ctrlRenewApplicationInfo1.RenewLocalDrivingLicense(); 
        }

        public FrmRenewDrivingLicenseApp()
        {
            InitializeComponent();
        }

        private void ctrlLicenseInfoWithFilter1_OnlicenseFound(object sender, ClsLibraryBussniselayr.ClsLicenses e)
        {
            ctrlRenewApplicationInfo1.LoadApplicationInfo(e.LicenseID);
            _currentLicense = e; 

              _localDrivingLiceneseApplication = 
                ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicenseApplication(e.ApplicationID);
            if (_localDrivingLiceneseApplication == null)
            {
                llShowLicenseInfo.Enabled = false;
                llShowLicenseHistory.Enabled = false;
                btnIssueLicense.Enabled = false;
                return;
            }
            else
            llShowLicenseHistory.Enabled = true;
            btnIssueLicense.Enabled = true; 
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLicenseHistory currentlicenseHistory = new FrmLicenseHistory(_localDrivingLiceneseApplication.LocalDrivingLicenseApplicationID);
            currentlicenseHistory.ShowDialog();
          
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if(_currentLicense.ExpirationDate.Value  >= DateTime.Now)
            {
                string LicenseExpirationDate = ClsGeneral.DataFormat(_currentLicense.ExpirationDate.Value); 
                MessageBox.Show($"Sorry Selected License Is Not Expirated yet " +
                    $" it will Expiraed On {LicenseExpirationDate}", "Expiraton Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; 
            }
            _RewnewLicense(); 
        }

        private void ctrlRenewApplicationInfo1_OnLicenseRenew(object sender, ClsLicenses e)
        {
            if ( MessageBox.Show($"Selected License Has Renew it Succsufully with ID {e.LicenseID} and" +
                   $" it will Expiraed On {e.ExpirationDate}", "Expiraton Date",
                   MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
               ctrlLicenseInfoWithFilter1.LoadLicenseInfo(e.LicenseID);
                _localDrivingLiceneseApplication =
                ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicenseApplication(e.ApplicationID);
                llShowLicenseInfo.Enabled = true; 
            } 


        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLocalLicenseInfo licenseInfo = new FrmShowLocalLicenseInfo(_localDrivingLiceneseApplication.LicenseInfo.LicenseID);
            licenseInfo.ShowDialog(); 
        }
    }
}
