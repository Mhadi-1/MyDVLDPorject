using ClsLibraryBussniselayr;
using MyDVLDPorject.genralClasess;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyDVLDPorject.genralClasess.ClsGeneral;

namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls
{
    public partial class ctrlGenralAppointmentsList : UserControl
    {
        private int? _LocalDrivingLicenseID;
        private ClsGeneral.enTestType _entestType;
        private DataTable _Datatable = new DataTable();
        private ClsTestAppointment _TestAppointment = new ClsTestAppointment();

        private bool _AppointmentIsActive()
        {
          
            if (_TestAppointment != null && _TestAppointment.IsLocked == false)
            {
                return true; 
            }
            return false; 
        }

        private bool IsTestStatusPass()
        {
           
            ClsTests tests = new ClsTests();
            if(_TestAppointment != null)
            {
               tests = ClsTests.FindByTestAppointmentID(_TestAppointment.TestAppointmentID , _TestAppointment.TestTypeID , true);
               if (tests != null)
               {
                   if(tests.TestResult == true)
                   {
                     MessageBox.Show("Person has already [Pass] this Test you can't Take Apponitment/Test again", "Confirm",
                     MessageBoxButtons.OK, MessageBoxIcon.Stop);
                     return true; 
              
                   }
               }

            }
            return false; 
        }

        private void _ShowAddNewTestApointmentForm()
        {
            FrmTestAppointment TestAppointment = new FrmTestAppointment(_LocalDrivingLicenseID , _entestType);
            CtrlShudleTestAppointment.OnTestAppointemtCreated += LoaderAppointmentsListOf;
            ClsGeneral.ApplicationType = ClsGeneral.enApplicationType.NewLocalApplication;
            TestAppointment.ShowDialog();
        }

        public ctrlGenralAppointmentsList()
        {
            InitializeComponent();
        }

        public void LoaderAppointmentsListOf(int? LocalDrivingLicenseID, int testType)
        {
            _LocalDrivingLicenseID = LocalDrivingLicenseID;
            _entestType = (ClsGeneral.enTestType)testType;


            _Datatable = ClsTestAppointment.GetAllTestAppointments(_LocalDrivingLicenseID.Value, (int)_entestType);

            dgrvAppointmentsList.DataSource = _Datatable;
           

           

                dgrvAppointmentsList.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11);
                dgrvAppointmentsList.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgrvAppointmentsList.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }

        private void siticoneActivityButton1_Click(object sender, EventArgs e)
        {
            _TestAppointment = ClsTestAppointment.FindTestAppointment(_LocalDrivingLicenseID.Value, (int)_entestType);

            if (_AppointmentIsActive())
            {
                MessageBox.Show(" person has already an active appointment ", "failed add new apointment",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;

            }

            if(_TestAppointment == null)
            {
              _ShowAddNewTestApointmentForm();
                return;
            }

            if (!IsTestStatusPass())
            {
                FrmTestAppointment TestAppointment = new FrmTestAppointment(_LocalDrivingLicenseID, _entestType);
                CtrlShudleTestAppointment.OnTestAppointemtCreated += LoaderAppointmentsListOf;
                ClsGeneral.ApplicationType = ClsGeneral.enApplicationType.RetakeTest;
                TestAppointment.ShowDialog();
                return; 
            }
            
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            FrmTestAppointment TestAppointment = new FrmTestAppointment(_LocalDrivingLicenseID, _entestType);
            CtrlShudleTestAppointment.OnTestAppointemtCreated += LoaderAppointmentsListOf;
            ClsGeneral.ApplicationType = ClsGeneral.enApplicationType.NewLocalApplication; 
            TestAppointment.ShowDialog();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsTestStatusPass())
            {
                FrmTakeTest takeTest = new FrmTakeTest(_LocalDrivingLicenseID, _entestType);
                CtrlSheduleTakeTest.OnTakeTest += LoaderAppointmentsListOf;
                takeTest.ShowDialog(); 
            }
        }
    }
}
