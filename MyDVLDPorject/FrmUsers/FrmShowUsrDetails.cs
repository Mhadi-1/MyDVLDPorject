using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.FrmUsers
{
    public partial class FrmShowUsrDetails : DevExpress.XtraEditors.XtraForm
    {
        private int _PersonID; 

        public FrmShowUsrDetails(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void FrmShowUsrDetails_Load(object sender, EventArgs e)
        {
            usrCtrlShowPersonInfoAndUsrLoginInfo1.LoadPersonData(_PersonID);
        }
    }
}
