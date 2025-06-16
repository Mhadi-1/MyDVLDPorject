using ClsLibraryBussniselayr;
using MyDVLDPorject.FrmUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.UserCtrls
{
    public partial class ctrlManageUsers : UserControl
    {
        DataTable _UsersTable = new DataTable();
        int _PersonID; 

        private void ShowUsersDataOnGridView()
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            tbl = clsUser.GetAllUsers();
           


            _UsersTable = tbl.DefaultView.ToTable(false , "UserID" , "FullName" , "IsActive"); 
            dgvUser.DataSource = _UsersTable;

            if (dgvUser.Rows.Count > 0)
            {
                dgvUser.Columns[0].HeaderText = "User ID";
                dgvUser.Columns[0].Width = 100;

                dgvUser.Columns[1].HeaderText = "FullName";
                dgvUser.Columns[1].Width = 120;


                dgvUser.Columns[2].HeaderText = "Is Active";
                dgvUser.Columns[2].Width = 170;
            }
           dgvUser.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           dgvUser.EnableHeadersVisualStyles = false;
           dgvUser.ColumnHeadersDefaultCellStyle.Font =
           new Font("Segoe UI", 11, FontStyle.Bold);
           dgvUser.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
           dgvUser.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue;
           lblRecord.Text = "#Record'(s) " + _UsersTable.Rows.Count.ToString();

        }
        private void FillCmbBxWithItems()
        {
            cmbobxfilteritems.Items.Clear(); 
            foreach (DataColumn column in _UsersTable.Columns)
            {
                if (column.ColumnName != "FullName" || column.ColumnName != "IsActive")
                {
                  cmbobxfilteritems.Items.Add(column.ColumnName.ToString()); 
                
                }

            }
        }
        private void FilterBy(string FilterBy)
        {
            string Filter;
            if (FilterBy == "UserID" || FilterBy == "PersonID" )
            {
                if (int.TryParse(txtbxSearch.Text.ToString(), out int Result))
                {
                    Filter = $"{FilterBy} = '{Result}'";
                    _UsersTable.DefaultView.RowFilter = Filter;
                }
                else
                {
                    txtbxSearch.Text = string.Empty;
                    _UsersTable.DefaultView.RowFilter = txtbxSearch.Text;
                }
                return;
            }

            if (txtbxSearch.Text != string.Empty)
            {
                Filter = $"{FilterBy} LIKE '{txtbxSearch.Text}%'";
                _UsersTable.DefaultView.RowFilter = Filter;
                return;
            }
            
            if(cmbxIsActive.Text == "True" || cmbxIsActive.Text == "False")
            {
                 Filter = $"IsActive = {cmbxIsActive.Text}";
                _UsersTable.DefaultView.RowFilter = Filter;

                return;
            }
            _UsersTable.DefaultView.RowFilter = string.Empty;

        }

        public ctrlManageUsers()
        {

            InitializeComponent();
        }

        private void ctrlManageUsers_Load(object sender, EventArgs e)
        {
            ShowUsersDataOnGridView();
            FillCmbBxWithItems();
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
           
            FilterBy(cmbobxfilteritems.Text);
        }

        private void btnAddNewUser_OnClick(object sender, EventArgs e)
        {
            
            FrmAddUser frmaddUser = new FrmAddUser();
            frmaddUser.ShowDialog();
            ShowUsersDataOnGridView();
        }

        private void cmbobxfilteritems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbobxfilteritems.Text == "IsActive")
            {
                txtbxSearch.Visible = false;
                cmbxIsActive.Visible = true;
               
                return;
            }
            else
            cmbxIsActive.Visible = false; ;
            txtbxSearch.Visible = true;
        }

        private void cmbxIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBy(cmbxIsActive.Text);
        }

        private void EditUser_MenuOnClick(object sender, EventArgs e)
        {

           
            FrmUpdateUser frmUpdate = new FrmUpdateUser(_PersonID);
            frmUpdate.ShowDialog();

        }

        private void UsersDataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow row = dgvUser.CurrentRow;
            _PersonID = Convert.ToInt32(row.Cells["PersonID"].Value);
            
            
        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmPassWord passWord = new FrmPassWord(_PersonID);
            passWord.ShowDialog(); 
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmAddUser frmaddUser = new FrmAddUser();
            frmaddUser.ShowDialog();
            ShowUsersDataOnGridView();

        }

      

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmShowUsrDetails showUsrDetails = new FrmShowUsrDetails(_PersonID);
            showUsrDetails.ShowDialog(); 
        }
    }
}
