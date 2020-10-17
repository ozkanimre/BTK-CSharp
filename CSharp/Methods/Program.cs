using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //metod cagirilmasi
            Add(); 

            //ikinci değişkenin default değer almasını istiyorsak tek değer gönderiyoruz
            Console.WriteLine(Add2(12));


            //ref keyword ile metoddan gelen değeri n1 atamasını gerçekleştiriyoruz
            int n1 = 15;
            int n2 = 20;
            Console.WriteLine(Add3(ref n1, n2));
            Console.WriteLine(n1);

            //out keyword ile metoddan gelen değeri n3 atamasını gerçekleştiriyoruz n3 boş olabilir
            int n3 ;
            int n4 = 20;
            Console.WriteLine(Add4(out n3, n4));
            Console.WriteLine(n1);



            //method overloading
            Console.WriteLine(multiply(4, 5));
            Console.WriteLine(multiply(4, 5,5));


            //params keyword
            Console.WriteLine(Add5(1,2,3,4,5,6,7));



            Console.ReadKey();
        }


        //basit metod kullanımı
        static void Add()
        {
            Console.WriteLine("Added");
        }


        //metodların parametrelerini default olarak ayarlayabiliriz
        static int Add2(int number1,int number2=20){ 
            return number1 + number2;
        }

        //ref keyword ile metodda belirtilen değeri ana değerle değiştirebiliriz
        static int Add3(ref int n1 , int n2)
        {
            n1 = 30;
            return n1 + n2;
        }



        //out keyword ile metodda belirtilen değeri ana değerle değiştirebiliriz fakat ana değeri boş bırakabiliriz
        static int Add4(out int n1, int n2)
        {
            n1 = 30;
            return n1 + n2;
        }




        //method overloading
        static int multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int multiply(int number1, int number2,int number3)
        {
            return number1 * number2 *number3;
        }




        //params keyword
        //params tan önce değişken tanımlayabiliyoruz ama arkasına yapamayız
        //static int Add5(int number ,params int[] numbers)
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
