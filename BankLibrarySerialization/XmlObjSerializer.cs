using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankLibrarySerialization
{
    public class XmlObjSerializer: ISerializer
    {
        public T? Deserialize<T>(FileRepository repository) where T : class
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                StreamReader? sr = repository.GetReader();

                if(sr != null)
                {
                    return (T?)serializer.Deserialize(sr);
                }

                return null;
            } catch(IOException e) {
                throw new IOException(e.Message);
            }
        }

        public void Serialize<T>(T obj, FileRepository repository) where T: class
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                StreamWriter? sw = repository.GetWriter();

                if (sw != null)
                {
                    serializer.Serialize(sw, obj);
                }

                
            } catch(IOException e)
            {
                throw new IOException(e.Message);
            }
        }
    }
}
