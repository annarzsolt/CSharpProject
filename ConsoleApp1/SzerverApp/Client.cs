using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerverApp
{
    class Client
    {
        public string Name { get; set; }
        public Client(string name)
        {
            Name = name;
        }
        public void ServerMessageHandler(object sender, ServerEventArgs e)
        {
            Console.WriteLine("{0} üzenetet kapott: {1}", this.Name, e.Message);
        }
    }
}
