using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string newWord = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    int number = (int)(word[i]);
                    word[i] = (char)(number - numbers[i]);
                    newWord += word[i];
                }
                else
                {
                    int number = (int)(word[i]);
                    word[i] = (char)(number + numbers[i]);
                    newWord += word[i];
                }
            }

            Console.WriteLine(newWord);
        }
    }
}
