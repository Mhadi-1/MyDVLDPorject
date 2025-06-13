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
    public partial class FrmScheduleStreetTest : DevExpress.XtraEditors.XtraForm
    {
        private int? _LocalDrivingLicenesID = null;

        public FrmScheduleStreetTest(int ? LocalApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenesID = LocalApplicationID; 
        }

        private void FrmScheduleStreetTest_Load(object sender, EventArgs e)
        {
            ctrlGenralApplicationInfo1.LoadApplicationInfo(_LocalDrivingLicenesID);
            ctrlGenralAppointmentsList1.LoaderAppointmentsListOf(_LocalDrivingLicenesID.Value, (int)ClsGeneral.enTestType.StreetTest);
        }
    }
}
