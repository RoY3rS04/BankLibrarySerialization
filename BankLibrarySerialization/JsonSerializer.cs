using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrarySerialization
{
    public class JsonSerializer : ISerializer
    {
        public T? Deserialize<T>(FileRepository repository) where T : class
        {

            string? jsonRecord;

            try
            {
                jsonRecord = repository.GetRecordFromFile();
                repository.CloseFile();

                if (jsonRecord != null)
                {
                    return JsonConvert.DeserializeObject<T>(jsonRecord);
                }

                return null;
            } catch (IOException e)
            {
                throw new IOException(e.Message);
            }
       
        }

        public void Serialize<T>(T record, FileRepository repository) where T : class
        {
            string json = JsonConvert.SerializeObject(record, Formatting.Indented);

            try
            {
                repository.WriteRecordToFile(json);
                repository.CloseFile();
            }
            catch (IOException e)
            {
                throw new IOException(e.Message);
            }
        }
    }
}
