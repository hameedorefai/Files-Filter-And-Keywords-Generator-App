using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    static public class clsCourseData
    {


        static public int AddNewCourse(string CourseName, int CourseNo, string CoursePath)
        {
            int CourseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Courses (CourseName , CourseNumber,CoursePath )
                             VALUES (@CourseName,@CourseNumber,@CoursePath);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseName", CourseName);
            command.Parameters.AddWithValue("@CourseNumber", CourseNo);
            command.Parameters.AddWithValue("@CoursePath", CoursePath);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    CourseID = insertedID;
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

            return CourseID;
        }

        static public bool GetCoursesInfoByCourseID(int CourseID, ref string CourseName, ref int CourseNo, ref string CoursePath)
        {

            bool Succeed = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Courses where CourseID = @CourseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseID", CourseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CourseName = reader["CourseName"].ToString();
                    CoursePath = reader["CoursePath"].ToString();
                    CourseNo = (int)reader["CourseNumber"];
                    Succeed = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Succeed;
        }
        static public bool GetCoursesInfoByCourseNo(int CourseNo, ref int CourseID, ref string CourseName, ref string CoursePath)
        {

            bool Succeed = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Courses where CourseNo = @CourseNo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseNo", CourseNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CourseName = reader["CourseName"].ToString();
                    CoursePath = reader["CoursePath"].ToString();
                    CourseID = (int)reader["CourseID"];
                    Succeed = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Succeed;
        }
        static public DataTable GetAllCoursesInfo()
        {

            DataTable dtCourses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Courses";

            SqlCommand command = new SqlCommand(query, connection);


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
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCourses;
        }
        static public DataTable GetAllNotCheckedCoursesInfo()
        {

            DataTable dtCourses = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "  select * from Courses where HasChecked = 0;";

            SqlCommand command = new SqlCommand(query, connection);


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
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dtCourses;
        }

        static public bool GetCoursePathByCourseID(int CourseID, ref string CoursePath)
        {
            bool Succeed = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT CoursePath FROM Courses where CourseID = @CourseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseID", CourseID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CoursePath = reader["CoursePath"].ToString();
                    Succeed = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return Succeed;
        }
        static public bool AddNewPathForCourseID(int CourseID, string CoursePath)
        {

            bool Succeed = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Courses
                            SET CoursePath = @CoursePath
                            WHERE CourseID = @CourseID;

";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseID", CourseID);
            command.Parameters.AddWithValue("@CoursePath", CoursePath);

            try
            {
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    Succeed = true;
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

            return Succeed;
        }

        static public bool AddNewPathForCourseNo(int CourseNo, string CoursePath)
        {

            bool Succeed = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Courses
                            SET CoursePath = @CoursePath
                            WHERE CourseNo = @CourseNo;

";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseNo", CourseNo);
            command.Parameters.AddWithValue("@CoursePath", CoursePath);

            try
            {
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    Succeed = true;
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

            return Succeed;
        }

        public static bool DeleteCourse(int CourseID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete Courses 
                                where CourseID = @CourseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CourseID", CourseID);

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


        static public bool SetCheckStatus(int CourseID,bool IsChecked)
        {
            int Checked = 0;
            if (IsChecked)
                Checked = 1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"update Courses
                                set HasChecked = @Checked
                                where courseid = @CourseID;
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseID", CourseID);
            command.Parameters.AddWithValue("@Checked", Checked);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    connection.Close();
                    return true;
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

            return false;
        }

        static public bool HasChecked(int CourseID)
        {
            bool HasChecked = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "  select HasChecked from Courses where courseID = @CourseID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CourseID", CourseID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Boolean.TryParse(reader["HasChecked"].ToString(), out bool isChcked);
                    HasChecked = isChcked;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return HasChecked;
        }

    }
}
