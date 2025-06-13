using ClsLibraryBussniselayr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDVLDPorject.Main.Frm_Driving_Licneses_Services.Frm_Release_License_s
{
    public partial class FrmListDetainLicenseApplication : DevExpress.XtraEditors.XtraForm
    {
        private DataTable _dtDetainedLicenses;

        public FrmListDetainLicenseApplication()
        {
            InitializeComponent();
        }

        private void ManageReleasedApplication_Load(object sender, EventArgs e)
        {
            _dtDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();

            dgvDetainedLicenses.DataSource = _dtDetainedLicenses;

            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 90;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns[1].Width = 90;

                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 160;

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 110;

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 110;

                dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].Width = 160;

                dgvDetainedLicenses.Columns[6].HeaderText = "N.No.";
                dgvDetainedLicenses.Columns[6].Width = 90;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 230;

                dgvDetainedLicenses.Columns[8].HeaderText = "Rlease App.ID";
                dgvDetainedLicenses.Columns[8].Width = 150;

            }
        }
    }
}
