using ClsLibraryBussniselayr;
using MyDVLDPorject.UserCtrls;
using System;
using ClsLibraryBussniselayr;
using System.Windows.Forms;
using MyDVLDPorject.FrmPeople;
using DevExpress.XtraEditors.Filtering.Templates;

namespace MyDVLDPorject.FrmUsers
{
    public partial class FrmAddUser : DevExpress.XtraEditors.XtraForm
    {
        

        private int _PersonID = -1;
        private void LoadPersonInfo(int ID)
        {
            _PersonID = ID;

            if (_PersonID > 0)
            {
                ctrlShowPesonDetails1.ShowDetails(_PersonID);
                return; 
            }
        }

        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void bntCansel_OnClick(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tbPersonInfo);
        }

        private void btnSelectAPerson_Click(object sender, EventArgs e)
        {

            FrmFindPerson findPerson = new FrmFindPerson();
            findPerson.DelegateDataCack += LoadPersonInfo;
            findPerson.ShowDialog();
        }

        private void btnNext_OnClick(object sender, EventArgs e)
        {
            if (clsUser.FindUserIDByPersonID(_PersonID) > 0)
            {
                MessageBox.Show("this person is a User already , try another one please !! ", "try another person",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (_PersonID > 0)
            {
                userCtrlLoginBoard1.PersonID(_PersonID);
                userCtrlLoginBoard1.Mode = UserCtrlLoginBoard.enctrlMode.Update;
                tabControl1.SelectTab(tbLoginInfo);
                return;
            }
            MessageBox.Show("person info must not be empty ", "try another person",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

     
    }
}
