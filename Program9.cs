using System;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void PalindromeCheck(string number)
        {

            string reversedNumber = string.Empty;

            for(int i = number.Length - 1; i >= 0; i--)
            {
               reversedNumber+=number[i];
            }

            if(reversedNumber == number)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
           
        }    
        static void Main(string[] args)
        {
            Console.WriteLine("Number:");
            string number = Console.ReadLine();
            while(number != "END")
            {
                PalindromeCheck(number);

                Console.WriteLine("Number:");
                number = Console.ReadLine();
            }
        }
    }
}