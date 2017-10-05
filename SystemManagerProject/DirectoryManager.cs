using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagerProject
{
    class DirectoryManager : IDirectoryManager
    {
        const string UserDir = @"D:\Drive\";

        public bool CreateDirectory(string path)
        {
            string userPath = UserDir + path;
            bool result = false;
            DirectoryInfo di = new DirectoryInfo(userPath);
            if (!di.Exists)
            {
                di.Create();
                di.Refresh();
                result = di.Exists;
            }

            return result;
        }

        public bool DeleteDirectory(string path)
        {
            string userPath = UserDir + path;
            bool result = false;
            DirectoryInfo di = new DirectoryInfo(userPath);
            if (di.Exists)
            {
                di.Delete();
                di.Refresh();
                result = !di.Exists;
            }

            return result;
        }

        public bool MoveDirectory(string oldPath, string newPath)
        {
            string userOldPath = UserDir + oldPath;
            string userNewPath = UserDir + newPath;
            bool result = false;
            DirectoryInfo di = new DirectoryInfo(userOldPath);
            if (di.Exists)
            {
                di.MoveTo(userNewPath);
                di = new DirectoryInfo(userNewPath);
                result = di.Exists;
            }

            return result;
        }

        public StringBuilder GetShortInfo(string path = "")
        {
            string userPath = UserDir + path;
            DirectoryInfo di = new DirectoryInfo(userPath);
            StringBuilder sb = new StringBuilder();

            AddingDirectoriesToStringBuilder(ref sb, di);
            AddingFilesToStringBuilder(ref sb, di);

            return sb;
        }

        void AddingFilesToStringBuilder(ref StringBuilder sb, DirectoryInfo di)
        {
            foreach (FileInfo f in di.GetFiles())
            {
                sb.AppendLine($"F - {f.Name}");
            }
        }

        void AddingDirectoriesToStringBuilder(ref StringBuilder sb, DirectoryInfo di)
        {
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                sb.AppendLine($"D - {d.Name}");
            }
        }





    }
}
