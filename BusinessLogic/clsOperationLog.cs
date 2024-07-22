using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace BusinessLogic
{
    public class clsOperationLog
    {
        static public int CreateNewOperationLog(int CourseID, string FileName, string OperationStatus,string OperationType,string Details = "")
        {
            DateTime OperationLogDate = DateTime.Now;
            return clsOperationLogData.CreateNewOperationLog(CourseID, FileName, OperationLogDate, OperationStatus,OperationType,Details);
        }
    }
}
