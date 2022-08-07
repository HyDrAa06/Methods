using System;

namespace PasswordValidator
{
    internal class Program
    {
        static void PassCheck(string pass)
        {
            char[] passwordArray = pass.ToArray();
            bool check = true;
            if(passwordArray.Length<6 || passwordArray.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                check = false;
            }


            int c = 0;
            for(int i = 0; i < passwordArray.Length; i++)
            {

                if (char.IsLetter(passwordArray[i])==false && char.IsDigit(passwordArray[i])==false)
                {                   
                    c++;                   
                }
            }
            if (c > 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                check = false;
            }

            int br = 0;
            for (int i = 0; i < passwordArray.Length; i++)
            {               
                if(char.IsDigit(passwordArray[i]) == true)
                {
                    br++;
                }
            }
            if(br < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                check = false;
            }

            if(check == true)
            {
                Console.WriteLine("Password is valid");
            }
        } 

        
        static void Main(string[] args)
        {
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            PassCheck(password);
        }
    }
}