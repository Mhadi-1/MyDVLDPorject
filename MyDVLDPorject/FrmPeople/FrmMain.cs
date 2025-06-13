using ClsLibraryBussniselayr;
using MyDVLDPorject.Frm_Appliciation;
using MyDVLDPorject.Frm_Appliciation.Drivers;
using MyDVLDPorject.Frm_Appliciation.Frms_International_Driving_License;
using MyDVLDPorject.FrmLicenses;
using MyDVLDPorject.Frms;
using MyDVLDPorject.FrmUsers;
using MyDVLDPorject.genralClasess;
using MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Detainted_Licenses;
using MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Release_License_s;
using MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Renew_Driving_License;
using MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Replacement_Or_Lost_Driving_Licesne;
using MyDVLDPorject.UserCtrls;
using MyMemeoryGame;
using System;
using System.Windows.Forms;

namespace MyDVLDPorject
{
    public partial class FrmMain : Form
    {

        
        public FrmMain(clsUser User)
        {
            ClsGeneral.CurrentUser = User; 
            InitializeComponent();
        }

        private void pepoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManagePepole managePepole = new FrmManagePepole();
            managePepole.ShowDialog(); 
        }

        private void singOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageUsers manageUsers = new FrmManageUsers();
            manageUsers.Show(); 
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmPassWord passWord = new FrmPassWord(ClsGeneral.CurrentUser.PersonID);
            passWord.ShowDialog(); 
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmShowUsrDetails showUsrDetails = new FrmShowUsrDetails(ClsGeneral.CurrentUser.PersonID);
            showUsrDetails.ShowDialog(); 
        }

        private void manageApplicaitionTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApplicicationType ApplicicationTypes = new FrmApplicicationType();
            ApplicicationTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageAppciationTest appciationTest = new FrmManageAppciationTest();
            appciationTest.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingLicenes drivingLicenes = new FrmLocalDrivingLicenes(ClsGeneral.CurrentUser);
            drivingLicenes.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void localDrivingLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManageLocalDrivingLicenseApplications drivingLicenseApplications = new FrmManageLocalDrivingLicenseApplications();
            drivingLicenseApplications.ShowDialog(); 
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDrivers drivers = new FrmDrivers();
            drivers.ShowDialog(); 
        }

        private void internationalApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIssueInternationalDrivingLicenes internationalDrivingLicenes = new FrmIssueInternationalDrivingLicenes();
            internationalDrivingLicenes.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIssueInternationalDrivingLicenes internationalDrivingLicenes = new FrmIssueInternationalDrivingLicenes();
            internationalDrivingLicenes.ShowDialog(); 
        }

        private void renewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRenewDrivingLicenseApp renewDrivingLicenseApp = new FrmRenewDrivingLicenseApp();
            renewDrivingLicenseApp.ShowDialog(); 
        }

        private void replacementOrDamangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReplacementorDamageLicense replacementorDamageLicense = new FrmReplacementorDamageLicense();
            replacementorDamageLicense.ShowDialog(); 
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetainedLicense detainedLicense = new FrmDetainedLicense();
            detainedLicense.ShowDialog(); 
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReleaseLicense releaseLicense = new FrmReleaseLicense();
            releaseLicense.ShowDialog(); 
        }
    }
}
