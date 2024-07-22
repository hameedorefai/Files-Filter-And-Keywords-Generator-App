//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace BusinessLogic
//{
//    static public class clsKeywordGenerator
//    {
//        public static List<string> GenerateKeywords(string courseName, string courseNumber)
//        {

//            List<string> Keywords = new List<string>();
//            List<string> Output = new List<string>();
//            int NumberInCourseName = _GetNumberInCourseName(courseName);


//            if (ContainsArabic(courseName))
//            {
//                // Split Course name and take the firs 2 words only.
//                string[] words = courseName.Split(' ');
//                string word1 = words[0];
//                string word2 = words.Length > 1 ? words[1] : "";
//                //  if (NumberInCourseName != -1)
//                // {
//                //     word2 = word2 + NumberfInCourseName.ToString();
//                // }

//                if (word2 != "")
//                {
//                    _GenerateForDoubleWords(ref Keywords, word1, word2, NumberInCourseName);
//                }
//                else
//                {
//                    _GenerateForSingleWord(ref Keywords, word1, NumberInCourseName);
//                }
//            }

//            //Keywords.Add(courseName);
//            Keywords.Insert(0, courseName);

//            Keywords = RemoveDoublicatedKeywords(Keywords);

//            if (NumberInCourseName != -1)
//            {
//                List<string> TempKeywords = new List<string>();
//                string keyword = "";
//                foreach (string keyword1 in Keywords)
//                {
//                    TempKeywords.Add(keyword1);
//                    keyword = _RemoveNumberInKeyword(keyword1);
//                    keyword = keyword.Trim();
//                    TempKeywords.Add(keyword + NumberInCourseName.ToString());
//                    TempKeywords.Add(keyword + " " + NumberInCourseName.ToString());
//                    TempKeywords.Add(keyword + " (" + NumberInCourseName.ToString() + ")");
//                    TempKeywords.Add(keyword + "(" + NumberInCourseName.ToString() + ")");
//                    TempKeywords.Add(keyword + "-" + NumberInCourseName.ToString());
//                    TempKeywords.Add(keyword + " -" + NumberInCourseName.ToString());
//                    TempKeywords.Add(keyword + "_" + NumberInCourseName.ToString());
//                    TempKeywords.Add(keyword + " _" + NumberInCourseName.ToString());
//                    TempKeywords.Add(keyword + " _ " + NumberInCourseName.ToString());
//                    TempKeywords.Add(keyword + "_ " + NumberInCourseName.ToString());
//                }
//                Keywords = TempKeywords;
//            }



//            // add Keywords to Output 
//            Output.AddRange(Keywords);

//            foreach (string keyword in Keywords)
//            {
//                Output.Add(keyword.Replace(' ', '-'));
//                Output.Add(keyword.Replace(' ', '+'));
//                Output.Add(keyword.Replace(' ', '_'));
//            }


//            Output.Add(courseNumber);
//            Output.Add(_CleanCouresNo(courseNumber));

//            return Output;
//        }

//        private static string _RemoveHamza(string word)
//        {
//            if (word.EndsWith("ء"))
//            {
//                return word.Substring(0, word.Length - 1);
//            }
//            else
//            {
//                return word;
//            }
//        }

//        private static string _ReplaceTa(string word)
//        {
//          //  if (word.EndsWith("ة"))
//         //   {
//                return word.Replace('ة', 'ه');
//          //  }
//          //  else
//          //  {
//          //      return word;
//          //  }
//        }

//        private static string _AddAl(string word)
//        {
//            if (!word.StartsWith("ال"))
//            {
//                return "ال" + word;
//            }
//            else
//            {
//                return word;
//            }
//        }
//        private static string _RemoveAl(string word)
//        {
//            if (word.StartsWith("ال"))
//            {
//                return word.Substring(2);
//            }
//            else
//            {
//                return word;
//            }
//        }
//        private static int _GetNumberInCourseName(string CourseName)
//        {
//            foreach (char c in CourseName)
//            {
//                if (char.IsDigit(c))
//                {
//                    return int.Parse(c.ToString());
//                }
//            }
//            return -1;
//        }

