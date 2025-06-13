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

namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Replacement_Or_Lost_Driving_Licesne
{
    public partial class FrmReplacementorDamageLicense : DevExpress.XtraEditors.XtraForm
    {
        private ClsApplicationTypes _applicationtype = new ClsApplicationTypes(); 
        private ClsLicenses _License = new ClsLicenses(); 

        private void IssueReplacementLicenseApplicatopn()
        {
            ClsLocalDrivingLiceneseApplication liceneseApplication = new ClsLocalDrivingLiceneseApplication();
            liceneseApplication.applicationInfo = new clsApplication(); 


           
            clsApplication CuurentApplication = clsApplication.FindApplication(_License.ApplicationID);

            if (CuurentApplication != null)
            liceneseApplication.LicenseClassID                      = _License.LicenseClassIfo.LicenseClassID;
            liceneseApplication.applicationInfo.ApplicationpersonID = CuurentApplication.ApplicationpersonID;
            liceneseApplication.applicationInfo.ApplicationDate     = DateTime.Now;
            liceneseApplication.applicationInfo.ApplicationTypeID   = _applicationtype.ID;
            liceneseApplication.applicationInfo.ApplicationStatus   = CuurentApplication.ApplicationStatus;
            liceneseApplication.applicationInfo.PaidFees            = _applicationtype.ApplicationFees;
            liceneseApplication.applicationInfo.LastAppicationDate  = DateTime.Now; 
            liceneseApplication.applicationInfo.CreatedUserID       = ClsGeneral.CurrentUser.ID;

            if(liceneseApplication.Save())
            {
                ClsLicenses NEWlicenses = new ClsLicenses();

                lblApplicationID.Text = liceneseApplication.applicationInfo.ApplicationID.ToString();

                NEWlicenses.ApplicationID = liceneseApplication.applicationInfo.ApplicationID;
                NEWlicenses.DriverID = _License.DriverID;
                NEWlicenses.LicenseClass = _License.LicenseClass;
                NEWlicenses.IssueDate = DateTime.Now;
                NEWlicenses.ExpirationDate = _License.ExpirationDate;
                NEWlicenses.Notes = _License.Notes;
                NEWlicenses.PaidFees = _License.PaidFees;
                NEWlicenses.IsActive = true;
                NEWlicenses.IssueReason = (ClsLicenses.enIssueReason)_applicationtype.ID;
                NEWlicenses.CreatedByUserID = ClsGeneral.CurrentUser.ID; 

                if(NEWlicenses.AddNewLicense())
                {
                    lblReplacementLicenseID.Text = NEWlicenses.LicenseID.ToString(); 
                    _License.IsActive = false;
                    if (_License.Update())
                    {
                        MessageBox.Show($"Done Replacement License By New ID  {NEWlicenses.LicenseID} " +
                         $" Now it's Active !", "Replacement Successfully",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ctrlLicenseInfoWithFilter1.LoadLicenseInfo(NEWlicenses.LicenseID); 
                        return; 
                    }
                }
            }
            

        }
        private void ShowReplacementApplcationInfo()
        {
            lblApplicationDate.Text = ClsGeneral.DataFormat(DateTime.Now);
            lblOldLicenseID.Text = _License.LicenseID < 0 ? "[???]" : _License.LicenseID.ToString(); 
            lblCreatedByUser.Text = ClsGeneral.CurrentUser.Name; 
            lblApplicationFees.Text = _applicationtype.ApplicationFees  < 0 ? "[$$$]" : _applicationtype.ApplicationFees.ToString(); 
        }

        public FrmReplacementorDamageLicense()
        {
            InitializeComponent();
        }


        private void rdolicense_CheckedChanged(object sender, EventArgs e)
        {
           
            if (((RadioButton)sender).Tag.ToString() == "Damage")
            {
                label1.Text = " Replacement For Damage License";
                _applicationtype = ClsApplicationTypes.GetApplicationTypeByID((int)
              ClsGeneral.enApplicationType.ReplacementForDamaged);
            }
            else
            {
                label1.Text = " Replacement For Lost License";
               _applicationtype = ClsApplicationTypes.GetApplicationTypeByID((int)ClsGeneral.enApplicationType.ReplacementForLost);
            }
            ShowReplacementApplcationInfo(); 
        }

        private void ctrlLicenseInfoWithFilter1_OnlicenseFound(object sender, ClsLicenses e)
        {
           
            if(e.IsActive)
            {
              _License = e;
               btnIssueLicense.Enabled = true; 
               ShowReplacementApplcationInfo();
               llShowLicenseHistory.Enabled = true;
               llShowLicenseInfo.Enabled = true;
                rdoDamagelicense.Enabled = true;
                rdoLostLicense.Enabled = true; 
               return; 
            }
            MessageBox.Show($"Sorry License By ID  {e.LicenseID} " +
             $" Not Active you can't replacement it !!", "Rplacement Filed",
             MessageBoxButtons.OK, MessageBoxIcon.Stop);

            _applicationtype = new ClsApplicationTypes();
            _License = new ClsLicenses(); 

            btnIssueLicense.Enabled = false;
            ShowReplacementApplcationInfo();
            llShowLicenseHistory.Enabled = false;
            llShowLicenseInfo.Enabled = false;
            rdoDamagelicense.Enabled = false;
            rdoLostLicense.Enabled = false;
            return; 
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            IssueReplacementLicenseApplicatopn(); 
        }
    }
}
