using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class ClsLicenses
    {
       public ClsDrivers DriverInfo;
       public ClsLicenseClass LicenseClassIfo;
       public int LicenseID { get; set; }
       public int ApplicationID { get; set;}
       public int DriverID { get; set;} 
       public int LicenseClass { get; set;}
       public DateTime? IssueDate { get; set;} 
       public DateTime? ExpirationDate { get; set;}
       public string Notes { get; set;}
       public decimal PaidFees { get; set;}
       public bool IsActive { get; set;}
       public enIssueReason IssueReason { get; set;}
       public int CreatedByUserID { get; set;}
       public bool IsDetained { get; set; }
       public clsDetainedLicense detainLicenseInfo; 

        public enum enIssueReason { FirstTime = 1, Renew = 2, LostReplacement = 3, DamagedReplacement = 4 };

        public ClsLicenses()
        {
            this.ApplicationID = 0;
            this.DriverID = 0;
            this.LicenseClass = 0;
            this.IssueDate = null;
            this.ExpirationDate = null;
            this.Notes = null;
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = 0;
            this.DriverInfo = null;
            this.LicenseClassIfo = null;
            this.LicenseID = -1; 
        }

        public ClsLicenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
             DateTime IssueDate, DateTime ExpirationDate, string Notes,
             decimal PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)

        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
            this.DriverInfo = ClsDrivers.FindByDriverID(DriverID);
            this.LicenseClassIfo = ClsLicenseClass.GetLicenseClass(LicenseClass);
            detainLicenseInfo = clsDetainedLicense.FindByLicenseID(this.LicenseID);
            this.IsDetained = clsDetainedLicense.IsLicenseDetained(this.LicenseID);
        }

        public bool AddNewLicense()
        {
            this.LicenseID = ClsLicensesDataAccess.AddNewLicense(this.ApplicationID, this.DriverID,
            this.LicenseClass, this.IssueDate.Value, this.ExpirationDate.Value,
            this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID); 

            if(this.LicenseID > 0 )
            {
                return true; 
            }
            return false; 
        }
        public bool Update()
        {
           return  ClsLicensesDataAccess.UpdateLicense(this.LicenseID, this.ApplicationID, this.DriverID,
                this.LicenseClass, this.IssueDate.Value, this.ExpirationDate.Value, this.Notes,
                 this.PaidFees, this.IsActive,(int)this.IssueReason, this.CreatedByUserID);
        }
        public static DataTable GetAll()
        {
            return ClsLicensesDataAccess.GetAllLicenses(); 
        }
        public static DataTable GetAllDriverLiceses(int DriverID)
        {
            return ClsLicensesDataAccess.GetDriverLicenses(DriverID); 
        }

        public static ClsLicenses FindLicense(int LicenseID)
        {
            int ApplicationID = -1; int DriverID = -1; int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0; bool IsActive = true; int CreatedByUserID = 1;
            byte IssueReason = 1;

            if (ClsLicensesDataAccess.GetLicenseInfoByID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass,
            ref IssueDate, ref ExpirationDate, ref Notes,
            ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new ClsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass,
                                     IssueDate, ExpirationDate, Notes,
                                     PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;
        }

        public static ClsLicenses FindLicenseByAppID(int ApplicationID)
        {
            int LicenseID = -1; int DriverID = -1; int LicenseClass = -1;
            DateTime IssueDate = DateTime.Now; DateTime ExpirationDate = DateTime.Now;
            string Notes = "";
            decimal PaidFees = 0; bool IsActive = true; int CreatedByUserID = 1;
            byte IssueReason = 1;

            if (ClsLicensesDataAccess.GetLicenseInfoByAppID(ref LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass,
            ref IssueDate, ref ExpirationDate, ref Notes,
            ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))

                return new ClsLicenses(LicenseID, ApplicationID, DriverID, LicenseClass,
                                     IssueDate, ExpirationDate, Notes,
                                     PaidFees, IsActive, (enIssueReason)IssueReason, CreatedByUserID);
            else
                return null;
        }

    }
}
