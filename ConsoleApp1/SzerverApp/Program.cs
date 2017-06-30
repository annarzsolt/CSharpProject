using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** Delegate */

namespace SzerverApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            Client c1 = new Client("Józsi");
            Client c2 = new Client("Zsolt");
            Client c3 = new Client("Jani");
            Client c4 = new Client("Peti");

            server.Connect(c1);
            server.Connect(c2);
            server.Connect(c3);
            server.Disconnect(c1);
            server.Connect(c4);
            server.Disconnect(c2);
            server.Disconnect(c3);
            server.Disconnect(c4);
            Console.ReadKey();
        }
    }
}
