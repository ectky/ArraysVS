using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            double altitude = double.Parse(array[0]);

            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i - 1] == "up")
                {
                    altitude += int.Parse(array[i]);
                }
                else
                {
                    altitude -= int.Parse(array[i]);
                }

                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }
    }
}
