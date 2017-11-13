using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizableArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            int[] array = new int[size];
            int index = 0;
            bool lastElement = false;
            bool printed = false;

            for (int i = 0; i < size; i++)
            {
                array[i] = int.MinValue;
            }

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "push")
                {
                    try
                    {
                        array[index] = int.Parse(command[1]);
                        index++;
                    }
                    catch (Exception)
                    {
                        size *= 2;
                        int[] array1 = new int[size];
                        for (int i = 0; i < array.Length; i++)
                        {
                            array1[i] = array[i];
                        }
                        array1[array.Length] = int.Parse(command[1]);
                        index++;
                        for (int i = array.Length + 1; i < array1.Length; i++)
                        {
                            array1[i] = int.MinValue;
                        }

                        array = new int[size];
                        for (int i = 0; i < array1.Length; i++)
                        {
                            array[i] = array1[i];
                        }
                    }
                }
                else if (command[0] == "removeAt")
                {
                    int removeAt = int.Parse(command[1]);
                    if (removeAt == index - 1)
                    {
                        index--;
                    }
                    array[removeAt] = int.MinValue;
                }
                else if (command[0] == "pop")
                {
                    index--;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (i == array.Length - 1)
                        {
                            array[i] = int.MinValue;
                            break;
                        }
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (array[j] == int.MinValue)
                            {
                                lastElement = true;
                            }
                            else
                            {
                                lastElement = false;
                                break;
                            }
                        }
                        if (lastElement)
                        {
                            array[i] = int.MinValue;
                            break;
                        }
                    }
                }
                else if (command[0] == "clear")
                {
                    index = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = int.MinValue;
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            printed = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != int.MinValue)
                {
                    Console.Write(array[i] + " ");
                    printed = true;
                }
            }
            if (!printed)
            {
                Console.WriteLine("empty array");
            }
        }
    }
}
