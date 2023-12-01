using System.Text.Json;

namespace TimesheetApplication.DB.WriteAndReadFromJson
{
    public class WriteToJson
    {
        public void WriteToJsons<T>(List<T> input, string GenericFileName)
        {
            try
            {
                string fileName = JsonHelper.GetPath(GenericFileName);
                string jsonString = JsonSerializer.Serialize(input);

                using(StreamWriter write = new StreamWriter(fileName)) 
                {
                    write.Write(jsonString);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        public void WriteSingleUserToJson<T>(T input, string GenericFileName)
        {
            try
            {
                string fileName = JsonHelper.GetPath(GenericFileName);
                string jsonString = JsonSerializer.Serialize(input);

                using (StreamWriter write = new StreamWriter(fileName))
                {
                    write.Write(jsonString);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public void WriteClockEventsToJsons<T>(T input, string GenericFileName)
        {
            try
            {
                string fileName = JsonHelper.GetPath(GenericFileName);
                string jsonString = JsonSerializer.Serialize(input);

                using (StreamWriter write = new StreamWriter(fileName))
                {
                    write.Write(jsonString);
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
