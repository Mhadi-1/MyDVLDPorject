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

namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Detainted_Licenses
{
    public partial class FrmDetainedLicense : DevExpress.XtraEditors.XtraForm
    {

        private ClsLicenses _Licenses = new ClsLicenses(); 
        private int _FineFees = -1; 

        private bool CheckValiedInput()
        {
            if (int.TryParse(txtbxFineFees.Text, out int val))
            {
                _FineFees = val; 
                return true; 
            }
            return false; 
        }

        private void DetainLicense(ClsLicenses licenses , int FineFees)
        {
            clsDetainedLicense DetainedLicense = new clsDetainedLicense();

            DetainedLicense.LicenseID = licenses.LicenseID;
            DetainedLicense.DetainDate = DateTime.Now;
            DetainedLicense.FineFees = Convert.ToSingle(FineFees);
            DetainedLicense.CreatedByUserID = ClsGeneral.CurrentUser.ID;
            DetainedLicense.IsReleased = false; 
            

            if (MessageBox.Show("Are you sure you want to detain this license" ,
               "license detain" , MessageBoxButtons.OKCancel ,MessageBoxIcon.Information) 
                == DialogResult.OK)
            {
                if(DetainedLicense.Save() )
                {
                    licenses.IsDetained = true;
                    licenses.IsActive = false; 
                    if (licenses.Update() ) {

                        lblDetainD.Text = DetainedLicense.DetainID.ToString(); 
                        MessageBox.Show("License Detained Successfully with ID = " + DetainedLicense.DetainID.ToString(), 
                        "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llShowLicenseInfo.Enabled = true;
                        llShowLicenseHistory.Enabled = true; 
                        return; 
                    }
                    return; 
                }
            }



        }

        public FrmDetainedLicense()
        {
            InitializeComponent();
        }

        private void ctrlLicenseInfoWithFilter1_OnlicenseFound(object sender, ClsLibraryBussniselayr.ClsLicenses e)
        {
            if(e.IsActive == false)
            {
                MessageBox.Show($"License By ID {e.LicenseID} Is DisAcitived " +
                    $" Please Check License Status", "Detained License" , MessageBoxButtons.OK , MessageBoxIcon.Stop);
                btnIssueLicense.Enabled = false;
                return; 
            }

            if (clsDetainedLicense.IsLicenseDetained(e.LicenseID) == true)
            {
                MessageBox.Show($"License By ID {e.LicenseID} Is Already Detained " +
                    $" Please Check Another License ", "Detained License", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnIssueLicense.Enabled = false;
                return;
            }

            if (e != null)
            {
               _Licenses = e;
               btnIssueLicense.Enabled = true; 
               lblDetainDate.Text = ClsGeneral.DataFormat(DateTime.Now);
               lblLicenseID.Text = e.LicenseID.ToString();
               lblCreatedByUser.Text = ClsGeneral.CurrentUser.Name;
                return; 
            }
           
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            if(CheckValiedInput())
            {
               
                DetainLicense(_Licenses , _FineFees);
                errorProvider1.SetError(txtbxFineFees, "");
            }
            else
            errorProvider1.SetError(txtbxFineFees, "Entair must be a number");
            txtbxFineFees.Focus();
            return; 
        }

        private void txtbxFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (CheckValiedInput())
            {
                errorProvider1.SetError(txtbxFineFees, "");
                e.Cancel = false;
                return;
            }
            else
             txtbxFineFees.Focus();
            e.Cancel = true;
            errorProvider1.SetError(txtbxFineFees, "Entair must be a number");
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 
            FrmShowLocalLicenseInfo localLicenseInfo = new FrmShowLocalLicenseInfo(_Licenses.LicenseID);
            localLicenseInfo.ShowDialog(); 
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClsLocalDrivingLiceneseApplication localDrivingLiceneseApplication =
                ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicenseApplication(_Licenses.ApplicationID); 
            if(localDrivingLiceneseApplication!= null)
            {
              FrmLicenseHistory licenseHistory = new FrmLicenseHistory(localDrivingLiceneseApplication.LocalDrivingLicenseApplicationID);
              licenseHistory.ShowDialog(); 
            }

        }
    }
}
