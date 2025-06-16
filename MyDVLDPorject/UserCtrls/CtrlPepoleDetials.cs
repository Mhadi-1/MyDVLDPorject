
using ClsLibraryBussniselayr;
using MyDVLDPorject.Frms;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.UserCtrls
{
    public partial class CtrlPepoleDetials : UserControl
    {
        private static DataTable _Table = new DataTable();

        private int _PersonID;
        private void LoadItemsToCmbobx()
        {
            cmbobxFilterKeys.Items.Clear();
            foreach (DataColumn column in _Table.Columns)
            {
                if (column.ColumnName !=  "DateOfBirth")
                {
                   cmbobxFilterKeys.Items.Add(column.ColumnName);
                    
                }
            }
        }
        private void FilterBy(string FilterBy)
        {
            string Filter; 
            if(FilterBy == "Phone" || FilterBy == "PersonID")
            {
               if (int.TryParse(txtbxSearch.Text.ToString(), out int Result))
               {
                   Filter = $"{FilterBy} = '{Result}'";
                   _Table.DefaultView.RowFilter = Filter;
               }
               else
               {
                    txtbxSearch.Text = string.Empty;
                    _Table.DefaultView.RowFilter = txtbxSearch.Text; 
               }
                return; 
            }


            if(txtbxSearch.Text != string.Empty)
            {
                Filter = $"{FilterBy} LIKE '{txtbxSearch.Text}%'";
                _Table.DefaultView.RowFilter = Filter;
                return; 
            }

             _Table.DefaultView.RowFilter = string.Empty; 

        }

        private async void Show_RefreshDataView()
        {
            Task <DataTable> _dtPeople = clsPerson.GetAllPeople();

           
            _Table = await _dtPeople;
            if(_Table.Rows.Count > 0 )
            {
                dgvPeople.DataSource = _Table; 
                dgvPeople.Columns[0].HeaderText = "Person ID";
                dgvPeople.Columns[0].Width = 110;

                dgvPeople.Columns[1].HeaderText = "National No.";
                dgvPeople.Columns[1].Width = 120;


                dgvPeople.Columns[2].HeaderText = "First Name";
                dgvPeople.Columns[2].Width = 120;

                dgvPeople.Columns[3].HeaderText = "Second Name";
                dgvPeople.Columns[3].Width = 140;




                dgvPeople.Columns[4].HeaderText = "Third Name";
                dgvPeople.Columns[4].Width = 120;

                dgvPeople.Columns[5].HeaderText = "Last Name";
                dgvPeople.Columns[5].Width = 120;

                dgvPeople.Columns[6].HeaderText = "Gendor";
                dgvPeople.Columns[6].Width = 120;

                dgvPeople.Columns[7].HeaderText = "Date Of Birth";
                dgvPeople.Columns[7].Width = 140;

                dgvPeople.Columns[8].HeaderText = "Nationality";
                dgvPeople.Columns[8].Width = 120;



                lblDataRecords.Text = "#Record'(s) " + _Table.Rows.Count.ToString();


                dgvPeople.EnableHeadersVisualStyles = false;
                dgvPeople.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 11, FontStyle.Bold);
                dgvPeople.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                dgvPeople.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkBlue;
            }

               

        }

        public CtrlPepoleDetials()
        {
            InitializeComponent();
        }

        private void CtrlPepoleDetials_Load(object sender, EventArgs e)
        {
           
            Show_RefreshDataView();
            LoadItemsToCmbobx();

        }

        private void btnAddNew_OnClick(object sender, EventArgs e)
        {
             FrmAddNewPerson frmAddNew = new FrmAddNewPerson();
             ctrlFindPerson.Mode = ctrlFindPerson.enMode.AddNew;
             frmAddNew.ShowDialog();
             Show_RefreshDataView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

               FrmUpdatePerson frmUpdate = new FrmUpdatePerson();
               ctrlFindPerson.Mode = ctrlFindPerson.enMode.Update;
               ctrlFindPerson.PersonID = _PersonID;
               frmUpdate.ShowDialog();
               Show_RefreshDataView();

        }

        private void cmbobxFilterKeys_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtbxSearch.Visible = true;
            cmbobxFilterKeys.SelectionStart = 0; 
          
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            FilterBy(cmbobxFilterKeys.SelectedItem.ToString());
        }

        private void showDetailesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmShowPersonDetails showPersonDetails = new FrmShowPersonDetails(_PersonID);
            showPersonDetails.ShowDialog();
            Show_RefreshDataView();


        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("would you like to delete this record","Insurance" ,
                MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(ctrlFindPerson.Delete(_PersonID))
                {
                    MessageBox.Show("record Has been deleted Succssfully", "Info");
                    Show_RefreshDataView();
                    return; 
                }
                 MessageBox.Show("sorry delete record was filed", "Info",MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
           
        }

        private void dgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPeople_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow row = dgvPeople.CurrentRow;
            _PersonID = Convert.ToInt32(row.Cells["personID"].Value);
            MainContextStrip.ShowItemToolTips = true;
            MainContextStrip.Enabled = true;
        }
    }
}
