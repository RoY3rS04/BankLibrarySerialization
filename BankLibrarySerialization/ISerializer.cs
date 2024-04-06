using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrarySerialization
{
    public interface ISerializer
    {
        void Serialize<T>(T record, FileRepository repository) where T: class;

        T? Deserialize<T>(FileRepository repository) where T: class;
    }
}
