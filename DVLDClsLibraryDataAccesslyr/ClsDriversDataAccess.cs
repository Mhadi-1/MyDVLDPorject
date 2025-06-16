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
    public class ClsDriversDataAccess
    {

        public static bool FindDriver( ref int DriverID , int personID, ref int CreatedUserID,ref  DateTime CreatedDate)
        {
            bool IsFound = false; ;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    string Query = @"select * from Drivers
                                   where(Drivers.PersonID = personID )";
                    using (SqlCommand Commaned = new SqlCommand(Query, connection))
                    {
                        Commaned.Parameters.AddWithValue("@personID", personID);
                        
                        using(SqlDataReader reader = Commaned.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                DriverID = (int)reader["DriverID"];
                                personID = (int)reader["PersonID"];
                                CreatedUserID = (int)reader["CreatedByUserID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                                IsFound = true; 
                            }
                        }
                        
                    }
                }

            }
            catch (Exception Ex)
            {
                ClsProjectSettings.EventLogExption(Ex.Message, System.Diagnostics.EventLogEntryType.Information);
                return (IsFound);


            }
            return (IsFound);
        }
        public static int  AddNewDriver(int personID , int CreatedUserID ,  DateTime CreatedDate)
        {
            int ScopIDResult = 0;
            try
            {
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
            {
                string Query = @"insert into Drivers Values(@personID , @CreatedUserID , @CreatedDate)
                                 select  SCOPE_IDENTITY()";
                    connection.Open();
                using (SqlCommand Commaned = new SqlCommand(Query, connection))
                {
                    Commaned.Parameters.AddWithValue("@personID", personID);
                    Commaned.Parameters.AddWithValue("@CreatedUserID", CreatedUserID);
                    Commaned.Parameters.AddWithValue("@CreatedDate", CreatedDate);

                        object Result = Commaned.ExecuteScalar(); 
                        if(Result != null && int.TryParse(Result.ToString() , out int ScopId))
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
            return (ScopIDResult ); 
        }
        public static bool UpdateDriver(int DrivID , int personID, int CreatedUserID, DateTime CreatedDate)
        {
            int RowAffictive = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    string Query = @"update Drivers 
                                     set Drivers.PersonID = @personID , 
                                     Drivers.CreatedByUserID = @CreatedUserID , 
                                     Drivers.CreatedDate = @CreatedDate 
                                     where (DriverID = @DrivID)";

                    using (SqlCommand Commaned = new SqlCommand(Query, connection))
                    {
                        Commaned.Parameters.AddWithValue("@personID", personID);
                        Commaned.Parameters.AddWithValue("@CreatedUserID", CreatedUserID);
                        Commaned.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                        Commaned.Parameters.AddWithValue("@DrivID", DrivID);

                        RowAffictive = Commaned.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception Ex)
            {
                ClsProjectSettings.EventLogExption(Ex.Message, System.Diagnostics.EventLogEntryType.Information);
                return (RowAffictive > 0);


            }
            return (RowAffictive > 0);
        }
        public static bool Find(ref int DriverID, ref int personID, ref int CreatedUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false; ;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    string Query = @"select * from Drivers
                                   where(Drivers.DriverID = @DriverID )";
                    connection.Open();
                    using (SqlCommand Commaned = new SqlCommand(Query, connection))
                    {
                        Commaned.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader = Commaned.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DriverID = (int)reader["DriverID"];
                                personID = (int)reader["PersonID"];
                                CreatedUserID = (int)reader["CreatedByUserID"];
                                CreatedDate = (DateTime)reader["CreatedDate"];
                                IsFound = true;
                            }
                        }

                    }
                }

            }
            catch (Exception Ex)
            {
                ClsProjectSettings.EventLogExption(Ex.Message, System.Diagnostics.EventLogEntryType.Information);
                return (IsFound);


            }
            return (IsFound);
        }
        public static DataTable GetAllDrivers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());

            string query = "SELECT * from Drivers_View order by FullName";

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

    }
}
