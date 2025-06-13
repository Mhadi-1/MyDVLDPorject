using MyDVLDPorject.UserCtrls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClsLibraryBussniselayr; 

namespace MyDVLDPorject.FrmUsers
{
    public partial class FrmUpdateUser : DevExpress.XtraEditors.XtraForm
    {
        private int _personID; 

        public FrmUpdateUser(int personID)
        {
            InitializeComponent();
            _personID = personID;
            
        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {
            usrctrlPersonWithFilter1.LoadPersonInfo(_personID);
            userCtrlLoginBoard1.PersonID(_personID);
            userCtrlLoginBoard1.Mode = UserCtrlLoginBoard.enctrlMode.Update;
        }
    }
}
