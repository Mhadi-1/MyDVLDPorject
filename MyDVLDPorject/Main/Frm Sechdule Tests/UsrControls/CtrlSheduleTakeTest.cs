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
    public partial class CtrlSheduleTakeTest : UserControl
    {
        public delegate void DelegateOnTestAppointemtCreated(int? LocalID, int TestType);
        public static DelegateOnTestAppointemtCreated OnTakeTest
            ;
        private ClsTestAppointment TestAppointment = new ClsTestAppointment(); 

        private bool _IsPassTest()
        {
            if (RidoPassTest.Checked)
            {
                return true; 
            }
            if (RadioFiledTest.Checked)
            {
                return false;

            }
            return false; 
        }

        private bool _AddNewTest()
        {
            ClsTests newtest = new ClsTests();
            newtest.TestAppointmentID = TestAppointment.TestAppointmentID;
            newtest.TestResult = _IsPassTest();
            newtest.Notes = richTextBox1.Text;
            newtest.CreatedUserID = TestAppointment.CreatedUserID;
            return newtest.Save(); 
        }

        private bool _UpdateAndSaveTestAppointment()
        {
            if (RidoPassTest.Checked || RadioFiledTest.Checked)
            {
                TestAppointment.IsLocked = true;
            }
             TestAppointment.Update();
            return true;
            
        }

        private void _AppointmentTitleType(ClsGeneral.enTestType TestType)
        {
            switch (TestType)
            {
                case ClsGeneral.enTestType.VisitionTest:
                    lblTitle.Text = "Visition Test";
                    return;
                case ClsGeneral.enTestType.WriteTest:
                    lblTitle.Text = "Written Test";
                    return;
                case ClsGeneral.enTestType.StreetTest:
                    lblTitle.Text = "Street Test";
                    return;
            }
        }

        public async void LoadTestInfo(int LocalLicenesApplicationID, ClsGeneral.enTestType testType)
        {


             TestAppointment = ClsTestAppointment.FindTestAppointment(LocalLicenesApplicationID , (int)testType); 
            if(TestAppointment != null)
            {
                ClsLocalDrivingLiceneseApplication liceneseApplication = ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicense(LocalLicenesApplicationID);
                clsApplication _application = clsApplication.FindApplication(liceneseApplication.ApplicationID);
                clsPerson person = clsPerson.FindByID(_application.ApplicationpersonID);
                ClsLicenseClass licenseClass = ClsLicenseClass.GetLicenseClass(liceneseApplication.LicenseClassID);
                
                lblLocalDrivingLicenseAppID.Text = LocalLicenesApplicationID.ToString();
                lblDrivingClass.Text             = licenseClass.ClassName;
                lblTrial.Text = liceneseApplication.CountOfTestTotalTrial(liceneseApplication.LocalDrivingLicenseApplicationID, (int)testType).ToString();
                lblDate.Text  = TestAppointment.AppointmentDate.ToShortDateString();
                lblFees.Text  = TestAppointment.PaidFees.ToString(); 
                
                lblFullName.Text  = person.FullName;


            }

            _AppointmentTitleType(testType);
        }

        public CtrlSheduleTakeTest()
        {
            InitializeComponent();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save ? After that you can not change the Pass/Fil result after you Save.?", "Confirm",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_UpdateAndSaveTestAppointment() && _AddNewTest())
                {

                    MessageBox.Show("Data Saved Successfully", "Data Saved", MessageBoxButtons.OK);
                    OnTakeTest.Invoke(TestAppointment.LocalDrivingLicenseID, TestAppointment.TestTypeID);
                    return;
                }
            }
        }
    }
}
