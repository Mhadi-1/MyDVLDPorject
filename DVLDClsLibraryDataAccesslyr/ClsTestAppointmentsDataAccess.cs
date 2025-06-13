using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDClsLibraryDataAccesslyr
{
    public class ClsTestAppointmentsDataAccess
    {

        public static DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from TestAppointments";
            SqlCommand command = new SqlCommand(Query, connection); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                if(reader.HasRows)
                {
                    dt.Load(reader); 
                }
            }catch (Exception Ex)
            {
                return null;
            }
            finally
            {
                connection.Close(); 
            }
            return dt; 
        }
        public static bool GetTestAppointment(ref int testAppointmentID, ref int testTypeID, ref int localDrivingLicenseID,
            ref DateTime appointmentDate,ref decimal paidFees, ref int createdUserID,ref bool isLocked)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from TestAppointments 
                           where (LocalDrivingLicenseApplicationID = @localDrivingLicenseID and
                                 TestTypeID = @testTypeID )";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@localDrivingLicenseID", localDrivingLicenseID);
            command.Parameters.AddWithValue("@testTypeID", testTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
               while (reader.Read())
               {
                    testAppointmentID     = (int)reader["TestAppointmentID"];
                    testTypeID            = (int)reader["TestTypeID"];
                    localDrivingLicenseID = (int)reader["LocalDrivingLicenseApplicationID"];
                    appointmentDate       = (DateTime)reader["AppointmentDate"];
                    paidFees              = (decimal)reader["PaidFees"];
                    createdUserID         = (int)reader["CreatedByUserID"];
                    isLocked              = (bool)reader["IsLocked"];
                    IsFound = true; 
               }
                
            }
            catch (Exception Ex)
            {
                return IsFound;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool UpdateTestAppointment(int testTypeID, bool IsLocked , int localDrivingLicenseID, DateTime newappointmentDate)
        {
            int RowAffictive = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"update TestAppointments 
                             set AppointmentDate =@newappointmentDate , 
                                 IsLocked        =@IsLocked
                             where (LocalDrivingLicenseApplicationID = @localDrivingLicenseID and
                             TestTypeID =@testTypeID )";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@newappointmentDate", newappointmentDate);
            command.Parameters.AddWithValue("@localDrivingLicenseID", localDrivingLicenseID);
            command.Parameters.AddWithValue("@testTypeID", testTypeID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            try
            {
                connection.Open(); 
                RowAffictive = command.ExecuteNonQuery();

            }
            catch (Exception exception) { return RowAffictive > 0; }
            finally { connection.Close(); }
            return RowAffictive > 0;
        }
        public static int AddNewTestAppointment(int testTypeID, int localDrivingLicenseID,
        DateTime appointmentDate, decimal paidFees, int createdUserID, bool isLocked)
        {
            int NewAppointmentID = -1;
            try
            {


                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    string Query = @"insert into TestAppointments
                           values (@testTypeID , @localDrivingLicenseID , @appointmentDate , @paidFees , @createdUserID , @isLocked)
                           select SCOPE_IDENTITY()";

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@testTypeID", testTypeID);
                        command.Parameters.AddWithValue("@localDrivingLicenseID", localDrivingLicenseID);
                        command.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                        command.Parameters.AddWithValue("@paidFees", paidFees);
                        command.Parameters.AddWithValue("@createdUserID", createdUserID);
                        command.Parameters.AddWithValue("@isLocked", isLocked);

                        object result = command.ExecuteScalar();

                        if (result != null & int.TryParse(result.ToString(), out int NEWID))
                        {
                            NewAppointmentID = NEWID;
                        }
                    }

                }
            }

            catch (Exception ex) { return NewAppointmentID; }
           
            return NewAppointmentID; 
        }
        public static DataTable GetAllTestAppointments(int localdrivingLicenseID , int TestTypeID)
        {
            DataTable dt = new DataTable();

            if (localdrivingLicenseID <= 0 || TestTypeID <= 0)
            {
                return dt; 
            }

            try
            {


                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    connection.Open();
                    string Query = @"select TestAppointmentID , AppointmentDate , PaidFees , TestTypes.TestTypeTitle , 
                             IsLocked
                             from TestAppointments
							 inner join TestTypes On TestTypes.TestTypeID = TestAppointments.TestTypeID
                             where (LocalDrivingLicenseApplicationID = @localdrivingLicenseID and 
                                   TestAppointments.TestTypeID = @TestTypeID)";
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@localdrivingLicenseID", localdrivingLicenseID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }

                }
            }
            catch (Exception Ex)
            {
                return null;
            }
            
            return dt;
        }

        public static bool UpdateAppointment(int testTypeID, bool IsLocked, int TestAppointmentID, DateTime newappointmentDate)
        {
            int RowAffictive = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"update TestAppointments 
                             set AppointmentDate =@newappointmentDate , 
                                 IsLocked        =@IsLocked
                             where (TestAppointmentID = @TestAppointmentID and
                             TestTypeID =@testTypeID )";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@newappointmentDate", newappointmentDate);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@testTypeID", testTypeID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            try
            {
                connection.Open();
                RowAffictive = command.ExecuteNonQuery();

            }
            catch (Exception exception) { return RowAffictive > 0; }
            finally { connection.Close(); }
            return RowAffictive > 0;
        }

    }
}
