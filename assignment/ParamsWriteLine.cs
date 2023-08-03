using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsWriteLineDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Custom WriteLine() with params array
                CustomWriteLine("Today is {0}.", DateTime.Now.DayOfWeek);
                CustomWriteLine("The answer is {0} and {1}.", 42, "forty-two");
                CustomWriteLine("The value of pi is approximately {0:F2}.", 3.14159);
         }

            static void CustomWriteLine(string format, params object[] args)
            {
                Console.WriteLine(format, args);
            }
    }
}

