using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagerProject
{
    class Menu
    {
        StringBuilder menuBuilder;
        DirectoryManager dirManager;
        FileManager fileManager;

        public Menu()
        {
            menuBuilder = new StringBuilder(); 
        }

        public void InitializeManager()
        {
            dirManager = new DirectoryManager();
            fileManager = new FileManager();
        }

        public void MainMenu()
        {
            Console.Clear();
            menuBuilder.Clear();

            menuBuilder.AppendLine("Menu Directories - 0");
            menuBuilder.AppendLine("Menu Files       - 1");
            menuBuilder.AppendLine("Exit             - any other key");
            Console.WriteLine(menuBuilder);

            string ans = Console.ReadLine();
            switch(ans)
            {
                case "0": MenuDirectory(); break;
                case "1": MenuFile(); break;
                default: Exit(); break;
            }
        }

        void MenuDirectory()
        {
            Console.Clear();
            menuBuilder.Clear();

            menuBuilder.AppendLine("Create dir          - 0");
            menuBuilder.AppendLine("Delete dir          - 1");
            menuBuilder.AppendLine("Move dir            - 2");
            menuBuilder.AppendLine("Get data(top level) - 3");
            menuBuilder.AppendLine("Exit                - any other key");
            Console.WriteLine(menuBuilder);

            string ans = Console.ReadLine();
            switch(ans)
            {
                case "0": CreateDir(); break;
                case "1": DeleteDir(); break;
                case "2": MoveDir(); break;
                case "3": ShowInfoTopLevel(); break;
                default: Exit(); break;
            }
        }

        private void CreateDir()
        {
            Console.Clear();
            Console.WriteLine("Set the name of dir:");
            string nameDir = Console.ReadLine();
            if (dirManager.CreateDirectory(nameDir))
                Console.WriteLine("Directory {0} was created successfully!", nameDir);
            else
                Console.WriteLine("Directory {0} wasn't created!", nameDir);

            MainMenu();
        }

        private void DeleteDir()
        {
            Console.Clear();
            Console.WriteLine("Set the name of dir:");
            string nameDir = Console.ReadLine();
            if (dirManager.DeleteDirectory(nameDir))
                Console.WriteLine("Directory {0} was deleted successfully!", nameDir);
            else
                Console.WriteLine("Directory {0} wasn't deleted!", nameDir);

            MainMenu();
        }

        private void MoveDir()
        {
            Console.Clear();
            Console.WriteLine("Set the name of dir:");
            string nameDir = Console.ReadLine();

            Console.WriteLine("Set a new name of dir:");
            string newNameDir = Console.ReadLine();

            if (dirManager.MoveDirectory(nameDir, newNameDir))
                Console.WriteLine("Directory {0} was moved to {1} successfully!", nameDir, newNameDir);
            else
                Console.WriteLine("Directory {0} wasn't moved to {1}!", nameDir, newNameDir);

            MainMenu();
        }

        private void ShowInfoTopLevel()
        {
            Console.Clear();
            Console.WriteLine("The list of data inside current directory - press 'Enter' or set the name:");
            string ans = Console.ReadLine();

            Console.WriteLine(dirManager.GetShortInfo(ans));
        }


        void MenuFile()
        {
            Console.Clear(); 
            menuBuilder.Clear();

            menuBuilder.AppendLine("Create file  - 0");
            menuBuilder.AppendLine("Delete file  - 1");
            menuBuilder.AppendLine("Move file    - 2");
            menuBuilder.AppendLine("Open file    - 3");
            menuBuilder.AppendLine("Edit file    - 4");
            menuBuilder.AppendLine("Exit         - any other key");
            Console.WriteLine(menuBuilder);

            string ans = Console.ReadLine();
            switch (ans)
            {
                case "0": CreateFile(); break;
                case "1": DeleteDir(); break;
                case "2": MoveDir(); break;
                case "3": ShowInfoTopLevel(); break;
                default: Exit(); break;
            }
        }

        private void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("Set the name of file:");
            string name = Console.ReadLine();

            if (fileManager.CreateFile(name))
                Console.WriteLine("File {0} was created successfully!", name);
            else
                Console.WriteLine("File {0} wasn't created!", name);

            MainMenu();
        }

        private void DeleteFile()
        {
            Console.Clear();
            Console.WriteLine("Set the name of file:");

            string name = Console.ReadLine();
            if (fileManager.DeleteFile(name))
                Console.WriteLine("File {0} was deleted successfully!", name);
            else
                Console.WriteLine("File {0} wasn't deleted!", name);

            MainMenu();
        }

        private void MoveFile()
        {
            Console.Clear();
            Console.WriteLine("Set the name of file:");
            string name = Console.ReadLine();

            Console.WriteLine("Set a new name of file:");
            string newName = Console.ReadLine();

            if (fileManager.MoveFile(name, newName))
                Console.WriteLine("File {0} was moved to {1} successfully!", name, newName);
            else
                Console.WriteLine("File {0} wasn't moved to {1}!", name, newName);

            MainMenu();
        }

        private void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Set the name of file:");
            string name = Console.ReadLine();

            Console.WriteLine(fileManager.OpenFileToRead(name));
            Console.ReadLine();

            MainMenu();
        }

        private void OpenFileToRead()
        {
            Console.Clear();
            Console.WriteLine("Set the name of file:");
            string name = Console.ReadLine();

            Console.WriteLine(fileManager.OpenFileToRead(name));
            Console.WriteLine("Rewrite - 0, add new record - any key");
            string ans = Console.ReadLine();

            Console.WriteLine("Write your text:");
            string value = Console.ReadLine();
            fileManager.OpenFileToWrite(name, value, ans != "0");

            Console.ReadLine();

            MainMenu();

        }

        void Exit()
        {
            Console.WriteLine("Goodbay!");
        }
    }
}
