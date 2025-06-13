using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frm_Appliciation.Frms_International_Driving_License.UserCtrls
{
    public partial class CtrlInternationApplicationInfo : UserControl
    {
        public int   ApplicationID { get; set; }
        public string CreatedByUser { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int LocalLicenseID { get; set; }
        public int InternationalLicenseID { get; set; }
        public decimal Fees { get; set; }


        private void _SetControl()
        {
            lblFees.Text = Fees.ToString();
            lblInternationalLicenseID.Text = InternationalLicenseID == 0 ? "???" : InternationalLicenseID.ToString(); 
            lblLocalLicenseID.Text = LocalLicenseID.ToString(); 
            lblExpirationDate.Text = ExpirationDate.ToShortDateString();
            lblIssueDate.Text = IssueDate.ToShortDateString(); 
            lblApplicationDate.Text = ApplicationDate.ToShortDateString();
            lblCreatedByUser.Text = CreatedByUser;
            lblApplicationID.Text = ApplicationID == 0 ? "???" : ApplicationID.ToString(); 
        }
        public void LoadAppicationIfo()
        {
            _SetControl();
        }
        public CtrlInternationApplicationInfo()
        {
            InitializeComponent();
        }

       
    }
}
