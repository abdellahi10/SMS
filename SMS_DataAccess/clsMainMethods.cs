using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS_DataAccess
{
    internal class clsMainMethods
    {
        public static DataTable GetTableRecords(string StoredProcedureName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(StoredProcedureName, connection);
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




        }

        public static DataTable GetTableRecords(string ParameterName, int RecordID, string StoredProcedureName)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            SqlCommand command = new SqlCommand(StoredProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue(ParameterName, RecordID);


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
        }

        public static bool DeleteRecordByID(string ParameterName, int RecordID, string StoredProcedureName)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(StoredProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue(ParameterName, RecordID);

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
        }

        public static bool CheckIsRecordExists(string ParameterName, int RecordID, string StoredProcedureName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(StoredProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue(ParameterName, RecordID);

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

        }

        public static bool CheckIsRecordExists(string ParameterName, string StringValue, string StoredProcedureName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            SqlCommand command = new SqlCommand(StoredProcedureName, connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue(ParameterName, StringValue);

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

        }

    
    }
}
