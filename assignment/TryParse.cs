using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "sfg";
            int intStr; bool intResultTryParse = int.TryParse(str, out intStr);
            if (intResultTryParse == true)
            {
                Console.WriteLine(intStr);
            }
            else
            {
                Console.WriteLine("Input is not in integer format");
            }
            Console.WriteLine("Enter a number");
            string str1=Console.ReadLine();
            int intStr1;
                bool result=int.TryParse(str1, out intStr1);
            if (result == true)
            Console.WriteLine("input is: "+intStr1);
            else
            { Console.WriteLine("Please enter a valid Integer"); }
        }
    }
}
