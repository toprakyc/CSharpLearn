using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//private erişim belirteci sadece tanımlandığı blok içerisinde geçerli olan bir yapıdır.
//class olabilir, property olabilir, değişken olabilir.. 
//private bir değişkende klasik süslü parantezler içinde olan yerlerde kullanım sağlanır. Farklı bir klasa
//Inheritance durumunda vs. private değişkene(propta olabilir her neyse) erişilemez. Fakat protected'ta erişilebilir.
//private'ten bir farkı budur. Internal ise protected'ın bir üstüdür.
//class ların default erişim belirteci internal dır.  classları kendi bağlı olduğu projede referans göstermeden kullanabiliriz
//internal ise proje içerisinde istediğimiz noktada çağırabileceğimiz anlamına gelir.  
//bir klas(üst seviye = iç içe değil) ya internaldır ya da publictir. private veya protected olamaz.
//public; başka bir projeden erişim sağlamak için kullanılır. Ayrıca References'a eklemek ve using AccessModifiers diye
//belirtmek gerekiyor.. (AccessModifiersDemo ya ekledim)
namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected int Id { get; set; }
        public void Save()
        {
            
        }
        public void Delete()
        {

        }
    }
    class Student: Customer
    {
        public void Save2()
        {
            
        }
    }
    public class Course
    {
        public string Name { get; set; }
    }
}
