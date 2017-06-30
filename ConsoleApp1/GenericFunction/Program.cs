using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>(2);
            s.Push(20);
            s.Push(99);
            try
            {
                s.Push(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption caught: {0} {1}", e.InnerException, e.Message);
            }
            
            s.t.Foreach<int>();

            Console.ReadKey();
        }
    }
}
