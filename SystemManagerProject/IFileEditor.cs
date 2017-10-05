using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagerProject
{
    interface IFileEditor
    {
        string ReadFromFile(string path);
        void WriteToFile(string path, string value, bool typeWriting);
    }
}
