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

namespace MyDVLDPorject.FrmUsers
{
    public partial class FrmPassWord : DevExpress.XtraEditors.XtraForm
    {
        private int _PersonID;
        private clsUser CurrentUser = new clsUser();

        private void ShowErrorProvider(Control control, string Message)
        {
            errorProvider1.SetError(control, Message);
        }
        private bool CheckValues()
        {
            if (string.IsNullOrEmpty(txtbxPassWod.Text))
            {
                ShowErrorProvider(txtbxPassWod, "current password must not be empty or whitespace");
                return false;
            }
            ShowErrorProvider(txtbxPassWod, string.Empty);

            if (string.IsNullOrEmpty(txtbxNewPassWord.Text))
            {
                ShowErrorProvider(txtbxNewPassWord, "new password must not be empty or whitespace");
                return false;
            }
            ShowErrorProvider(txtbxNewPassWord, string.Empty);

            if (string.IsNullOrEmpty(txtbxConfirtPassWord.Text))
            {
                ShowErrorProvider(txtbxConfirtPassWord, "confirt password must not be empty or whitespace");
                return false;
            }
            ShowErrorProvider(txtbxConfirtPassWord, string.Empty);
            return true;
        }


        public FrmPassWord(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID; 
        }

        private void PassWod_IconRightClick(object sender, EventArgs e)
        {
            if (((SiticoneTextBox)sender).UseSystemPasswordChar != true)
            {
                ((SiticoneTextBox)sender).UseSystemPasswordChar = true;
                ((SiticoneTextBox)sender).IconRight = Resources.hide_Password;
                return;
            }
          ((SiticoneTextBox)sender).UseSystemPasswordChar = false;
            ((SiticoneTextBox)sender).IconRight = Resources.show_password;
        }

        private void Savebtn_OnClick(object sender, EventArgs e)
        {

            ShowErrorProvider(txtbxPassWod, string.Empty);
            if (txtbxPassWod.Text != CurrentUser.password)
            {
                ShowErrorProvider(txtbxPassWod, "password not match current password !!");
                return;
            }

            if (CheckValues())
            {
                CurrentUser.password = txtbxNewPassWord.Text;
                if (CurrentUser.Save())
                    MessageBox.Show("password has Changed Succssfully", "password changed");
                else
                    MessageBox.Show("sorry password  was filed to Change !!", "password changed");
                return;

            }
        }

        private void txtbxPassWod_Validating(object sender, CancelEventArgs e)
        {
            if (txtbxPassWod.Text != CurrentUser.password)
            {
                ShowErrorProvider(txtbxPassWod, "password not match current password !!");
                return;
            }
            ShowErrorProvider(txtbxPassWod, string.Empty);
        }

        private void txtbxConfirtPassWord_Validating(object sender, CancelEventArgs e)
        {
            if (txtbxConfirtPassWord.Text != txtbxNewPassWord.Text)
            {
                e.Cancel = true;
                txtbxConfirtPassWord.Focus();
                ShowErrorProvider(txtbxConfirtPassWord, "sorry Confirt password not match new password !!");
                return;
            }
            ShowErrorProvider(txtbxConfirtPassWord, string.Empty);
        }

        private void FrmPassWord_Load(object sender, EventArgs e)
        {
            usrCtrlShowPersonInfoAndUsrLoginInfo1.LoadPersonData(_PersonID);
            CurrentUser = clsUser.GetUser(_PersonID);
        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }
    }
}
