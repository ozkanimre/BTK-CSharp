using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // birinci tanım şekli
            string[] students = new string[3];
            students[0] = "Ahmet";
            students[1] = "Duru";
            students[2] = "Mehmet";

            //ikinci tanım şekli
            string[] students2 = { "Ahmet" , "Duru" , "Mehmet" };
            
            //hata verir çünkü yukarıda bellekte sadece 3 alan ayrıldı
            //students2[3] = "mahmut";


            //dizlerle işlem için genellikle foreach döngüsü kullanılır
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }



            string[,] regions = new string[7, 3]
            {
                { "İstanbul","Kocaeli","Trakya",},
                { "Ankara","Konya","Eskişehir",},
                { "Antalya","Adana","Mersin",},
                { "İzmir","Bodrum","Aydın",},
                { "Iğdır","Erzurum","Van",},
                { "Samsun","Rize","Trabzon",},
                { "Gaziantep","Mardin","Urfa",}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.Write(regions[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
