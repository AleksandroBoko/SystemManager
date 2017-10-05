using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagerProject
{
    interface IFileManager
    {
        bool CreateFile(string path);
        bool DeleteFile(string path);
        bool MoveFile(string oldPath, string newPath);
    }
}
