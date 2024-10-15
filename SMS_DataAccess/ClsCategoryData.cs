using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_DataAccess
{
    public class ClsCategoryData
    {
        // All Methods Contain Stored Procedure

        public static bool GetCategoryInfoByID(int CategoryID, ref string CategoryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_GetCategoryInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CategoryID", CategoryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CategoryName = (string)reader["CategoryName"];
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

        public static bool GetCategoryInfoByName(string CategoryName, ref int CategoryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_GetCategoryInfoByName", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CategoryName", CategoryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CategoryID = (int)reader["CategoryID"];

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

        public static int AddNewCategory(string CategoryName)
        {
            //this function will return the new Category ID if succeeded and -1 if not.
            int CategoryID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_AddNewCategory", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CategoryName", CategoryName);

            SqlParameter OutputParam = new SqlParameter("@NewCategoryID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(OutputParam);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                CategoryID = (int)command.Parameters["@NewCategoryID"].Value;
            }

            catch (Exception)
            {
                // Here Person ID Shuld Be Equal -1
            }

            finally
            {
                connection.Close();
            }

            return CategoryID;



        }

        public static bool UpdateCategory(int CategoryID, string CategoryName)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_UpdateCategory", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@CategoryName", CategoryName);
            
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                //return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        //Reuseable
        public static DataTable GetAllCategories()
        {
            // Old Version
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
              @"Select * From Categories";

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

            return clsMainMethods.GetTableRecords("SP_GetAllCategories");
        }

        //Reuseable
        public static bool DeleteCategory(int CategoryID)
        {
            // Old Version
            /*
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete From Categories 
                                where CategoryID = @CategoryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryID", CategoryID);

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

            return clsMainMethods.DeleteRecordByID("@CategoryID", CategoryID, "SP_DeleteCategory");
        }

        //Reuseable
        public static bool IsCategoryExist(int CategoryID)
        {
            // Old Version
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Categories WHERE CategoryID = @CategoryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryID", CategoryID);

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
                //isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
            */

            return clsMainMethods.CheckIsRecordExists("@CategoryID", CategoryID, "SP_IsCategoryExist");
        }

        //Reuseable
        public static bool IsCategoryExist(string CategoryName)
        {
            // Old Version
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Categories WHERE CategoryName = @CategoryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryName", CategoryName);

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

            return clsMainMethods.CheckIsRecordExists("@CategoryName", CategoryName, "SP_IsCategoryExistByName");
        }


    }


}
