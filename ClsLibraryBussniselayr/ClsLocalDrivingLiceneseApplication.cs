using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClsLibraryBussniselayr
{
    public class ClsLocalDrivingLiceneseApplication 
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication applicationInfo = new clsApplication();
        public ClsLicenses LicenseInfo = new ClsLicenses(); 
       
        private bool _AddNewLocalLicenesApplication(int ApplicationID, int ClassLicenesID)
        {
            this.LocalDrivingLicenseApplicationID = ClsLocalDrivingLiceneseDataAccess.AddNewLocalLiceneseApplication(ApplicationID , ClassLicenesID);
            return (this.LocalDrivingLicenseApplicationID > 0);
        } 

        public ClsLocalDrivingLiceneseApplication()
        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
            this.applicationInfo = null;
        }

        private ClsLocalDrivingLiceneseApplication(int localDrivingLicenseApplicationID,int applicationID, int licenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.ApplicationID = applicationID;
            this.LicenseClassID = licenseClassID;
            this.applicationInfo = clsApplication.FindApplication(this.ApplicationID);
            this.LicenseInfo = ClsLicenses.FindLicenseByAppID(this.ApplicationID);
        }

        public static ClsLocalDrivingLiceneseApplication CheckDrivingLicenese(int PersonID , string className)
        {
            ClsLicenseClass licenseClass = ClsLicenseClass.GetLicenseClass(className);
          

            int LocalLicenseApplicationID = -1 , LicenseClassID = licenseClass.LicenseClassID;
            int ApplicationID = 0; 

            if (ClsLocalDrivingLiceneseDataAccess.IsHasALocalLicenes( ref LocalLicenseApplicationID ,ref PersonID, ref  LicenseClassID , ref ApplicationID))
            {
               
                return new ClsLocalDrivingLiceneseApplication(LocalLicenseApplicationID, ApplicationID , LicenseClassID);
                
            }
            return null; 
        }
        public bool Save()
        {
            if(this.applicationInfo.AddNewApplication())
            {
                return _AddNewLocalLicenesApplication(this.applicationInfo.ApplicationID, this.LicenseClassID);
            }
            return false;
        }
        public static DataTable GetAll()
        {
           return ClsLocalDrivingLiceneseDataAccess.GetAllLocalDrivingApplication();
        }

        public static ClsLocalDrivingLiceneseApplication FindLocalDrivingLicenseApplication(int ApplicationID)
        {
            int LiceseClassID = 0; 
            int LocalLicenseApplicationID = ClsLocalDrivingLiceneseDataAccess.FindApplicationID(ref ApplicationID, ref LiceseClassID);
            if(LocalLicenseApplicationID != 0 )
            {
              
                return new ClsLocalDrivingLiceneseApplication(LocalLicenseApplicationID, ApplicationID, LiceseClassID);
            }
            return null;
        }

        public bool Delete()
        {
            if(ClsLocalDrivingLiceneseDataAccess.DeleteLocalAppByApplicationID(this.LocalDrivingLicenseApplicationID))
            {
               return  this.applicationInfo.DeleteApplication(this.ApplicationID); 
            }
            return false; 
        }

        public static ClsLocalDrivingLiceneseApplication FindLocalDrivingLicense(int localDrivingLicenseID)
        {
            int LiceseClassID = 0;
            int ApplicationID = 0; 
            bool Found = ClsLocalDrivingLiceneseDataAccess.FindLocalDrivingLicenese(localDrivingLicenseID , ref ApplicationID, ref LiceseClassID);
            if (Found)
            {
                return new ClsLocalDrivingLiceneseApplication(localDrivingLicenseID, ApplicationID, LiceseClassID);
            }
            return null;
        }
        public byte CountOfTestTotalTrial(int LocalApplicationID , int TestTypeID)
        {
            return ClsLocalDrivingLiceneseDataAccess.TotalTrial(LocalApplicationID, TestTypeID);
        }
    }
}
