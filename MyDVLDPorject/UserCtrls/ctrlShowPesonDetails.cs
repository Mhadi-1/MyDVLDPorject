
using ClsLibraryBussniselayr;
using MyDVLDPorject.Frms;
using MyDVLDPorject.Properties;
using System;
using System.Windows.Forms;

namespace MyDVLDPorject.UserCtrls
{
    public partial class ctrlShowPesonDetails : UserControl
    {
        private static clsPerson person = new clsPerson();

        private void _CheckGendor(int Gendor)
        {
            if (Gendor == 1)
            {
                lblGendor.Text = "Male";
                return;
            }
            lblGendor.Text = "Female";
        }
        private void _LoadPersonImage(string ImageName)
        {
            if(ImageName != string.Empty)
            {
                pcbxPersonImage.Load(ImageName); 
            }
        }

        public void ShowDetails(int ID)
        {
             person = clsPerson.FindByID(ID);
            if (person != null)
            {
                lblPersonID.Text    = person.ID.ToString();
                lblNationalNo.Text  =  person.NationalNo;
                lblFullName.Text    = person.FullName;
                lblDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                lblEmail.Text       = person.Email;
                lblPhone.Text       = person.Phone;
                lblAddress.Text = person.Address;
                lblCountry.Text =  person.CountryName;
                _LoadPersonImage(person.ImagePath);
                _CheckGendor(person.Gendor);
                return;
            }
            ClearCardInfo();

        }
        public void ClearCardInfo()
        {
            if (person != null)
            {
                person.Clear();

            }
            lblPersonID.Text = "[???]";
            lblNationalNo.Text = "[???]";
            lblFullName.Text = "[???]";
            lblDateOfBirth.Text = "[???]";
            lblEmail.Text = "[???]";
            lblPhone.Text = "[???]";
            lblAddress.Text = "[???]";
            lblCountry.Text = "[???]";
            pcbxPersonImage.Image = Resources.man;
        }
        

        public ctrlShowPesonDetails()
        {
            
            InitializeComponent();
        }

        private void UpdateInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (person.ID == 0)
                return;
            ctrlFindPerson.PersonID = person.ID;
            ctrlFindPerson.Mode = ctrlFindPerson.enMode.Update;
            FrmUpdatePerson frmUpdate = new FrmUpdatePerson();
            frmUpdate.DataBackHandel += ShowDetails;
            frmUpdate.Show();
        }

        private void ctrlShowPesonDetails_Load(object sender, EventArgs e)
        {
            ShowDetails(0);
        }

       
    }
}
