
using ClsLibraryBussniselayr;
using MyDVLDPorject;
using MyDVLDPorject.genralClasess;
using MyDVLDPorject.Properties;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Windows.Forms;


namespace MyMemeoryGame
{
    public partial class FrmLogin : Form
    {

        
        void SetErrorProvider(Control control, string Message)
        {
            errorProvider1.SetError(control, Message);
        }
        private bool CheckUserNameAndPassWord()
        {
            ClsGeneral.CurrentUser = clsUser.GetUser(TxtBxUserName.Text); 
            if(ClsGeneral.CurrentUser != null)
            {
                if(ClsGeneral.CurrentUser.IsActive == false)
                {
                    lblIncrrectPass.Text = "your account is desactivated please contact your admin";
                    lblIncrrectPass.Visible = true;
                    return false;
                }

                lblIncrrectPass.Text = "Sorry user name or password is incorrect  please try agin !!";
                return (ClsGeneral.CurrentUser.password == TxtBxPassWord.Text && ClsGeneral.CurrentUser.IsActive == true);
            }
            return false; 
            
        }
        private string EncryptionWord(string S1 , int EncryptionNum)
        {
            StringBuilder encryptionWord = new StringBuilder();
            for (int i = 0; i < S1.Length; i ++ )
            {
                char encryptedChar = (char)(S1[i] + EncryptionNum);
                encryptionWord.Append(encryptedChar);
            }
            return encryptionWord.ToString(); 
        }
        private string DescryprionWord(string S1 , int DescryptionNum)
        {
            StringBuilder encryptionWord = new StringBuilder();
            for (int i = 0; i < S1.Length; i++)
            {
                char encryptedChar = (char)(S1[i] - DescryptionNum);
                encryptionWord.Append(encryptedChar);
            }
            return encryptionWord.ToString();
        }
        private void WriteUserLoginInfoToWindowsRegistry()
        {

           
            if (checkBox1.Checked)
            {

                ClsProjectSettings.SaveToWinRegistry(EncryptionWord(TxtBxUserName.Text ,30 ), EncryptionWord(TxtBxPassWord.Text,30) ,  checkBox1.Checked); 
            }
            else
            {
                ClsProjectSettings.SaveToWinRegistry("None", "None", false);

            }
            return;
        }
        private void GetUserInfoFromCerdintaliesFile()
        {

           
            TxtBxPassWord.UseSystemPasswordChar = true;
            string[] lines = ClsProjectSettings.GetRegistryValue(); 

            if (Convert.ToBoolean(lines[2]) == true)
            {
                TxtBxUserName.Text = DescryprionWord(lines[0] , 30);
                TxtBxPassWord.Text = DescryprionWord(lines[1] , 30);
                checkBox1.Checked = Convert.ToBoolean(lines[2]);
            }
            else
            {
                  return;

                
               
            }
            
        }
        private void LogintoMianScreen()
        {
            if (CheckUserNameAndPassWord())
            {
                WriteUserLoginInfoToWindowsRegistry();
                FrmMain main = new FrmMain(ClsGeneral.CurrentUser);
                main.Show();
                this.Hide();
                return;
            }
            lblIncrrectPass.Visible = true;
            SetErrorProvider(lblIncrrectPass , "try agin pleas");
            ClsProjectSettings.EventLogExption("UserName or PassWord Dose Not Exsist !.", System.Diagnostics.EventLogEntryType.Error);
            return;
        }
        private bool CheckTextBxValue()
        {
            
            if (TxtBxUserName.Text == string.Empty)
            {
                SetErrorProvider(TxtBxUserName, "user name must not be empty");
                return false; 
            }
            if(TxtBxPassWord.Text == string.Empty)
            {
                SetErrorProvider(TxtBxPassWord, "password can not be empty");
                return false;
            }
            SetErrorProvider(TxtBxUserName, "");
            SetErrorProvider(TxtBxPassWord, "");
            return true; 


        }


        public FrmLogin()
        {

            InitializeComponent();
            GetUserInfoFromCerdintaliesFile(); 
        }

        private void Btn_Next_OnClick(object sender, System.EventArgs e)
        {
            if(CheckTextBxValue())
            {
               LogintoMianScreen(); 
            }
            return; 
        }
        private void BtnCancel_OnClick(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void TxtBxPassWord_IconRightClick(object sender, System.EventArgs e)
        {
            if (TxtBxPassWord.UseSystemPasswordChar != true)
            {
                TxtBxPassWord.IconRight = Resources.hide_Password;
                TxtBxPassWord.UseSystemPasswordChar = true; 


                return; 
            }
            TxtBxPassWord.UseSystemPasswordChar = false;
            TxtBxPassWord.IconRight = Resources.show_password;
           
        }
        private void TxtBx_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            lblIncrrectPass.Visible = false;
            SetErrorProvider(lblIncrrectPass, string.Empty); 
            if (((SiticoneTextBox)sender).Text == string.Empty)
            {
                e.Cancel = true;
                this.Focus();
                SetErrorProvider((SiticoneTextBox)sender, "filed must not be embpty !!"); 
            }
            else
            {
                e.Cancel = false;
                SetErrorProvider((SiticoneTextBox)sender, string.Empty);
                
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
