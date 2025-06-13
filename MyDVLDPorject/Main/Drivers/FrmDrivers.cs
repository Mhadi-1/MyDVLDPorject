using ClsLibraryBussniselayr;
using MyDVLDPorject.Frm_Appliciation.Frms_LocalDrivingApp;
using MyDVLDPorject.Frms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frm_Appliciation.Drivers
{
    public partial class FrmDrivers : DevExpress.XtraEditors.XtraForm
    {

        private DataTable _dtAllDrivers;
        private void _LoadAllDrivers()
        {
            cbFilterBy.SelectedIndex = 0;
            _dtAllDrivers = ClsDrivers.GetAllDrivers();
            dgvDrivers.DataSource = _dtAllDrivers;
            lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();
            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 100;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 100;

                dgvDrivers.Columns[2].HeaderText = "National No.";
                dgvDrivers.Columns[2].Width = 120;

                dgvDrivers.Columns[3].HeaderText = "Full Name";
                dgvDrivers.Columns[3].Width = 350;

                dgvDrivers.Columns[4].HeaderText = "Active Licenses";
                dgvDrivers.Columns[4].Width = 150;
            }
            dgvDrivers.ColumnHeadersDefaultCellStyle.Font =
              new Font("Segoe UI", 10);
            dgvDrivers.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvDrivers.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvDrivers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public FrmDrivers()
        {
            InitializeComponent();
        }




        private void FrmDrivers_Load(object sender, EventArgs e)
        {
            _LoadAllDrivers(); 
        }

        private void txtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (cbFilterBy.Text == "Driver ID" || cbFilterBy.Text == "Person ID")
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
            FrmShowPersonDetails frm = new FrmShowPersonDetails(PersonID);
            frm.ShowDialog();
            FrmDrivers_Load(null, null); 
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterValue.Visible = (cbFilterBy.Text != "None");


            if (cbFilterBy.Text == "None")
            {
                txtFilterValue.Enabled = false;
            }
            else
                txtFilterValue.Enabled = true;

            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "Driver ID":
                FilterColumn = "DriverID";
                break;

                case "Person ID":
                FilterColumn = "PersonID";
                break;

                case "National No.":
                FilterColumn = "NationalNo";
                break;


                case "Full Name":
                FilterColumn = "FullName";
                break;

                default:
                FilterColumn = "None";
                break;

            }

            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDrivers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "NationalNo")
                //in this case we deal with numbers not string.
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterValue.Text.Trim());
            else
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterValue.Text.Trim());

            lblRecordsCount.Text = _dtAllDrivers.Rows.Count.ToString();
        }
    }
}
