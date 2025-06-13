

using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLDClsLibraryDataAccesslyr
{
    public class ClsUserDataAccess
    {

        public static bool GetUser(ref int ID  , ref int PersonID , ref string userName , ref string PassWord , 
            ref bool IsAcctive )
        {
            bool IsFound = false; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select top 1 * from Users
                             where Users.UserName = @UserName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@userName", userName); 
            try
            {
                connection.Open();
               SqlDataReader reader =  command.ExecuteReader();
                while(reader.Read())
                {
                    ID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    userName = (string)reader["userName"];
                    PassWord = (string)reader["PassWord"];
                    IsAcctive = (System.Boolean)reader["IsActive"];
                    IsFound = true; 
                }
                reader.Close();
            }
            catch(Exception Ex)
            {
                return IsFound; 
            }
            finally
            {
                connection.Close(); 
            }
            return IsFound;
        }

        public static bool GetUserByUserID(int UserID, ref int PersonID, ref string userName, ref string PassWord,
           ref bool IsAcctive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select top 1 * from Users
                             where Users.UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    userName = (string)reader["userName"];
                    PassWord = (string)reader["PassWord"];
                    IsAcctive = (System.Boolean)reader["IsActive"];
                    IsFound = true;
                }
                reader.Close();
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
        public static bool GetUserbyPersonID(ref int UserID, ref int PersonID, ref string userName, ref string PassWord,
            ref bool IsAcctive)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from Users 
                           WHERE Users.PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    userName = (string)reader["userName"];
                    PassWord = (string)reader["PassWord"];
                    IsAcctive = (System.Boolean)reader["IsActive"];
                    IsFound = true;
                }
                reader.Close();
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
        public static DataTable GetAllUsers()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select * from UsersInfo";

            SqlCommand command = new SqlCommand(Query , connection); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    table.Load(reader);
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
            return table;
        }
        public static int FindUserIDByPersonID(int PersonID)
        {
            int UserID = 0; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Select  top 1 * from  Users 
                               Where Users.PersonID = @PersonID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader(); 
                while(reader.Read())
                {
                    
                    UserID = (int)reader["UserID"];
                }
                    reader.Close(); 
            }
            catch (Exception Ex )
            {
                return UserID; 
            }
            finally { connection.Close(); }
            return UserID; 
        }
        public static int AddNew(int Person , string UserName ,string PassWord , bool IsActive )
        {
            int IsAdded = 0; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"insert into Users 
                            Values (@Person , @UserName , @PassWord , @IsActive)
                            select SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Person", Person); 
            command.Parameters.AddWithValue("@UserName", UserName); 
            command.Parameters.AddWithValue("@PassWord", PassWord);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            try
            {
                connection.Open();
                object RowActiffed = command.ExecuteScalar(); 

                if(RowActiffed != null && int.TryParse(RowActiffed.ToString() , out int UserID))
                {
                    IsAdded = UserID; 
                }

            }
            catch (Exception Ex )
            {
                return IsAdded; 
            }
            finally
            {
                connection.Close(); 
            }
            return IsAdded; 
        }
        public static bool CheckuserByUserName(string Name)
        {
            int IsFound = 0; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"select top 1 * from Users  
                                where username = @Name";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Name", Name); 
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    IsFound = 1;
                    reader.Close();
                }
            }
            catch(Exception Ex)
            {
                return (IsFound > 0 );
            }
            finally { connection.Close(); };
            return (IsFound > 0); 

        }
        public static bool Update(int ID, string UserName, string PassWord, bool IsActive)
        {
            int RowAffcitve = 0; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Update users 
                            SET UserName = @UserName , 
                               PassWord = @PassWord , 
                               IsActive = @IsActive 
                              Where UserID = @UserID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserName", UserName); 
            command.Parameters.AddWithValue("@PassWord", PassWord); 
            command.Parameters.AddWithValue("@IsActive", IsActive); 
            command.Parameters.AddWithValue("@UserID", ID);
            try
            {
                connection.Open();
                RowAffcitve = command.ExecuteNonQuery(); 
            }catch (Exception Exp)
            {
                return( RowAffcitve > 0); 
            }
            finally
            {
                connection.Close();
            }
            return (RowAffcitve > 0);


        }

        public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
        ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());

            string query = "SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];


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

    }
}
