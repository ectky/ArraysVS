using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class Program
    {
        static string IntegerToBase(int number, int toBase)
        {
            int remeinder = 0;
            string converted = "";
            while (number != 0)
            {
                remeinder = number % toBase;
                converted = (char)(remeinder + 48) + converted;
                number /= toBase;
            }
            return converted;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(number, toBase));
        }
    }
}
