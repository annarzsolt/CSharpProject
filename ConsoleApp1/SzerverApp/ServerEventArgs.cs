using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerverApp
{
    class ServerEventArgs : EventArgs
    {
        public string Message { get; set; }
        public ServerEventArgs(string message)
            :base()
        {
            this.Message = message;
        }
    }
}
