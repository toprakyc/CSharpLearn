using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//tek başına bir interface in instance'ı oluşturulamaz.(interface ve abstract türü soyut nesneleri
//newleyemeyiz.) Onu inherit eden klasların ki oluşturulabilir.
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //InterfaceDemo();

            //elimizde bir data var ve bu datayı tüm veritabanlarına yazacağız.. nasıl yaparız
            ICustomerDal[] customerDals =  { new SqlServerCustomerDal(), new OracleCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();      //hem sqle hemde oracle a yazar.. İleride mySql diye bir ekleme olursa onuda katarız..
            }

            Console.ReadLine();
        }

        private static void InterfaceDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Update(new OracleCustomerDal());
            customerManager.Delete(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            Customer customer = new Customer()      //bu 1. yöntem
            {
                Id = 1,
                Firstname = "Maxwell",
                LastName = "Clark",
                Address = "St. Saint-jermen"
            };
            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            

            PersonManager personManager1 = new PersonManager(); 
            personManager.Add(new Student { Id = 2, Firstname = "Taner", LastName = "Tolga", Department = "Mersin" });  //bu da 2.
        }
    }
    //interface lerde prop tanımı yazılırken başındaki public yazılmaz. sadece imza kısmı yazılır.
    //yani dönüş değeriyle başlanır. Interfaceler klasslara aynı özellikleri vermek için kullanılır.
    //Tek başına anlamsızdır. Interfaceler soyut nesnedir. Klaslar somut nesnelerdir. Interfacelere tanımlanan operasyonları,
    //property veya metot farketmez; onu implemente eden klasında da doldurulması gerekir. Altı kızarıyor zaten..
    interface IPerson   //interface tanımı.. klasa çok benzer. içinde property tanımladık
    {
        int Id { get; set; }
        string Firstname { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager     //iş katmanı operasyonlarını burada tanımlıyoruz..
    {
        public void Add(IPerson person) 
        {
            Console.WriteLine(person.Firstname);
        }
    }
}

