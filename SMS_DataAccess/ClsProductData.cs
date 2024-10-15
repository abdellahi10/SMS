using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SMS_DataAccess
{
    public class ClsProductData
    {
        // All Methods Contain Stored Procedure

        public static bool GetProductInfoByID(int ProductID, ref int CategoryID,
            ref string ProductName,ref string Description, ref int QuantityStock, ref decimal Price, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetProductInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProductID", ProductID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CategoryID = (int)reader["CategoryID"];
                    ProductName = (string)reader["ProductName"];

                    //Description: allows null in database so we should handle null
                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = string.Empty;


                    QuantityStock = (int)reader["QuantityStock"];
                    Price =(decimal)(reader["Price"]);


                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = string.Empty;
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

        public static bool GetProductInfoByName(string ProductName, ref int ProductID, ref string Description, ref int CategoryID,
            ref int QuantityStock, ref decimal Price, ref string ImagePath)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetProductInfoByName", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProductName", ProductName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    ProductID = (int)reader["ProductID"];
                    CategoryID = (int)reader["CategoryID"];

                    //Description: allows null in database so we should handle null
                    if (reader["Description"] != DBNull.Value)
                        Description = (string)reader["Description"];
                    else
                        Description = string.Empty;

                    QuantityStock = (int)reader["QuantityStock"];
                    Price = (decimal)(reader["Price"]);

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = string.Empty;
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

        public static int AddNewProduct(int CategoryID, string ProductName, string Description, int QuantityStock, decimal Price, string ImagePath)
        {
            //this function will return the new Product ID if succeeded and -1 if not.
            int ProductID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_AddNewProduct", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Add Parameters
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@ProductName", ProductName);

            if (Description != "" && Description != null)
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", System.DBNull.Value);

            command.Parameters.AddWithValue("@QuantityStock", QuantityStock);
            command.Parameters.AddWithValue("@Price", Price);


            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            SqlParameter OutputParam = new SqlParameter("@NewProductID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(OutputParam);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                // Retrive the ID of the New Person
                ProductID = (int)command.Parameters["@NewProductID"].Value;
            }

            catch (Exception)
            {
                // Log It Later
            }

            finally
            {
                connection.Close();
            }

            return ProductID;
        }

        public static bool UpdateProduct(int ProductID, int CategoryID,
             string ProductName, string Description, int QuantityStock, decimal Price, string ImagePath)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_UpdateProduct", connection);
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@ProductName", ProductName);

            if (Description != "" && Description != null)
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", System.DBNull.Value);

            command.Parameters.AddWithValue("@QuantityStock", QuantityStock);
            command.Parameters.AddWithValue("@Price", Price);

          

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
        }

        //Reuseable
        public static DataTable GetAllProducts()
        {
            // Old Version
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetAllProducts", connection);
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

            return clsMainMethods.GetTableRecords("SP_GetAllProducts");

        }
       
        //Reuseable
        public static bool DeleteProduct(int ProductID)
        {
            // Old Version 
            /*
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_DeleteProduct", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProductID", ProductID);

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

            return clsMainMethods.DeleteRecordByID("@ProductID", ProductID, "SP_DeleteProduct");

        }

        //Reuseable
        public static bool IsProductExist(int ProductID)
        {
            // Old Version 
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_CheckProductExists", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProductID", ProductID);

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

            return clsMainMethods.CheckIsRecordExists("@ProductID", ProductID, "SP_CheckProductExists");
        }

        //Reuseable
        public static bool IsProductExist(string ProductName)
        {
            // Old Version 
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_CheckProductExistsByName", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProductName", ProductName);

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

           return clsMainMethods.CheckIsRecordExists("@ProductName", ProductName, "SP_CheckProductExistsByName");
        }

        //Reuseable
        public static bool isThisCategoryConnectedWithProduct(int CategoryID)
        {
            // Old Version 
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_CheckCategoryConnectedWithProduct", connection);
            command.CommandType = CommandType.StoredProcedure;
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
            }
            finally
            {
                connection.Close();
            }

            return isFound;
            */

            return clsMainMethods.CheckIsRecordExists("@CategoryID", CategoryID, "SP_CheckCategoryConnectedWithProduct");

        }
    }
}
