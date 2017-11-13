using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbersAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2 == 1 || array[i] % 2 == -1) && i % 2 == 1)
                {
                    Console.WriteLine($"Index {i} -> {array[i]}");
                }
            }

            
        }
    }
}
