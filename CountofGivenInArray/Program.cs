using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int count = 0;

            foreach (int item in array)
            {
                if (item == element)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
