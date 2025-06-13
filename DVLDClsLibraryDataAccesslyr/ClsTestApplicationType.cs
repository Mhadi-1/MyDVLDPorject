using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDClsLibraryDataAccesslyr
{
    static public class  ClsTestApplicationType
    {
        public static DataTable GetAll()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Select * from TestTypes";
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
        public static bool GetTestTypeByID(int TestID , ref string TestTypsTitle , ref string TestTypsDescription  , ref decimal TestTypeFees)
        {
            bool IsFound = false; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Select * from TestTypes 
                             Where TestTypeID = @TestID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestID", TestID); 
            try
            {
                connection.Open();
               SqlDataReader reader =  command.ExecuteReader();
                while(reader.Read())
                {
                    TestID = (int)reader["TestTypeID"];
                    TestTypsTitle = (string)reader["TestTypeTitle"];
                    TestTypsDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (Decimal)reader["TestTypeFees"];
                    IsFound = reader.HasRows;
                }
                reader.Close();
            }
            catch(Exception Exp)
            {
                return (IsFound );
            }
            finally
            {
                connection.Close(); 
            }
            return (IsFound);
        }
        public static bool UpdateTestType(int TestID, string Title, string Description,  decimal Fees)
        {
            int RowAffict = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Update TestTypes 
                             Set TestTypeTitle = @Title, 
                                 TestTypeDescription = @Description, 
                                 TestTypeFees = @Fees  
                           where TestTypeID = @TestID"; 
            SqlCommand command = new SqlCommand(Query , connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);
            command.Parameters.AddWithValue("@TestID", TestID);

            try 
            {
                connection.Open();
                RowAffict = command.ExecuteNonQuery();

            }catch(Exception Ex)
            {
                return (RowAffict > 0);
            }
            finally
            {
                connection.Close();
            }
            return (RowAffict > 0);
        }
    }
}
