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

        void MainMenu()
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


        }

        void MenuFile()
        {

        }

        void Exit()
        {
            Console.WriteLine("Goodbay!");
        }
    }
}