//        public static List<string> RemoveDoublicatedKeywords(List<string> Keywords)
//        {
//            List<string> TrimmedKeywords = new List<string>();
//            Keywords = Keywords.Distinct().ToList();
//            foreach (string keyword in Keywords)
//            {
//                TrimmedKeywords.Add(keyword.Trim());
//            }
//            return TrimmedKeywords;
//        }
//        public static bool ContainsArabic(string CourseName)
//        {
//            Regex arabicPattern = new Regex(@"[\u0600-\u06FF\u0750-\u077F\u08A0-\u08FF\uFB50-\uFDFF\uFE70-\uFEFF]");
//            return arabicPattern.IsMatch(CourseName);
//        }

//        private static void _GenerateForDoubleWords(ref List<string> Keywords, string word1, string word2, int NumberInCourseName)
//        {
//            string numberInCourseName = "";
//            if (NumberInCourseName != -1) // if Number exists
//                numberInCourseName = " " + NumberInCourseName.ToString();

//            // اختبار وجود الهمزة في الكلمتين
//            string word1WithoutHamza = _RemoveHamza(word1);
//            string word2WithoutHamza = _RemoveHamza(word2);

//            // اختبار وجود التاء المربوطة في الكلمتين
//            string word1WithoutTa= _ReplaceTa(word1);
//            string word2WithoutTa = _ReplaceTa(word2);


//            // اختبار وجود ال التعريف في الكلمتين
//            string word1WithAl = _AddAl(word1);
//            string word2WithAl = (!word2.StartsWith("و")) ? _AddAl(word2) : word2;

//            // without al
//            string word1WithoutAl = _RemoveAl(word1);
//            string word2WithoutAl = _RemoveAl(word2);

//            // without al and hamza
//            string word1WithoutAlAndHamza = _RemoveHamza(_RemoveAl(word1));
//            string word2WithoutAlAndHamza = _RemoveHamza(_RemoveAl(word2));


//            // الكلمات الأصلية
//            Keywords.Add(word1 + " " + word2 + numberInCourseName);

//            // بدون همزة
//            Keywords.Add(word1WithoutHamza + " " + word2 + numberInCourseName);
//            Keywords.Add(word1 + " " + word2WithoutHamza + numberInCourseName);
//            Keywords.Add(word1WithoutHamza + " " + word2WithoutHamza + numberInCourseName);

//            // بإضافة ال التعريف
//            Keywords.Add(word1WithAl + " " + word2 + numberInCourseName);
//            Keywords.Add(word1 + " " + word2WithAl + numberInCourseName);
//            Keywords.Add(word1WithAl + " " + word2WithAl + numberInCourseName);

//            // بإضافة ال التعريف وبدون همزة
//            Keywords.Add(word1WithAl + " " + word2WithoutHamza + numberInCourseName);
//            Keywords.Add(word1WithoutHamza + " " + word2WithAl + numberInCourseName);

//            // بدون ال التعريف
//            Keywords.Add(word1WithoutAl + " " + word2 + numberInCourseName);
//            Keywords.Add(word1 + " " + word2WithoutAl + numberInCourseName);
//            Keywords.Add(word1WithoutAl + " " + word2WithoutAl + numberInCourseName);

//            // بدون ال التعريف وبدون همزة
//            Keywords.Add(word1WithoutAlAndHamza + " " + word2 + numberInCourseName);
//            Keywords.Add(word1 + " " + word2WithoutAlAndHamza + numberInCourseName);
//            Keywords.Add(word1WithoutAlAndHamza + " " + word2WithoutAlAndHamza + numberInCourseName);

//            // بإضافة ال التعريف وبدون ال التعريف
//            Keywords.Add(word1WithAl + " " + word2WithoutAl + numberInCourseName);
//            Keywords.Add(word1WithoutAl + " " + word2WithAl + numberInCourseName);

//            // بإضافة ال التعريف وبدون همزة وبدون ال التعريف
//            Keywords.Add(word1WithAl + " " + word2WithoutAlAndHamza + numberInCourseName);
//            Keywords.Add(word1WithoutAlAndHamza + " " + word2WithAl + numberInCourseName);

