using MyDVLDPorject.genralClasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests
{
    public partial class FrmTakeTest : DevExpress.XtraEditors.XtraForm
    {
        private int? _LocalDrivingLicenseID = null;
        private ClsGeneral.enTestType _TestType;
        

        public FrmTakeTest(int? LocalLicesenApplicationID, ClsGeneral.enTestType testType)
        {
            InitializeComponent();
            _LocalDrivingLicenseID = LocalLicesenApplicationID;
            _TestType = testType; 
        }

        private void FrmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlSheduleTakeTest1.LoadTestInfo(_LocalDrivingLicenseID.Value, _TestType); 
        }

        private void ctrlSheduleTakeTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
