using System;

namespace MiddleCharacters
{
    internal class Program
    {
        static void Middle(string word)
        {
            char[] wordArray= word.ToArray();
            int temp = wordArray.Length/2;

            if(wordArray.Length % 2 == 0)
            {
                char firstMiddleletter = wordArray[temp-1];
                char secondMiddleletter = wordArray[temp];
                Console.WriteLine("{0}{1}",firstMiddleletter, secondMiddleletter);
            }
            else
            {                
                char middleLetter = wordArray[wordArray.Length / 2];
                Console.WriteLine("asdwasd");
                Console.WriteLine(middleLetter);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input");
            string input = Console.ReadLine();

            Console.WriteLine("Output:");
            Middle(input);

            
        }
    }
}