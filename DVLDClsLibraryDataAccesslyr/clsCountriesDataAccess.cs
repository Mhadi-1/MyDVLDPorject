
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDClsLibraryDataAccesslyr
{
    public class clsCountriesDataAccess
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Select * from Countries";
            SqlCommand command = new SqlCommand(Query, connection); 
            try
            {
              
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader(); 
                if(Reader.HasRows)
                {
                    dt.Load(Reader); 
                }
                Reader.Close(); 
            }
            catch (Exception Ex)
            {
                return null; 
            }
            finally { connection.Close(); ;  };
            return dt; 
        }

        public static int FindCountryID(string CountryName)
        {
            int FoundID = 0; 
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Select CountryID from Countries 
                             Where (CountryName = @CountryName)";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                object  Result =  command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString() , out int Res))
                {
                    FoundID = Res; 
                }
            }
            catch(Exception Ex )
            {
                return FoundID; 
            }
            finally { connection.Close();}

            return FoundID; 
        }
        public static string GetCountry(int ID)
        {
            string CountryName = string.Empty; 

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Select top 1 CountryName From Countries 
                             where CountryID = @ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID); 

            try
            {
                connection.Open();
               SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    CountryName = (string)reader["CountryName"]; 
                }
            }
            catch (Exception Ex)
            {
                
                return CountryName;
            }
            finally { connection.Close(); }

            return CountryName;
        }
    }
}
