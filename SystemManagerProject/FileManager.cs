using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagerProject
{
    class FileManager : IFileManager
    {
        IFileEditor fEditor;

        public void Initialize()
        {
            fEditor = new FileEditor();
        }

        public bool CreateFile(string path)
        {
            bool result = false;
            FileInfo f = new FileInfo(path);
            if(!f.Exists)
            {
                f.Create();
                f.Refresh();
                result = f.Exists;
            }

            return result;
        }

        public bool DeleteFile(string path)
        {
            bool result = false;
            FileInfo f = new FileInfo(path);
            if(f.Exists)
            {
                f.Delete();
                f.Refresh();
                result = !f.Exists;
            }
            return result;
        }

        public bool MoveFile(string oldPath, string newPath)
        {
            bool result = false;
            FileInfo f = new FileInfo(oldPath);
            if(f.Exists)
            {
                f.MoveTo(newPath);
                f = new FileInfo(newPath);
                result = f.Exists;
            }

            return result;
        }

        public string OpenFileToRead(string path)
        {
            if (fEditor == null)
                return "";

            return fEditor.ReadFromFile(path);
        }

        public void OpenFileToWrite(string path, string value, bool writingType)
        {
            if (fEditor == null)
                return;

            fEditor.WriteToFile(path, value, writingType);
        }
    }
}
