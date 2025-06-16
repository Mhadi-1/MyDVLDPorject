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
    public partial class FrmScheduleVisionTest : DevExpress.XtraEditors.XtraForm
    {
        private int? _LocalDrivingLicenesID = null; 

        public FrmScheduleVisionTest(int ApplicationID)
        {

            InitializeComponent();
            _LocalDrivingLicenesID = ApplicationID; 
        }

        private void FrmScheduleVisionTest_Load(object sender, EventArgs e)
        {
            ctrlGenralApplicationInfo1.LoadApplicationInfo(_LocalDrivingLicenesID);
            ctrlGenralAppointmentsList1.LoaderAppointmentsListOf(_LocalDrivingLicenesID.Value , (int)ClsGeneral.enTestType.VisitionTest); 
        }

        private void ctrlGenralAppointmentsList1_Load(object sender, EventArgs e)
        {

        }
    }
}
