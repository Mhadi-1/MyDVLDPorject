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
    public partial class FrmUpdateApplicationTypes : DevExpress.XtraEditors.XtraForm
    {
        private ClsApplicationTypes ApplicationType = new ClsApplicationTypes();
        private int _ApplicationID; 

        private void ShowErrorProvider(Control Cntrl , string Message)
        {
            errorProvider1.SetError(Cntrl, Message); 
        }
        private bool CheckValues()
        {
            if (txtBxApplicationTypeTitle.Text == string.Empty)
            {
                ShowErrorProvider(txtBxApplicationTypeTitle, "_application title must not be empty");
                return false;
            }
            ShowErrorProvider(txtBxApplicationTypeTitle, string.Empty);

            if (txtBxApplicationFees.Text == string.Empty)
            {
                ShowErrorProvider(txtBxApplicationFees, "_application fees must not be empty");
                return false;
            }
            ShowErrorProvider(txtBxApplicationTypeTitle, string.Empty);
            return true;
        }

        public FrmUpdateApplicationTypes(int ApplicationID)
        {
            _ApplicationID = ApplicationID; 

            InitializeComponent();
        }

        private void FrmUpdateApplicationTypes_Load(object sender, EventArgs e)
        {
            ApplicationType = ClsApplicationTypes.GetApplicationTypeByID(_ApplicationID); 
            if(ApplicationType != null)
            {
                lbApplicatiolnlD.Text = ApplicationType.ID.ToString();
                txtBxApplicationTypeTitle.Text = ApplicationType.ApplicationTitle;
                txtBxApplicationFees.Text = ApplicationType.ApplicationFees.ToString();
                return; 
            }
        }

        private void btnSave_OnClick(object sender, EventArgs e)
        {
            if(CheckValues())
            {
                ApplicationType.ApplicationTitle = txtBxApplicationTypeTitle.Text;
                ApplicationType.ApplicationFees = Convert.ToDecimal(txtBxApplicationFees.Text);
                if(ApplicationType.UpdateApplicationType())
                {
                    MessageBox.Show("Application Type Has Update Successfully", "Update Application Type");
                    this.Close();
                    return; 
                }
                else
                    MessageBox.Show("Sorry Application Update Was Filed", "Update Application Type");
            }
        }

    }
}