//            // جميع الاحتمالات الممكنة مع تداخل مختلف التعديلات
//            Keywords.Add(word1WithoutHamza + " " + word2WithoutAl + numberInCourseName);
//            Keywords.Add(word1WithoutAl + " " + word2WithoutHamza + numberInCourseName);
//            Keywords.Add(word1WithAl + " " + word2WithoutAlAndHamza + numberInCourseName);
//            Keywords.Add(word1WithoutAlAndHamza + " " + word2WithAl + numberInCourseName);
//            Keywords.Add(word1WithoutAl + " " + word2WithoutAlAndHamza + numberInCourseName);
//            Keywords.Add(word1WithoutAlAndHamza + " " + word2WithoutAl + numberInCourseName);
//            Keywords.Add(word1WithAl + " " + word2WithoutHamza + numberInCourseName);
//            Keywords.Add(word1WithoutHamza + " " + word2WithAl + numberInCourseName);

//            // الحالات مع التاء المربوطة cases with Ta.
//            Keywords.Add(word1WithoutTa + " " + word2 + numberInCourseName);
//            Keywords.Add(word1 + " " + word2WithoutTa + numberInCourseName);
//            Keywords.Add(word1WithoutTa + " " + word2WithoutTa + numberInCourseName);

//            Keywords.Add(word1WithoutHamza + " " + word2WithoutTa + numberInCourseName);
//            Keywords.Add(word1WithoutTa + " " + word2WithoutHamza + numberInCourseName);

//            Keywords.Add(word1WithAl + " " + word2WithoutTa + numberInCourseName);
//            Keywords.Add(word1WithoutTa + " " + word2WithAl + numberInCourseName);

//            Keywords.Add(word1WithoutAl + " " + word2WithoutTa + numberInCourseName);
//            Keywords.Add(word1WithoutTa + " " + word2WithoutAl + numberInCourseName);

//            Keywords.Add(word1WithoutAlAndHamza + " " + word2WithoutTa + numberInCourseName);
//            Keywords.Add(word1WithoutTa + " " + word2WithoutAlAndHamza + numberInCourseName);

//            Keywords.Add(word1WithoutTa + " " + word2WithoutAl + numberInCourseName);
//            Keywords.Add(word1WithoutAl + " " + word2WithoutTa + numberInCourseName);
//            Keywords.Add(word1WithAl + " " + word2WithoutTa + numberInCourseName);
//            Keywords.Add(word1WithoutTa + " " + word2WithAl + numberInCourseName);
//            Keywords.Add(word1WithoutHamza + " " + word2WithoutTa + numberInCourseName);
//            Keywords.Add(word1WithoutTa + " " + word2WithoutHamza + numberInCourseName);

//        }
//        private static void _GenerateForSingleWord(ref List<string> Keywords, string word1, int NumberInCourseName)
//        {
//            string numberInCourseName = "";
//            if (NumberInCourseName != -1) // if Number exists
//                numberInCourseName = " " + NumberInCourseName.ToString();

//            string word1WithoutHamza = _RemoveHamza(word1);

//            // اختبار وجود ال التعريف في الكلمتين
//            string word1WithAl = _AddAl(word1);

//            // without al
//            string word1WithoutAl = _RemoveAl(word1);

//            // without al and hamza
//            string word1WithoutAlAndHamza = _RemoveHamza(_RemoveAl(word1));

//            // الكلمات الأصلية
//            Keywords.Add(word1 + numberInCourseName);

//            // بدون همزة
//            Keywords.Add(word1WithoutHamza + numberInCourseName);

//            // بإضافة ال التعريف
//            Keywords.Add(word1WithAl + numberInCourseName);

//            // بإضافة ال التعريف وبدون همزة
//            Keywords.Add(word1WithAl + numberInCourseName);
//            Keywords.Add(word1WithoutHamza + numberInCourseName);

//            // بدون ال التعريف
//            Keywords.Add(word1WithoutAl + numberInCourseName);

//            // بدون ال التعريف وبدون همزة
//            Keywords.Add(word1WithoutAlAndHamza + numberInCourseName);
//        }
//        private static string _CleanCouresNo(string CourseNo)
//        {
//            if (CourseNo.Contains("/"))
//            { 
//            string[] Elements = CourseNo.Split('/');
//                return Elements[1];
//            }
//            return CourseNo;
//        }
//        private static string _RemoveNumberInKeyword(string keyword)
//        {
//            int index = 0;
//            foreach (char c in keyword)
//            {
//                if (char.IsDigit(c))
//                {
//                    keyword = keyword.Remove(index);
//                    break;
//                }
//                index++;
//            }
//            return keyword;
//        }


