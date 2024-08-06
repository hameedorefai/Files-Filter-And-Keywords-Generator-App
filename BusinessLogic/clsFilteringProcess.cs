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
        static public int[] FilterFiles()
        {

            int LocalCourseID = -1;
            string LocalFileName = "";
            float LocalFileLength = 0;
            int FilteredFilesCounter = 0;
            int FileswithGUID = 0;
            int RepeatedAndDeletedFiles = 0;
            int AllFilesCount = 0;

            string SourceFolderPath = clsPath.GetSourceFolderPath();
            DataTable Courses = clsCourse.GetAllCoursesInfo();
            var AllFiles = Directory.GetFiles(SourceFolderPath, "*.*", SearchOption.AllDirectories);

            foreach (DataRow courseRow in Courses.Rows)
            {
                try
                {
                          int CourseID = Convert.ToInt32(courseRow["CourseID"]);
               //     int CourseID = 309;
                    LocalCourseID = CourseID;
                    string SubCourseFolderPath = clsCourse.GetCoursePathByCourseID(CourseID);

                    if (!Directory.Exists(SubCourseFolderPath))
                    {
                        Directory.CreateDirectory(SubCourseFolderPath);
                    }

                    // temporary
                    // SubCourseFolderPath = SubCourseFolderPath + @"\MidtermExams"; // here, I can add the sub file. (inside course file)

                     AllFilesCount = AllFiles.Count();
                    clsCourse Course = clsCourse.Find(CourseID);
                    List<string> keywords = Course.GetAllKeywords();

                    List<string> normalizedKeywords = keywords.Select(k => Regex.Replace(k, @"[\W_]+", "").ToLower()).ToList();

                    var filteredFiles = AllFiles.Where(file =>
                    {
                        string normalizedFileName = Regex.Replace(Path.GetFileNameWithoutExtension(file), @"[\W_]+", "").ToLower();
                        return normalizedKeywords.Any(keyword => normalizedFileName.Contains(keyword));
                    });

                    if (filteredFiles == null)
                         continue;

                    foreach (var file in filteredFiles)
                    {
                        float FileLength = file.Length;
                        LocalFileLength = FileLength;
                        try
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file);
                            LocalFileName = fileName;
                            string fileExtension = Path.GetExtension(file);
                            string destinationFilePath = Path.Combine(SubCourseFolderPath, fileName + fileExtension);

                            if (File.Exists(destinationFilePath))
                            {
                                FileInfo sourceFileInfo = new FileInfo(file);
                                FileInfo destinationFileInfo = new FileInfo(destinationFilePath);

                                if (sourceFileInfo.Length != destinationFileInfo.Length)
                                {
                                    string newFileName = fileName + "_GUID:" + Guid.NewGuid().ToString() + fileExtension;
                                    string newDestinationFilePath = Path.Combine(SubCourseFolderPath, newFileName);

                                     File.Move(file, newDestinationFilePath);
                                   // File.Copy(file, newDestinationFilePath);
                                    clsOperationLog.CreateNewOperationLog(CourseID, newFileName, "Succeed", "Adding GUID Files", FileLength);
                                    FilteredFilesCounter++;
                                    FileswithGUID++;
                                }
                                else
                                {
                                    string repeatedFilesFolderPath = @"D:\ExportetData\RepeatedFiles";
                                    if (!Directory.Exists(repeatedFilesFolderPath))
                                    {
                                        Directory.CreateDirectory(repeatedFilesFolderPath);
                                    }

                                    // Delete the file in the source folder or move it to a new and independ folder.
                                    File.Delete(file);
                                    clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Succeed", "Removing Files", FileLength);
                                    RepeatedAndDeletedFiles++;
                                }
                            }
                            else
                            {
                                 File.Move(file, destinationFilePath);
                               // File.Copy(file, destinationFilePath, true);
                                clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Succeed", "Adding Files", file.Length);
                                FilteredFilesCounter++;
                            }
                        }
                        catch (Exception ex)
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file);
                            clsOperationLog.CreateNewOperationLog(CourseID, fileName, "Failed", "Adding Files", FileLength,ex.Message);
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
                    clsOperationLog.CreateNewOperationLog(LocalCourseID, LocalFileName, "Failed", "Adding Files", LocalFileLength, ex.Message);
                }
            }
            int[] arrData = new int[4];
            arrData[0] = FilteredFilesCounter;
            arrData[1] = FileswithGUID;
            arrData[2] = RepeatedAndDeletedFiles;
            arrData[3] = AllFilesCount;
            return arrData;
        }


        static void DeleteAllImages(string folderPath)
        {
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".ico" };

            try
            {
                var allFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);

                foreach (var file in allFiles)
                {
                    string fileExtension = Path.GetExtension(file).ToLower();

                    if (Array.Exists(imageExtensions, ext => ext.Equals(fileExtension)))
                    {
                        File.Delete(file);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }


    }
}
