using ClsLibraryBussniselayr;
using DevExpress.XtraEditors.Filtering.Templates;
using MyDVLDPorject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.IO; 
using System.Windows.Forms;
using Siticone.Desktop.UI.WinForms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace MyDVLDPorject.UserCtrls
{
    public partial class ctrlFindPerson : UserControl
    {

        public static int PersonID { get; set; }
        private static string PersonPicturename = string.Empty; 
        public enum enMode { AddNew , Update};
        public static enMode Mode;
        clsPerson person = new clsPerson(); 
        private void _ClearTxtBoxs()
        {
             lblPersonID.Text     = string.Empty;
             TxtBxNationalNo.Text = string.Empty;
             TxtBxNationalNo.ReadOnly = false; 
             txtbxFirstName.Text  = string.Empty;
             txtbxSecondName.Text = string.Empty;
             txtbxThirdName.Text  = string.Empty;
             txtbxLastName.Text   = string.Empty;
             DateOfBirth.Text     = string.Empty;
             txtbxEmail.Text      = string.Empty;
             txtbxPhone.Text      = string.Empty;
             txtbxAddress.Text    = string.Empty;
             cmbbxCountry.SelectedItem = "None";
             rdobtnMale.Enabled = true;
             rdobtnFemale.Enabled = true;
             linkedRemoveImage.Visible = false; 

        }
        private void _FillCmbxWithCountriesItems()
        {
            DataTable table = new DataTable(); 
            table = clsCountries.GetAllCountries(); 
            foreach(DataRow Row in table.Rows)
            {
                cmbbxCountry.Items.Add(Row["CountryName"]); 
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
        private void _LoadIamge(string ImagePath)
        {
           
            if(ImagePath != string.Empty)
            {
                pcbxPersonImage.Load(ImagePath.ToString());
                pcbxPersonImage.Tag = "#";
                linkedRemoveImage.Visible = true;
                PersonPicturename = ImagePath;  
            }
        }
        private async void _GetPeronsDetails()
        {
           
            person = clsPerson.FindByID(PersonID);
          
            if (person != null)
            {
                lblPersonID.Text = person.ID.ToString();
                TxtBxNationalNo.Text = person.NationalNo;
                TxtBxNationalNo.ReadOnly = true; 
                txtbxFirstName.Text = person.FirstName;
                txtbxSecondName.Text = person.SecondName;
                txtbxThirdName.Text = person.ThirdName;
                txtbxLastName.Text = person.LastName;
                DateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                txtbxEmail.Text = person.Email;
                txtbxPhone.Text = person.Phone;
                txtbxAddress.Text = person.Address;
                _LoadIamge(person.ImagePath);
                _FillCmbxWithCountriesItems();
                _CheckGendor(person.Gendor);
                cmbbxCountry.SelectedItem = person.CountryName;
            }
                


        }
        private void _ShowErrorProvider(string  message , Control control)
        {
            errorProvider1.SetError(control, message);
        }
        private bool _IsNationalNoExist(string NationalNo)
        {
            return clsPerson.IsNationalNoExit(NationalNo);
        }
        private bool _IsValiedEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
        }
        private bool _CheckControlValue(Control control , string Text)
        {
            if (Text == string.Empty)
            {
                _ShowErrorProvider("This Filed Requaerd !!", control);
                 return false; 
            }
            _ShowErrorProvider(string.Empty, control);
            return true; 
        }
        private bool _CheckValues()
        {
            if(!_CheckControlValue((SiticoneTextBox)txtbxFirstName, txtbxFirstName.Text))
                return false;
            if (!_CheckControlValue((SiticoneTextBox)txtbxSecondName,txtbxSecondName.Text))
                return false;
            if (!_CheckControlValue((SiticoneTextBox)txtbxThirdName , txtbxThirdName.Text))
                return false;
            if (!_CheckControlValue((SiticoneTextBox)txtbxLastName, txtbxLastName.Text))
                return false;
            if (!_CheckControlValue((SiticoneTextBox)TxtBxNationalNo , TxtBxNationalNo.Text))
                return false;
            if (!_CheckControlValue((TextBox)txtbxPhone , txtbxPhone.Text ))
                return false;
            if (!_CheckControlValue((SiticoneTextBox)txtbxAddress , txtbxAddress.Text))
                return false;
            else
                return true; 
        }
        private bool _AddNewPereson()
        {
          
            person = new clsPerson();
            person.FirstName = txtbxFirstName.Text;
            person.SecondName = txtbxSecondName.Text;
            person.ThirdName = txtbxThirdName.Text;
            person.LastName = txtbxLastName.Text;
            person.NationalNo = TxtBxNationalNo.Text;
            person.nationalityCountryID = clsCountries.FindCountryID(cmbbxCountry.SelectedItem.ToString());
            person.Phone = txtbxPhone.Text;
            person.Address = txtbxAddress.Text;
            person.DateOfBirth = DateOfBirth.Value;
            person.ImagePath = PersonPicturename;

            if (rdobtnFemale.Checked)
                person.Gendor = 0;
            else
                person.Gendor = 1; 

            if(_IsValiedEmail(txtbxEmail.Text))
                person.Email = txtbxEmail.Text; 
            else
                person.Email = DBNull.Value.ToString(); 

            if(person.Save())
            {
               lblPersonID.Text = person.ID.ToString();
               return true;
            }
            else
                return false;
            
        }
        private bool _Update()
        {
            if(person != null)
            {
                person.NationalNo = TxtBxNationalNo.Text;
                person.FirstName  = txtbxFirstName.Text;
                person.SecondName = txtbxSecondName.Text;
                person.ThirdName  = txtbxThirdName.Text;
                person.LastName   = txtbxLastName.Text;
                person.DateOfBirth = DateOfBirth.Value;
                person.Phone = txtbxPhone.Text;
                person.Address = txtbxAddress.Text;
                person.nationalityCountryID = clsCountries.FindCountryID(cmbbxCountry.SelectedItem.ToString());
                person.ImagePath = PersonPicturename;
                if (rdobtnFemale.Checked)
                    person.Gendor = 0;
                else
                    person.Gendor = 1;

                if (_IsValiedEmail(txtbxEmail.Text))
                    person.Email = txtbxEmail.Text;
                else
                    person.Email = DBNull.Value.ToString();

                return person.Save(); 
            }
                return false; 
        }
        private static bool _Delete(int ID)
        {
            return clsPerson.Delete(ID); 
        }

        public ctrlFindPerson()
        {
           
            InitializeComponent();
        }

        private void ctrlFindPerson_Load(object sender, EventArgs e)
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    _FillCmbxWithCountriesItems();
                    _ClearTxtBoxs();
                    return;
                case enMode.Update:
                    _GetPeronsDetails();
                    return;
            }
        }
        private void rdobtn_OnClick(object sender, EventArgs e)
        {
               if(pcbxPersonImage.Tag == "#")
               {
                 return; 
               }
               if (((RadioButton)sender).Text == "Male" && ((RadioButton)sender).Checked == true)
               {
                  pcbxPersonImage.Image = Resources.man;
                  pcbxPersonImage.Tag = "Man"; 
                   return;
               }
                pcbxPersonImage.Image = Resources.woman;
                pcbxPersonImage.Tag = "Woman";


        }

        private void linkedSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Desktop";
            openFileDialog1.DefaultExt = ".PNG";
            openFileDialog1.Title = "Add/Change Image";
            openFileDialog1.Filter = "jpg Files (*.jpg) |*.jpg| All Files (.) |*.png*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = String.Empty; 
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PersonPicturename = openFileDialog1.FileName;
                _LoadIamge(PersonPicturename); 
            }

        }
        private void txtbx_Validating(object sender, CancelEventArgs e)
        {
            if(((SiticoneTextBox)sender).Text == string.Empty)
            {
                e.Cancel = true;
                _ShowErrorProvider("The Field Must Not Be Empty !!",(SiticoneTextBox)sender); 
                this.Focus(); 
            }
            else
            {
                e.Cancel = false;
                _ShowErrorProvider("", (SiticoneTextBox)sender);
            }
        }
        private void txtbxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtbxEmail.Text == string.Empty)
            {
                _ShowErrorProvider("", txtbxEmail);
                return;
            }

            if (_IsValiedEmail(txtbxEmail.Text))
            {
                _ShowErrorProvider("", txtbxEmail);
                 return;
            }
            else
            {
                _ShowErrorProvider("Email Is Valied !!", txtbxEmail);
                
            }
        }
        private void linkedRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(rdobtnMale.Checked)
            {
                pcbxPersonImage.Image = Resources.man;
                pcbxPersonImage.Tag = "Man";
                
            }
            else
            {
               pcbxPersonImage.Image = Resources.woman;
               pcbxPersonImage.Tag = "Woman";

            }
            PersonPicturename = DBNull.Value.ToString();
            linkedRemoveImage.Visible = false;
        }
        private void TxtBxNationalNo_TextChanged(object sender, EventArgs e)
        {
            if (_IsNationalNoExist(TxtBxNationalNo.Text))
            {

                _ShowErrorProvider("This NationalNo Has already Exist try another!!", TxtBxNationalNo);
                this.Focus();
            }
            _ShowErrorProvider("", TxtBxNationalNo);
        }

        public  bool AddNew()
        {
            if(_CheckValues())
            {
                return _AddNewPereson();
                 
            }
            return false; 
           
        }
        public bool Update()
        {
            return _Update();
        }
        public static bool Delete(int ID)
        {
            return _Delete(ID); 
        }

      
    }
}
