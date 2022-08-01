using System;

namespace CharactersInRange
{
    internal class Program
    {
        static void Characters(char char1, char char2)
        {

            for(char i = char1 ; i < char2; i++)
            {
                if(i != char1)
                {
                    Console.Write(i + " ");
                }
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First character:");
            char firstChar = char.Parse(Console.ReadLine());

            Console.WriteLine("Second character:");
            char secondChar = char.Parse(Console.ReadLine());


            if (secondChar < firstChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            Characters(firstChar, secondChar);
        }
    }
}