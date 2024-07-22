using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class clsKeyword
    {
        int KeywordID { get; set; }
        string Keyword { get; set; }
        int CourseID { get; set; }


        //public clsKeyword()
        //{
        //    KeywordID = -1;
        //    Keyword = "";
        //    CourseID = -1;
        //}

        public clsKeyword(int courseID)
        {
            KeywordID = -1;
            Keyword = "";
            CourseID = courseID;
        }

        public clsKeyword(int keywordID, string keyword, int courseID)
        {
            KeywordID = keywordID;
            Keyword = keyword;
            CourseID = courseID;
        }

        static public int GetAllKeywordsCount()
        {
            return clsKeywordData.GetAllKeywordsCount();
        }

         public  List<string> GetAllKeywords()
        {
            return clsKeywordData.GetAllKeywordsForCourseID(CourseID);
        }

        public DataTable GetAllKeywordsDT()
        {
            //string[] keywords = { "مهارات التواصل في تكنولوجيا المعلومات", "مهارات تواصل", "مهارات التواصل", "مهارات_التواصل", "مهارات_تواصل" };//clsKeyword.GetAllKeywords(1);
            // return keywords;
            DataTable dataTable = clsKeywordData.GetAllKeywordsInfoForCourseID(CourseID);

            return dataTable;
        }
         public bool AddNewKeyword(string Keyword)
        {
            return (clsKeywordData.AddNewKeywordForCourseID(Keyword, CourseID) > 0) ;
        }

        private List<string> _GenerateKeywords()
        {
            clsCourse Course = clsCourse.Find(CourseID);
            
            return clsKeywordGenerator.GenerateKeywords(Course.CourseName, Course.CourseNo.ToString());
        }

        private bool _IsExist(string Keyword)
        {
            List<string> OldKeywords = GetAllKeywords();

          //  var Result = OldKeywords.Where(x=>x.Equals(Keyword)).ToList();  
            foreach(string OldKeyword in OldKeywords)
            {
                if (OldKeyword.Equals(Keyword))
                    return true;
            }
            return false;
        }
        public int GenerateKeywords()
        {
            int KeywordsCounter = 0;
            try
            {

                List<string> NewKeywords = _GenerateKeywords();
                foreach (string keyword in NewKeywords)
                {
                    if(!_IsExist(keyword))
                    {
                        AddNewKeyword(keyword);
                        KeywordsCounter++;

                    }
                }
            }
            catch(Exception ex)
            {
                KeywordsCounter = -1;
            }
            return KeywordsCounter;
        }

        static public int GetKeywordsCountForCourseID(int CourseID)
        {
            return clsCourse.GetKeywordsConutByCourseID(CourseID);
        }

        static public bool DeleteKeyword(int keywordID)
        {
            return clsKeywordData.DeactivateKeyword(keywordID);
        }
    }
}
