using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop(); seç-sağ tıkla refactoring ile metot haline getirdik.
            //WhileLoop();
            //DoWhileLoop(); 
            //ForeachLoop();

            if (IsPrimeNumber(23) == true)
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)   //asal sayı: kendisi ve 1 hariç tam böleni olmayan sayıdır
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number%i == 0)
                {
                    result = false;
                    Console.WriteLine("Divider number is: {0}", i);
                    break;  //gereksiz yere çalışmasını önler veya i = number dersek şarta girmez ve alttan return eder.
                }
            }
            return result;
        }
        private static void ForeachLoop()
        {
            string[] names = new string[3] { "Yücel", "Can", "Toprak" };
            foreach (var item in names)
            {
                //names[1] = "Mahmut";
                //item = "Sami"; //read only olduğundan foreach içerisinde datayı değiştirme yapılamaz..
                Console.WriteLine(item);
            }
        }

        private static void DoWhileLoop()
        {
            int num = 20;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num >= 100);
            Console.WriteLine("Number is {0}", num);
        }

        private static void WhileLoop()
        {
            int num = 0;
            while (num <= 100)
            {
                Console.WriteLine(num);
                num += 1;
            }
            Console.WriteLine("Now number is {0}", num);
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)  //int i olduğundan sadece for bloğunda geçerli
            {
                Console.WriteLine(i);
            }
        }
    }
}
