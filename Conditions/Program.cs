using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 20;
            if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else if(number == 21)
            {
                Console.WriteLine("Number is 21");
            }
            else
            {
                Console.WriteLine("Number is not 20 or 21");
            }
            //single line if : Console.WriteLine(number == 20 ? "Number is 20" : "Number is not 20");
            Console.ReadLine();
        }
    }
}
