using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class ClsTests
    {
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedUserID { get; set; }

        enum enMode { AddNew = 1 , Update = 2 };
        enMode Mode; 

        private bool _AddNew ()
        {
            this.TestID = ClsTetsDataAccess.AddNewTestAppointment(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedUserID);
            return (this.TestID > 0); 
        }
        private bool _Update ()
        {
            return ClsTetsDataAccess.UpdateTest(this.TestID, this.TestResult, this.Notes); 
        }

        public ClsTests()
        {
            this.TestID = 0;
            this.TestAppointmentID = 0;
            this.TestResult = false;
            this.Notes = string.Empty;
            this.CreatedUserID = 0;
            Mode = enMode.AddNew; 
        }

        private ClsTests(int testID, int testAppointmentID, bool testResult, string notes, int createdUserID)
        {
            this.TestID = testID;
            this.TestAppointmentID = testAppointmentID;
            this.TestResult = testResult;
            this.Notes = notes;
            this.CreatedUserID = createdUserID;
            Mode = enMode.Update; 
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew: 
                    if(_AddNew()) {
                        return true; 
                    }
                    return false;
                case enMode.Update:
                    return _Update(); 
            }
            return false; 
        }

        public static ClsTests FindByTestAppointmentID(int TestAppointmentID, int TestType , bool testResult)
        {
            int testid = 0, createdbyuserid = 0;
            string note = "";  
            if(ClsTetsDataAccess.FindTest(TestAppointmentID , ref testid , ref testResult , ref note ,ref  createdbyuserid , TestType) > 0 )
            {
                return new ClsTests(testid, TestAppointmentID, testResult, note, createdbyuserid); 
            }
            return null; 

        }
        public static int GetTestPassedCount(int LocalDrivigLicenesID)
        {
            return ClsTetsDataAccess.GetPassedTestCount(LocalDrivigLicenesID); 
        }
    }
}