//        private static List<string> UnificationAlif(string courseName)
//        {
//            List<string> variations = new List<string>();

//            // Original variation
//            variations.Add(courseName);

//            // Variation replacing 'أ' with 'إ', 'آ', and 'ا'
//            variations.Add(courseName.Replace('أ', 'إ'));
//            variations.Add(courseName.Replace('أ', 'آ'));
//            variations.Add(courseName.Replace('أ', 'ا'));

//            // Variation replacing 'إ' with 'أ', 'آ', and 'ا'
//            variations.Add(courseName.Replace('إ', 'أ'));
//            variations.Add(courseName.Replace('إ', 'آ'));
//            variations.Add(courseName.Replace('إ', 'ا'));

//            // Variation replacing 'آ' with 'أ', 'إ', and 'ا'
//            variations.Add(courseName.Replace('آ', 'أ'));
//            variations.Add(courseName.Replace('آ', 'إ'));
//            variations.Add(courseName.Replace('آ', 'ا'));

//            // Variation replacing 'ا' with 'أ', 'إ', and 'آ'
//            variations.Add(courseName.Replace('ا', 'أ'));
//            variations.Add(courseName.Replace('ا', 'إ'));
//            variations.Add(courseName.Replace('ا', 'آ'));

//            return variations;
//        }



