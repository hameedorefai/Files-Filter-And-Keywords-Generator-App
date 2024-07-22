using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class clsCourse
    {

        public int CourseID { get; set; }
        public int CourseNo { get; set; }
        public string CourseName { get; set; }
        public string CoursePath { get; set; }
        //    clsKeyword KeywordsInfo
        public clsKeyword Keyword;

        public clsCourse(int courseID, string courseName, int courseNo, string coursePath)
        {
            CourseID = courseID;
            CourseNo = courseNo;
            CourseName = courseName;
            CoursePath = coursePath;
            Keyword = new clsKeyword(CourseID);
        }

        public DataTable GetAllKeywordsDT()
        {
            return Keyword.GetAllKeywordsDT();
        }
        public List<string> GetAllKeywords()
        {
            return clsKeywordData.GetAllKeywordsForCourseID(this.CourseID);
        }

        static public DataTable GetAllCoursesInfo()
        {
            return clsCourseData.GetAllCoursesInfo();
        }
        static public DataTable GetAllNotCheckedCoursesInfo()
        {
            return clsCourseData.GetAllNotCheckedCoursesInfo();
        }

        static private bool _AddNewPathForCourseID(int CourseID, string CoursePath)
        {
            return clsCourseData.AddNewPathForCourseID(CourseID, CoursePath);
        }
        static public clsCourse Find(int CourseID)
        {
            int CourseNo = -1;
            string CourseName = "", CoursePath = "";
            if (clsCourseData.GetCoursesInfoByCourseID(CourseID, ref CourseName, ref CourseNo, ref CoursePath))
                return new clsCourse(CourseID, CourseName, CourseNo, CoursePath);
            return null;
        }
        static public clsCourse FindByCourseNo(int CourseNo)
        {
            int CourseID = -1;
            string CourseName = "", CoursePath = "";
            if (clsCourseData.GetCoursesInfoByCourseNo(CourseNo, ref CourseID, ref CourseName, ref CoursePath))
                return new clsCourse(CourseID, CourseName, CourseNo, CoursePath);
            return null;
        }

        static public string GetCoursePathByCourseID(int CourseID)
        {
            clsCourse Course = Find(CourseID);
            string CoursePath = "";

            if (Course != null && clsCourseData.GetCoursePathByCourseID(CourseID, ref CoursePath))
            {
                if (!Directory.Exists(CoursePath))
                {
                    CoursePath = clsPath.GetFilteredFolderPath() + Course.CourseNo;// + "\\AllFiles\\";

                    Directory.CreateDirectory(CoursePath);
                    _AddNewPathForCourseID(Course.CourseID, CoursePath);
                }
            }
            return CoursePath;
        }

        static private string CreateCoursePathByCourseNo(int CourseNo)
        {
            string CoursePath;
            CoursePath = clsPath.GetFilteredFolderPath() + CourseNo;

            Directory.CreateDirectory(CoursePath);
            return CoursePath;

        }
        static public int AddNewCourse(string CourseName,int CourseNo)
        {
            string CoursePath = CreateCoursePathByCourseNo(CourseNo);

            return clsCourseData.AddNewCourse(CourseName, CourseNo, CoursePath);
        }

        static public bool DeleteCourse(int CourseID)
        {
            return clsCourseData.DeleteCourse(CourseID);
        }

        static public int GetKeywordsConutByCourseID(int CourseID)
        {
            return clsKeyword.GetKeywordsCountForCourseID(CourseID);
        }

         public bool SetCheckStatus(bool IsChecked)
        {
            return clsCourseData.SetCheckStatus(CourseID, IsChecked);
        }
        public bool HasChecked()
        {
            return clsCourseData.HasChecked(CourseID);
        }
    }
}
