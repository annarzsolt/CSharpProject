using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunction
{
    static public class ForeachFunction
    {
        static public void Foreach<T>(this T[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
