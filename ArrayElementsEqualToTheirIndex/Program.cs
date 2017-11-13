using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElementsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] newArray = new int [array.Length];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                {
                    newArray[j] = i;
                    j++;
                }
            }

            for (int i = 0; i < j; i++)
            {
                Console.Write(newArray[i] + " ");
            }
        }
    }
}
