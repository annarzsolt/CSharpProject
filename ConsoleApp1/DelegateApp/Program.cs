using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass d = new DelegateClass();

            d.Connect("OMG MEGY1");
            d.Connect("OMG MEGY2");

            Console.ReadKey();
        }
    }
}
