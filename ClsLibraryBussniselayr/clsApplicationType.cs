using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class clsApplicationType
    {
        public int ApplicationTestID { get; set; }
        public string ApplicationTestTitle { get; set; }
        public string ApplicationTestDescription { get; set; }
        public decimal ApplicatiolnTestFees { get; set; }

        public clsApplicationType()
        {
            this.ApplicationTestID = -1;
            this.ApplicationTestTitle = string.Empty;
            this.ApplicationTestDescription = string.Empty;
            this.ApplicatiolnTestFees = 0; 
        }

        private clsApplicationType(int applicationTestID, string applicationTestTitle, string applicationTestDescription, decimal applicatiolnTestFees)
        {
            this.ApplicationTestID = applicationTestID;
            this.ApplicationTestTitle = applicationTestTitle;
            this.ApplicationTestDescription = applicationTestDescription;
            this.ApplicatiolnTestFees = applicatiolnTestFees;
        }

        public static DataTable GetAllData()
        {
            return ClsTestApplicationType.GetAll();
        }
        public static clsApplicationType GetApplicationTypeByID(int TestID)
        {
            string ApplicationTitle = "", ApplicationDescription = "";
            decimal ApplicationFees = 0; 
            if(ClsTestApplicationType.GetTestTypeByID(TestID , ref ApplicationTitle , ref ApplicationDescription, ref ApplicationFees))
            {
                return new clsApplicationType(TestID, ApplicationTitle, ApplicationDescription, ApplicationFees);
            }
            return null;
        }
        public bool Save()
        {
            return ClsTestApplicationType.UpdateTestType(this.ApplicationTestID , 
                this.ApplicationTestTitle , this.ApplicationTestDescription , this.ApplicatiolnTestFees);
        }

    }
}
