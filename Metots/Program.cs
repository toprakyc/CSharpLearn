using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Çalışmalar: Metotlar, Parametreli Metotlar, Default Parametreli Metotlar, Ref Keywordü, Out Keywordü, Metot Overloading
//Params Keywordü
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            Console.WriteLine(Add2(15));

            int number1 = 21;
            int number2 = 100;
            var result = Add3(ref number1, number2);  //out keywordü kullanırsakta number1 ı set etme zorunluluğumuz kalkmış olur
            //fakat out kullanıyorsak; number1 değişkeninin Add3() metodu içerisinde en az 1 kez set edilmiş olması gerekir.
            //bu zorunlukluk ref ile out arasındaki farklardan 2.sidir. ilki refte değişken set edilmesi zorunluluğuydu.
            Console.WriteLine(result);
            Console.WriteLine(number1); //Metot içinde 30 yapılsada, değer tipli olduğundan 20 yazar. Ama eğer ref keywordünü
            //kullanırsak değer tipli değişkeni referans tipe çevirmiş oluruz. hem metot hemde metodun çağırılmasında ref
            //keywordu kullandık..
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,3,4));
            Console.WriteLine(Add4(1,2,3,4,5,6)); //params kullandık.

            Console.ReadLine();
        }
        //metotları neden kullanıyoruz?
        //örneğin bir kaydetme metodunuz var. her seferinde bu kodu yazmıyoruz. Bunun yerine metot yazıp lazımolunca
        //çağırıyor ve kullanıyoruz.. Ve tek merkezde kontrol edebiliyoruz.
        static void Add()   //void olduğundan sadece çıktı verir
        {
            Console.WriteLine("Added!!");
        }
        static int Add2(int number1, int number2=30)   //hem 2 parametreli hemde veri döndürüyor. -- default parametreli 
            //olması için de number2 ye yaptığımızı yaparız.. yukarıda(main içinde) da sadece bir parametre girişi yaparız.
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3(ref int number1, int number2)
        {
            number1 = 32;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2) //çarpma metodu
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3) //çarpma metodunu overload ettik. metodun 
                                                //imzası örneğin ->  int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers)   //overloadla içinden çıkamazsak params kullanırız kaç sayı varsa o kadar toplar
        {
            return numbers.Sum();
        }
    }
}
