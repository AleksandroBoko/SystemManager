using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemManagerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = "Test";
            string newDir = "RealTest";

            DirectoryManager dm = new DirectoryManager();
            //dm.CreateDirectory("Test1");
            //dm.CreateDirectory("Test2");
            //dm.CreateDirectory("Test3");

            Console.WriteLine(dm.GetShortInfo());

            //if (dm.CreateDirectory(dir))
            //{
            //    Console.WriteLine("Directory was created!");

            //    if(dm.MoveDirectory(dir, newDir))
            //        Console.WriteLine("Directory was moved!");

            //    if (dm.DeleteDirectory(dir))
            //        Console.WriteLine("Directory was removed!");
            //}

            Console.ReadKey();

        }
    }
}
