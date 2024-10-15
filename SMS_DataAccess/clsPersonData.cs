using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_DataAccess
{
    public class clsPersonData
    {
        // All Methods Contain Stored Procedure

        public static bool GetPersonInfoByID(int PersonID, ref string FirstName, ref string LastName,
         ref short Gendor, ref string Phone, ref string Email, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetPersonInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Gendor = (byte)reader["Gendor"];
                    Phone = (string)reader["Phone"];


                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetPersonInfoByFirstName(string FirstName, ref int PersonID, ref string LastName,
              ref short Gendor, ref string Phone, ref string Email, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetPersonInfoByFirstName", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    LastName = (string)reader["LastName"];
                    Gendor = (byte)reader["Gendor"];
                    Phone = (string)reader["Phone"];


                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetPersonInfoByLastName(string LastName, ref int PersonID, ref string FirstName,
          ref short Gendor, ref string Phone, ref string Email, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetPersonInfoByLastName", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    Gendor = (byte)reader["Gendor"];
                    Phone = (string)reader["Phone"];


                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception)
            {

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
       
        public static int AddNewPerson(string FirstName, string LastName, short Gendor,
         string Phone, string Email, string ImagePath)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_AddnewPerson", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            SqlParameter OutputParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(OutputParam);

            try
            {
                // Excute 
                connection.Open();
                command.ExecuteNonQuery();

                // Retrive the ID of the New Person
                PersonID = (int)command.Parameters["@NewPersonID"].Value;
                // Console.WriteLine($"New Person ID: {PersonID}");

            }

            catch (Exception)
            {
                // Here Person ID Shuld Be Equal -1
            }

            finally
            {
                connection.Close();
            }

            return PersonID;


            //---------------------
            //Previous Version Code
            /*
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People (FirstName, LastName, Gendor,Phone, Email,ImagePath)
                             VALUES (@FirstName, @LastName,@Gendor,@Phone, @Email,@ImagePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception)
            {
                // Here Person ID Shuld Be Equal -1
            }

            finally
            {
                connection.Close();
            }

            return PersonID;
            */
            //---------------------

        }

        public static bool UpdatePerson(int PersonID, string FirstName, string LastName,
            short Gendor,  string Phone,  string Email, string ImagePath)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_UpdatePerson", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                // Log it Later;
            }
            finally
            {
                connection.Close();
            }

             return (rowsAffected > 0);

            //---------------------
            //Previous Version Code
            /*
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update  People  
                            set FirstName = @FirstName,
                                LastName = @LastName, 
                                Gendor=@Gendor,
                                Phone = @Phone,
                                Email = @Email, 
                                ImagePath =@ImagePath
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
            */
            //---------------------

        }

        //Reuseable
        public static DataTable GetAllPeople()
        {
            // Old Version
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetAllPeople", connection);
            command.CommandType = CommandType.StoredProcedure;

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
            catch (Exception)
            {
                //Shuld Be Error In ExecuteReader
            }
            finally
            {
                connection.Close();
            }

            return dt;
            */

            return clsMainMethods.GetTableRecords("SP_GetAllPeople");
        }

        //Reuseable
        public static bool DeletePerson(int PersonID)
        {
            // Old Version
            /*
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_DeletePerson", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
            */

            return clsMainMethods.DeleteRecordByID("@PersonID", PersonID, "SP_DeletePerson");

        }

        //Reuseable
        public static bool IsPersonExist(int PersonID)
        {
            // Old Version
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_CheckPersonExists", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                reader.Close();

            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
            */

            return clsMainMethods.CheckIsRecordExists("@PersonID", PersonID, "SP_CheckPersonExists");

        }


    }

}
