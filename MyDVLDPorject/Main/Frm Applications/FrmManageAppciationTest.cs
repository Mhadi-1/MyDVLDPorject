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
    public partial class FrmManageAppciationTest : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _table = new DataTable();
        private int _TestID;
        private void LoadApplicationTestTypes()
        {
            _table.Clear();
            _table =clsApplicationType.GetAllData();


            dgrvApplicationTypes.DataSource = _table;
            dgrvApplicationTypes.Columns["TestTypeID"].HeaderText = "ID";
            dgrvApplicationTypes.Columns["TestTypeTitle"].HeaderText = "Title";
            dgrvApplicationTypes.Columns["TestTypeDescription"].HeaderText = "Description";
            dgrvApplicationTypes.Columns["TestTypeFees"].HeaderText = "Fees";

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Font = new Font("Arial", 11);
            dgrvApplicationTypes.ColumnHeadersDefaultCellStyle = cellStyle;
            dgrvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            lblRecord.Text = "#Record'(s) " + _table.Rows.Count.ToString();
        }
       
        public FrmManageAppciationTest()
        {
            InitializeComponent();
        }

        private void FrmManageAppciationTest_Load(object sender, EventArgs e)
        {
            LoadApplicationTestTypes();
        }

        private void dgrvApplicationTypes_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgrvApplicationTypes.CurrentRow;
            _TestID = Convert.ToInt32(row.Cells["TestTypeID"].Value); 
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmApplicationTestTypeUpdate applicationTestTypeUpdate = new FrmApplicationTestTypeUpdate(_TestID);
            applicationTestTypeUpdate.ShowDialog();
            LoadApplicationTestTypes();

        }
    }
}
