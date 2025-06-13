using System;
using System.Configuration; 


namespace DVLDClsLibraryDataAccesslyr
{
    public  class clsDataAccessSettings
    {
       
        public static string GetConnectionString()
        {
            return "Server =. ; DataBase =DVLD ;User Id = sa ; PassWord = 123456";
        }

       
    }
}
