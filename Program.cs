using System;

namespace VowelsCount
{
    internal class Program
    {

        static void VowelsCheck(string word)
        {
            int br = 0;
            char[]vowels = word.ToArray();

            for(int i = 0; i < vowels.Length; i++)
            {
                if(vowels[i] == 'a' || vowels[i] == 'A' || vowels[i] == 'e' || vowels[i] == 'E' || vowels[i] == 'o' || vowels[i] == 'O' || vowels[i] == 'i' || vowels[i] == 'I' || vowels[i] == 'u' || vowels[i] == 'U')
                {
                    br++;
                }
            }
            
            Console.WriteLine("Vowels count: " + br);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Word:");
            string word = Console.ReadLine();
            VowelsCheck(word);
        }
    }
}