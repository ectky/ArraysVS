using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            bool symetric = false;

            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] == array[array.Length - 1 - i])
                {
                    symetric = true;
                }
                else
                {
                    symetric = false;
                    break;
                }
            }

            if (symetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
