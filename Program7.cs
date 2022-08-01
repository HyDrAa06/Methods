using System;

namespace MultiplicationSign
{
    internal class Program
    {
        static void Sign(int num1, int num2, int num3)
        {
            List<int> list =new List<int> { num1, num2, num3 };
            int br = 0;
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i] < 0)
                {
                    br++;
                }
            }

            if(br % 2 == 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Three numbers:");
            int firstNumber=int.Parse(Console.ReadLine());
            int SecondNumber=int.Parse(Console.ReadLine());
            int thirdNumber=int.Parse(Console.ReadLine());

            Sign(firstNumber, SecondNumber, thirdNumber);
        }
    }
}
