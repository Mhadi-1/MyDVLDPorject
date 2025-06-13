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

namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License.UserCtrls
{
    public partial class CtrlLicenseInfoWithFilter : UserControl
    {
        private int _LicenseID = -1;
        public event EventHandler<ClsLicenses> OnlicenseFound; 

        private void _OnLicenseFound(ClsLicenses licenses)
        {
            if(OnlicenseFound != null)
            {
                OnlicenseFound(this, licenses); 
            }
        }
        
        public CtrlLicenseInfoWithFilter()
        {
            InitializeComponent();
            ctrlLocalDrivingLicenesInfo1.OnLicenseFound += _OnLicenseFound; 
        }

        public void setIsDetaintTxtlbl(string txt)
        {
            ctrlLocalDrivingLicenesInfo1.setIsDetaintTxtlbl(txt); 
        }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtLicenseID.Text = LicenseID.ToString();
            ctrlLocalDrivingLicenesInfo1.LoadLicenseInfo(LicenseID);

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

            if (int.TryParse(txtLicenseID.Text, out int val))
            {
                _LicenseID = val;
                LoadLicenseInfo(_LicenseID);
            }
            else
                return; 
        }

      
    }
}
