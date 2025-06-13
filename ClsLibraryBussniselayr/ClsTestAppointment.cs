using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class ClsTestAppointment 
    {
        public int TestAppointmentID
        {
            get; set;
        }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedUserID { get; set; }
        public bool IsLocked { get; set; }
        enum enMode { AddNew  = 1 , Update = 2};
        private enMode Mode; 

        private bool _Update()
        {
            return ClsTestAppointmentsDataAccess.UpdateTestAppointment(this.TestTypeID,this.IsLocked ,  this.LocalDrivingLicenseID, this.AppointmentDate);
        }
        private bool _AddNew()
        {
            this.TestAppointmentID = ClsTestAppointmentsDataAccess.AddNewTestAppointment(this.TestTypeID,
                this.LocalDrivingLicenseID, this.AppointmentDate, this.PaidFees, this.CreatedUserID, this.IsLocked);
            return (this.TestAppointmentID > 0);
        }

        public ClsTestAppointment()
        {
            this.TestAppointmentID = 0;
            this.TestTypeID = 0;
            this.LocalDrivingLicenseID = 0;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedUserID = 0;
            this.IsLocked = false;
            Mode = enMode.AddNew; 
        }

        public ClsTestAppointment(int testAppointmentID, int testTypeID, int localDrivingLicenseID,
            DateTime appointmentDate, decimal paidFees, int createdUserID, bool isLocked)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseID = localDrivingLicenseID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedUserID = createdUserID;
            IsLocked = isLocked;
            Mode = enMode.Update;
        }

        public static DataTable GetAllTestAppointments()
        {
            return ClsTestAppointmentsDataAccess.GetAllTestAppointments();
        }
        public static ClsTestAppointment FindTestAppointment(int localDrivingLiceseID , int testTypeID)
        {
            int testAppointmentid = 0, createdUserID = 0;
            DateTime appointmentdate = DateTime.Now;
            decimal paidfees = 0; bool Islocked = false; 
            if(ClsTestAppointmentsDataAccess.GetTestAppointment(ref testAppointmentid , ref testTypeID , ref localDrivingLiceseID , 
                ref appointmentdate , ref paidfees , ref createdUserID , ref Islocked))
            {
                return new ClsTestAppointment(testAppointmentid, testTypeID, localDrivingLiceseID, appointmentdate, paidfees
                    , createdUserID, Islocked); 
            }
            return null; 
        }
        public static DataTable GetAllTestAppointments(int localDrivingLiceseID, int testTypeID)
        {
            DataTable table = new DataTable();
            table = ClsTestAppointmentsDataAccess.GetAllTestAppointments(localDrivingLiceseID, testTypeID);
            return table; 
        }

        public bool Update()
        {
            return ClsTestAppointmentsDataAccess.UpdateAppointment(this.TestTypeID, this.IsLocked, this.TestAppointmentID, this.AppointmentDate) ; 
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew: 
                if(_AddNew())
                {
                    return true; 
                }
                return false;
                //case enMode.Update:
                //return _Update(); 
            }
            return false; 
        }
    }
}
