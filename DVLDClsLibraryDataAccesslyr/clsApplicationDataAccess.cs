using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDClsLibraryDataAccesslyr
{

    public class clsApplicationDataAccess
    {
       

        public static int CreateApplication(int applicationpersonID, DateTime applicationDate,
            int applicationTypeID, int applicationStatus, DateTime lastAppicationDate,
            decimal paidFees, int createdUserID)
        {
            int Result = 0; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"insert into Applications 
                             VALUES (@applicationpersonID,@applicationDate,@applicationTypeID,
                             @applicationStatus,@lastAppicationDate,@paidFees,@createdUserID)
                             select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@applicationpersonID", applicationpersonID);
            command.Parameters.AddWithValue("@applicationDate", applicationDate);
            command.Parameters.AddWithValue("@applicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@applicationStatus", applicationStatus);
            command.Parameters.AddWithValue("@lastAppicationDate", lastAppicationDate);
            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@createdUserID", createdUserID);

            try
            {
                connection.Open();

                object obj = command.ExecuteScalar(); 

                if(obj != null && int.TryParse(obj.ToString() , out int Res))
                {
                    Result = Res; 
                }

            }
            catch(Exception Ex)
            {
                return Result; 
            }
            finally
            {
                connection.Close(); 
            }
            return Result;


        }

           public static bool FindApplicationByPersonID(int PersonID , ref int applicationID ,ref DateTime applicationDate,
            ref int applicationTypeID, ref int applicationStatus,  ref DateTime lastAppicationDate,
            ref decimal paidFees,ref int createdUserID)
           {
            int IsFound = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from  Applications 
                            where ApplicantPersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
               try
               {
                   connection.Open();
                   SqlDataReader reader = command.ExecuteReader();
                   while (reader.Read())
                   {
                       applicationID = (int)reader["ApplicationID"];
                       applicationDate = (DateTime)reader["ApplicationDate"];
                       applicationTypeID = (int)reader["ApplicationTypeID"];
                       applicationStatus = (byte)reader["ApplicationStatus"];
                       lastAppicationDate = (DateTime)reader["LastStatusDate"];
                       paidFees = (decimal)reader["PaidFees"];
                       createdUserID = (int)reader["CreatedByUserID"];
                       IsFound = 1;
                   }
                    reader.Close(); 
                 
               }
               catch (Exception Ex)
               {
                  return (IsFound > 0); 
               }
               finally
               {
                connection.Close();
               }
                return (IsFound > 0); 


           }

        public static bool FindApplication(ref int PersonID, int applicationID, ref DateTime applicationDate,
           ref int applicationTypeID, ref int applicationStatus, ref DateTime lastAppicationDate,
           ref decimal paidFees, ref int createdUserID)
        {
            int IsFound = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from  Applications 
                            where ApplicationID = @applicationID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@applicationID", applicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    applicationID = (int)reader["ApplicationID"];
                    PersonID = (int)reader["ApplicantPersonID"]; 
                    applicationDate = (DateTime)reader["ApplicationDate"];
                    applicationTypeID = (int)reader["ApplicationTypeID"];
                    applicationStatus = (byte)reader["ApplicationStatus"];
                    lastAppicationDate = (DateTime)reader["LastStatusDate"];
                    paidFees = (decimal)reader["PaidFees"];
                    createdUserID = (int)reader["CreatedByUserID"];
                    IsFound = 1;

                }
                reader.Close();

            }
            catch (Exception Ex)
            {
                return (IsFound > 0);
            }
            finally
            {
                connection.Close();
            }
            return (IsFound > 0);


        }

        public static int GetActiveApplicationIDBYClassID(int PersonID , int ApplicationTypeID , int ClassLicenesID)
         {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());

            string query = @"SELECT ActiveApplicationID = Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", ClassLicenesID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
              
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }
        public static bool DeleteApplicationByID(int ApplicationID)
        {
            int RowAffictive = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"delete from Applications
                            where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                connection.Open();
                RowAffictive = command.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                return RowAffictive > 0;
            }
            finally
            {
                connection.Close();
            }
            return RowAffictive > 0;
        }
        public static bool UpdateStatue(int ApplicationID , int NewStatus)
        {
            int RowAffictive = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Update Applications
                             Set ApplicationStatus = @NewStatus
                            where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);


            try
            {
                connection.Open();
                RowAffictive = command.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                return RowAffictive > 0;
            }
            finally
            {
                connection.Close();
            }
            return RowAffictive > 0;
        }
    }

    
   
}
