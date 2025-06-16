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
using static MyDVLDPorject.genralClasess.ClsGeneral;

namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls
{
    public partial class CtrlShudleTestAppointment : UserControl
    {
        // Delegate Function 
        public delegate void  DelegateOnTestAppointemtCreated(int? LocalID , int TestType);
        public static DelegateOnTestAppointemtCreated OnTestAppointemtCreated;
        // eums 

      
        // Variables
        private int? _LocalDrivingLicenseID = null;
        private ClsGeneral.enTestType _entestType;
        //Classes 
        private clsApplication _application = new clsApplication();
        ClsTestAppointment _NewTestAppointment = new ClsTestAppointment();

        private bool _IsLockedTestAppointment()
        {
            ClsTestAppointment Appointment = ClsTestAppointment.FindTestAppointment(_LocalDrivingLicenseID.Value, (int)_entestType);
            if (Appointment != null && Appointment.IsLocked == true)
            {
                dateTimePicker1.Enabled = false;
                btnSave.Enabled = false;
                lblUserMessage.Visible = true; 
                return true;
            }
            return false;
        }
        private void _ShowRetakeTestInfo()
        {
            dateTimePicker1.Enabled = true; ;
            btnSave.Enabled = true; ;
            lblUserMessage.Visible = false;
            ClsApplicationTypes applicationTypes = ClsApplicationTypes.GetApplicationTypeByID((int)enApplicationType.RetakeTest); 
            if(applicationTypes != null)
            {
                gbRetakeTestInfo.Enabled = true;
                lblRetakeAppFees.Text = applicationTypes.ApplicationFees.ToString();
                lblTotalFees.Text = (applicationTypes.ApplicationFees + Convert.ToDecimal(lblFees.Text)).ToString(); 

            }
        }

        private void _AddNewAppointment(bool IsNewAppointemnt = false)

        {
            if(!IsNewAppointemnt)
            {
                _NewTestAppointment = ClsTestAppointment.FindTestAppointment(_LocalDrivingLicenseID.Value, (int)_entestType);
                if(_NewTestAppointment != null)
                {
                    _NewTestAppointment.AppointmentDate = dateTimePicker1.Value; 
                    if (_NewTestAppointment.Update())
                    {
                        OnTestAppointemtCreated.Invoke(_NewTestAppointment.LocalDrivingLicenseID, _NewTestAppointment.TestTypeID);
                        return;
                    }
                }
                else
                {
                    _NewTestAppointment = new ClsTestAppointment();
                }
            }
         

            if (IsNewAppointemnt)
            {
                _NewTestAppointment = new ClsTestAppointment(); 
            }

            _NewTestAppointment.LocalDrivingLicenseID = _LocalDrivingLicenseID.Value;
            _NewTestAppointment.TestTypeID = (int)_entestType;
            _NewTestAppointment.AppointmentDate = dateTimePicker1.Value;
            _NewTestAppointment.PaidFees = Convert.ToDecimal(lblFees.Text);
            _NewTestAppointment.IsLocked = false;
            _NewTestAppointment.CreatedUserID = _application.CreatedUserID;

            if (_NewTestAppointment.Save())
            {
                OnTestAppointemtCreated.Invoke(_NewTestAppointment.LocalDrivingLicenseID, _NewTestAppointment.TestTypeID);
                return;
            }
        }
        private void _AddNewRetakTest()
        {
            clsApplication Newapplication = new clsApplication();
            ClsApplicationTypes applicationTypes = ClsApplicationTypes.GetApplicationTypeByID((int)enApplicationType.RetakeTest);
            if (_application != null)
            {
                Newapplication.ApplicationpersonID = _application.ApplicationpersonID;
                Newapplication.ApplicationDate     = dateTimePicker1.Value;
                Newapplication.ApplicationTypeID   = applicationTypes.ID;
                Newapplication.ApplicationStatus   = (int)ClsGeneral.enApplicationStatus.New;
                Newapplication.ApplicationTypeID   = applicationTypes.ID;
                Newapplication.PaidFees = applicationTypes.ApplicationFees;
                Newapplication.LastAppicationDate  = dateTimePicker1.Value;
                Newapplication.CreatedUserID       = _application.CreatedUserID;
                if(Newapplication.AddNewApplication())
                {
                    _AddNewAppointment(true);
                     return; 
                }
            }
        }

        private void _AddTestAppointemt()
        {
            switch (ClsGeneral.ApplicationType)
            {
                case enApplicationType.NewLocalApplication:
                    _AddNewAppointment();
                    return;
                case enApplicationType.RetakeTest:
                    _AddNewRetakTest();
                    return; 
            }
        }


        private void _AppointmentTitleType(ClsGeneral.enTestType TestType)
        {
            switch (TestType)
            {
                case ClsGeneral.enTestType.VisitionTest:
                    lblTitle.Text = "New Visition Test _Appointment";
                    return;
                case ClsGeneral.enTestType.WriteTest:
                    lblTitle.Text = "New Written Test _Appointment";
                    return;
                case ClsGeneral.enTestType.StreetTest:
                    lblTitle.Text = "New Street Test _Appointment";
                    return;
            }
        }

        public async void LoadTesAppointmenttInfo(int LocalLicenesApplicationID , ClsGeneral.enTestType testType)
        {

            _LocalDrivingLicenseID = LocalLicenesApplicationID;
            _entestType = testType;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            ClsLocalDrivingLiceneseApplication liceneseApplication = new ClsLocalDrivingLiceneseApplication();
            liceneseApplication = ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicense(LocalLicenesApplicationID);
             _application = clsApplication.FindApplication(liceneseApplication.ApplicationID);
            lblLocalDrivingLicenseAppID.Text = liceneseApplication.LocalDrivingLicenseApplicationID.ToString();
            ClsLicenseClass LicenseClass = ClsLicenseClass.GetLicenseClass(liceneseApplication.LicenseClassID);
            lblDrivingClass.Text = LicenseClass.ClassName;
            clsApplicationType applicationType = clsApplicationType.GetApplicationTypeByID(_application.ApplicationTypeID);
            lblTitle.Text = applicationType.ApplicationTestTitle;
            lblFees.Text = applicationType.ApplicatiolnTestFees.ToString();
            clsPerson person = clsPerson.FindByID(_application.ApplicationpersonID);
            lblFullName.Text = person.FullName;
          
            lblTrial.Text = liceneseApplication.CountOfTestTotalTrial(LocalLicenesApplicationID,(int)testType).ToString();
            _AppointmentTitleType(testType);

            if (ClsGeneral.ApplicationType ==  ClsGeneral.enApplicationType.RetakeTest)
            {
                _ShowRetakeTestInfo(); 
                return; 
            }
              _IsLockedTestAppointment(); 


        }


        public CtrlShudleTestAppointment()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _AddTestAppointemt(); 

        }

        private void gbTestType_Enter(object sender, EventArgs e)
        {

        }
    }
}
