using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SetGetConstructor d = new SetGetConstructor() { Name = "Alma", Age = 45 };
            Console.WriteLine(d.Name + " " + d.Age);
            Console.ReadKey();
        }
    }
}
