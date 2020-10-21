using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //nesne oluşturmak
            CustomerManager customerManager = new CustomerManager();
            
            //nesne ile ilgili metotları kullanmak
            customerManager.Add();
            customerManager.Update();

            

            //1.kullanım
            Customer customer = new Customer();
            customer.Id = 12;
            customer.FirstName = "Mehmet";
            customer.city = "Yozgat";

            //2.kullanım
            Customer customer2 = new Customer
            {
                Id = 2 , FirstName = "Berkay" , city = "Samsun"
            };
            Console.WriteLine(customer2.FirstName);


            Console.ReadKey();
        }


       

        
    }
}
