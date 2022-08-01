using System;

namespace NxNMatrix
{
    internal class Program
    {
        static void PrintLine(int n)
        {
            for(int i =0; i < n; i++)
            {
                for(int j =0; j < n; j++)
                {
                    Console.Write(n);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Matrix:");
            PrintLine(n);
        }
    }
}