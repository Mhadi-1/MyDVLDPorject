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
    public partial class FrmApplicationTestTypeUpdate : DevExpress.XtraEditors.XtraForm
    {
        private int _TestTypeID { get; set; }
        private clsApplicationType applicationTest = new clsApplicationType();

        private void GetApplicationtTestData()
        {
            applicationTest = clsApplicationType.GetApplicationTypeByID(_TestTypeID);
            if (applicationTest != null)
            {
                lbApplicatiolnlD.Text = applicationTest.ApplicationTestID.ToString(); ;
                txtBxApplicationTestTypeTitle.Text = applicationTest.ApplicationTestTitle;
                txtbxApplicationTestTypeDescription.Text = applicationTest.ApplicationTestDescription;
                txtbxApplicationTestTypeFees.Text = applicationTest.ApplicatiolnTestFees.ToString();

            }
        }
        private bool CheckFees()
        {
            
            if (decimal.TryParse(txtbxApplicationTestTypeFees.Text, out decimal Result))
            {
                return true;
            }
            return false;

        }

        private bool UpdateApplicationTestType()
        {
            

           
            if (applicationTest != null && CheckFees())
            {
                applicationTest.ApplicationTestTitle = txtBxApplicationTestTypeTitle.Text;
                applicationTest.ApplicationTestDescription = txtbxApplicationTestTypeDescription.Text;
                applicationTest.ApplicatiolnTestFees = Convert.ToDecimal(txtbxApplicationTestTypeFees.Text);
                return applicationTest.Save();

            }
            else return false;
        }

        public FrmApplicationTestTypeUpdate(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void FrmApplicationTestTypeUpdate_Load(object sender, EventArgs e)
        {
            GetApplicationtTestData();
        }

        private void btnSave_Clcik(object sender, EventArgs e)
        {
            if(UpdateApplicationTestType())
            {
                MessageBox.Show("test type update it auccessfully", "update test");
                return;
            }
            MessageBox.Show("sorry update test type was field", "update test");
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
