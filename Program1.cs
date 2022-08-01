using System;

namespace ArrayManipulator
{
    internal class Program
    {
        static void Exchange(List<int> array, int index)
        {
            List<int> temp = new List<int>(array.Count);

            if (index < 0 || index >= array.Count)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                for(int i = index; i < array.Count; i++)
                {
                    temp.Add(array[index+1]);
                    array.RemoveAt(index + 1);
                }
                for(int i = temp.Count-1; i >=0; i--)
                {
                    array.Insert(0, temp[i]);
                }
                Console.WriteLine(string.Join(" ", array));
            }
        }

        static void MaxEven(List<int> array)
        {
            int br = 0;
            int tempIndex = 0;
            for (int i =0; i < array.Count; i++)
            {
                if(array[i] % 2 == 0)
                {
                    if (array[i] > br)
                    {
                        br = array[i];
                        tempIndex = i;
                    }
                }
            }
            Console.WriteLine(tempIndex);
        }
        static void MaxOdd(List<int> array)
        {
            int br = 0;
            int tempIndex = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] > br)
                    {
                        br = array[i];
                        tempIndex=i;
                    }
                }
            }
            Console.WriteLine(tempIndex);
        }
        static void MinEven(List<int> array)
        {
            int br = array[0];
            int tempIndex = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] < br)
                    {
                        br = array[i];
                        tempIndex= i;
                    }
                }
            }
            Console.WriteLine(tempIndex);
        }
        static void MinOdd(List<int> array)
        {
            int br = array[0];
            int tempIndex = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] < br)
                    {
                        br = array[i];
                        tempIndex = i;
                    }
                }
            }
            Console.WriteLine(tempIndex);
        }

        static void FirstEven(List<int> array,int index)
        {
            for(int i = 0; i < index; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[j] % 2 == 0)
                    {
                        Console.WriteLine(array[j]);
                        break;
                    }
                }
            }
            
        }

        static void LastEven(List<int> array, int index)
        {
            for(int i = 0; i < index; i++)
            {
                for(int j=array.Count-1; j>=0; j--)
                {
                    if (array[j] % 2 == 0)
                    {
                        Console.WriteLine(array[j]);
                        break;
                    }
                }
            }
        }

        static void FirstOdd(List<int> array, int index)
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[j] % 2 != 0)
                    {
                        Console.WriteLine(array[j]);
                        break;
                    }
                }
            }
        }

        static void LastOdd(List<int> array, int index)
        {
            for (int i = 0; i < index; i++)
            {
                for (int j = array.Count - 1; j >= 0; j--)
                {
                    if (array[j] % 2 != 0)
                    {
                        Console.WriteLine(array[j]);
                        break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Array:");

            List<int> array=Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine("Command: ");
            string[] command=Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    Exchange(array, int.Parse(command[1]));
                }

                if(command[0] == "max" && command[1] == "even")
                {
                    MaxEven(array);
                }

                if (command[0] == "max" && command[1] == "odd")
                {
                    MaxOdd(array);
                }

                if (command[0] == "min" && command[1] == "even")
                {
                    MinEven(array);
                }

                if (command[0] == "min" && command[1] == "odd")
                {
                    MinOdd(array);
                }
                if (command[0] == "first" && command[2] == "even")
                {
                    FirstEven(array, int.Parse(command[1]));
                }

                if (command[0] == "first" && command[2] == "odd")
                {
                    FirstOdd(array, int.Parse(command[1]));
                }

                if (command[0] == "last" && command[2] == "even")
                {
                    LastEven(array, int.Parse(command[1]));
                }

                if (command[0] == "last" && command[2] == "odd")
                {
                    LastOdd(array, int.Parse(command[1]));
                }

                Console.WriteLine("Command: ");
                command = Console.ReadLine().Split().ToArray();

            }
        }
    }
}