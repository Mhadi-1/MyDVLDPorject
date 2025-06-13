using ClsLibraryBussniselayr;
using DevExpress.Utils.About;
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

namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License.UserCtrls
{
    public partial class CtrlRenewApplicationInfo : UserControl
    {
        private ClsLicenses _CurrentLice = new ClsLicenses();
        public event EventHandler<ClsLicenses> OnLicenseRenew; 

        public CtrlRenewApplicationInfo()
        {
            InitializeComponent();
        }
        private void OnLicenseRenewd(ClsLicenses ReNewlicense)
        {
            if (OnLicenseRenew != null)
            {
                OnLicenseRenew?.Invoke(this, ReNewlicense);
            }
        }

        public void RenewLocalDrivingLicense()
        {
            ClsLicenses ReNewlicense = new ClsLicenses();
            ClsLocalDrivingLiceneseApplication clsLocalDriving = new ClsLocalDrivingLiceneseApplication(); 
            clsApplication CurrentApplication = clsApplication.FindApplication(_CurrentLice.ApplicationID);
            clsLocalDriving.applicationInfo = new clsApplication(); 

            ClsApplicationTypes applicationtype = ClsApplicationTypes.GetApplicationTypeByID((int)ClsGeneral.enApplicationType.RenewDrivingLicense);

            clsLocalDriving.applicationInfo.ApplicationDate = DateTime.Now;
            clsLocalDriving.applicationInfo.ApplicationStatus = CurrentApplication.ApplicationStatus;
            clsLocalDriving.applicationInfo.ApplicationpersonID = CurrentApplication.ApplicationpersonID;
            clsLocalDriving.applicationInfo.ApplicationTypeID = CurrentApplication.ApplicationTypeID;
            clsLocalDriving.applicationInfo.CreatedUserID = ClsGeneral.CurrentUser.ID;
            clsLocalDriving.applicationInfo.LastAppicationDate = DateTime.Now;
            clsLocalDriving.applicationInfo.PaidFees = (applicationtype.ApplicationFees);
            clsLocalDriving.LicenseClassID = applicationtype.ID ;

            if (clsLocalDriving.Save())
            {

                lblApplicationID.Text = clsLocalDriving.applicationInfo.ApplicationID.ToString();
                 _CurrentLice.IsActive = false; 
                if(_CurrentLice.Update() )
                {
                   ReNewlicense.Notes = txtNotes.Text;
                   ReNewlicense.LicenseClass = _CurrentLice.LicenseClass;
                   ReNewlicense.ApplicationID = clsLocalDriving.applicationInfo.ApplicationID;
                   ReNewlicense.ExpirationDate = DateTime.Now.AddYears(_CurrentLice.LicenseClassIfo.DefultValiedityLength); 
                   ReNewlicense.PaidFees = (clsLocalDriving.applicationInfo.PaidFees + _CurrentLice.LicenseClassIfo.ClassFees);
                   ReNewlicense.IssueReason = ClsLicenses.enIssueReason.Renew;
                   ReNewlicense.IssueDate = DateTime.Now;
                   ReNewlicense.IsActive = true;
                   ReNewlicense.CreatedByUserID = ClsGeneral.CurrentUser.ID;
                   ReNewlicense.IsDetained = false;
                   ReNewlicense.DriverID = _CurrentLice.DriverID; 

                   if(ReNewlicense.AddNewLicense())
                   {
                        lblRenewedLicenseID.Text = ReNewlicense.LicenseID.ToString(); 
                        OnLicenseRenewd(ReNewlicense); 
                        return; 
                   }

                }
                return; 
            }
       
        }

        public void LoadApplicationInfo(int LicenseID)
        {
            ClsLicenses license = ClsLicenses.FindLicense(LicenseID);
            ClsApplicationTypes applicationtype = ClsApplicationTypes.GetApplicationTypeByID((int)ClsGeneral.enApplicationType.RenewDrivingLicense); 
            if(license != null)
            {
                _CurrentLice = license; 
                
               lblApplicationDate.Text = ClsGeneral.DataFormat(DateTime.Now);

               lblApplicationFees.Text = applicationtype.ApplicationFees.ToString(); 
               lblLicenseFees.Text = license.LicenseClassIfo.ClassFees.ToString(); 
               
               lblIssueDate.Text = ClsGeneral.DataFormat(DateTime.Now);
               lblExpirationDate.Text = ClsGeneral.DataFormat(DateTime.Now.AddYears(license.LicenseClassIfo.DefultValiedityLength)); 

               lblOldLicenseID.Text = license.LicenseID.ToString();
                lblCreatedByUser.Text = ClsGeneral.CurrentUser.Name;
               lblTotalFees.Text = (applicationtype.ApplicationFees + license.LicenseClassIfo.ClassFees).ToString(); 
            } 
        }

    }
}
