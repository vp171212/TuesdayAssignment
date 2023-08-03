using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12, fact;
            bool b = multiPurpose(in num1, out fact);
            Console.WriteLine("Factorial is: " + fact);
            Console.WriteLine(b ? "number is prime" : "number is not prime");
        }

        private static bool multiPurpose(in int num1, out int factorial)
        {
             factorial = 1;
            for (int i = 2; i <= num1; i++)
            {
                factorial *= i;
            }
            if (num1 == 0 || num1 == 1)
            {
                return false;
            }

            for (int i = 2; i * i <= num1; i++)
                {
                    if (num1 % i == 0)
                    {
                        return false;                  
                    }
                }
            return true;
        }
    }
}
