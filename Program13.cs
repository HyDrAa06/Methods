using System;

namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void SmallestNumber(int a, int b, int c, int smallestNumber)
        {
            if(a < b && a < c)
            {
                smallestNumber = a;
            }
            if (b < a && b < c)
            {
                smallestNumber = b;
            }
            if (c < b && c < a)
            {
                smallestNumber = c;
            }


            Console.WriteLine("Smallest number: " + smallestNumber);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First number:");
            int a =int.Parse(Console.ReadLine());

            Console.Write("Second number:");
            int b =int.Parse(Console.ReadLine());

            Console.WriteLine("Third number:");
            int c =int.Parse(Console.ReadLine());

            int smallestNumber = 0;

            SmallestNumber(a, b, c, smallestNumber);
        }
    }
}