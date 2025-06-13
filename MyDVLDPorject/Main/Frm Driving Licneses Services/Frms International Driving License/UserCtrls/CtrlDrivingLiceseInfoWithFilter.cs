using ClsLibraryBussniselayr;
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

namespace MyDVLDPorject.Frm_Appliciation.Frms_International_Driving_License.UserCtrls
{
    public partial class CtrlDrivingLiceseInfoWithFilter : UserControl
    {

        private int _LicenseID = -1;

        public event EventHandler<ClsLicenses> OnLicenseFound; 

        private void LicenseFound(ClsLicenses license)
        {
            
            if(OnLicenseFound != null)
            OnLicenseFound.Invoke(this, license); 
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtLicenseID.Text = LicenseID.ToString();
            ctrlLocalDrivingLicenesInfo1.LoadLicenseInfo(LicenseID);
            ClsLicenses licenses = ClsLicenses.FindLicense(LicenseID);
            if (licenses == null)
            {
                return;
            }
           int AppID = 0;
           int InterID = 0;
           ctrlInternationApplicationInfo1.ApplicationDate = DateTime.Now;
           ctrlInternationApplicationInfo1.IssueDate = DateTime.Now;
           ctrlInternationApplicationInfo1.Fees = ClsApplicationTypes.GetApplicationTypeByID((int)ClsGeneral.enApplicationType.NewInternationLicense).ApplicationFees;
           ctrlInternationApplicationInfo1.LocalLicenseID = LicenseID;
           ctrlInternationApplicationInfo1.ExpirationDate = DateTime.Now.AddYears(1);
           ctrlInternationApplicationInfo1.CreatedByUser = ClsGeneral.CurrentUser.Name;
           AppID = licenses.ApplicationID;
           InterID = ClsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(licenses.DriverID); 
           ctrlInternationApplicationInfo1.ApplicationID = AppID == 0 ? -1 : AppID;
           ctrlInternationApplicationInfo1.InternationalLicenseID = InterID == 0 ? -1 : InterID;
           ctrlInternationApplicationInfo1.LoadAppicationIfo(); 
        }

        public CtrlDrivingLiceseInfoWithFilter()
        {
            InitializeComponent();
            ctrlLocalDrivingLicenesInfo1.OnLicenseFound += LicenseFound; 
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseID.Focus();
                return;

            }
            
            _LicenseID = int.Parse(txtLicenseID.Text);
            LoadLicenseInfo(_LicenseID); 
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void gbFilters_Enter(object sender, EventArgs e)
        {

        }
    }
}
