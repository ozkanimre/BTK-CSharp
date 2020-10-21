using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            //Intro();
            string sentence = "My name is Özkan";

            //lenght özelliği verilen string değerinin uzunluğunu bulur
            var lenght = sentence.Length;
            Console.WriteLine(lenght);

            //clone özelliği verilen string'in koyasını oluştrumak için kullanılır
            var clone = sentence.Clone();
            sentence = "My name is Clay";
            Console.WriteLine(clone);

            //String tırnak içinde belirtilen karakter ile bitiyormu veya başlıyormu bool bir değer döndürür
            bool result = sentence.EndsWith("y");
            bool result2 = sentence.StartsWith("My name");
            Console.WriteLine(result);
            Console.WriteLine(result2);

            //name kelimesinin nereden başladığını bulur index değerini verir bulamadığında -1 değerini döndürür
            //aranan aynı değerden birden fazla varsa bulduğu ilk değeri bulur ve durur
            var result3 = sentence.IndexOf("name");
            var result4 = sentence.IndexOf(" ");
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            //aramaya sondan başlar ve aranan aynı değerden birden fazla varsa bulduğu ilk değeri bulur ve durur
            var result5 = sentence.LastIndexOf(" ");
            Console.WriteLine(result5);

            //string değere ekstra ekleme yapmak için kullanılır
            var result6 = sentence.Insert(0,"Hello, ");
            Console.WriteLine(result6);


            //stringlerde metinleri bölmek için kullanılır
            //1.karakterden itibaren 3 karakter al
            var result7 = sentence.Substring(1,3); 
            Console.WriteLine(result7);


            //stringlerde metinleri küçük harfe çevirir
            var result8 = sentence.ToLower();
            Console.WriteLine(result8);

            //stringlerde metinleri büyük harfe çevirir
            var result9 = sentence.ToUpper();
            Console.WriteLine(result9);


            //stringlerde karakter değiştirmek için kullanılır
            var result10 = sentence.Replace(" ","-");
            Console.WriteLine(result10);

            //stringlerde belli bir stringten sonrasını silmek için kullanılır
            //aralıkta seçebiliyoruz string.Remove(2,5);
            var result11 = sentence.Remove(2);
            Console.WriteLine(result11);

            Console.ReadKey();
        }


        private static void Intro()
        {
            // string bir char dizisidir
            string city = "İstanbul";

            //string elemanlarına tek tek ulaşabiliriz diziler gibi
            Console.WriteLine(city[2]);

            //Stringleri dizi ile yazdırabiliriz
            foreach (var item in city)
            {
                Console.Write(item + " ");
            }

            string city2 = "Ankara";

            //stringleri birbiri arkasına toplayabiliriz
            string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
