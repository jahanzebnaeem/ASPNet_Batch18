using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iteration - 1
            //string inPutVal = Console.ReadLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    if (inPutVal.ToLower() == "jahanzeb")
            //    {
            //        Console.WriteLine(inPutVal + " has taught ASP.NET Batchs - " + i);
            //    }
            //    else
            //    {
            //        Console.WriteLine(i + " - Hello ASP.NET Batch-18");
            //    }
            //}

            // Iteration - 2
            //int inPutVal = Convert.ToInt32(Console.ReadLine());

            //if (inPutVal % 2 == 0)
            //    Console.WriteLine("Number is Even");
            //else
            //    Console.WriteLine("Number is Odd");

            // Iteration - 3
            int inPutVal = Convert.ToInt32(Console.ReadLine());
            int inPutVal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of your input values = " + (inPutVal + inPutVal2));
        }
    }
}
