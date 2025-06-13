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
    public partial class FrmShowPersonDetails : Form
    {
        private int _PersonID = -1; 
        public FrmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID; 
        }

        private void ctrlShowPesonDetails1_Load(object sender, EventArgs e)
        {
            ctrlShowPesonDetails1.ShowDetails(_PersonID); 
        }
    }
}
