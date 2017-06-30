using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set; Get;
            SetGetConstructor d = new SetGetConstructor() { Name = "Alma", Age = 45 };
            Console.WriteLine(d.Name + " " + d.Age);

            // reference params 
            RefValue r = new RefValue();
            int x = 2;
            int y = 10;
            Console.WriteLine(x + " " + y);
            r.ChangeValues(ref x, ref y);
            Console.WriteLine(x + " " + y);

            // object parameter
            ParamsObject p = new ParamsObject();
            p.PrintElements("one", "two");

            // default params
            DefaultParams dp = new DefaultParams(firstName: "Zsolt", lastName: "Annár", job: "UI");
            //dp.FirstName = "oké";
            Console.WriteLine(dp.FirstName);

            // Extended Method
            string s = "mystring";
            s.Print();
            ExtendedMethode.Print(s);

            // Class Library
            ClassLib.PrintHello();

            //PowFunction(x,y)
            double result = PowFunction.Pow(2, 10);
            result.Print();

            //Interface
            IAnimal anim = new Animal()
            {
                Age = 15,
                Name = "Alma"
            };

            Console.WriteLine(anim.Name);


            Console.ReadKey();
        }
    }
}
