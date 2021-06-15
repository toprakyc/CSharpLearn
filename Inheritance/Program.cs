using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//zaten bir önceki çalışmada interfacelerde inheritance mantığını kullandık. Buradada klaslar üzerinden bakalım duruma.
//bir klasın birden fazla interfaceden inherit olabildiğini gördük. Ama bir klas birden fazla klastan inherit olamaz
//peki interface mi kullanmalıyız yoksa inheritance mi?
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = { new Customer {FirstName="Hadi", LastName="Turan", City="Ankara", Id=007}, 
                                new Student {FirstName="Salih", LastName="Kılıç", Department="Science", Id=006} };
            foreach (var name in persons)
            {
                Console.WriteLine("Name and Surname: {0} {1}",name.FirstName, name.LastName);
            }
            Console.ReadLine();
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string City { get; set; }
    }
    class Student:Person
    {
        public string Department { get; set; }
    }
}
