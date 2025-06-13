using ClsLibraryBussniselayr;
using DevExpress.XtraLayout.Filtering.Templates;
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

namespace MyDVLDPorject.Frm_Appliciation
{
    public partial class FrmIssueNewLocalDrivingLicnese : DevExpress.XtraEditors.XtraForm
    {
        int? _LocalDrivinglLicenseID = null;
      
        private void _IssueNewLocalDrivingLicense()
        {
            ClsLicenses licenses = new ClsLicenses();
            ClsLocalDrivingLiceneseApplication drivingLiceneseApplication =
                ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicense(_LocalDrivinglLicenseID.Value);
            clsApplication application = clsApplication.FindApplication(drivingLiceneseApplication.ApplicationID);
            ClsLicenseClass licenseClass = ClsLicenseClass.GetLicenseClass(drivingLiceneseApplication.LicenseClassID);
            ClsDrivers driver = new ClsDrivers();
            licenses.ApplicationID = drivingLiceneseApplication.ApplicationID;
            licenses.Notes = txtboxNotes.Text;
            licenses.CreatedByUserID = application.CreatedUserID;
            licenses.LicenseClass = licenseClass.LicenseClassID;
            licenses.PaidFees = licenseClass.ClassFees;
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            licenses.IssueDate = dateTime; 
            licenses.ExpirationDate = dateTime.AddYears(licenseClass.DefultValiedityLength);
            licenses.IsActive = true;
            licenses.IssueReason = ClsLicenses.enIssueReason.FirstTime; 
            driver.PersonID = application.ApplicationpersonID;
            driver.CreatedDate = licenses.IssueDate;
            driver.CreatedUserID = application.CreatedUserID; 
            if(driver.Save())
            {
                licenses.DriverID = driver.DriverID.Value; 
                if(licenses.AddNewLicense())
                {
                  
                    if ( MessageBox.Show($"License Issued Successfully With License ID = {licenses.LicenseID}" , "Successed" , 
                    MessageBoxButtons.OK , MessageBoxIcon.Information) == DialogResult.OK )
                    {
                        clsApplication.UpdateApplicationStatus(application.ApplicationID,
                            (int)ClsGeneral.enApplicationStatus.completed); 

                        this.Close(); 
                        return; 
                    }
                }
            }
            MessageBox.Show($"License Issued Filed With ID = {licenses.LicenseID} !! ", "try agin",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public FrmIssueNewLocalDrivingLicnese(int ? LocalDrivingLecesneApplicationID)
        {
            InitializeComponent();
            _LocalDrivinglLicenseID = LocalDrivingLecesneApplicationID; 
           
        }

        private void FrmIssueNewLocalDrivingLicnese_Load(object sender, EventArgs e)
        {
            ctrlGenralApplicationInfo1.LoadApplicationInfo(_LocalDrivinglLicenseID); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _IssueNewLocalDrivingLicense(); 
        }

        private void ctrlGenralApplicationInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
