using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace ThreadsApp
{
    class Program
    {
        public delegate int MyDelegate(int x);
        static int Square(int x)
        {
            Console.WriteLine("Szál-ID: {0}", Thread.CurrentThread.ManagedThreadId);
            return (x * x);
        }
        static void AsyncMethodComplete(IAsyncResult iar)
        {
            Console.WriteLine("Aszinkron szál kész...");
            AsyncResult result = (AsyncResult)iar;
            MyDelegate d = (MyDelegate)result.AsyncDelegate;
            Console.WriteLine("Üzenet: {0}", iar.AsyncState);
            Console.WriteLine("Eredmény: {0}", d.EndInvoke(iar));
        }
        static public void Main()
        {
            MyDelegate d = Square;
            Console.WriteLine("Szál-ID {0}", Thread.CurrentThread.ManagedThreadId);
            IAsyncResult iar = d.BeginInvoke(12, new AsyncCallback(AsyncMethodComplete), "Üzenet a jövõbõl :)");
            
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("BlaBla...");
            }

            Console.ReadKey();
        }
    }
}
