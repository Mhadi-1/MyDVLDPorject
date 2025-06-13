using ClsLibraryBussniselayr;
using MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests;
using MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp;
using MyDVLDPorject.FrmLicenses;
using MyDVLDPorject.genralClasess;
using Newtonsoft.Json.Linq;
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
    public partial class FrmManageLocalDrivingLicenseApplications : DevExpress.XtraEditors.XtraForm
    {


        private DataTable _table = new DataTable();
        private int? _LocalDrivingLecesneApplicationID;
        private byte? _PassedTestCount;
        private bool _IsProccessCompleted = false; 

        private void _ShowMenuTitleApplicationComplited(bool Value = false)
        {
            DeleteApplicationToolStripMenuItem.Enabled = Value;
            CancelApplicaitonToolStripMenuItem.Enabled = Value;
            showDetailsToolStripMenuItem.Enabled = Value;
            showLicenseToolStripMenuItem.Enabled = !Value;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = Value;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = Value;
            editToolStripMenuItem.Enabled = Value;
            showDetailsToolStripMenuItem.Enabled = Value;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = !Value;
            ScheduleTestsMenue.Enabled = Value;
        }
        private void _IsuueNewLocalLicenseForFristTime()
        {
            FrmIssueNewLocalDrivingLicnese issueNewLocalDrivingLicnese = new FrmIssueNewLocalDrivingLicnese(_LocalDrivingLecesneApplicationID);
            issueNewLocalDrivingLicnese.ShowDialog(); 
        }
      

        private void ShowMenuStripValiedTestType()
        {
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            if (_PassedTestCount == 3 )
            {
                issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                return; 
            }
            _PassedTestCount++;
            switch ((ClsGeneral.enTestType)_PassedTestCount)
            {
                case ClsGeneral.enTestType.VisitionTest:
                scheduleVisionTestToolStripMenuItem.Enabled = true;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                return;
                case ClsGeneral.enTestType.WriteTest:
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = true;
                scheduleStreetTestToolStripMenuItem.Enabled = false;
                return;
                case ClsGeneral.enTestType.StreetTest:
                scheduleVisionTestToolStripMenuItem.Enabled = false;
                scheduleWrittenTestToolStripMenuItem.Enabled = false;
                scheduleStreetTestToolStripMenuItem.Enabled = true;
                return;
            }
        }

        private void FilterBy(string FilterBy)
        {
            string Filter;
            if (FilterBy == "LocalDrivingLicenseApplicationID" || FilterBy == "PassedTestCount")
            {
                if (int.TryParse(txtbxSearch.Text.ToString(), out int Result))
                {
                    Filter = $"{FilterBy} = '{Result}'";
                    _table.DefaultView.RowFilter = Filter;
                    return;
                }
                else
                {
                    txtbxSearch.Text = string.Empty;
                    _table.DefaultView.RowFilter = txtbxSearch.Text;
                    return;
                }
            }
                if (txtbxSearch.Text != string.Empty)
                {
                    Filter = $"{FilterBy} LIKE '{txtbxSearch.Text}%'";
                    _table.DefaultView.RowFilter = Filter;
                    return;
                }

                _table.DefaultView.RowFilter = string.Empty;

          
        }
        private void _GetAllLocalDrivingLicenses()
        {
            
            DataTable Table = ClsLocalDrivingLiceneseApplication.GetAll();
            Table.DefaultView.ToTable(false, "LocalDrivingLicenseApplicationID", "ClassName", "NationalNo", "FullName", "ApplicationDate",
                "PassedTestCount", "Status");
           

            _table = Table;

            dtgridviewLocalLicenses.DataSource = _table; 
            if(dtgridviewLocalLicenses.RowCount > 0 )
            {
                dtgridviewLocalLicenses.Columns[0].HeaderText = "L.DL.AppID";
                dtgridviewLocalLicenses.Columns[0].Width = 100;
               
                dtgridviewLocalLicenses.Columns[1].HeaderText = "Class Name";
                dtgridviewLocalLicenses.Columns[1].Width = 120;

                dtgridviewLocalLicenses.Columns[2].HeaderText = "National No";
                dtgridviewLocalLicenses.Columns[2].Width = 120;

                dtgridviewLocalLicenses.Columns[3].HeaderText = "Full Name";
                dtgridviewLocalLicenses.Columns[3].Width = 170;

                dtgridviewLocalLicenses.Columns[4].HeaderText = "Application Date";
                dtgridviewLocalLicenses.Columns[4].Width = 120;

                dtgridviewLocalLicenses.Columns[5].HeaderText = "Test Count";
                dtgridviewLocalLicenses.Columns[5].Width = 120;

                dtgridviewLocalLicenses.Columns[6].HeaderText = "Status";
                dtgridviewLocalLicenses.Columns[6].Width = 120;

            }


            dtgridviewLocalLicenses.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);
            dtgridviewLocalLicenses.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dtgridviewLocalLicenses.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue;
            dtgridviewLocalLicenses.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cmbobxFilterKeys.SelectedIndex = 0; 
        }

        public FrmManageLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private void FrmManageLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            _GetAllLocalDrivingLicenses();
          
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if(cmbobxFilterKeys.SelectedIndex == 0 )
            {
                return; 
            }
            FilterBy(cmbobxFilterKeys.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLocalDrivingLicenes localDrivingLicenes = new FrmLocalDrivingLicenes(ClsGeneral.CurrentUser);
            localDrivingLicenes.ShowDialog();
            _GetAllLocalDrivingLicenses();
        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this _application?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            ClsLocalDrivingLiceneseApplication liceneseApplication =
            ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicenseApplication(_LocalDrivingLecesneApplicationID.Value);
            
            if (liceneseApplication != null && liceneseApplication.Delete())
            {
                MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _GetAllLocalDrivingLicenses();
            }
            else
            {
                MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void dtgridviewLocalLicenses_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
           
            DataGridViewRow Row = dtgridviewLocalLicenses.CurrentRow;
            _LocalDrivingLecesneApplicationID = Convert.ToInt32(Row.Cells["LocalDrivingLicenseApplicationID"].Value);
            _PassedTestCount = Convert.ToByte(Row.Cells["PassedTestCount"].Value);
            if (Convert.ToString(Row.Cells["Status"].Value) == "Completed")
            {
                _IsProccessCompleted = true; 
            }
            else
            {
                _IsProccessCompleted = false; 
            }
        

        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScheduleVisionTest sheduleVisionTest = new FrmScheduleVisionTest(_LocalDrivingLecesneApplicationID.Value);
            sheduleVisionTest.ShowDialog();
            _GetAllLocalDrivingLicenses();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScheduleWrittenTest scheduleWrittenTest = new FrmScheduleWrittenTest(_LocalDrivingLecesneApplicationID);
            scheduleWrittenTest.ShowDialog();
            _GetAllLocalDrivingLicenses();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmScheduleStreetTest scheduleStreetTest = new FrmScheduleStreetTest(_LocalDrivingLecesneApplicationID);
            scheduleStreetTest.ShowDialog();
            _GetAllLocalDrivingLicenses();
        }

        private void cmsApplications_Opened(object sender, EventArgs e)
        {
            if(_IsProccessCompleted)
            {
                _ShowMenuTitleApplicationComplited();
                return; 
            }
            _ShowMenuTitleApplicationComplited(true);
            ShowMenuStripValiedTestType();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _IsuueNewLocalLicenseForFristTime();
            _GetAllLocalDrivingLicenses(); 
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsLocalDrivingLiceneseApplication LocalDrivingLicense =
                ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicense(_LocalDrivingLecesneApplicationID.Value); 

            FrmShowLocalLicenseInfo localLicenseInfo = new FrmShowLocalLicenseInfo(LocalDrivingLicense.LicenseInfo.LicenseID);
            localLicenseInfo.ShowDialog(); 
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicenseHistory licenseHistory = new FrmLicenseHistory(_LocalDrivingLecesneApplicationID.Value);
            licenseHistory.ShowDialog(); 
        }
    }
}
