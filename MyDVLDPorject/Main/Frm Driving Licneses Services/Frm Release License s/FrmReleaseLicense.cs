
using ClsLibraryBussniselayr;
using MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp;
using MyDVLDPorject.genralClasess;
using System;
using System.Windows.Forms;

namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Release_License_s
{
    public partial class FrmReleaseLicense : DevExpress.XtraEditors.XtraForm
    {
        private ClsLicenses _CurrentLicense = new ClsLicenses(); 
        public FrmReleaseLicense()
        {
            InitializeComponent();
        }

        private void _ReleaseLicense()
        {
            ClsApplicationTypes applicationtype =
               ClsApplicationTypes.GetApplicationTypeByID((int)ClsGeneral.enApplicationType.ReleaseDetained);
            clsApplication application = new clsApplication();
            if (applicationtype != null)
            {
                application.ApplicationpersonID = _CurrentLicense.DriverInfo.PersonID.Value;
                application.ApplicationDate = DateTime.Now;
                application.ApplicationTypeID = applicationtype.ID;
                application.ApplicationStatus = clsApplication.FindApplication(_CurrentLicense.ApplicationID).ApplicationStatus;
                application.LastAppicationDate = DateTime.Now;
                application.PaidFees = applicationtype.ApplicationFees;
                application.CreatedUserID = ClsGeneral.CurrentUser.ID;
                if (application.AddNewApplication())
                {
                    _CurrentLicense.IsActive = true;
                    if (_CurrentLicense.Update())
                    {

                        if (_CurrentLicense.detainLicenseInfo.ReleaseDetainedLicense(ClsGeneral.CurrentUser.ID, application.ApplicationID))
                        {
                            MessageBox.Show($"license is release it succssefully by application id {application.ApplicationID}",
                              "released license succssefully",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ctrlLicesenDetainedInfo.ShowApplicationID(application.ApplicationID);
                            btnIssueLicense.Enabled = false;
                            return;

                        }

                    }
                }

            }
        }

        private void ctrlLicenseInfoWithFilter1_OnlicenseFound(object sender, ClsLibraryBussniselayr.ClsLicenses licenses)
        {
            if(licenses.IsDetained == false)
            {
                MessageBox.Show("This license is not detained you can't release it" +
                    " Please choose another license ", "release license filed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; 
            }
              _CurrentLicense = licenses; 
              ctrlLicesenDetainedInfo.LoadInfo(licenses);
              btnIssueLicense.Enabled = true;
              llShowLicenseHistory.Enabled = true;
              llShowLicenseInfo.Enabled = true; 
        }

        private void btnIssueLicense_Click(object sender, System.EventArgs e)
        {
            _ReleaseLicense(); 
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLocalLicenseInfo localLicenseInfo = new FrmShowLocalLicenseInfo(_CurrentLicense.LicenseID);
            localLicenseInfo.ShowDialog(); 

        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClsLocalDrivingLiceneseApplication localDrivingLiceneseApplication =
                ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicenseApplication(_CurrentLicense.ApplicationID); 
            if(localDrivingLiceneseApplication != null)
            {
               FrmLicenseHistory personlicenseHistory = new FrmLicenseHistory(localDrivingLiceneseApplication.LocalDrivingLicenseApplicationID);
               personlicenseHistory.ShowDialog();
                return;

            }
        }
    }
}
