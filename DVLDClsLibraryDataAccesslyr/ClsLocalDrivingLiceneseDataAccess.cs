using MyDVLDPorject.genralClasess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDClsLibraryDataAccesslyr
{
    public class ClsLocalDrivingLiceneseDataAccess
    {

        public static bool IsHasALocalLicenes( ref int LocalDrivingLicenseApplicatiolnID ,ref  int PersonID , ref int licenseClassID , ref int applicationID)
        {
            int IsFound = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID ,
                 LocalDrivingLicenseApplications.ApplicationID , 
                 LicenseClasses.LicenseClassID
                 FROM LocalDrivingLicenseApplications INNER JOIN
                 Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                 LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
				 where (Applications.ApplicantPersonID  = @PersonID and LicenseClasses.LicenseClassID = @licenseClassID)
                ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    LocalDrivingLicenseApplicatiolnID = (int)reader["LocalDrivingLicenseApplicationID"];
                    applicationID     = (int)reader["ApplicationID"];
                    licenseClassID    = (int)reader["LicenseClassID"];
                    IsFound = 1; 
                }

            }
            catch (Exception Exp)
            {
                ClsProjectSettings.EventLogExption(Exp.Message, System.Diagnostics.EventLogEntryType.Information);
                return (IsFound > 0); 
            }
            finally
            {
                connection.Close();
            }
            return (IsFound > 0);
        }
        public static int AddNewLocalLiceneseApplication(int ApplicationID , int ClassLiceneID)
        {
            int Result = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Insert into LocalDrivingLicenseApplications 
                            values(@ApplicationID , @LicenseClassID) 
                            select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", ClassLiceneID);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar(); 
                if(obj !=null && int.TryParse(obj.ToString()  , out int Res ))
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
        public static DataTable GetAllLocalDrivingApplication()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"SELECT * FROM LocalDrivingLicenseApplications_View";
            SqlCommand command = new SqlCommand(Query, connection); 
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close(); 
            }
            catch(Exception Ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

            return dt;


        }
        public static bool DeleteLocalAppByApplicationID(int LDLAPPID)
        {
            int RowAffictive = 0; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"delete from LocalDrivingLicenseApplications
                            where LocalDrivingLicenseApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", LDLAPPID); 
            try
            {
                connection.Open();
                RowAffictive = command.ExecuteNonQuery();

            }
            catch(Exception Ex)
            {
                return RowAffictive > 0 ; 
            }
            finally
            {
                connection.Close(); 
            }
            return RowAffictive > 0;
        }
        public static int FindApplicationID(ref int ApplicationID ,ref int LicenceClassID)
        {
            int ID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from LocalDrivingLicenseApplications
                             where ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
               SqlDataReader reader =  command.ExecuteReader();
                while(reader.Read())
                {
                    ApplicationID  = (int)reader["ApplicationID"];
                    LicenceClassID = (int)reader["LicenseClassID"];
                    ID = (int)reader["LocalDrivingLicenseApplicationID"]; 
                }

            }
            catch (Exception Ex)
            {
                return ID;
            }
            finally
            {
                connection.Close();
            }
            return ID ;
        }
        public static bool FindLocalDrivingLicenese(int LocalDrivingLicenesID , ref int ApplicationID ,ref int ClassLicenesID)
        {
            int ID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from LocalDrivingLicenseApplications
                              where LocalDrivingLicenseApplicationID = @LocalDrivingLicenesID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenesID", LocalDrivingLicenesID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    ClassLicenesID = (int)reader["LicenseClassID"];
                    ID = (int)reader["LocalDrivingLicenseApplicationID"];
                }

            }
            catch (Exception Ex)
            {
                return ID > 0 ;
            }
            finally
            {
                connection.Close();
            }
            return ID > 0 ;
        }
        public static byte TotalTrial(int LocalApplicationID , int TestType)
        {
            byte TotalTrail = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"SELECT TotalTrialCount = Count(Tests.TestID )  FROM LocalDrivingLicenseApplications
                           inner Join TestAppointments On TestAppointments.LocalDrivingLicenseApplicationID =
                           LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                           INNER JOIN Tests On Tests.TestAppointmentID =
                           TestAppointments.TestAppointmentID
                           where(LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalApplicationID and 
                           TestAppointments.TestTypeID = @TestType )";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LocalApplicationID", LocalApplicationID);
            command.Parameters.AddWithValue("@TestType", TestType);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar(); 
                if(Result != null & byte.TryParse(Result.ToString() , out byte Count))
                {
                    TotalTrail = Count; 
                }
            }
            catch(Exception Ex)
            {
                return TotalTrail; 
            }
            finally
            {
                connection.Close();
            }
            return TotalTrail;
        }
    }
}
