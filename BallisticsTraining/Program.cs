using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] comands = Console.ReadLine().Split(' ').ToArray();
            int x = coordinates[0];
            int y = coordinates[1];
            int x1 = 0;
            int y1 = 0;

            for (int i = 1; i < comands.Length; i += 2)
            {
                if (comands[i - 1] == "up")
                {
                    y1 += int.Parse(comands[i]);
                }
                else if (comands[i - 1] == "down")
                {
                    y1 -= int.Parse(comands[i]);
                }
                else if (comands[i - 1] == "left")
                {
                    x1 -= int.Parse(comands[i]);
                }
                else if (comands[i - 1] == "right")
                {
                    x1 += int.Parse(comands[i]);
                }
            }
            Console.WriteLine($"firing at [{x1}, {y1}]");

            if (x1 == x && y1 == y)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
