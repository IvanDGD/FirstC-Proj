using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GarbageCollection
{
    internal class File
    {

        string _fileName;
        string _filePath;
        string _data = string.Empty;
        bool _isOpened = false;

        public File(string fileName, string filePath)
        {
            _fileName = fileName;
            _filePath = filePath;
        }

        public void AddData(string data)
        {
            _data += data;
        }

        public void OpenFile()
        {
            _isOpened = true;
        }

        public void CloseFile()
        {
            _isOpened = false;
        }

        public void Dispose()
        {
            if (_isOpened)
            {
                CloseFile();
            }
        }

        ~File()
        {
            Dispose();
        }

    }
}
