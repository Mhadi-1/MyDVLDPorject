using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DVLDClsLibraryDataAccesslyr
{
    public class clsPepoleDataAccess
    {

        public static DataTable GetAllPepole()
        {
            DataTable Dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = "select * from PeopleInfo_View_2";
            SqlCommand command = new SqlCommand(Query, connection); 

            try
            {
                connection.Open();
                SqlDataReader reader =  command.ExecuteReader(); 
               
                if(reader.HasRows)
                {
                    Dt.Load(reader); 
                }
                reader.Close(); 

            }catch(Exception Ex)
            {
                return null; 

            } finally { connection.Close(); }

            return Dt; 
        }

        public static int AddNew(string NationalNo , string FirstName , string SecondName , string ThirdName , string LastName, 
        DateTime DateOfBirth , int Gendor , string Address , string Phone , 
        string Email , int NationalityCountryID , string ImagePath)
        {
            int? PersonID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    connection.Open();

                    string Query = @"insert Into People(NationalNo ,FirstName ,
                            SecondName,ThirdName,LastName,DateOfBirth,Gendor,
                           Address,Phone,Email,NationalityCountryID,ImagePath) 

                           Values (@NationalNo ,@FirstName ,
                           @SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,
                           @Address,@Phone,@Email,@NationalityCountryID,@ImagePath)
                            Select SCOPE_IDENTITY()";

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);

                        object RowAffictive = command.ExecuteScalar();
                        if (RowAffictive != null && int.TryParse(RowAffictive.ToString(), out int ID))
                        {
                            PersonID = ID;
                        }
                    }

                }
            }
            catch (Exception Ex)
            {
                return PersonID ?? 0 ;
            }
           
            return PersonID ?? 0; 
        } 

        public static bool Update(int ID , string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
        DateTime DateOfBirth, int Gendor, string Address, string Phone,
        string Email, int NationalityCountryID, string ImagePath)
        {
            Nullable<int> RowAffictive = null;
            try
            {
                using (var connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {

                    string Query = @"UPDATE People
                           SET NationalNo = @NationalNo,
                               FirstName  = @FirstName,
                               SecondName = @SecondName,
                               ThirdName  = @ThirdName, 
                               LastName   = @LastName,
                               DateOfBirth= @DateOfBirth, 
                               Gendor     = @Gendor , 
                               Address    = @Address , 
                               Phone      = @Phone , 
                               Email      = @Email , 
                               NationalityCountryID=@NationalityCountryID, 
                               ImagePath  = @ImagePath
                              WHERE PersonID = @ID";
                    connection.Open();
                    using (var command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Gendor", Gendor);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                        command.Parameters.AddWithValue("@ID", ID);
                        RowAffictive = command.ExecuteNonQuery();
                       
                    }

                }
            
          
              
               
            }
            catch(Exception Ex)
            {
                return (RowAffictive.HasValue) ; 
            }
        
                return (RowAffictive.HasValue);
        }
        public static bool FindNationalNo(ref int ID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName,
        ref DateTime DateOfBirth, ref int Gendor, ref string Address, ref string Phone,
        ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {
            int? IsFound = null;
            try
            {
                using (var connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    string Query = $"select top 1 * from People where (People.NationalNo = @NationalNo)";
                    connection.Open();

                    using (var command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = (string)reader["ThirdName"];
                                LastName = (string)reader["LastName"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = (byte)reader["Gendor"];
                                Address = (string)reader["Address"];
                                Phone = (string)reader["Phone"];
                                Email = (string)reader["email"];
                                NationalityCountryID = (int)reader["NationalityCountryID"];
                                if (reader["imagePath"] != System.DBNull.Value)
                                    ImagePath = (string)reader["ImagePath"];
                                else
                                    ImagePath = string.Empty;
                                IsFound = 1;
                            }
                        }

                    }

                }


                  
            }
            catch (Exception Ex)
            {
                return (IsFound.HasValue);
            }
        
            return (IsFound.HasValue);

        }
        public static bool FindPerson(ref int ID  , ref string NationalNo , ref string FirstName ,
         ref string Second , ref string Third , ref string LastName ,ref DateTime dateOfBirth,
         ref int gendor,ref  string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath)
        {
            int ?  IsFind = null;

            try
            {


                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {

                    string Query = @"Select top 1 * from People 
                            where PersonID = @ID";

                    connection.Open();
                    using (SqlCommand Command = new SqlCommand(Query, connection))
                    {
                        Command.Parameters.AddWithValue("@ID", ID);
                        using (SqlDataReader reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                Second = (string)reader["SecondName"];
                                Third = (string)reader["ThirdName"];
                                LastName = (string)reader["LastName"];
                                dateOfBirth = (DateTime)reader["DateOfBirth"];
                                gendor = (byte)reader["Gendor"];
                                address = (string)reader["Address"];
                                phone = (string)reader["Phone"];
                                email = (string)reader["email"];
                                nationalityCountryID = (int)reader["NationalityCountryID"];
                                if (reader["imagePath"] != System.DBNull.Value)
                                    imagePath = (string)reader["ImagePath"];
                                else
                                    imagePath = string.Empty;
                                IsFind = 1;
                            }
                        }

                    }

                }

            }

            catch (Exception Ex)
            {
                return (IsFind.HasValue);
            }
            return (IsFind.HasValue); 
        }
        public static bool Delete(int PersonID)
        {
            int RowAffictive = 0; 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString());
            string Query = @"Delete From People Where(PersonID = @PersonID)";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", @PersonID);
            try
            {
                connection.Open();
                RowAffictive = command.ExecuteNonQuery(); 

            }catch(Exception Ex)
            {
                return( RowAffictive > 0) ; 
            }
            finally
            {
                connection.Close(); 
            }
            return (RowAffictive > 0);
        }
        public static bool IsExitNationNo(string NationalNo)
        {
            int ? IsFound = null;
            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    string Query = $"select top 1 * from People where (People.NationalNo = @NationalNo)";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@NationalNo", NationalNo);
                        object RowAfctive = command.ExecuteScalar();
                        if (RowAfctive != null && int.TryParse(RowAfctive.ToString(), out int Result))
                        {
                            IsFound = Result;
                        }
                    }
                }
            }

            catch (Exception Ex)
            {
                return (IsFound.HasValue);
            }
           
            return (IsFound.HasValue); 
        }

        public static bool FindByFirstName(ref int ID, ref string NationalNo, ref string FirstName,
        ref string Second, ref string Third, ref string LastName, ref DateTime dateOfBirth,
        ref int gendor, ref string address, ref string phone, ref string email, ref int nationalityCountryID, ref string imagePath)
        {
            int ? IsFind = null;
            try
            {

                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.GetConnectionString()))
                {
                    string Query = @"Select top 1 * from People 
                            where FirstName = @FirstName";
                    connection.Open();
                    using (SqlCommand Command = new SqlCommand(Query, connection))
                    {
                        Command.Parameters.AddWithValue("@FirstName", FirstName);
                        using (var reader = Command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ID = (int)reader["PersonID"];
                                NationalNo = (string)reader["NationalNo"];
                                FirstName = (string)reader["FirstName"];
                                Second = (string)reader["SecondName"];
                                Third = (string)reader["ThirdName"];
                                LastName = (string)reader["LastName"];
                                dateOfBirth = (DateTime)reader["DateOfBirth"];
                                gendor = (byte)reader["Gendor"];
                                address = (string)reader["Address"];
                                phone = (string)reader["Phone"];
                                email = (string)reader["email"];
                                nationalityCountryID = (int)reader["NationalityCountryID"];
                                if (reader["imagePath"] != System.DBNull.Value)
                                    imagePath = (string)reader["ImagePath"];
                                else
                                    imagePath = string.Empty;
                                IsFind = 1;
                            }

                        }
                    }

                }
            }
            catch (Exception Ex)
            {
                return (IsFind.HasValue);
            }

               return (IsFind.HasValue);
        }

    }
}
