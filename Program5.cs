using System;

namespace FactorialDivision
{
    internal class Program
    {
        static int Factorial(int number, int result)
        {
            for(int i = 1;i <= number; i++)
            {
                result = result * i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First number:");
            int firstNumber=int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int secondNumber=int.Parse(Console.ReadLine());

            int firstResult = 1;
            int secondResult = 1;

            Factorial(firstNumber, firstResult);
            Factorial(secondNumber, secondResult);

            int result = Factorial(firstNumber, firstResult) / Factorial(secondNumber, secondResult);

            Console.WriteLine(String.Format("{0:0.00}", result));

        }
    }
}