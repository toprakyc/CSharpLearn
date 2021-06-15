using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//abstract klaslar hem interfaceler hemde virtual metotların toplamı gibidir.. Abstract klaslarda hem dolu hemde
//boş operasyonlar tanımlayabliriz. Ezilebilir metotları abstract diye belirtiriz. Abstract klaslar da
//interfaceler gibi newlenemezler. Abstract klaslar birer inheritancedır. Birden fazla klasla inherit
//edilemez. Ama interfaceler eklenebilir
namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add(); //oracleda ve sqlde aynı add çalışır
            database.Delete();     //delete operasyonu uyarlanmış şekildedir iki veritabanı içinde..
            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }
    abstract class Database //klasın kensisi abstract ve içeride içi boş tanımlamak içinde ayrıca belirtiyoruz abstract diye
    {
        public void Add()
        {
            Console.WriteLine("Added by default.");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql.");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle.");
        }
    }
}
