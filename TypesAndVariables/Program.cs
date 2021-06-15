using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hellooooo");
            //----------------DEĞER TİPLER-------------------
            short number2 = 32767;      //16 bit yer kaplar
            long number3 = 9223372036854775807;     //64 bit yer kaplar
            byte number4 = 255;     //1 byte yer kaplar
            int number1 = 2147483647;   //32 bit yer kaplar. Değer tiptir
            bool condition = true; //bu da bir değer tip
            char character = 'A';
            string city = "Ankara";
            double number5 = 10.5;
            decimal number6 = 10.4m;    //int için long neyse double içinde decimal odur. virgülden sonra 29 değer tutabilir
            
            var deger = 10; //ilk değerini ne verirsek int, string; artık o tiptedir
            deger = 'A'; //int olduğundan 65 yazar.

            Console.WriteLine("Number1 is: " + number1);
            Console.WriteLine("Number1 is: {0}", number1);
            Console.WriteLine("Number2 is: {0}", number2);
            Console.WriteLine("Number3 is: {0}", number3);
            Console.WriteLine("Number4 is: {0}", number4);
            Console.WriteLine("character is: {0}", (int)character); //rahatlıkla ascii ye çevirebiliriz.
            Console.WriteLine("String is: {0}", city);
            Console.WriteLine("Number5 is: {0}", number5);
            Console.WriteLine("Number6 is: {0}", number6);
            Console.WriteLine("Deger is: {0}", deger);
            Console.WriteLine(Days.Friday); //kast ile (int) dersek sıra no verir...


            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday  //tek tek string yazmamış oluyoruz. magic string muhabbeti 
    }
}
