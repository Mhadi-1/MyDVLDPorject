using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.FrmPeople
{
    public partial class FrmFindPerson : DevExpress.XtraEditors.XtraForm
    {
        public delegate void EventPersonID(int personID);
        public event EventPersonID DelegateDataCack;

        private int _PersonID { get; set; }

        public FrmFindPerson()
        {
            InitializeComponent();
           
        }

      
        private void usrctrlPersonWithFilter1_OnPersonIDFound(int obj)
        {
            _PersonID = obj; 
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            DelegateDataCack?.Invoke(_PersonID);
            this.Hide();
        }

        private void FrmFindPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
