using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
//using System.Linq;

namespace BusinessLogic
{
    public class clsPath
    {
        static private string _OriginalSourceFolderPath = @"D:\ExportetData\MidtermExams\files\";
        static private string _OriginalFilteredFolderPath = @"D:\FolderFilesFilterApp\Courses\"; 
        
        static string SourceFolderPath = _OriginalSourceFolderPath;
        static string FilteredFolderPath = _OriginalFilteredFolderPath;

        static public string GetSourceFolderPath()
        {
            return SourceFolderPath;
        }
        static public bool SetSourceFolderPath(string sourceFolderPath)
        {
            SourceFolderPath = sourceFolderPath;
            return true;
        }

        static public string GetFilteredFolderPath()
        {
            return FilteredFolderPath;
        }
        static public bool SetFilteredFolderPath(string filteredFolderPath)
        {
            FilteredFolderPath = filteredFolderPath;
            return true;
        }




    }
}
