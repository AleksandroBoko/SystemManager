using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagerProject
{
    class FileEditor : IFileEditor
    {
        string result = "";
        public string ReadFromFile(string path)
        {
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                try
                {
                    using (StreamReader sm = new StreamReader(path))
                    {
                        result = sm.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {

                }
            }

            return result;
        }

        public void WriteToFile(string path, string value, bool typeWriting)
        {
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path, typeWriting))
                    {
                        sw.WriteLine(value);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
