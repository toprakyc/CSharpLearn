using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//profesyonel programcılıkla ilgili temel bir örnek. CustomerManager'da bir public property ile ILogger türünde
//bir Logger ürettik; ve kullanım esnasında stratejimizin ne olacağını(File mi Sms mi Database mi..) set ettik.
//Sonra Add() i çağırdık. eğer şu satırdaki(customerManager.Logger = new SmsLogger();) Logger'ı set etmeseydik
//hata verirdi uygulama. Ayrıca interface kullanma nedenimiz her loglama türünün ayrı ayrı kodlanması gerektiğindendir.
//Eğer loglama db ve file için aynı fakat sms için farklı olsaydı o zaman interface yerine virtual yapardık.
//Eğer abstract kullansaydık; örneğin bir operasyonu herkes kullanırdı, başka bir operasyonu herkes değiştirip kullanırdı..
namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new FileLogger();   //setlenen loglama türü değiştirilip çalıştırılabilir
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILogger Logger { get; set; }     //prop oluşturduk. -Property Injection-
        public void Add()
        {
            Logger.Log();      //prop ı çağırdık.
            Console.WriteLine("Customer Added!");
        }
    }
    class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
//eğer bir loglama klasınız miras almıyorsa bir sorun var demektir. Çünkü ileride müşteriniz daha farklı
//isteklerde bulunacak ve kodları en baştan tekrar yazmanız gerekecek. Bir interface ile bu sorunu çözebiliriz.
