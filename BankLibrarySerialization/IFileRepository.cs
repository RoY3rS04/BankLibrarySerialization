using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrarySerialization
{
    public interface IFileRepository
    {

        void OpenOrCreateFile();
        void WriteRecordToFile(string jsonRecord);
        string? GetRecordFromFile();
        void CloseFile();
    }
}
