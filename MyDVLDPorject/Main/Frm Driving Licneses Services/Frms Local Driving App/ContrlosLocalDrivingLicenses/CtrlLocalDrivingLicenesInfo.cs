using ClsLibraryBussniselayr;
using DevExpress.Utils.About;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp.ContrlosLocalDrivingLicenses
{
    public partial class CtrlLocalDrivingLicenesInfo : UserControl
    {
        private int? _LicenseID = null;
        private ClsLicenses _licenses = new ClsLicenses();

        public delegate void LicenseFound(ClsLicenses license);
        public LicenseFound OnLicenseFound;


        private void OnFoundLicense()
        {
            if(OnLicenseFound != null)
            {
               OnLicenseFound.Invoke(_licenses); 
            }
        }

        public static string DateToShort(DateTime Dt1)
        {

            return Dt1.ToString("dd/MMM/yyyy");
        }

        private string FindIssuReasone(ClsLicenses.enIssueReason issueReason)
        {
            switch (issueReason)
            {
                case ClsLicenses.enIssueReason.FirstTime:
                return "FristTime";
                case ClsLicenses.enIssueReason.Renew:
                return "Renew";
                case ClsLicenses.enIssueReason.LostReplacement:
                return "LostReplace";
                case ClsLicenses.enIssueReason.DamagedReplacement:
                return "DamagedReplace";
            }
            return "None"; 
        }

        public void LoadLicenseInfo (int LicenseID)
        {
            
            _licenses = ClsLicenses.FindLicense(LicenseID);

            if (_licenses == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID.ToString(),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return; 
            }

    
            lblLicenseID.Text = _licenses.LicenseID.ToString();
            lblIsActive.Text = _licenses.IsActive ? "Yes" : "No";
            lblIsDetained.Text = _licenses.IsDetained ? "Yes" : "No";
            lblClass.Text = _licenses.LicenseClassIfo.ClassName;
            lblFullName.Text = _licenses.DriverInfo.PersonInfo.FullName;
            lblNationalNo.Text = _licenses.DriverInfo.PersonInfo.NationalNo;
            lblGendor.Text = _licenses.DriverInfo.PersonInfo.Gendor == 0 ? "Male" : "Female";
            lblDateOfBirth.Text = DateToShort(_licenses.DriverInfo.PersonInfo.DateOfBirth);
            lblIssueReason.Text = FindIssuReasone(_licenses.IssueReason);
            lblIsDetained.Text = _licenses.IsDetained == true ? "Yes" : "No"; 
            lblDriverID.Text = _licenses.DriverID.ToString();
            lblIssueDate.Text = DateToShort(_licenses.IssueDate.Value);
            lblExpirationDate.Text = DateToShort(_licenses.ExpirationDate.Value);
            lblNotes.Text = _licenses.Notes == "" ? "No Notes" : _licenses.Notes;
            string ImagePath = _licenses.DriverInfo.PersonInfo.ImagePath;
            OnFoundLicense();
            if (ImagePath != "")
             pbPersonImage.Load(ImagePath);
         
        }
        public void setIsDetaintTxtlbl(string detaintText = "No")
        {
            lblIsDetained.Text = detaintText; 
        }

        public CtrlLocalDrivingLicenesInfo()
        {
            InitializeComponent();
        }

       
    }
}
