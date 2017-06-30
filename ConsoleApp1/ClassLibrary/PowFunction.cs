using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PowFunction
    {
        static public double Pow(double x, int y)
        {
            if (y == 0)
            {
                return 1.0;
            }
            else
            {
                return x * Pow(x, y - 1);
            }
        }
    }
}
