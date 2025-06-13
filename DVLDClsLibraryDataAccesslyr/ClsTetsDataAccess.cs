using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDClsLibraryDataAccesslyr
{
    public class ClsTetsDataAccess
    {
      
        public static bool UpdateTest(int TestID  , bool TestResult, string Notes)
        {
            int RowAffictive = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"update Tests 
                            set TestResult = @TestResult, 
                            Notes          = @Notes 
                            where (TestID  = @TestID)";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                RowAffictive = command.ExecuteNonQuery();

            }
            catch (Exception exception) { return RowAffictive > 0; }
            finally { connection.Close(); }
            return RowAffictive > 0;
        }
        public static int AddNewTestAppointment(int TestAppointmentID, bool TestResult , string Notes ,int CreatedUserID)
        {
            int NewAppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"insert into Tests
                           values (@TestAppointmentID , @TestResult , @Notes , @CreatedUserID)
                           select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedUserID", CreatedUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null & int.TryParse(result.ToString(), out int NEWID))
                {
                    NewAppointmentID = NEWID;
                }
            }
            catch (Exception ex) { return NewAppointmentID; }
            finally { connection.Close(); }
            return NewAppointmentID;
        }
        public static int FindTest(int TestAppointmentID , ref int TestID , ref bool TestResult , ref string Notes , ref int CreatedUserID , int TestType)
        {
            int ID = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select  Tests.TestID , Tests.TestAppointmentID , Tests.TestResult , Tests.Notes , Tests.CreatedByUserID
                             FROM TestAppointments 
                             INNER JOIN Tests On Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             inner join TestTypes On TestTypes.TestTypeID = TestAppointments.TestTypeID
                             where (TestAppointments.TestAppointmentID =@TestAppointmentID and TestAppointments.TestTypeID = @TestType and TestResult = @TestResult)";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@TestType", TestType);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TestID             = (int)reader["TestID"];
                    TestAppointmentID  = (int)reader["TestAppointmentID"];
                    TestResult         = (bool)reader["TestResult"];
                    Notes              = (string)reader["Notes"];
                    CreatedUserID      = (int)reader["CreatedByUserID"];
                    ID = TestID;
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
            return ID;
        }
        public static int GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            int Count = 0; 
            string Query = @"SELECT PassedTestCount = count(TestTypeID)
                         FROM Tests INNER JOIN
                         TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
			  		 where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestResult=1"; 
            try
            {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
            {
                connection.Open();
           
                using (SqlCommand command = new SqlCommand(Query, connection))
                {
                   command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
                    object Result =   command.ExecuteScalar();  
                    if(Result != null && int.TryParse(Result.ToString() , out int NumberOfTest ))
                    {
                        Count = NumberOfTest; 
                    }
                }
            }

            } catch(Exception Ex)
            {
                return Count; 
            }
            return Count; 
        }
    }
}
