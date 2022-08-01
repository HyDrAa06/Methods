using System;

namespace DataTypes
{
    internal class Program
    {

        static void DataTypes(string command, string input)
        {
            if(command == "int")
            {
                Console.WriteLine("Result: " + int.Parse(input)*2);
            }
            if(command == "real")
            {
                Console.WriteLine("Result: " + String.Format("{0:0.00}", (int.Parse(input) * 1.5)));
            }
            if( command == "string")
            {
                Console.WriteLine("Result: ${0}$",input);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Command:");
            string command=Console.ReadLine();
            Console.WriteLine("Input:");
            string input=Console.ReadLine();

            DataTypes(command, input);
        }
    }
}