using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            if(IsPerfectNumber(496) == 496)
            {
                Console.WriteLine("Number is perfect!");
            }
            else
            {
                Console.WriteLine("Number is not perfect!");
            }
            Console.ReadLine();
        }
        private static int IsPerfectNumber(int a)
        {
            int mult = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    mult += i;
                    Console.Write(" + {0}", i);
                }
            }
            Console.WriteLine(" Divider numbers total is: {0}", mult);
            return mult;
        }
    }
}
