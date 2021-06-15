using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//stringler reference typetır.
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            //StringMethods();

            Console.ReadLine();
        }

        private static void StringMethods()
        {
            string sentence = "My name is Yucel Toprak.";
            var result = sentence.Length;   //Length bir özelliktir yani property. Karakter sayısını döndürdük.
            Console.WriteLine(result);
            var result2 = sentence.Clone();
            //clone() da bir metot. result2 oluştuğunda yeni bir referans değeri ile bağlanır.
            //When a String object is created, the actual value is stored within dynamic memory, or on the Heap.
            //So String is a Reference type, because it does not have default allocation size. Immutable means, it cannot
            //be changed after it has been created. Every change to a string will create a new string
            sentence = "My name is not Yucel Toprak.";
            Console.WriteLine(result2);     //çıktı yine ilk setlenen değerdir çünkü referans tip.

            bool result3 = sentence.EndsWith(".");
            bool result4 = sentence.StartsWith("My ");
            var result5 = sentence.IndexOf("name");   //sıklıkla kullanılan metotlardan. Bir stringde belli bir karakter
                                                      //veya ifadeyi aramak için kullanılır. Bulamazsa -1 döner.
            var result6 = sentence.LastIndexOf("e");  //aramaya sondan başlar
            var result7 = sentence.Insert(0, "He said: ");      //Insert kullanımı. Index ile kullanılır.
            var result8 = sentence.Substring(15);
            var result9 = sentence.Substring(15, 12);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");      //karakteri değiştirir
            var result13 = sentence.Remove(5);  //5 ten sonrasını atar
            var result14 = sentence.Remove(11, 4);    //5 ten sonra 10 tanesini uçur anlamında.
            Console.WriteLine(result9);
        }

        private static void Intro()
        {
            string a = "Ankara";    //stringler char array dir   Console.WriteLine(a[0]);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            string b = "İstanbul";
            string result = a + b;     //3. bir değişkenle string toplama
            Console.WriteLine(result);

            string c = "Samsun";
            Console.WriteLine(String.Format("{0} {1} {2}", a, b, c)); //string.Format kullanımı. bu sayede bellekte 3.
                                                                      //bir result değişkeninden kaçınmış oluruz.
        }
    }
}
