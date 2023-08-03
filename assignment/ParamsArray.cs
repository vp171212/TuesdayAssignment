using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = sumUp(10, 26, 23, 75);
            int sum = sumUp(138, 456, 65, 78, 23, 45);
            Console.WriteLine("Summation is: "+total);
            Console.WriteLine("Total sum is: "+sum);
        }
        static int sumUp(params int[] amount)
        {
            int summation = 0;
            foreach(int numbers in amount) 
            {
                summation += numbers;
            }
            return summation;
        }
    }
}
