using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrimeNumber(number)==true ? "It's a prime number" : "It's not a prime number");
            Console.ReadKey();
        }

        static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
