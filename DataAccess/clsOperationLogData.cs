using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class clsOperationLogData
    {
        public static int CreateNewOperationLog(int CourseID, string FileName, DateTime OperationLogDate
                            ,string OperationStatus,string OperationType,string Details)
        {
            int OperationLogID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO OperationsLog (CourseID,OperationLogDate,FileName,OperationStatus,OperationType,Details)
                             VALUES (@CourseID, @OperationLogDate,@FileName,@OperationStatus,@OperationType,@Details);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseID", CourseID);
            command.Parameters.AddWithValue("@OperationLogDate", OperationLogDate);
            command.Parameters.AddWithValue("@FileName", FileName);
            command.Parameters.AddWithValue("@OperationStatus", OperationStatus);
            command.Parameters.AddWithValue("@OperationType", OperationType);
            command.Parameters.AddWithValue("@Details", Details);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    OperationLogID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

              return OperationLogID;
        }
    }
}
