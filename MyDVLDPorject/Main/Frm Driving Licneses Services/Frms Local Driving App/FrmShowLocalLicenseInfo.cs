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
    public partial class FrmShowLocalLicenseInfo : DevExpress.XtraEditors.XtraForm
    {
        private int LicenseID;

        public FrmShowLocalLicenseInfo(int? LicenseID)
        {
            InitializeComponent();
            this.LicenseID = LicenseID.Value; 
        }

        private void FrmShowLocalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenesInfo1.LoadLicenseInfo(LicenseID); 
        }
    }
}
