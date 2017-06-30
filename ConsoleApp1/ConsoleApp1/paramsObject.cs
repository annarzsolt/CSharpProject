using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ParamsObject
    {
        public void PrintElements(params object[] elements)
        {
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
