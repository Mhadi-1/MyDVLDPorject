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

namespace MyDVLDPorject.Frm_Appliciation
{
    public partial class FrmApplicicationType : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _table = new DataTable();
        private int _ApplicationID; 

        private void LoadApplicationTypes()
        {
            _table.Clear();
            _table = ClsApplicationTypes.GetAll();

           
            dgrvApplicationTypes.DataSource = _table;
            dgrvApplicationTypes.Columns["ApplicationTypeID"].HeaderText = "PersonID";
            dgrvApplicationTypes.Columns["ApplicationTypeTitle"].HeaderText = "Title";
            dgrvApplicationTypes.Columns["ApplicationFees"].HeaderText = "Fees";

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Font = new Font("Arial", 11); 
            dgrvApplicationTypes.ColumnHeadersDefaultCellStyle = cellStyle;
            dgrvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            lblRecord.Text = "#Record'(s) " + _table.Rows.Count.ToString();

        }

        public FrmApplicicationType()
        {
            InitializeComponent();
        }

        private void FrmApplicicationType_Load(object sender, EventArgs e)
        {
            LoadApplicationTypes();
        }

        private void dgrvApplicationTypes_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow Row = new DataGridViewRow();
            Row = dgrvApplicationTypes.CurrentRow;
            _ApplicationID =  Convert.ToInt32(Row.Cells["ApplicationTypeID"].Value); 
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmUpdateApplicationTypes updateApplicationTypes = new FrmUpdateApplicationTypes(_ApplicationID);
            updateApplicationTypes.ShowDialog();
            LoadApplicationTypes();

        }

       
    }
}
