using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_DataAccess
{
    public class ClsUserData 
    {
        // All Methods Contain Stored Procedure

        public static bool GetUserInfoByID(int UserID,ref int PersonID, ref string UserName, ref byte UserRole, ref string Password ,ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetUserInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

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
                    UserRole = (byte)reader["UserRole"];
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

        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName, ref byte UserRole, ref string Password ,ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_GetUserInfoByPersonID", connection);
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

                    UserID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    UserRole = (byte)reader["UserRole"];
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

        public static bool GetUserInfoByUserName(string UserName, ref int UserID, ref int PersonID, ref byte UserRole, ref string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetUserInfoByUserName", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    UserID = (int)reader["PersonID"];
                    PersonID = (int)reader["PersonID"];
                    UserRole = (byte)reader["UserRole"];
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

        public static int AddNewUser(int PersonID,  string UserName, byte UserRole, string Password, bool IsActive)
        {
            //this function will return the new User ID if succeeded and -1 if not.
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_AddNewUser", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@UserRole", UserRole);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            SqlParameter OutputParam = new SqlParameter("@NewUserID", SqlDbType.Int)
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
                UserID = (int)command.Parameters["@NewUserID"].Value;
            }

            catch (Exception)
            {
                // Here Person ID Shuld Be Equal -1
            }

            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, byte UserRole, string Password, bool IsActive)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_UpdateUser", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@UserRole", UserRole);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
               // return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        //Reuseable
        public static DataTable GetAllUsers()
        {
            // Old Version
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetAllUsers", connection);
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
             return clsMainMethods.GetTableRecords("SP_GetAllUsers");
        }

        //Reuseable
        public static bool DeleteUser(int UserID)
        {
            // Old Version
            /*
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_DeleteUser", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@UserID", UserID);

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

           return clsMainMethods.DeleteRecordByID("@UserID", UserID, "SP_DeleteUser");
        }

        //Reuseable
        public static bool IsUserExist(int UserID)
        {
            // Old Version
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_IsUserExist", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@UserID", UserID);

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
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
            */

            return clsMainMethods.CheckIsRecordExists("@UserID", UserID, "SP_IsUserExist");

        }

        //Reuseable
        public static bool IsPersonUser(int PersonID)
        {
            // Old Version
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_IsPersonUser", connection);
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
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
            */
            return clsMainMethods.CheckIsRecordExists("@PersonID", PersonID, "SP_IsPersonUser");
        }

        //Reuseable
        public static bool IsUserExist(string UserName)
        {
            // Old Version
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_IsUserExistByName", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@UserName", UserName);

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
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
            */

            return clsMainMethods.CheckIsRecordExists("@UserName", UserName, "SP_IsUserExistByName");
        }

        //Reuseable
        public static bool IsUserActive(int UserID)
        {
            // Old Version
            /*
            bool isActive = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_IsUserActive", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isActive = reader.HasRows;

                reader.Close();
            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isActive = false;
            }
            finally
            {
                connection.Close();
            }

            return isActive;
            */

            return clsMainMethods.CheckIsRecordExists("@UserID", UserID, "SP_IsUserActive");
        }

        public static bool GetUserInfoByUsernameAndPassword(ref int UserID, ref int PersonID, string UserName, 
            ref byte UserRole, string Password, ref bool IsActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_GetUserInfoByUsernameAndPassword", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    UserRole = Convert.ToByte(reader["UserRole"]);
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
            catch (Exception)
            {
                //clsLogData.Log("Application", ex.Message, EventLogEntryType.Error);

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
