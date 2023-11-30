using System.Text.Json;

namespace TimesheetApplication.DB.WriteAndReadFromJson
{
    public class ReadFromJson
    {
        public List<T> ReadFromJsons<T>(string fileName)
        {
            try
            {
                string path = JsonHelper.GetPath(fileName);
                string jsonContent = File.ReadAllText(path);

                return jsonContent.Length > 0
                    ? JsonSerializer.Deserialize<List<T>>(jsonContent) ?? new List<T>()
                    : new List<T>();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
