using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class ClsLicenseClass
    {
        public int LicenseClassID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int DefultValiedityLength { get; set; }
        public decimal ClassFees { get; set; }

        public ClsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.ClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.MinimumAllowedAge = 0;
            this.DefultValiedityLength = 0;
            this.ClassFees = 0;
        }

        private ClsLicenseClass(int licenseClassID, string className,
            string classDescription, int minimumAllowedAge, int defultValiedityLength,
            decimal classFees)
        {
            this.LicenseClassID = licenseClassID;
            this.ClassName = className;
            this.ClassDescription = classDescription;
            this.MinimumAllowedAge = minimumAllowedAge;
            this.DefultValiedityLength = defultValiedityLength;
            this.ClassFees = classFees;
        }

        public static DataTable GetAll()
        {
            return clsLicenecsClassesDataAccess.GetAll(); 
        }

        public static ClsLicenseClass GetLicenseClass(int ID)
        {
            string className = "", classDescription = "";
            byte minimumAllowedAge = 0 , defultValiedityLength = 0;
            decimal classFees = 0;

            if (clsLicenecsClassesDataAccess.GetLicensClassByID(ID,ref className , ref classDescription
                ,ref  minimumAllowedAge ,ref defultValiedityLength ,ref classFees))
            {
                return new ClsLicenseClass(ID, className, classDescription, minimumAllowedAge, defultValiedityLength, classFees);
            }
            return null; 
        }
        public static ClsLicenseClass GetLicenseClass(string ClassName)
        {
            string classDescription = ""; byte minimumAllowedAge = 0 , defultValiedityLength = 0;
            int ID = 0;
            decimal classFees = 0;
            if(clsLicenecsClassesDataAccess.GetClassID(ref ID , ClassName , ref classDescription , ref minimumAllowedAge
                , ref defultValiedityLength ,ref classFees)  > 0)
            {
                return new ClsLicenseClass(ID, ClassName, classDescription, minimumAllowedAge, defultValiedityLength, classFees);
            }
            return null;
        }
    }
}
