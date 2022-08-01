using System;

namespace TribonacciSequence
{
    internal class Program
    {
        static void TribonacciSequence(int number)
        {
            int n = 1;
            int temp = 0;
            int b = 0;
            int c = 0;
            
            for (int i = 1; i <= number; i++)
            {                
                Console.Write(n + " ");
                temp = n;
                n = b + c + n;
                c = b;
                b = temp;

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Tribonacci Sequence:");
            TribonacciSequence(number);
        }
    }
}
