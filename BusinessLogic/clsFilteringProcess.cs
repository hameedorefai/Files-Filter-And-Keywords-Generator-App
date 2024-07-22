using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class clsFilteringProcess
    {


        static public int FilterFiles()
        {
            int FilteredFilesCounter = 0;

            string SourceFolderPath = clsPath.GetSourceFolderPath();

            DataTable Courses = clsCourse.GetAllCoursesInfo();
            foreach (DataRow courseRow in Courses.Rows)
            {
                try
                {
                     int CourseID = Convert.ToInt32(courseRow["CourseID"]);
                    // int CourseID = 362;


                    string SubCourseFolderPath = clsCourse.GetCoursePathByCourseID(CourseID);
                    if (!Directory.Exists(SubCourseFolderPath))
                    {

                        Directory.CreateDirectory(SubCourseFolderPath);
                    }

                    var AllFiles = Directory.GetFiles(SourceFolderPath);
                    clsCourse Course = clsCourse.Find(CourseID);
                    List<string> keywords = Course.GetAllKeywords();
                    var filteredFiles = AllFiles.Where(file => keywords.Any(keyword => Path.GetFileName(file).IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0));




                    string fileName = "";
                    foreach (var file in filteredFiles)
                    {
                        try
                        {
                            fileName = Path.GetFileNameWithoutExtension(file);

                            File.Copy(file, Path.Combine(SubCourseFolderPath, fileName), true);



                            if (File.Exists(Path.Combine(SubCourseFolderPath, fileName)))
                            {
                                clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Succeed", "Adding Files");
                                FilteredFilesCounter++;
                            }
                            else
                            {
                                try
                                {
                                    throw new Exception("File does not exist: " + Path.Combine(SubCourseFolderPath, fileName));
                                }
                                catch (Exception ex)
                                {
                                    clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Failed", "Adding Files", ex.Message);
                                    if (FilteredFilesCounter == 0)
                                    {
                                        FilteredFilesCounter = -1; // هذا اللوجيك غير دقيقة سأعود لهذا الأمر لاحقاً.
                                    }

                                }
                            }



                        }
                        catch (Exception ex)
                        {
                            clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Failed", "Adding Files", ex.Message);
                            if (FilteredFilesCounter == 0)
                            {
                                FilteredFilesCounter = -1; // هذا اللوجيك غير دقيقة سأعود لهذا الأمر لاحقاً.
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (FilteredFilesCounter == 0)
                    {
                        FilteredFilesCounter = -1;
                    }
                }
                break;// temporary
            }

            return FilteredFilesCounter;
        }


        }
}
