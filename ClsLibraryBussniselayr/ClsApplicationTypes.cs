using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class ClsApplicationTypes
    {
        public int ID { get; set; }
        public string ApplicationTitle { get; set; }
        public Decimal ApplicationFees { get; set; }
        
        public static DataTable GetAll()
        {
            return ClsManageApplicaitionTypesDataAccess.GetAllApplicationTypes();
        }

        public ClsApplicationTypes()
        {
            this.ID = -1;
            this.ApplicationTitle = string.Empty;
            this.ApplicationFees = -1;
        }
        private  ClsApplicationTypes(int ApplicationID, string ApplicationTitle, Decimal ApplicationFees)
        {
            this.ID = ApplicationID;
            this.ApplicationTitle = ApplicationTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static ClsApplicationTypes GetApplicationTypeByID(int ApplicationID)
        {
            string ApplicationTitle = "";
            Decimal ApplicationFees = 0;
            if (ClsManageApplicaitionTypesDataAccess.GetApplicationTypeByID(ref ApplicationID,ref ApplicationTitle, ref ApplicationFees) != null )
            {
                return new ClsApplicationTypes(ApplicationID, ApplicationTitle, ApplicationFees);
            }
            return null;

        }
        public  bool UpdateApplicationType()
        {
            return (ClsManageApplicaitionTypesDataAccess.
                UpdateApplicationType(this.ID, this.ApplicationTitle, this.ApplicationFees));
          
        }
    }
}
