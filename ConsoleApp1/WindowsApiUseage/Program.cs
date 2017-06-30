using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;


namespace WindowsApiUseage
{
    class Program
    {
        static void Main(string[] args)
        {

            //-- 1) --

            //API.MessageBox(0, "Hello", "Nincs", 0);

            //-- 2) --

            //Process[] processList = Process.GetProcesses(".");

            //foreach (Process process in processList)
            //{
            //    Console.WriteLine("PID: {0}, Process - név: {1}", process.Id, process.ProcessName);

            //    ProcessThreadCollection ptc = process.Threads;
            //    foreach (ProcessThread thread in ptc)
            //    {
            //        Console.WriteLine("Id: {0}, Állapot: {1}", thread.Id, thread.ThreadState);
            //    }
            //    Console.WriteLine("-- ** --");
            //}

            //-- 3 --

            //Process explorer = Process.Start("iexplore.exe");
            //Thread.Sleep(5000);
            //explorer.Kill();

            //-- 4 --

            //AppDomain currAD = AppDomain.CurrentDomain;
            //Console.WriteLine(currAD.FriendlyName);

            //AppDomain secondAD = AppDomain.CreateDomain("second");
            //Console.WriteLine(secondAD.FriendlyName);

            //AppDomain.Unload(secondAD);


            Console.ReadKey();
        }

        //-- 1) --

        //public class API
        //{
        //    [DllImport("user32.dll")]
        //    public static extern int MessageBox(int hWnd, string text, string caption, uint type);
        //}
    }
}
