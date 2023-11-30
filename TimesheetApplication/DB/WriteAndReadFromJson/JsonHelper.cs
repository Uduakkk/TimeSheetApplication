namespace TimesheetApplication.DB.WriteAndReadFromJson
{
    public class JsonHelper
    {
        public static string GetPath(string filename)
        {
            string currentDir = Environment.CurrentDirectory;
            string filePath = Path.Combine(currentDir, "DB", "JsonFiles", filename);
            if (File.Exists(filePath)) 
            { 
                return filePath;
            }
           try
            {
                FileInfo fileInfo = new FileInfo(filePath);

                using (FileStream fileStream = fileInfo.Create()) ;

                return fileInfo.FullName;
            }
            catch(System.Exception ex) 
            {
                throw ex;
            }
        }
    }
}
