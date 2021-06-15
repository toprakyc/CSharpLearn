using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//constructor ile bir sinifin ihtiyac duyduğu parametreleri set ederiz. Constrctorlar overload edilebilir.
namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsingParameterWithConstructor();

            //UsingConstructorsExampleTwo();

            //ProfessionalLoggerType(); //Constructor injection

            SendingParameterToBaseClassessConstructorBlock();

            //StaticClassesAndMethods();

            Console.ReadLine();
        }

        private static void StaticClassesAndMethods()
        {
            Teacher.Number = 10; //static nesneler ortak nesnelerdir. genellikle static nesnelerden uzak durmaya çalışırız.
            Utilities.Validate();

            Manager.DoSomething();      //manager klasının bu operasyonu instance'sız çağrılabilir
            Manager manager = new Manager();
            manager.DoSomething2(); //instance ile çağırırız
        }

        private static void ProfessionalLoggerType()
        {
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
        }

        private static void UsingConstructorsExampleTwo()
        {
            Product product = new Product { Id = 10, Name = "Pencil" }; //bu şekilde tanımlamak yerine
            Product product1 = new Product(15, "Scriwdriver");  //bu şekilde constructor ile de kullanılabilir
        }

        private static void UsingParameterWithConstructor()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
        }

        private static void SendingParameterToBaseClassessConstructorBlock()
        {
            PersonManager personManager = new PersonManager("Yucel");
            personManager.Add();
        }
    }
    class CustomerManager
    {
        int _count=10;  //default değer
        public CustomerManager(int count)   
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed.");
        }
        public void Add()
        {
            Console.WriteLine("Added {0} items.", _count);
        }
    }
    class Product
    {
        public Product()
        {

        }
        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }
    class EmployeeManager
    {
        ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message.",_entity);
        }
    }
    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)    //temel sınıfın yapıcı bloğuna parametre yollamak
        {

        }
        public void Add()
        {
            Console.WriteLine("Added!");
            Message();          //base klasın metodunu kullandık.
        }
    }
    static class Teacher    //static nesnemizin tüm özelliklerinin de static bildirgesine sahip
                            //olması gerekir; metot property vs. hepsi.. Ve bu klasın nesnesinin instance'ı üretilmez.
    {
        public static int Number { get; set; }
    }
    static class Utilities  //sık kullandığımız bir operasyon olsun diyelim.. Bir iş yap ve bitir gibi bir durum.
                            //Amaç bu. Validate e bir de parametre verirsiniz.. Utilities.Validate(); şeklinde main içinde çağırılır
    {                       
        static Utilities()
        {
            //ctor tanımlanabilir
        }
        public static void Validate()   
        {
            Console.WriteLine("Validation is done!");       //validasyon kodu old. varsayalım
        }
    }
    class Manager //klası statik yapmayıp özelliklerini statik yapabiliriz.. Bu senaryoda klasımızın statik olmaması gerekiyor.
    {
        public static void DoSomething()         //statik yaptık ama klas statik değil
        {                                        //statiklerle ilgili kullanım senaryolarına örnek olarak "singleton dizayn pattern" verilebilir.
            Console.WriteLine("Done 1");
        }
        public void DoSomething2()              
        {
            Console.WriteLine("Done 2");
        }
    }
}