
using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLDClsLibraryDataAccesslyr
{
    public class ClsManageApplicaitionTypesDataAccess
    {


        public static DataTable GetAllApplicationTypes()
        {
            DataTable table = new DataTable(); 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from  ApplicationTypes";
            SqlCommand command = new SqlCommand(Query, connection); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                if(reader.HasRows)
                {
                    table.Load(reader);
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
            return table;

        }
        public static bool GetApplicationTypeByID(ref int ID ,ref string ApplicationType , ref Decimal ApplicationFees )
        {
            int IsFound = 0; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Select * from  ApplicationTypes
                            where ApplicationTypeID = @ID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                while(reader.Read())
                {
                    ID = (int)reader["ApplicationTypeID"];
                    ApplicationType = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (Decimal)reader["ApplicationFees"];
                    IsFound = 1; 
                }
                reader.Close(); 
            }
            catch(Exception ex)
            {
                return (IsFound > 0 );
            }
            finally { connection.Close();  }
            return (IsFound > 0);
        }
        public static bool UpdateApplicationType(int ID, string ApplicationTitle, decimal Fees)
        {
            int rowsAffected = 0; 
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
            {
                string query = @"UPDATE ApplicationTypes 
                         SET ApplicationTypeTitle = @ApplicationTitle, 
                             ApplicationFees = @Fees 
                         WHERE ApplicationTypeID = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@ApplicationTitle", ApplicationTitle);
                    command.Parameters.AddWithValue("@Fees", Fees); 
                    command.Parameters.AddWithValue("@ID", ID);

                    try
                    {
                        connection.Open(); 
                        rowsAffected = command.ExecuteNonQuery(); 
                    }
                    catch (SqlException ex)
                    {
                      
                        return false; 
                    }
                    finally 
                    {
                        connection.Close();
                    }
                }
            }
            return rowsAffected > 0; 
        }

    }
}
