using ClsLibraryBussniselayr;
using MyDVLDPorject.Frms;
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

namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls
{
    public partial class ctrlDrivingLicenseApplicationInfo : UserControl
    {
     

       private  clsApplication _application = new clsApplication(); 
      
       private string _ConvertApplicationStatus(int applicationstatusid)
        {
            switch ((ClsGeneral.enApplicationStatus)applicationstatusid)
            {
                case ClsGeneral.enApplicationStatus.New:
                    return "New";
                case ClsGeneral.enApplicationStatus.cancelled:
                    return "cancelled";
                case ClsGeneral.enApplicationStatus.completed:
                    return "completed"; 
            }
            return string.Empty; 
        }

        public async void LoadApplicationInfo(int LocalDrivingApplicationID)
        {
            ClsLocalDrivingLiceneseApplication LocalDriving =  ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicense(LocalDrivingApplicationID);
            _application = clsApplication.FindApplication(LocalDriving.ApplicationID);
            if(LocalDriving != null)
            {
                clsPerson person = clsPerson.FindByID(_application.ApplicationpersonID);

                lblApplicationID.Text = _application.ApplicationID.ToString();
                lblStatus.Text = _ConvertApplicationStatus(_application.ApplicationStatus);
                lblFees.Text = _application.PaidFees.ToString();
                ClsApplicationTypes applicationtype = ClsApplicationTypes.GetApplicationTypeByID(_application.ApplicationTypeID);
                lblType.Text = applicationtype.ApplicationTitle;
                lblDate.Text = _application.ApplicationDate.ToShortDateString();
                lblStatusDate.Text = _application.LastAppicationDate.ToShortDateString();
                lblCreatedByUser.Text = clsUser.GetUserName(_application.CreatedUserID);
                
                lblApplicant.Text = person.FullName;

            }
        }

        public ctrlDrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_application.ApplicationpersonID == -1)
                return;
            FrmShowPersonDetails showPersonDetails = new FrmShowPersonDetails(_application.ApplicationpersonID);
            showPersonDetails.ShowDialog();
        }
    }
}
