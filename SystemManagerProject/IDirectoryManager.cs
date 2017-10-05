using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SystemManagerProject
{
    interface IDirectoryManager
    {
        bool CreateDirectory(string path);
        bool DeleteDirectory(string path);
        bool MoveDirectory(string oldPath, string newPath);
        StringBuilder GetShortInfo(string path);
        //void GetFullInfo(string path);
    }
}
