
using MyDVLDPorject.UserCtrls;
using System.Windows.Forms;

namespace MyDVLDPorject.Frms
{
    public partial class FrmUpdatePerson : Form
    {
        public delegate void  EventDataBackHandel(int PersonID);
        public EventDataBackHandel DataBackHandel;

        public FrmUpdatePerson()
        {
            
            InitializeComponent();
        }

        private void siticoneButton1_Click(object sender, System.EventArgs e)
        {
            if(ctrlFindPerson1.Update())
            {
                MessageBox.Show("Person Has Been Updated Succssfully", "Info", MessageBoxButtons.OK);
                DataBackHandel?.Invoke(ctrlFindPerson.PersonID);
                return; 
            }
            MessageBox.Show("Update Person Was Filed ", "Info", MessageBoxButtons.OK , MessageBoxIcon.Error);

        }
    }
}
