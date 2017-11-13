using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string name = Console.ReadLine();

            while (name != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        Console.WriteLine($"{name} -> {phones[i]}");
                    }
                }
                name = Console.ReadLine();
            }
        }
    }
}
