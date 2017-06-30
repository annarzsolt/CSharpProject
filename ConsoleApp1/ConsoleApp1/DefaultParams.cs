using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DefaultParams
    {
        
        public DefaultParams(string firstName, string lastName, string job = "N/A")
        {
            FirstName = firstName;
            LastName = lastName;
            Job = job;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Job { get; private set; }
    }
}
