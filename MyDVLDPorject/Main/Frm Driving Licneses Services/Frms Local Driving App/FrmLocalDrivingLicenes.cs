using ClsLibraryBussniselayr;
using DevExpress.Utils.Extensions;
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

namespace MyDVLDPorject.FrmLicenses
{
    public partial class FrmLocalDrivingLicenes : DevExpress.XtraEditors.XtraForm
    {


        private ClsApplicationTypes _applicationType = new ClsApplicationTypes();
        private ClsLocalDrivingLiceneseApplication _localDrivingLiceneseApplication 
            = new ClsLocalDrivingLiceneseApplication();

        private bool IsAppilcationActive()
        {
            int ClassLicenseIndex = ClsLicenseClass.GetLicenseClass(cmbxLicensesClassesTypes.Text).LicenseClassID;

            int IsActiveApplication = clsApplication.GetActiveApplicationsID(ClsGeneral.Person.ID,
                clsApplication.enApplicationType.NewDrivingLicense,
                ClassLicenseIndex); 

            if(IsActiveApplication != -1)
            {

                MessageBox.Show(
                 $"The selected person already has an active _application for this license class (Application ID: " +
                 $"{IsActiveApplication}).\n\nPlease choose another license class.",
                 "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);          
                return true;

            }
              return false; 
          
        }

        private void _FillCombxWithClassLicenseFilters()
        {
           
            DataTable Table = ClsLicenseClass.GetAll(); 
            foreach(DataRow Row in Table.Rows)
            {
                cmbxLicensesClassesTypes.Items.Add(Row["ClassName"].ToString()); 
            }

            if (ClsGeneral.CurrentUser != null)
            {
                lblUserName.Text = ClsGeneral.CurrentUser.Name;
            }

            lblDate.Text = DateTime.Now.ToShortDateString();
            _applicationType = ClsApplicationTypes.GetApplicationTypeByID((int)clsApplication.enApplicationType.NewDrivingLicense);
            lblFees.Text = _applicationType.ApplicationFees.ToString();
            return; 
        }

        private bool _CreatNewLocalDrivingApplication()
        {

            if(IsAppilcationActive())
            {
                return false;
            }

              clsApplication applicationInfo = new clsApplication(); 
              applicationInfo.ApplicationpersonID = ClsGeneral.Person.ID;
              applicationInfo.ApplicationDate     = DateTime.Now;
              applicationInfo.ApplicationTypeID   = _applicationType.ID;
              applicationInfo.ApplicationStatus   = (int)ClsGeneral.enApplicationStatus.New;
              applicationInfo.LastAppicationDate  = DateTime.Now;
              applicationInfo.PaidFees            = _applicationType.ApplicationFees;
              applicationInfo.CreatedUserID = ClsGeneral.CurrentUser.ID;
              _localDrivingLiceneseApplication.LicenseClassID      = ClsLicenseClass.GetLicenseClass(cmbxLicensesClassesTypes.Text).LicenseClassID;
              _localDrivingLiceneseApplication.applicationInfo = applicationInfo; 

            if (_localDrivingLiceneseApplication.Save())
            {

                lblApplicationID.Text = _localDrivingLiceneseApplication.ApplicationID.ToString();
                 return true;

            }
           
            return false;
        }

        public FrmLocalDrivingLicenes(clsUser currentuser)
        {
            InitializeComponent();
            usrctrlPersonWithFilter1.DelegateClearPersonID += DelegatePersonID;
            ClsGeneral.CurrentUser = currentuser;
        }

        private void DelegatePersonID(int PersonID)
        {
            ClsGeneral.Person.ID = PersonID; 
        }

        private void btnNext_OnClick(object sender, EventArgs e)
        {
             if (ClsGeneral.Person.ID > 0 )
             {
                tabApplciationInfo.IsAccessible = true;
                tabControl1.SelectedTab = tabApplciationInfo;

                return;
             }
            MessageBox.Show("person informstion must not be empty", "perosn info");
            tabControl1.SelectedTab = tabpersonInfo;

        }

        private void usrctrlPersonWithFilter1_OnPersonIDFound(int obj)
        {
             ClsGeneral.Person.ID = obj;
        }

        private void FrmLocalDrivingLicenes_Load(object sender, EventArgs e)
        {
                 _FillCombxWithClassLicenseFilters();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (ClsGeneral.Person.ID > 0 && tabApplciationInfo.IsAccessible)
            {

                tabControl1.SelectedTab = tabApplciationInfo;
                tabApplciationInfo.IsAccessible = false;
                return;
            }
            tabControl1.SelectedTab = tabpersonInfo;

        }

        private void siticoneActivityButton1_Click(object sender, EventArgs e)
        {
            if( _CreatNewLocalDrivingApplication())
            {
                MessageBox.Show("_application was created successfully", "new _application");
                return;
            }
           
        }
    }
}
