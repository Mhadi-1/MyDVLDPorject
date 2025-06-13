using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClsLibraryBussniselayr
{
    public  class ClsInternationalLicense 
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public ClsDrivers DriverInfo;
        public int ApplicationID;
        public int CreatedUserID; 
        public int InternationalLicenseID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }

        private bool _AddNew()
        {
            this.InternationalLicenseID =
                ClsInternationalLicenseDataAccess.AddNewInternationalLicense(this.ApplicationID, this.DriverID, this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedUserID);
            return (this.InternationalLicenseID > 0); 
        }

        public ClsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.IsActive = true;
            Mode = enMode.AddNew;
        }
        private ClsInternationalLicense(int internationalLicenseID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive)
        {
            InternationalLicenseID = internationalLicenseID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            Mode = enMode.Update; 
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                if (_AddNew())
                {
                    return true;
                }
                return false; 
            }
            return false; 
        }


        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return ClsInternationalLicenseDataAccess.GetDriverInternationalLicenses(DriverID);
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {

            return ClsInternationalLicenseDataAccess.GetActiveInternationalLicenseIDByDriverID(DriverID);

        }

    }
}
