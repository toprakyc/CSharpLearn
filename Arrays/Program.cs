using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//diziler ve çok boyutlu diziler.. Foreach kullanımı, for kullanımı. Çok boyutlu dizi için getUpperBound kullanımı

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = new string[2]; //Array tanımlama
            elements[0] = "Hava";
            elements[1] = "Ateş";

            foreach (var item in elements)  //foreach kullanımı
            {
                Console.WriteLine(item);
            }

            int[] numbers = new int[2]; //int array
            numbers[0] = 2;
            numbers[1] = 4;

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            int[] arr = {2,5,6,8};      //farklı bir array tanımlama yolu. new yok bu sefer. kaç eleman verdiysek o kadar elemanlı
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //7 bölge ve her bölgenin en büyük 3 şehri. Yani 7 satır 3 er sütun.
            string[,] regions = new string[7, 3] //Çok boyutlu dizi
            {
                {"İstanbul","İzmit","Sakarya"},
                {"İzmir","Aydın","Manisa"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Trabzon","Rize","Tokat"},
                {"Hakkari","Şırnak","Malatya"},
                {"Adıyaman","Gaziantep","Şanlıurfa"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)     //0 ıncı dimension -> regions.GetUpperBound(0) (Satır)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)     //1. dimension -> regions.GetUpperBound(1) (Sütun)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**************");
            }

            //foreach (var item in regions)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadLine();
        }
    }
}
