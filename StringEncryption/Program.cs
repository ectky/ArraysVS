using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEncryption
{
    class Program
    {
        static string Encrypt(char letter)
        {
            int code = (int)letter;
            int firstDigit = 0;
            int lastDigit = 0;
            if (code >= 100)
            {
                firstDigit = code / 100;
                lastDigit = code % 10;
            }
            else
            {
                firstDigit = code / 10;
                lastDigit = code % 10;
            }
            string message = "";
            message += (char)(48 + firstDigit);
            message += (char)(48 + lastDigit);
            message += (char)(code - firstDigit);
            message = (char)(code + lastDigit) + message;
            return message;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                message += Encrypt(letter);
            }

            Console.WriteLine(message);
        }
    }
}
