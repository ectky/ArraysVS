using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void RepeatString(string message, int cnt)
        {
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(message);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            int cnt = int.Parse(Console.ReadLine());
            RepeatString(message, cnt);
        }
    }
}
