using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnSafeMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int x = 10;
                int* y = &x;

                Console.WriteLine((int)y);

                Console.ReadKey();
            }
        }
    }
}