//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
    static public class clsKeywordGenerator
    {
        private static List<string> UnificationAlif(string courseName)
        {
            List<string> variations = new List<string>();

            // Original variation
            variations.Add(courseName);

            // Variation replacing 'أ' with 'إ', 'آ', and 'ا'
            variations.Add(courseName.Replace('أ', 'إ'));
            variations.Add(courseName.Replace('أ', 'آ'));
            variations.Add(courseName.Replace('أ', 'ا'));

            // Variation replacing 'إ' with 'أ', 'آ', and 'ا'
            variations.Add(courseName.Replace('إ', 'أ'));
            variations.Add(courseName.Replace('إ', 'آ'));
            variations.Add(courseName.Replace('إ', 'ا'));

            // Variation replacing 'آ' with 'أ', 'إ', and 'ا'
            variations.Add(courseName.Replace('آ', 'أ'));
            variations.Add(courseName.Replace('آ', 'إ'));
            variations.Add(courseName.Replace('آ', 'ا'));

            //// Variation replacing 'ا' with 'أ', 'إ', and 'آ'
            //variations.Add(courseName.Replace('ا', 'أ'));
            //variations.Add(courseName.Replace('ا', 'إ'));
            //variations.Add(courseName.Replace('ا', 'آ'));

            return variations;
        }

        public static List<string> GenerateKeywords(string courseName, string courseNumber)
        {
            List<string> Keywords = new List<string>();
            List<string> Output = new List<string>();
            int NumberInCourseName = _GetNumberInCourseName(courseName);

            if (ContainsArabic(courseName))
            {
                string[] words = courseName.Split(' ');
                string word1 = words[0];
                string word2 = words.Length > 1 ? words[1] : "";

                if (word2 != "")
                {
                    _GenerateForDoubleWords(ref Keywords, word1, word2, NumberInCourseName);
                }
                else
                {
                    _GenerateForSingleWord(ref Keywords, word1, NumberInCourseName);
                }
            }

            Keywords.Insert(0, courseName);
            Keywords = RemoveDoublicatedKeywords(Keywords);

            if (NumberInCourseName != -1)
            {
                List<string> TempKeywords = new List<string>();
                string keyword = "";
                foreach (string keyword1 in Keywords)
                {
                    TempKeywords.Add(keyword1);
                    keyword = _RemoveNumberInKeyword(keyword1);
                    keyword = keyword.Trim();
                    TempKeywords.Add(keyword + NumberInCourseName.ToString());
                    TempKeywords.Add(keyword + " " + NumberInCourseName.ToString());
                    TempKeywords.Add(keyword + " (" + NumberInCourseName.ToString() + ")");
                    TempKeywords.Add(keyword + "(" + NumberInCourseName.ToString() + ")");
                    TempKeywords.Add(keyword + "-" + NumberInCourseName.ToString());
                    TempKeywords.Add(keyword + " -" + NumberInCourseName.ToString());
                    TempKeywords.Add(keyword + "_" + NumberInCourseName.ToString());
                    TempKeywords.Add(keyword + " _" + NumberInCourseName.ToString());
                    TempKeywords.Add(keyword + " _ " + NumberInCourseName.ToString());
                    TempKeywords.Add(keyword + "_ " + NumberInCourseName.ToString());
                }
                Keywords = TempKeywords;
            }

            Output.AddRange(Keywords);

            foreach (string keyword in Keywords)
            {
                Output.Add(keyword.Replace(' ', '-'));
                Output.Add(keyword.Replace(' ', '+'));
                Output.Add(keyword.Replace(' ', '_'));
            }

            Output.Add(courseNumber);
            Output.Add(_CleanCouresNo(courseNumber));

            return Output;
        }

        private static string _RemoveHamza(string word)
        {
            if (word.EndsWith("ء"))
            {
                return word.Substring(0, word.Length - 1);
            }
            else
            {
                return word;
            }
        }

        private static string _ReplaceTa(string word)
        {
            return word.Replace('ة', 'ه');
        }

        private static string _AddAl(string word)
        {
            if (!word.StartsWith("ال"))
            {
                return "ال" + word;
            }
            else
            {
                return word;
            }
        }

        private static string _RemoveAl(string word)
        {
            if (word.StartsWith("ال"))
            {
                return word.Substring(2);
            }
            else
            {
                return word;
            }
        }

        private static int _GetNumberInCourseName(string CourseName)
        {
            foreach (char c in CourseName)
            {
                if (char.IsDigit(c))
                {
                    return int.Parse(c.ToString());
                }
            }
            return -1;
        }

        public static List<string> RemoveDoublicatedKeywords(List<string> Keywords)
        {
            List<string> TrimmedKeywords = new List<string>();
            Keywords = Keywords.Distinct().ToList();
            foreach (string keyword in Keywords)
            {
                TrimmedKeywords.Add(keyword.Trim());


            }
            return TrimmedKeywords;
        }

        public static bool ContainsArabic(string CourseName)
        {
            Regex arabicPattern = new Regex(@"[\u0600-\u06FF\u0750-\u077F\u08A0-\u08FF\uFB50-\uFDFF\uFE70-\uFEFF]");
            return arabicPattern.IsMatch(CourseName);
        }

        private static void _GenerateForDoubleWords(ref List<string> Keywords, string word1, string word2, int NumberInCourseName)
        {
            string numberInCourseName = "";
            if (NumberInCourseName != -1)
                numberInCourseName = " " + NumberInCourseName.ToString();

            string word1WithoutHamza = _RemoveHamza(word1);
            string word2WithoutHamza = _RemoveHamza(word2);

            string word1WithoutTa = _ReplaceTa(word1);
            string word2WithoutTa = _ReplaceTa(word2);

            string word1WithAl = _AddAl(word1);
            string word2WithAl = (!word2.StartsWith("و")) ? _AddAl(word2) : word2;

            string word1WithoutAl = _RemoveAl(word1);
            string word2WithoutAl = _RemoveAl(word2);

            string word1WithoutAlAndHamza = _RemoveHamza(_RemoveAl(word1));
            string word2WithoutAlAndHamza = _RemoveHamza(_RemoveAl(word2));

            Keywords.Add(word1 + " " + word2 + numberInCourseName);
            Keywords.Add(word1WithoutHamza + " " + word2 + numberInCourseName);
            Keywords.Add(word1 + " " + word2WithoutHamza + numberInCourseName);
            Keywords.Add(word1WithoutHamza + " " + word2WithoutHamza + numberInCourseName);

            Keywords.Add(word1WithAl + " " + word2 + numberInCourseName);
            Keywords.Add(word1 + " " + word2WithAl + numberInCourseName);
            Keywords.Add(word1WithAl + " " + word2WithAl + numberInCourseName);

            Keywords.Add(word1WithAl + " " + word2WithoutHamza + numberInCourseName);
            Keywords.Add(word1WithoutHamza + " " + word2WithAl + numberInCourseName);

            Keywords.Add(word1WithoutAl + " " + word2 + numberInCourseName);
            Keywords.Add(word1 + " " + word2WithoutAl + numberInCourseName);
            Keywords.Add(word1WithoutAl + " " + word2WithoutAl + numberInCourseName);

            Keywords.Add(word1WithoutAlAndHamza + " " + word2 + numberInCourseName);
            Keywords.Add(word1 + " " + word2WithoutAlAndHamza + numberInCourseName);
            Keywords.Add(word1WithoutAlAndHamza + " " + word2WithoutAlAndHamza + numberInCourseName);

            Keywords.Add(word1WithAl + " " + word2WithoutAl + numberInCourseName);
            Keywords.Add(word1WithoutAl + " " + word2WithAl + numberInCourseName);

            Keywords.Add(word1WithAl + " " + word2WithoutAlAndHamza + numberInCourseName);
            Keywords.Add(word1WithoutAlAndHamza + " " + word2WithAl + numberInCourseName);

            Keywords.Add(word1WithoutHamza + " " + word2WithoutAl + numberInCourseName);
            Keywords.Add(word1WithoutAl + " " + word2WithoutHamza + numberInCourseName);

            Keywords.Add(word1WithoutTa + " " + word2 + numberInCourseName);
            Keywords.Add(word1 + " " + word2WithoutTa + numberInCourseName);
            Keywords.Add(word1WithoutTa + " " + word2WithoutTa + numberInCourseName);

            Keywords.Add(word1WithoutHamza + " " + word2WithoutTa + numberInCourseName);
            Keywords.Add(word1WithoutTa + " " + word2WithoutHamza + numberInCourseName);

            Keywords.Add(word1WithAl + " " + word2WithoutTa + numberInCourseName);
            Keywords.Add(word1WithoutTa + " " + word2WithAl + numberInCourseName);

            Keywords.Add(word1WithoutAl + " " + word2WithoutTa + numberInCourseName);
            Keywords.Add(word1WithoutTa + " " + word2WithoutAl + numberInCourseName);

            Keywords.Add(word1WithoutAlAndHamza + " " + word2WithoutTa + numberInCourseName);
            Keywords.Add(word1WithoutTa + " " + word2WithoutAlAndHamza + numberInCourseName);

            Keywords.Add(word1WithoutTa + " " + word2WithoutAl + numberInCourseName);
            Keywords.Add(word1WithoutAl + " " + word2WithoutTa + numberInCourseName);
            Keywords.Add(word1WithAl + " " + word2WithoutTa + numberInCourseName);
            Keywords.Add(word1WithoutTa + " " + word2WithAl + numberInCourseName);
            Keywords.Add(word1WithoutHamza + " " + word2WithoutTa + numberInCourseName);
            Keywords.Add(word1WithoutTa + " " + word2WithoutHamza + numberInCourseName);







            Keywords.AddRange(UnificationAlif(word1 + " " + word2));
        
        
        
        
        
        
        }

        private static void _GenerateForSingleWord(ref List<string> Keywords, string word1, int NumberInCourseName)
        {
            string numberInCourseName = "";
            if (NumberInCourseName != -1)
                numberInCourseName = " " + NumberInCourseName.ToString();

            string word1WithoutHamza = _RemoveHamza(word1);
            string word1WithAl = _AddAl(word1);
            string word1WithoutAl = _RemoveAl(word1);
            string word1WithoutAlAndHamza = _RemoveHamza(_RemoveAl(word1));

            Keywords.Add(word1 + numberInCourseName);
            Keywords.Add(word1WithoutHamza + numberInCourseName);
            Keywords.Add(word1WithAl + numberInCourseName);
            Keywords.Add(word1WithAl + numberInCourseName);
            Keywords.Add(word1WithoutHamza + numberInCourseName);
            Keywords.Add(word1WithoutAl + numberInCourseName);
            Keywords.Add(word1WithoutAlAndHamza + numberInCourseName);
        }

        private static string _CleanCouresNo(string CourseNo)
        {
            if (CourseNo.Contains("/"))
            {
                string[] Elements = CourseNo.Split('/');
                return Elements[1];
            }
            return CourseNo;
        }

        private static string _RemoveNumberInKeyword(string keyword)
        {
            int index = 0;
            foreach (char c in keyword)
            {
                if (char.IsDigit(c))
                {
                    keyword = keyword.Remove(index);
                    break;
                }
                index++;
            }
            return keyword;
        }
    }
}
