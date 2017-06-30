using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal : IAnimal
    {
        public string Name { set; get; }
        public int Age { set; get; }
    }
}
