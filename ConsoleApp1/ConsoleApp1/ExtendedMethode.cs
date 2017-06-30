using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static public class ExtendedMethode
    {
        static public void Print(this string s)
        {
            Console.WriteLine(s);
        }
        static public void Print(this double d)
        {
            Console.WriteLine(d);
        }
    }
}
