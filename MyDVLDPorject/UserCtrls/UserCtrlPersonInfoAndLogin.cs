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

namespace MyDVLDPorject.UserCtrls
{
    public partial class UsrCtrlShowPersonInfoAndUsrLoginInfo : UserControl
    {

        private clsUser CurrentUser = new clsUser();

        private void ShowLoginInfo()
        {
           
            if (CurrentUser != null)
            {
                lblUserID.Text   += " " + CurrentUser.ID.ToString();
                lbluserName.Text += " " + CurrentUser.Name;
                lblIsActive.Text += " " + CurrentUser.IsActive;

            }
        }

        public void LoadPersonData(int PersonID)
        {
            usrCtrlPersonCard1.LoadPersonInfo(PersonID);
            CurrentUser = clsUser.GetUser(PersonID);
            ShowLoginInfo(); 
        }

        public UsrCtrlShowPersonInfoAndUsrLoginInfo()
        {
         
            InitializeComponent();
        }

       

       
    }
}
