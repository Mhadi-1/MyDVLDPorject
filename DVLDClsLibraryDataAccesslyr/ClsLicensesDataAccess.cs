using MyDVLDPorject.genralClasess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDClsLibraryDataAccesslyr
{
    public class ClsLicensesDataAccess
    {
        public static int AddNewLicense(int ApplicationID ,int DriverID, int LicenseClass ,
            DateTime IssueDate ,DateTime ExpirationDate ,string Notes ,
            decimal PaidFees , bool IsActive , byte IssueReason , int CreatedByUserID)
        {
            int ScopIDResult = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    string Query = @"INSERT INTO Licenses VALUES
                                     (@ApplicationID, @DriverID,
                                     @LicenseClass,@IssueDate,
                                     @ExpirationDate,@Notes,@PaidFees , 
                                     @IsActive , @IssueReason , 
                                     @CreatedByUserID)
                                     select SCOPE_IDENTITY()";
                    connection.Open(); 
                    using (SqlCommand Commaned = new SqlCommand(Query, connection))
                    {
                        Commaned.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        Commaned.Parameters.AddWithValue("@DriverID", DriverID);
                        Commaned.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                        Commaned.Parameters.AddWithValue("@IssueDate", IssueDate);
                        Commaned.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        Commaned.Parameters.AddWithValue("@Notes", Notes);
                        Commaned.Parameters.AddWithValue("@PaidFees", PaidFees);
                        Commaned.Parameters.AddWithValue("@IsActive", IsActive);
                        Commaned.Parameters.AddWithValue("@IssueReason", IssueReason);
                        Commaned.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        object Result = Commaned.ExecuteScalar();
                        if (Result != null && int.TryParse(Result.ToString(), out int ScopId))
                        {
                            ScopIDResult = ScopId;
                        }
                    }
                }

            }
            catch (Exception Ex)
            {
                ClsProjectSettings.EventLogExption(Ex.Message, System.Diagnostics.EventLogEntryType.Information);
                return (ScopIDResult);


            }
            return (ScopIDResult);
        }

        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
          ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
          ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());

            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    PaidFees = Convert.ToDecimal(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["DriverID"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetLicenseInfoByAppID(ref int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass,
         ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
         ref decimal PaidFees, ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());

            string query = "SELECT * FROM Licenses WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;
                    LicenseID = (int)reader["LicenseID"]; 
                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClass = (int)reader["LicenseClass"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];

                    PaidFees = Convert.ToDecimal(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    CreatedByUserID = (int)reader["DriverID"];


                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
           DateTime IssueDate, DateTime ExpirationDate, string Notes,
           decimal PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());

            string query = @"UPDATE Licenses
                           SET ApplicationID = @ApplicationID,
                              DriverID = @DriverID,
                              LicenseClass = @LicenseClass,
                              IssueDate = @IssueDate,
                              ExpirationDate = @ExpirationDate,
                              Notes = @Notes,
                              PaidFees = @PaidFees,
                              IsActive = @IsActive,
                              IssueReason = @IssueReason 
                         WHERE ( LicenseID = @LicenseID ) ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID); 
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllLicenses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());

            string query = "SELECT * FROM Licenses";

            SqlCommand command = new SqlCommand(query, connection);

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

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static DataTable GetDriverLicenses(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());

            string query = @"SELECT     
                           Licenses.LicenseID,
                           ApplicationID,
		                   LicenseClasses.ClassName, Licenses.IssueDate, 
		                   Licenses.ExpirationDate, Licenses.IsActive
                           FROM Licenses INNER JOIN
                                LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            where DriverID=@DriverID
                            Order By IsActive Desc, ExpirationDate Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

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

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }
    }


}
