using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//SOLID ->  Yazılım geliştirme prensipleri
//Bu kodda Interface Segregation prensibine uyduk.
//Single Responsibility : Sınıflarımızın iyi tanımlanmış tek bir sorumluluğu olmalı.
//Open-Closed : Sınıflarımız değişikliğe kapalı ancak yeni davranışların eklenmesine açık olmalı.
//Liskov Substitution : Kodumuzda herhangi bir değişiklik yapmaya gerek kalmadan türetilmiş sınıfları (sub class) türedikleri ata sınıfın (base class) yerine kullanabilmeliyiz.
//Interface Segregation : Genel kullanım amaçlı tek bir kontrat yerine daha özelleşmiş birden çok kontrat oluşturmayı tercih etmeliyiz.
//Dependency Inversion : Katmanlı mimarilerde üst seviye modüller alt seviyedeki modüllere doğruda bağımlı olmamalıdır.

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();      //tüm çalışanlara çalış emri verdik.
            }
            Console.WriteLine("*******************");
            IEat[] eats = { new Manager(), new Worker()};
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.WriteLine("*******************");
            ISalary[] salarys = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salarys)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }
    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager eating...");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager getting paid...");
        }

        public void Work()
        {
            Console.WriteLine("Manager working...");
        }
    }
    class Worker:IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker eating...");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker getting paid...");
        }

        public void Work()
        {
            Console.WriteLine("Worker working...");
        }
    }
    class Robot:IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot working...");
        }
    }
}
