using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BusinessLogic
{

    public class clsFilteringProcess
    {
        static public int FilterFiles()
        {
            int LocalCourseID = -1;
            string LocalFileName = "";

            int FilteredFilesCounter = 0;
            string SourceFolderPath = clsPath.GetSourceFolderPath();
            DataTable Courses = clsCourse.GetAllCoursesInfo();

            foreach (DataRow courseRow in Courses.Rows)
            {
                try
                {
                    int CourseID = Convert.ToInt32(courseRow["CourseID"]);
                    LocalCourseID = CourseID;
                    string SubCourseFolderPath = clsCourse.GetCoursePathByCourseID(CourseID);

                    if (!Directory.Exists(SubCourseFolderPath))
                    {
                        Directory.CreateDirectory(SubCourseFolderPath);
                    }

                    // temporary
                   // SubCourseFolderPath = SubCourseFolderPath + @"\MidtermExams"; // here, I can add the sub file. (inside course file)

                                        var AllFiles = Directory.GetFiles(SourceFolderPath);
                    clsCourse Course = clsCourse.Find(CourseID);
                    List<string> keywords = Course.GetAllKeywords();


                    List<string> normalizedKeywords = keywords
                        .Select(k => Regex.Replace(k, @"[\W_]+", "").ToLower())
                        .ToList();

                    var filteredFiles = AllFiles.Where(file =>
                    {

                        string normalizedFileName = Regex.Replace(Path.GetFileNameWithoutExtension(file), @"[\W_]+", "").ToLower();
                        return normalizedKeywords.Any(keyword => normalizedFileName.Contains(keyword));
                    });

                    foreach (var file in filteredFiles)
                    {
                        try
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file); 
                            LocalFileName = fileName;
                            string fileExtension = Path.GetExtension(file);
                            string destinationFilePath = Path.Combine(SubCourseFolderPath, fileName + fileExtension);

                              File.Copy(file, destinationFilePath, true);
                          //  File.Move(file, destinationFilePath);

                            if (File.Exists(destinationFilePath))
                            {
                                clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Succeed", "Adding Files");
                                FilteredFilesCounter++;
                            }
                            else
                            {
                                clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Failed", "Adding Files", "");
                                if (FilteredFilesCounter == 0)
                                {
                                    FilteredFilesCounter = -1; // هذا اللوجيك غير دقيق سأعود له لاحقاً.
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file);
                            clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Failed", "Adding Files", ex.Message);
                            if (FilteredFilesCounter == 0)
                            {
                                FilteredFilesCounter = -1; // هذا اللوجيك غير دقيق سأعود له لاحقاً.
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
                    clsOperationLog.CreateNewOperationLog(LocalCourseID, LocalFileName, "Failed", "Adding Files", ex.Message);
                }
            }

            return FilteredFilesCounter;
        }
    }
}
