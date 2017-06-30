using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    class DelegateClass
    {
        public delegate void MyDelegate(object sender, string msg);
        public MyDelegate handler;
        public DelegateClass() { }
        
        public void Connect(string message)
        {
            handler += this.HandlerMessage;
            OnChange(message);
        }
        public void OnChange(string msg)
        {
            if(handler != null)
            {
                handler(this, msg);
            }
        }
        public void HandlerMessage(object sender, string msg)
        {
            Console.WriteLine("Connect: {0}", msg);
        }
    }
}
