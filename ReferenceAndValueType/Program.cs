using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;  //eklendi
using System.Threading.Tasks;
//integer, double, boolean, enum, decimal gibi değişkenler DEĞER tiptir.
//Class, string, array, interface, abstract klaslar REFERANS tiptir.
namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 10;
            number1 = number2;
            number2 = 50;
            Console.WriteLine(number1);

            string[] a = new string[] { "Ankara", "Afyon", "Artvin" };
            string[] k = new string[] { "Kocaeli", "Kırşehir", "Kars" };
            a = k;  //garbage collector; a'nın nesnesi olmadığı için temizler. Artık iki dizi de k'nin adresini referans alır
            k[2] = "Sivas"; //bu değişimler istisnasız ikisini de etkiler.
            Console.WriteLine(a[2]);

            //class örneği olsun buda. Veritabanı datasının işlemleri bu klasla yapılır..
            DataTable dataTable1 = new DataTable();     //using System.Data; eklendi
            DataTable dataTable2 = new DataTable();
            dataTable2 = dataTable1;    //datatable2 nin newlenmiş olmasının anlamı kalmadı.


            Console.ReadLine();
        }
    }
}
