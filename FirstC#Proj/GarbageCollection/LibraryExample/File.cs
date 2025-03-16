using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstC_Proj.GarbageCollection.LibraryExample
{
    internal class File : IDisposable
    {
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public string FilePath { get; set; }

        private bool disposed = false;

        public File(string fileName, long fileSize, string filePath)
        {
            FileName = fileName;
            FileSize = fileSize;
            FilePath = filePath;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"File Name: {FileName}");
            Console.WriteLine($"File Size: {FileSize} bytes");
            Console.WriteLine($"File Path: {FilePath}");
        }

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine($"File {FileName} closed.");
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        ~File()
        {
            if (!disposed)
            {
                Console.WriteLine($"Finalizer called");
            }
        }
    }
}
