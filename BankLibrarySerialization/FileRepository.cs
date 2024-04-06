using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrarySerialization
{
    public class FileRepository : IFileRepository
    {

        private FileStream? _fileStream;
        private StreamReader? _reader;
        private StreamWriter? _writer;
        private string _fileName;

        public FileRepository(string fileName)
        {
            _fileName = fileName;
        }

        public void CloseFile()
        {
            try
            {
                _writer?.Close();
                _reader?.Close();
            }catch(IOException) {
                throw new IOException("Can't close the file");
            }
        }

        public void OpenOrCreateFile()
        {
            try
            {
                _fileStream = new FileStream(_fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                _writer = new StreamWriter(_fileStream);
                _reader = new StreamReader(_fileStream);

            }catch(IOException ex)
            {
                throw new IOException(ex.Message);
            }
        }

        public void WriteRecordToFile(string jsonRecord)
        {
            try
            {
                _writer?.WriteLine(jsonRecord);
            } catch(IOException)
            {
                throw new IOException("Error while trying to save record");
            }
        }

        public string? GetRecordFromFile()
        {
            try
            {
                _reader?.DiscardBufferedData();
                _reader?.BaseStream.Seek(0, SeekOrigin.Begin);
                string? strRecord = _reader?.ReadToEnd();
                return strRecord;
            } catch(IOException)
            {
                throw new IOException("Failed to read file");
            }
        }

        public string? GetFileName()
        {
            return _fileName;
        }

        public StreamWriter? GetWriter()
        {
            return _writer;
        }

        public StreamReader? GetReader()
        {
            return _reader;
        }
    }
}
