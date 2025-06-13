using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class ClsDrivers
    {
        public int? DriverID  = null;
        public int? PersonID = null;
        public int? CreatedUserID = null;
        public DateTime? CreatedDate = null;

        public clsPerson PersonInfo; 
         /// <summary>
         /// Class Mode To Access The Mode Of The Class
         /// </summary>
         /// <Add name = "AddNew" > If Mode Is Addnew That Means To Do Empty Object </Add>
        private enum enMode { AddNew = 1  , Update = 2 }
        enMode Mode; 

        private bool _AddNewDriver()
        {
            this.DriverID = ClsDriversDataAccess.AddNewDriver(this.PersonID.Value, this.CreatedUserID.Value, this.CreatedDate.Value);
            return (this.DriverID.Value > 0); 
        }
        private bool _UpdateDriver()
        {
            return ClsDriversDataAccess.UpdateDriver(this.DriverID.Value, this.PersonID.Value, this.CreatedUserID.Value, this.CreatedDate.Value); 
        }

        public ClsDrivers()
        {
            this.DriverID = null;
            this.PersonID = null;
            this.CreatedUserID = null;
            this.CreatedDate = null;
            this.PersonInfo = null; 
            Mode = enMode.AddNew; 
        }
        private ClsDrivers(int? driverID, int? personID, int? createdUserID, DateTime? createdDate)
        {
            this.DriverID = driverID;
            this.PersonID = personID;
            this.CreatedUserID = createdUserID;
            this.CreatedDate = createdDate;
            this.PersonInfo = clsPerson.FindByID(personID.Value);
            Mode = enMode.Update; 
        }

        public static DataTable GetAllDrivers()
        {
            return ClsDriversDataAccess.GetAllDrivers(); 
        }
        public static ClsDrivers Find(int PersonID)
        {
            int createdbyUserID = -1, driverID = -1;
            DateTime createdate = DateTime.Now; 

            if (ClsDriversDataAccess.FindDriver(ref driverID , PersonID , ref createdbyUserID , ref createdate))
            {
                return new ClsDrivers(driverID, PersonID, createdbyUserID, createdate); 
            }
            return null; 
        }
        public static ClsDrivers FindByDriverID(int DriverID)
        {
            int createdbyUserID = -1, PersonID = -1 ;
            DateTime createdate = DateTime.Now;

            if (ClsDriversDataAccess.Find(ref DriverID,ref PersonID, ref createdbyUserID, ref createdate))
            {
                return new ClsDrivers(DriverID, PersonID, createdbyUserID, createdate);
            }
            return null;
        }
        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew : 
                return _AddNewDriver();

                case enMode.Update: 
                return _UpdateDriver(); 
            }
             return false; 
        }

    }

}
