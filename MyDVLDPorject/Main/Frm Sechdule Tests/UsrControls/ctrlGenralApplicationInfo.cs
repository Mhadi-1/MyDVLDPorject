using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Frm_Appliciation.Frm_Sechdule_Tests.UsrControls
{
    public partial class ctrlGenralApplicationInfo : UserControl
    {
      

        public ctrlGenralApplicationInfo()
        {
            InitializeComponent();
            
         
        }

        public void LoadApplicationInfo(int? ApplicationID)
        {
            if(ApplicationID.HasValue)
            {
              ctrlApplicationBasicProccessInfo1.LoadLocalApplicationInfo(ApplicationID.Value);
              ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfo(ApplicationID.Value);

            }
            else
             return; 
        }

       
    }
}
