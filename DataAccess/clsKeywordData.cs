<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class clsKeywordData
    {
        static public int GetAllKeywordsCount()
        {
            object result = null ;
            DataTable dtCourses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT count(*)FROM Keywords";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                 result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            int Count = -1;
            int.TryParse(result.ToString(), out Count);
            return Count;
        }

        static public DataTable GetAllKeywordsInfoForCourseID(int CourseID)
        {

            DataTable dtCourses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

          //  string query = "SELECT * FROM Keywords where CourseID = @CourseID";
            string query = "SELECT * FROM Keywords where CourseID = @CourseID and Status = 'activated'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseID", CourseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtCourses.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
              //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCourses;
        }

        static public List<string> GetAllKeywordsForCourseID(int CourseID)
        {

            List<string> Keywords = new List<string>();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Keyword FROM Keywords where Keywords.CourseID = @CourseID";
            //string query = "SELECT Keyword FROM Keywords where Keywords.CourseID = @CourseID and Status = 'activate'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseID", CourseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Keywords.Add((string)reader["Keyword"].ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //return Keywords.ToArr();
            return Keywords;
        }

        //static public int AddNewKeywordForCourseID(string keyword, int CourseID)
        //{
        //    int KeywordID = -1;

        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = @"INSERT INTO keywords (keyword , CourseID,Status)
        //                     VALUES (@keyword,@CourseID,'activated');
        //                     SELECT SCOPE_IDENTITY();";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@keyword", keyword);
        //    command.Parameters.AddWithValue("@CourseID", CourseID);


        //    try
        //    {
        //        if (count > 0)
        //        {
        //            // Keyword already exists, handle accordingly
        //            // For example, return or log a message
        //            return; // or handle the duplicate case
        //        }

        //        connection.Open();

        //        object result = command.ExecuteScalar();

        //        if (result != null && int.TryParse(result.ToString(), out int insertedID))
        //        {
        //            KeywordID = insertedID;
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine("Error: " + ex.Message);
        //    }

        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return KeywordID;
        //}
        static public int AddNewKeywordForCourseID(string keyword, int CourseID)
        {
            int KeywordID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();

                // Query to check if the keyword already exists
                string checkQuery = "SELECT COUNT(*) FROM keywords WHERE keyword = @keyword";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@keyword", keyword);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Keyword already exists, handle accordingly
                        ActivateKeyword(KeywordID);
                        return KeywordID;

                    }
                }

                // Query to insert a new keyword
                string insertQuery = @"INSERT INTO keywords (keyword, CourseID, Status)
                               VALUES (@keyword, @CourseID, 'activated');
                               SELECT SCOPE_IDENTITY();";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@keyword", keyword);
                    insertCommand.Parameters.AddWithValue("@CourseID", CourseID);

                    try
                    {
                        object result = insertCommand.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            KeywordID = insertedID;
                        }
                    }
                    catch (SqlException ex) when (ex.Number == 2627) // Unique key violation error code
                    {
                        // Handle the unique key constraint violation
                        Console.WriteLine("Keyword already exists.");
                    }
                    catch (Exception ex)
                    {
                        // Handle other possible exceptions
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return KeywordID;
        }

        static public int GetKeywordsCountForCourseID(int CourseID)
        {
            object result = null;
            DataTable dtCourses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

          //  string query = "SELECT count(Keyword) FROM Keywords where Keywords.CourseID = @CourseID";
            string query = "SELECT count(Keyword) FROM Keywords where Keywords.CourseID = @CourseID where Status = 'activated'";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            int Count = -1;
            int.TryParse(result.ToString(), out Count);
            return Count;
        }


        //we use this instead of deletion.
        public static bool DeactivateKeyword(int KeywordID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Keywords
                                SET Status = 'Deactivated'
	                               WHERE KeywordID = @KeywordID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@KeywordID", KeywordID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
        public static bool ActivateKeyword(int KeywordID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Keywords
                                SET Status = activated
	                               WHERE KeywordID = @KeywordID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@KeywordID", KeywordID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class clsKeywordData
    {
        static public int GetAllKeywordsCount()
        {
            object result = null ;
            DataTable dtCourses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT count(*)FROM Keywords";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                 result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            int Count = -1;
            int.TryParse(result.ToString(), out Count);
            return Count;
        }

        static public DataTable GetAllKeywordsInfoForCourseID(int CourseID)
        {

            DataTable dtCourses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

          //  string query = "SELECT * FROM Keywords where CourseID = @CourseID";
            string query = "SELECT * FROM Keywords where CourseID = @CourseID and Status = 'activated'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseID", CourseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dtCourses.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
              //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCourses;
        }

        static public List<string> GetAllKeywordsForCourseID(int CourseID)
        {

            List<string> Keywords = new List<string>();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            //string query = "SELECT Keyword FROM Keywords where Keywords.CourseID = @CourseID";
            string query = "SELECT Keyword FROM Keywords where Keywords.CourseID = @CourseID and Status = 'activate'";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseID", CourseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Keywords.Add((string)reader["Keyword"].ToString());

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //return Keywords.ToArr();
            return Keywords;
        }

        //static public int AddNewKeywordForCourseID(string keyword, int CourseID)
        //{
        //    int KeywordID = -1;

        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = @"INSERT INTO keywords (keyword , CourseID,Status)
        //                     VALUES (@keyword,@CourseID,'activated');
        //                     SELECT SCOPE_IDENTITY();";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@keyword", keyword);
        //    command.Parameters.AddWithValue("@CourseID", CourseID);


        //    try
        //    {
        //        if (count > 0)
        //        {
        //            // Keyword already exists, handle accordingly
        //            // For example, return or log a message
        //            return; // or handle the duplicate case
        //        }

        //        connection.Open();

        //        object result = command.ExecuteScalar();

        //        if (result != null && int.TryParse(result.ToString(), out int insertedID))
        //        {
        //            KeywordID = insertedID;
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine("Error: " + ex.Message);
        //    }

        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return KeywordID;
        //}
        static public int AddNewKeywordForCourseID(string keyword, int CourseID)
        {
            int KeywordID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                connection.Open();

                // Query to check if the keyword already exists
                string checkQuery = "SELECT COUNT(*) FROM keywords WHERE keyword = @keyword";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@keyword", keyword);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Keyword already exists, handle accordingly
                        ActivateKeyword(KeywordID);
                        return KeywordID;

                    }
                }

                // Query to insert a new keyword
                string insertQuery = @"INSERT INTO keywords (keyword, CourseID, Status)
                               VALUES (@keyword, @CourseID, 'activated');
                               SELECT SCOPE_IDENTITY();";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@keyword", keyword);
                    insertCommand.Parameters.AddWithValue("@CourseID", CourseID);

                    try
                    {
                        object result = insertCommand.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            KeywordID = insertedID;
                        }
                    }
                    catch (SqlException ex) when (ex.Number == 2627) // Unique key violation error code
                    {
                        // Handle the unique key constraint violation
                        Console.WriteLine("Keyword already exists.");
                    }
                    catch (Exception ex)
                    {
                        // Handle other possible exceptions
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return KeywordID;
        }

        static public int GetKeywordsCountForCourseID(int CourseID)
        {
            object result = null;
            DataTable dtCourses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

          //  string query = "SELECT count(Keyword) FROM Keywords where Keywords.CourseID = @CourseID";
            string query = "SELECT count(Keyword) FROM Keywords where Keywords.CourseID = @CourseID where Status = 'activated'";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //  Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            int Count = -1;
            int.TryParse(result.ToString(), out Count);
            return Count;
        }


        //we use this instead of deletion.
        public static bool DeactivateKeyword(int KeywordID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Keywords
                                SET Status = 'Deactivated'
	                               WHERE KeywordID = @KeywordID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@KeywordID", KeywordID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }
        public static bool ActivateKeyword(int KeywordID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Keywords
                                SET Status = activated
	                               WHERE KeywordID = @KeywordID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@KeywordID", KeywordID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

    }
}
>>>>>>> 9052b7e699351b2d3f6cbab3cd02523c129d58e9
