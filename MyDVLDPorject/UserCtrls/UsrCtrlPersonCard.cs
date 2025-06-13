using ClsLibraryBussniselayr;
using DevExpress.XtraEditors.Filtering.Templates;
using MyDVLDPorject.Properties;
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
    public partial class UsrCtrlPersonCard : UserControl
    {
        private clsPerson person = new clsPerson(); 
        private void _LoadPersonImage(string ImageName)
        {
            if (ImageName != string.Empty)
            {
                pcbxPersonImage.Load(ImageName);
            }
        }
        private void _CheckGendor(int Gendor)
        {
            if (Gendor == 1)
            {
                rdobtnMale.Checked = true;
                rdobtnMale.Enabled = true;
                rdobtnFemale.Enabled = false;
                return;
            }
            rdobtnFemale.Checked = true;
            rdobtnFemale.Enabled = true; ;
            rdobtnMale.Enabled = false;
        }
        public void LoadPersonInfo(int ID = 0)
        {
            if(ID > 0 )
            {
               person = clsPerson.FindByID(ID);
            }
            if (person != null)
            {

                lblPersonID.Text = person.ID.ToString();
                lblNationalNo.Text = person.NationalNo;
                lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                lblDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                LblEmail.Text = person.Email;
                lblPhoneNumb.Text = person.Phone;
                lblAddress.Text = person.Address;
                lblCountry.Text = person.CountryName;

                _LoadPersonImage(person.ImagePath);
                _CheckGendor(person.Gendor);
               


            }

        }
        public void ClearCardInfo()
        {
            if(person != null)
            {
               person.Clear();

            }
            lblPersonID.Text = "[???]";
            lblNationalNo.Text = "[???]";
            lblName.Text = "[???]";
            lblDateOfBirth.Text = "???";
            LblEmail.Text = "???";
            lblPhoneNumb.Text = "???";
            lblAddress.Text = "???";
            lblCountry.Text = "???";
            pcbxPersonImage.Image = Resources.man;
            rdobtnMale.Checked = true;
            rdobtnFemale.Checked = false;
            
           
        }

        public UsrCtrlPersonCard()
        {
            InitializeComponent();
        }

        private void UsrCtrlPersonCard_Load(object sender, EventArgs e)
        {

        }
    }
}
