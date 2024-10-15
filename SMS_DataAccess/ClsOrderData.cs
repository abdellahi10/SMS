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
    public class ClsOrderData
    {
        // All Methods Contain Stored Procedure

        public static bool GetOrderInfoByID(int OrderID, ref int CustomerID, ref DateTime OrderDate, ref int OrderedByUserID, ref byte Status)
        {


            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_GetOrderInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OrderID", OrderID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    CustomerID = (int)reader["CustomerID"];
                    OrderDate = (DateTime)reader["OrderDate"];
                    OrderedByUserID = (int)reader["OrderedByUserID"];
                    Status = (byte)reader["Status"];


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

        public static int AddNewOrder(int CustomerID, DateTime OrderDate, int OrderedByUserID , byte Status)
        {
            //this function will return the new Order ID if succeeded and -1 if not.
            int OrderID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_AddNewOrder", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@OrderDate", OrderDate);
            command.Parameters.AddWithValue("@OrderedByUserID", OrderedByUserID);
            command.Parameters.AddWithValue("@Status", Status);

            SqlParameter OutputParam = new SqlParameter("@NewOrderID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(OutputParam);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                // Retrive the ID of the New Person
                OrderID = (int)command.Parameters["@NewOrderID"].Value;
            }

            catch (Exception)
            {
                // Here Product ID Shuld Be Equal -1
            }

            finally
            {
                connection.Close();
            }

            return OrderID;
        }

        public static bool UpdateOrder(int OrderID, int CustomerID, DateTime OrderDate, int OrderedByUserID, byte Status)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_UpdateOrder", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OrderID", OrderID);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@OrderDate", OrderDate);
            command.Parameters.AddWithValue("@OrderedByUserID", OrderedByUserID);
            command.Parameters.AddWithValue("@Status", Status);

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
        public static DataTable GetAllOrders()
        {
            // Old Version
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * From Orders Order by OrderDate Desc";

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

            return clsMainMethods.GetTableRecords("SP_GetAllOrders");
        }

        //Reuseable
        public static DataTable GetAllCustomerOrders(int CustomerID)
        {
            // Old Version
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Select * From Orders Where CustomerID = @CustomerID  Order by OrderDate Desc";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);


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

            return clsMainMethods.GetTableRecords("@CustomerID", CustomerID, "SP_GetAllCustomerOrders");

        }

        //Reuseable
        public static bool DeleteOrder(int OrderID)
        {
            // Old Version
            /*
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Orders 
                                where OrderID = @OrderID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderID", OrderID);

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

            return clsMainMethods.DeleteRecordByID("@OrderID", OrderID, "SP_DeleteOrder");
        }

        //Reuseable
        public static bool IsOrderExist(int OrderID)
        {
            // Old Version
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Orders WHERE OrderID = @OrderID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderID", OrderID);

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

            return clsMainMethods.CheckIsRecordExists("@OrderID", OrderID, "SP_IsOrderExist");
        }

        //Reuseable
        public static bool IsCustomerHasOrder(int CustomerID)
        {
            // Old Version
            /*
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Found=1 FROM Orders WHERE CustomerID = @CustomerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

            return clsMainMethods.CheckIsRecordExists("@CustomerID", CustomerID, "SP_IsCustomerHasOrder");
        }

    }
}
