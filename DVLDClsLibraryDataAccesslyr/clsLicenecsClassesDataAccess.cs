using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDClsLibraryDataAccesslyr
{
    public class clsLicenecsClassesDataAccess
    {
      

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from LicenseClasses";
            SqlCommand command = new SqlCommand(Query, connection); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                if(reader.HasRows)
                {
                    dt.Load(reader); 
                }
                reader.Close(); 
            }
            catch (Exception Ex)
            {
                return null; 
            }
            finally
            {
                connection.Close(); 
            }
            return dt;
        }
        public static bool GetLicensClassByID(int ID ,ref string className,
            ref string classDescription, ref byte minimumAllowedAge, ref byte defaultValidityLength,
            ref decimal classFees)
        {
            int IsFound = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"
                          select * from LicenseClasses
                          where LicenseClassID = @ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                while(reader.Read())
                {
                    ID = (int)reader["LicenseClassID"];
                    className = (string)reader["ClassName"];
                    classDescription = (string)reader["ClassDescription"];
                    minimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    defaultValidityLength = (byte)reader["DefaultValidityLength"];
                    classFees = (decimal)reader["classFees"];
                    IsFound = 1; 
                }
                reader.Close(); 
            }
            catch(Exception Ex)
            {
                return (IsFound > 0); 
            }
            finally
            {
                connection.Close();
            }
            return (IsFound > 0);
        }


        public static int GetClassID(ref int ID, string className,
            ref string classDescription, ref byte minimumAllowedAge, ref byte defaultValidityLength,
            ref decimal classFees)
        {
            int IsFound = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Select * from LicenseClasses 
                             Where ClassName = @ClassName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClassName", className);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ID = (int)reader["LicenseClassID"];
                    className = (string)reader["ClassName"];
                    classDescription = (string)reader["ClassDescription"];
                    minimumAllowedAge = (byte)reader["MinimumAllowedAge"];
                    defaultValidityLength = (byte)reader["DefaultValidityLength"];
                    classFees = (decimal)reader["classFees"];
                    IsFound = ID;
                }
                reader.Close();
            }
            catch (Exception Ex)
            {
                return ID;
            }
            finally
            {
                connection.Close();
            }
            return ID;

        }
    }
}
