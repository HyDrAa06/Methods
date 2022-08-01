using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void CharAmount(string password, bool valid)
        {
            char[] passwordCheck = password.ToArray();
            if (passwordCheck.Length < 6 || passwordCheck.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters.");

            }
            else
            {
                valid = true;
            }
        }

        static void CharContain(string password, bool valid)
        {
            
        }
        static void AtLeast2Digits(string password, bool valid)
        {           
            char[] passwordCheck = password.ToArray();
            

            int br = 0;
            string s1 = "0";
            string s2 = "9";
            char[] char1 = s1.ToArray();
            char[] char2 = s2.ToArray();

            for(char i = char1[0]; i <= char2[0]; i++)
            {
                if (passwordCheck.Contains(i))
                {
                    br++;
                }
            }

            if (br < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");

            }

            else
            {
                valid = true;
            } 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Password:");
            string password = Console.ReadLine();
            bool valid = false;

            CharAmount(password, valid);
            CharContain(password, valid);
            AtLeast2Digits(password, valid);

            if (valid == true)
            {
                Console.WriteLine("Password is valid.");
            }
        }
    }
}