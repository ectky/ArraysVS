using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurrencesOfLargerNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double element = double.Parse(Console.ReadLine());
            int count = 0;

            foreach (double item in array)
            {
                if (item > element)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
