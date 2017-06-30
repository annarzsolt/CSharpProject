using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RefValue
    {
        public void ChangeValues(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
