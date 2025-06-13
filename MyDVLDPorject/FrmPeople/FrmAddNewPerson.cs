using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frms
{
    public partial class FrmAddNewPerson : Form
    {
        public FrmAddNewPerson()
        {
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if(ctrlFindPerson1.AddNew()) {

                MessageBox.Show("New Person Add Succssefully", "Info", MessageBoxButtons.OK);
                return; 
            }
                MessageBox.Show("Add Person Was Filed !! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
