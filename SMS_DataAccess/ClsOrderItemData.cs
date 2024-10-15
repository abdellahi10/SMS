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
    public class ClsOrderItemData
    {
        // All Methods Contain Stored Procedure

        public static bool GetOrderItemInfoByID(int ItemID,ref int OrderID, ref int ProductID, 
            ref int Quantity, ref double ItemPrice, ref double TotalAmount)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_GetOrderItemInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ItemID", ItemID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    OrderID = (int)reader["OrderID"];
                    ProductID = (int)reader["ProductID"];
                    Quantity = (int)reader["Quantity"];
                    ItemPrice = Convert.ToDouble(reader["ItemPrice"]);
                    TotalAmount = Convert.ToDouble(reader["TotalAmount"]);


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

        public static int AddNewItem(int OrderID, int ProductID, int Quantity,  double ItemPrice,  double TotalAmount)
        {
            //this function will return the newItem ID if succeeded and -1 if not.
            int ItemID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_AddNewItem", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OrderID", OrderID);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@ItemPrice", ItemPrice);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

            SqlParameter OutputParam = new SqlParameter("@NewItemID", SqlDbType.Int)
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
                ItemID = (int)command.Parameters["@NewItemID"].Value;
            }

            catch (Exception)
            {
                // Here Item ID Shuld Be Equal -1
            }

            finally
            {
                connection.Close();
            }

            return ItemID;
        }

        public static bool UpdateItem(int ItemID, int OrderID, int ProductID,int Quantity, double ItemPrice, double TotalAmount)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_UpdateItem", connection);
            command.CommandType = CommandType.StoredProcedure;


            command.Parameters.AddWithValue("@ItemID", ItemID);
            command.Parameters.AddWithValue("@OrderID", OrderID);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@ItemPrice", ItemPrice);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);

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
        }

        public static int[] GetMainReoprt()
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand("SP_MainReport", connection);
            command.CommandType = CommandType.StoredProcedure;

            int[] MainReport = new int[7];

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found

                    MainReport[0] = (int)reader["PeopleCount"];
                    MainReport[1] = (int)reader["UsersCount"];
                    MainReport[2] = (int)reader["CustomersCount"];
                    MainReport[3] = (int)reader["ProductsCount"];
                    MainReport[4] = (int)reader["OrdersCount"];
                    MainReport[5] = (int)reader["SalesCount"];
                    MainReport[6] = (int)reader["SalesAmount"];

                }
                else
                {
                    // The record was not found
                    
                }

                reader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                connection.Close();
            }

            return MainReport;


        }

        //Reuseable
        public static DataTable GetAllItems()
        {
            // Old Version 
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * From OrderItems";

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

            return clsMainMethods.GetTableRecords("SP_GetAllItems");

        }

        //Reuseable
        public static DataTable GetAllSales()
        {
            // Old Version 
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * From Vsales";

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

            return clsMainMethods.GetTableRecords("SP_GetAllSales");
        }

        //Reuseable
        public static bool isItemIncludeThisProduct(int ProductID)
        {
            // Old Version 
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM OrderItems WHERE ProductID = @ProductID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ProductID", ProductID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch 
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

            return clsMainMethods.CheckIsRecordExists("@ProductID", ProductID, "SP_IsItemIncludeProduct");
        }
    }
}
