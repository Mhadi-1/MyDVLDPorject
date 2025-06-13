using ClsLibraryBussniselayr;
using DevExpress.XtraEditors.Filtering.Templates;
using MyDVLDPorject.Frms;
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
    public partial class usrctrlPersonWithFilter : UserControl
    {

        public int PersonID ;
        public delegate void DelegateDatapersonIdDataBack(int ID);
        public event DelegateDatapersonIdDataBack DelegateClearPersonID; 

        public event Action<int> OnPersonIDFound;
        
        protected virtual double OnPersonFound(int obj)
        {
            Action<int> Handler = OnPersonIDFound;
            if(Handler != null)
            {
                Handler(PersonID);
            }

            return 0; 
        }

        private void _fillCmbobxWithItems()
        {

            comboBox1.Items.Add("PersonID");
            comboBox1.Items.Add("National No");
            comboBox1.Items.Add("None");
            comboBox1.SelectedIndex = 2; 
        }

        bool CheckValue(ref int ID)
        {
            if (SearchTextBx.Text != null && int.TryParse(SearchTextBx.Text, out int Result))
            {
                ID = Result;
                PersonID = ID; 
                return true;
            }
            else
            {
                SearchTextBx.Text = string.Empty;
            }
            return false;
        }

        private void FindPersonBy(string SelectedItem )
        {
            if (SelectedItem == "PersonID")
            {
                int ID = 0;
                if (CheckValue(ref ID))
                {
                    PersonID = ID;
                    ctrlShowPesonDetails1.ShowDetails(PersonID);

                }
            }

            if (SelectedItem == "National No")
            {
                if(!string.IsNullOrEmpty(SearchTextBx.Text))
                {
                    
                    clsPerson person = clsPerson.FindByNationalNo(SearchTextBx.Text);
                    if(person.ID > 0 )
                    {
                      PersonID = person.ID;
                        ctrlShowPesonDetails1.ShowDetails(PersonID);
                    }
                    else 
                        return;

                }
            }

            if(PersonID > 0 )
            {
                OnPersonFound(PersonID);
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
            ctrlShowPesonDetails1.ShowDetails(PersonID);
            SearchTextBx.Text = PersonID.ToString();
            comboBox1.SelectedItem = "Person ID";
            btnSearch.Enabled = false;
            SearchTextBx.Enabled = false;
            comboBox1.Enabled = false;
            btnClear.Enabled = false;
            this.PersonID = PersonID;


        }

        public usrctrlPersonWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "None" )
            {
                SearchTextBx.Text = string.Empty; 
                return; 
            }
            else
            FindPersonBy(comboBox1.SelectedItem.ToString());

        }

        private void usrctrlPersonWithFilter_Load(object sender, EventArgs e)
        {
            _fillCmbobxWithItems();
          
        }
      
        private void btnClear_Click(object sender, EventArgs e)
        {
            ctrlShowPesonDetails1.ClearCardInfo();
            comboBox1.SelectedItem = "None";
            SearchTextBx.Text = string.Empty;
            PersonID = 0;
            OnPersonFound(PersonID);
        }

    }
}
