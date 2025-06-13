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

namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Replacement_Or_Lost_Driving_Licesne.UserCtrls
{
    public partial class CtrlApplicationInfoForLicesenReplacement : UserControl
    {

        public CtrlApplicationInfoForLicesenReplacement()
        {
            InitializeComponent();
        }

        public void LoadInfo(ClsLicenses licenses )
        {
            clsDetainedLicense detainedLicense = 
           clsDetainedLicense.FindByLicenseID(licenses.LicenseID);
            
            if(detainedLicense != null)
            {
                ClsApplicationTypes applicationTypes = ClsApplicationTypes.GetApplicationTypeByID((int)ClsGeneral.enApplicationType.ReleaseDetained);
                lblDetainD.Text = detainedLicense.DetainID.ToString();
                lblDetainDate.Text =ClsGeneral.DataFormat(detainedLicense.DetainDate.Value);
                lblApplicationFees.Text = applicationTypes.ApplicationFees.ToString();  ;
                lblFineFees.Text = detainedLicense.FineFees.ToString() ;
                lblLicenseID.Text = detainedLicense.LicenseID.ToString();
                lblCreatedByUser.Text = clsUser.FindByUserID(detainedLicense.CreatedByUserID).Name;
                lblTotalFineFees.Text = (detainedLicense.FineFees + (float)applicationTypes.ApplicationFees).ToString(); 
            }
        }

        public void ShowApplicationID(int applicationID)
        {
            { lblApplicationID.Text = applicationID.ToString(); }
            return; 
        }
       
    }
}
