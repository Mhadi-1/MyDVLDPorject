using ClsLibraryBussniselayr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp
{
    public partial class FrmLicenseHistory : DevExpress.XtraEditors.XtraForm
    {
        private int? _LocalLicenseID;
        
        private string ToShortDateTime(DateTime date)
        {
            return date.ToString("dd/MMM/yyyy"); 
        }
        private void _GetAllInternationalLicense(int DriverID)
        {
            DataTable table = new DataTable();

            table = ClsInternationalLicense.GetDriverInternationalLicenses(DriverID);

            if (table.Rows.Count ==0 ) { 
                return;
            }

            table.DefaultView.ToTable(false, "InternationalLicenseID", "ApplicationID",
                "IssuedUsingLocalLicenseID", "IssueDate", "ExpirationDate",
                "IsActive");

            datagridviewinternationalLicenses.DataSource = table;



            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void _GetAllCurrentLocalLicense(ClsLicenses licenses )
        {
            DataTable table = new DataTable();
            table.Columns.Add("LiceID");
            table.Columns.Add("AppID");
            table.Columns.Add("Class Name");
            table.Columns.Add("Issue Date");
            table.Columns.Add("Exprinse Date");
            table.Columns.Add("Is Active");
            table = ClsLicenses.GetAllDriverLiceses(licenses.DriverInfo.DriverID.Value); 
          
            dataGridView1.DataSource = table;
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Columns[0].HeaderText = "LiceID";
                dataGridView1.Columns[0].Width = 100;

                dataGridView1.Columns[1].HeaderText = "AppID";
                dataGridView1.Columns[1].Width = 120;

                dataGridView1.Columns[2].HeaderText = "Class Name";
                dataGridView1.Columns[2].Width = 220;

                dataGridView1.Columns[3].HeaderText = "Issue Date";
                dataGridView1.Columns[3].Width = 100;

                dataGridView1.Columns[4].HeaderText = "Exprinse Date";
                dataGridView1.Columns[4].Width = 160;

                dataGridView1.Columns[5].HeaderText = "Is Active";
                dataGridView1.Columns[5].Width = 90;

            }


            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public FrmLicenseHistory(int? localDrivingLicenseID)
        {
            InitializeComponent();
            _LocalLicenseID = localDrivingLicenseID;
        }

        private void FrmLicenseHistory_Load(object sender, EventArgs e)
        {
            ClsLocalDrivingLiceneseApplication liceneseApplication =
            ClsLocalDrivingLiceneseApplication.FindLocalDrivingLicense(_LocalLicenseID.Value); 

            if( liceneseApplication != null)
            ctrlShowPesonDetails1.ShowDetails(liceneseApplication.applicationInfo.ApplicationpersonID);
       
            _GetAllCurrentLocalLicense(liceneseApplication.LicenseInfo);
            _GetAllInternationalLicense(liceneseApplication.LicenseInfo.DriverID);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
