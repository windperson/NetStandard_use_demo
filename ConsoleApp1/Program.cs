using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCLlib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var aObj = new MyEntity {ID = 123, Name = "abc"};

            Console.WriteLine($"aObj.ID={aObj.ID}, aObj.Name={aObj.Name}");
            Console.ReadKey();
        }
    }
}
