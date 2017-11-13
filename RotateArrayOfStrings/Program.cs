using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            string[] newArray = new string[array.Length];

            newArray[0] = array[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray[i + 1] = array[i];
            }

            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
