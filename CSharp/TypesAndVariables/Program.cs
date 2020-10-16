using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number1 = 142; //8 bit 0 -> 255
            short number2 = 1224; //16 bit -32768 -> 32767
            int number3 = 125445;  //32 bit -2147483648 -> 2147483647
            long number4 = 14545452; //64 bit -9223372036854775808 -> 9223372036854775807

            double number5 = 5.45;
            decimal number6 = 45.45m;

            bool cond = true; //true - false

            char character = 'D';

            var number7 = 45;

            number7 = 'A';

            Console.WriteLine("number1 is {0}", number1);
            Console.WriteLine("character is {0}", (int)character);
            Console.WriteLine((int)Days.Saturday);
            Console.WriteLine("number7 is {0}", number7);

            Console.ReadKey();
        }
    }

    enum Days
    {
        Monday = 15, Tuesday = 20, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
