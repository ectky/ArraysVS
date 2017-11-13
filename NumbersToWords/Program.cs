using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class Program
    {
        static void Letterize(int number)
        {
            string minus = "";
            
            if (number > 999)
            {
                Console.WriteLine("too large");
            }
            else if (number < -999)
            {
                Console.WriteLine("too small");
            }
            else if (number > -100 && number < 100)
            {
                return;
            }
            else
            {
                if (number < 0)
                {
                    minus = "minus ";
                    number = Math.Abs(number);
                }
                int hundreds = number / 100;
                string hundred = "";
                switch (hundreds)
                {
                    case 1: hundred = "one"; break;
                    case 2: hundred = "two"; break;
                    case 3: hundred = "three"; break;
                    case 4: hundred = "four"; break;
                    case 5: hundred = "five"; break;
                    case 6: hundred = "six"; break;
                    case 7: hundred = "seven"; break;
                    case 8: hundred = "eight"; break;
                    case 9: hundred = "nine"; break;
                    default:
                        break;
                }
                int ones = number % 10;
                number /= 10;
                int tenths = number % 10;
                string tenth = "";
                string one = "";

                if (ones == 0 && tenths == 0)
                {
                    Console.WriteLine($"{minus}{hundred}-hundred");
                    return;
                }

                if (tenths == 1)
                {
                    switch (ones)
                    {
                        case 0: tenth = "ten"; break;
                        case 1: tenth = "eleven"; break;
                        case 2: tenth = "twelve"; break;
                        case 3: tenth = "thirteen"; break;
                        case 4: tenth = "fourteen"; break;
                        case 5: tenth = "fifteen"; break;
                        case 6: tenth = "sixteen"; break;
                        case 7: tenth = "seventeen"; break;
                        case 8: tenth = "eighteen"; break;
                        case 9: tenth = "nineteen"; break;
                        default:
                            break;
                    }
                    Console.WriteLine($"{minus}{hundred}-hundred and {tenth}");
                }
                else
                {
                    switch (tenths)
                    {
                        case 2: tenth = "twenty "; break;
                        case 3: tenth = "thirty "; break;
                        case 4: tenth = "forty "; break;
                        case 5: tenth = "fifty "; break;
                        case 6: tenth = "sixty "; break;
                        case 7: tenth = "seventy "; break;
                        case 8: tenth = "eighty "; break;
                        case 9: tenth = "ninety "; break;
                        default:
                            break;
                    }

                    switch (ones)
                    {
                        case 1: one = "one"; break;
                        case 2: one = "two"; break;
                        case 3: one = "three"; break;
                        case 4: one = "four"; break;
                        case 5: one = "five"; break;
                        case 6: one = "six"; break;
                        case 7: one = "seven"; break;
                        case 8: one = "eight"; break;
                        case 9: one = "nine"; break;
                        default:
                            one = "";
                            break;
                    }
                    Console.WriteLine($"{minus}{hundred}-hundred and {tenth}{one}");
                }
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Letterize(number);
            }

        }
    }
}
