using MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls;
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
    public partial class FrmTestAppointment : DevExpress.XtraEditors.XtraForm
    {
        private int _ApplicationID = -1;
        private ClsGeneral.enTestType _TestType;

        public FrmTestAppointment(int? ApplicationID ,  ClsGeneral.enTestType testType)
        {
            InitializeComponent();
            _ApplicationID = ApplicationID.Value;
            _TestType      = testType; 
        }

        private void FrmTestAppointment_Load(object sender, EventArgs e)
        {
            
            ctrlShudleTest1.LoadTesAppointmenttInfo(_ApplicationID , _TestType);
        }
    }
}
