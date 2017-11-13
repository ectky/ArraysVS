using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            string previous = ""; bool checker = false;
            string str = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == previous && checker)
                {
                    str = array[i];
                }
                if (array[i] == previous)
                {
                    checker = true;
                }
                else
                {
                    checker = false;
                }
                previous = array[i];
            }

            for (int i = 0; i < 2; i++)
            {
                Console.Write(str + ' ');
            }
            Console.Write(str);

        }
    }
}
