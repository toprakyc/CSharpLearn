using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//klaslar yapmak istediğimiz işlemleri gruplara ayırmak. Bu grup üzerinden işlemlerimizi yapmak ve rahatlıkla bu gruplara
//ulaşmak için kullanırız.
//Customer adında bir klas oluşturup; klasların property tutma özelliğini inceleyelim.
namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer(); //propertyli klas tanımlama 1
            customer.Id = 313974;       //prop içindeki set bloğu çalışır
            customer.FirstName = "Yucel";
            customer.LastName = "Toprak";
            customer.City = "Istanbul";

            Customer customer1 = new Customer   //propertyli klas tanımlama 2
            {
                City = "Kocaeli",
                FirstName = "Muhammed",
                LastName ="Ali",
                Id = 947852
            };
            Console.WriteLine(customer1.FirstName); //prop içindeki get bloğu çalışır

            Console.ReadLine();
        }
    }
}
