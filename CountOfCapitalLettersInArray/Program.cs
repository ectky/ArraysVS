using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfCapitalLettersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int count = 0; char letter;

            for (int i = 0; i < array.Length; i++)
            {
                if (char.TryParse(array[i], out letter))
                {
                    if (letter >= 'A' && letter <= 'Z')
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
