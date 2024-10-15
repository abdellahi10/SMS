using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_DataAccess
{
    public class ClsCustomerData
    {
        // All Methods Contain Stored Procedure

        public static bool GetCustomerInfoByID(int CustomerID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_GetCustomerInfoByID", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

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

        public static bool GetCustomerInfoByPersonID(int PersonID, ref int CustomerID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_GetCustomerInfoByPersonID", connection);
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

                    CustomerID = (int)reader["CustomerID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

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

        public static int AddNewCustomer(int PersonID, int CreatedByUserID,  DateTime CreatedDate)
        {
            //this function will return the new Customer ID if succeeded and -1 if not.
            int CustomerID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_AddNewCustomer", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            SqlParameter OutputParam = new SqlParameter("@NewCustomerID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(OutputParam);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

                CustomerID = (int)command.Parameters["@NewCustomerID"].Value;
            }

            catch (Exception)
            {
                // Here Person ID Shuld Be Equal -1
            }

            finally
            {
                connection.Close();
            }

            return CustomerID;

        }

        public static bool UpdateCustomer(int CustomerID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand("SP_UpdateCustomer", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CustomerID", CustomerID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);

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
        public static DataTable GetAllCustomers()
        {
            // Old Version
            /*
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
              @"Select 
                CustomerID,
                FullName = Trim(People.FirstName) +'  '+ Trim(People.LastName),
                case 
                When People.Gendor = 0 then 'ذكر' else 'انثى'
                end as Gendr,
				Convert(Varchar ,CreatedDate, 103) as CreatedDate
                from Customers
                join People on People.PersonID = Customers.PersonID;";

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

            return clsMainMethods.GetTableRecords("SP_GetAllCustomers");
        }

        //Reuseable
        public static bool DeleteCustomer(int CustomerID)
        {
            // Old Version
            /*
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete from Customers 
                                where CustomerID = @CustomerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

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

            return clsMainMethods.DeleteRecordByID("@CustomerID", CustomerID, "SP_DeleteCustomer");
        }

        //Reuseable
        public static bool IsCustomerExist(int CustomerID)
        {
            // Old Version
            /*
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT IsExist=1 FROM Customers WHERE CustomerID = @CustomerID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CustomerID", CustomerID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsExist = reader.HasRows;

                reader.Close();
            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                IsExist = false;
            }
            finally
            {
                connection.Close();
            }

            return IsExist;
            */

            return clsMainMethods.CheckIsRecordExists("@CustomerID", CustomerID, "SP_IsCustomerExist");
        }

        //Reuseable
        public static bool IsThisPersonCustomer(int PersonID)
        {
            // Old Version
            /*
            bool IsExist = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT IsExist=1 FROM Customers WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                IsExist = reader.HasRows;

                reader.Close();
            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                IsExist = false;
            }
            finally
            {
                connection.Close();
            }

            return IsExist;
            */

            return clsMainMethods.CheckIsRecordExists("@PersonID", PersonID, "SP_IsPersonCustomer");
        }

    }

}
