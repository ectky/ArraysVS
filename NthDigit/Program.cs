using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class Program
    {
        static int FindNthDigit(long number, int index)
        {
            int digit = 0;

            for (int i = 0; i < index-1; i++)
            {
                number /= 10;
            }
            digit = (int)(number % 10);
            return digit;
        }

        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }
    }
}
