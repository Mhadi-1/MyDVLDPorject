using DVLDClsLibraryDataAccesslyr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsLibraryBussniselayr
{
    public class clsCountries
    {
        public string Name { get; set; }
        public int ID { get; set;  }

        public clsCountries()
        {
            Name = string.Empty;
            ID = -1; 
        }
        private clsCountries(int countryID , string countryName)
        {
            Name = countryName;
            ID = countryID;
        }
        public static DataTable GetAllCountries()
        {
            return clsCountriesDataAccess.GetAllCountries(); 

        }
        public static clsCountries FindCountry(string CountryName)
        {
            int ID =  clsCountriesDataAccess.FindCountryID(CountryName); 
            if (ID > 0 )
            {
                return new clsCountries(ID, CountryName); 
            }
            return null;
        }
        public static int FindCountryID(string CountryName)
        {
            return clsCountriesDataAccess.FindCountryID(CountryName);
        } 
        public static string GetCountryName(int  countryID)
        {
            return clsCountriesDataAccess.GetCountry(countryID);
        }
        
        

    }
}
