using ClsLibraryBussniselayr;
using MyDVLDPorject.Properties;
using Siticone.Desktop.UI.WinForms;
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
    public partial class UserCtrlLoginBoard : UserControl
    {
        public enum enctrlMode { AddNew , Update};
        public enctrlMode Mode;
        private int _PersonID; 
        public static clsUser user = new clsUser();

        public  void PersonID(int ID) {

            _PersonID = ID; 
        }

        private void ShowInfo()
        {
             user = clsUser.GetUser(_PersonID); 
            if(user != null)
            {
                lblUserID.Text = user.ID.ToString();
                txtUserName.Text = user.Name;
                txtbxPassWod.Text = user.password;
                txtbxConfirtPassWord.Text = user.password;
                checkBox1.Checked = user.IsActive;
               
                return;

            }
        }

        void SetErrorProvider(Control control, string Message)
        {
            errorProvider1.SetError(control, Message);
        }
        bool CheckValues()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                SetErrorProvider(txtUserName, "user1 name must not be empty or white space!!");
                return false;
            }
            SetErrorProvider(txtUserName, "");
            if (string.IsNullOrEmpty(txtbxPassWod.Text))
            {
                SetErrorProvider(txtbxPassWod, "password must not be empty or white space!!");
                return false;
            }
            SetErrorProvider(txtbxPassWod, "");
            if (string.IsNullOrEmpty(txtbxConfirtPassWord.Text))
            {
                SetErrorProvider(txtbxConfirtPassWord, "passWord to Confirt must not be empty or white space!!");
                return false;
            }
            SetErrorProvider(txtbxConfirtPassWord, "");
            return true;

        }
        bool Saveuser(ref clsUser user1)
        {
            
            user1.Name = txtUserName.Text.ToString();
            user1.password = txtbxPassWod.Text;
            user1.IsActive = checkBox1.Checked;
            user1.PersonID = _PersonID;
            return user1.Save();

        }

        public UserCtrlLoginBoard()
        {
            InitializeComponent();
        }

        private void txtbxConfirtPassWord_Validating(object sender, CancelEventArgs e)
        {
            if (txtbxConfirtPassWord.Text != txtbxPassWod.Text)
            {
                SetErrorProvider(txtbxConfirtPassWord, "confirt pasword not match the password");
                e.Cancel = true;
                txtbxConfirtPassWord.Focus();
                return;
            }
            else
                SetErrorProvider(txtbxConfirtPassWord, "");
            e.Cancel = false;


        }

        private void btnSave_OnClick(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                if(Mode == enctrlMode.AddNew)
                {
                  if (clsUser.IsAccess(txtUserName.Text))
                  {
                      MessageBox.Show($"CurrentUser By Name {txtUserName.Text} is Has Alread Exists", "try another name",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                      return;
                  }
                }
                  user = new clsUser(); 

                if (Saveuser(ref user))
                {
                    lblUserID.Text = user.ID.ToString();
                    MessageBox.Show("CurrentUser Login Info Was Added sucssfully !!", "Login Info",
                       MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("add CurrentUser Login Info was filed !!", "try agin",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }


        private void UserCtrlLoginBoard_Load(object sender, EventArgs e)
        {
            if (Mode == enctrlMode.Update)
            {
                ShowInfo();
            }
            else return;
        }

        private void IconPassWord_OnClick(object sender, EventArgs e)
        {
            if (((SiticoneTextBox)sender).UseSystemPasswordChar != true)
            {
                ((SiticoneTextBox)sender).IconRight = Resources.hide_Password;
                ((SiticoneTextBox)sender).UseSystemPasswordChar = true;
               
                return; 
            }
            ((SiticoneTextBox)sender).IconRight = Resources.show_password;
            ((SiticoneTextBox)sender).UseSystemPasswordChar = false;
        }
    }
}
