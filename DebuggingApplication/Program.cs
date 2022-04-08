using System;

namespace DebuggingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string userResponse = Console.ReadLine();

            if (int.TryParse(userResponse,out int value))
            {
                Console.WriteLine("The entered value is a integer");
            }
        }
    }
}