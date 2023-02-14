using System.IO;
using Microsoft.EntityFrameworkCore;

namespace UpCount
{
    public class DB_Control : DbContext
    {
        public static string GetUpCountFolder()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirectoryInfo = new(currentDirectory);
            string grandParentPath = currentDirectoryInfo.Parent.Parent.FullName;
            return grandParentPath;
        }

        public static string GetConnectionString()
        {
            string mock = string.Format("{0}\\db\\", GetUpCountFolder());
            string[] files = Directory.GetFiles(mock, "*.sqlite", SearchOption.AllDirectories);
            return string.Format("Data Source={0}", files[0]);
        }
    }
}
