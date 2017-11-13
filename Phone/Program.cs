using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();
            string str = "";
            int sum = 0;

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "done")
            {
                if (command[0] == "call")
                {
                    for (int i = 0; i < phones.Length; i++)
                    {
                        if (command[1] == phones[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");
                            for (int j = 0; j < phones[i].Length; j++)
                            {
                                char number = phones[i][j];
                                if (number >= '0' && number <= '9')
                                {
                                    sum += (int)char.GetNumericValue(number);
                                }
                            }
                            if (sum % 2 == 0)
                            {
                                Console.Write("call ended.");
                                int mins = sum / 60;
                                int secs = sum - (mins * 60);
                                Console.WriteLine($" duration: {mins:D2}:{secs:D2}");
                            }
                            else
                            {
                                Console.WriteLine("no answer");
                            }
                            break;
                        }

                        if (command[1] == names[i])
                        {
                            Console.WriteLine($"calling {phones[i]}...");
                            for (int j = 0; j < phones[i].Length; j++)
                            {
                                char number = phones[i][j];
                                if (number >= '0' && number <= '9')
                                {
                                    sum += (int)char.GetNumericValue(number);
                                }
                            }
                            if (sum % 2 == 0)
                            {
                                Console.Write("call ended.");
                                int mins = sum / 60;
                                int secs = sum - (mins * 60);
                                Console.WriteLine($" duration: {mins:D2}:{secs:D2}");
                            }
                            else
                            {
                                Console.WriteLine("no answer");
                            }
                            break;
                        }
                    }
                }
                else if (command[0] == "message")
                {
                    for (int i = 0; i < phones.Length; i++)
                    {
                        if (command[1] == phones[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");
                            for (int j = 0; j < phones[i].Length; j++)
                            {
                                char number = phones[i][j];
                                if (number >= '0' && number <= '9')
                                {
                                    sum -= (int)char.GetNumericValue(number);
                                }
                            }
                            if (sum % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                            break;
                        }

                        if (command[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {phones[i]}...");
                            for (int j = 0; j < phones[i].Length; j++)
                            {
                                char number = phones[i][j];
                                if (number >= '0' && number <= '9')
                                {
                                    sum -= (int)char.GetNumericValue(number);
                                }
                            }
                            if (sum % 2 == 0)
                            {
                                Console.WriteLine("meet me there");
                            }
                            else
                            {
                                Console.WriteLine("busy");
                            }
                            break;
                        }
                    }
                }
                sum = 0;
                command = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
