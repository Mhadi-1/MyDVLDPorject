using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class clsApplication
    {

        public int ApplicationID { get; set; }
        public int ApplicationpersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public int ApplicationStatus { get; set; }
        public DateTime LastAppicationDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedUserID { get; set; }
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public bool _AddApplication()
        {
            this.ApplicationID = clsApplicationDataAccess.CreateApplication(this.ApplicationpersonID, this.ApplicationDate,
                this.ApplicationTypeID, this.ApplicationStatus, this.LastAppicationDate, this.PaidFees, this.CreatedUserID);
            return (this.ApplicationID > 0);
        }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ApplicationpersonID = -1;
            this.ApplicationTypeID = -1;
            this.CreatedUserID = -1;
            this.ApplicationStatus = -1;
            this.PaidFees = 0;
        }

        public clsApplication(int applicationID, int applicationpersonID, DateTime applicationDate,
            int applicationTypeID, int applicationStatus, DateTime lastAppicationDate,
            decimal paidFees, int createdUserID)
        {
            this.ApplicationID = applicationID;
            this.ApplicationpersonID = applicationpersonID;
            this.ApplicationDate = applicationDate;
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationStatus = applicationStatus;
            this.LastAppicationDate = lastAppicationDate;
            this.PaidFees = paidFees;
            this.CreatedUserID = createdUserID;
        }

        public bool AddNewApplication()
        {
            return _AddApplication();
        }
        public static bool UpdateApplicationStatus(int ApplicationID , int Status)
        {
            return clsApplicationDataAccess.UpdateStatue( ApplicationID , Status); 
        }
        public static clsApplication FindApplicationByPersonID(int PersonID)
        {
            int ApplicationID = -1, applicationTypeID = -1, applicationStatus = -1, createdUserID = -1;
            DateTime applicationDate = new DateTime();
            DateTime lastAppicationDate = new DateTime();
            decimal paidFees = 0;
            if (clsApplicationDataAccess.FindApplicationByPersonID(PersonID, ref ApplicationID, ref applicationDate
                , ref applicationTypeID, ref applicationStatus, ref lastAppicationDate, ref paidFees, ref createdUserID))
            {
                return new clsApplication(ApplicationID, PersonID, applicationDate, applicationTypeID, applicationStatus,
                    lastAppicationDate, paidFees, createdUserID);
            }
            return null;
        }
        public static clsApplication FindApplication(int ApplicationID)
        {
            int PersonID = -1, applicationTypeID = -1, applicationStatus = -1, createdUserID = -1;
            DateTime applicationDate = new DateTime();
            DateTime lastAppicationDate = new DateTime();
            decimal paidFees = 0;
            if (clsApplicationDataAccess.FindApplication(ref PersonID, ApplicationID, ref applicationDate
                , ref applicationTypeID, ref applicationStatus, ref lastAppicationDate, ref paidFees, ref createdUserID))
            {
                return new clsApplication(ApplicationID, PersonID, applicationDate, applicationTypeID, applicationStatus,
                    lastAppicationDate, paidFees, createdUserID);
            }
            return null;
        }

        public bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationDataAccess.DeleteApplicationByID(ApplicationID);
        }

        public static int GetActiveApplicationsID(int PersonID , clsApplication.enApplicationType enApplicationType , int LicenClassID)
        {
            return clsApplicationDataAccess.GetActiveApplicationIDBYClassID(PersonID, (int)enApplicationType, LicenClassID); 
        }


    }
}
