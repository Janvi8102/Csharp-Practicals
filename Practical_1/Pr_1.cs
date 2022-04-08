using System;

namespace Practical_1
{
    class Pr_1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First Number:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            float num2 = float.Parse(Console.ReadLine());

            float sum = num1 + num2;
            float sub = num1 - num2;
            float mul = num1 * num2;
            float div = num1 / num2;

            Console.WriteLine("Sum of {0} and {1} is: {2}",num1, num2, sum);
            Console.WriteLine("Subtractionof {0} and {1} is: {2}", num1, num2, sub);
            Console.WriteLine("Multiplicationof {0} and {1} is: {2}", num1, num2, mul);
            Console.WriteLine("Divisionof {0} and {1} is: {2}", num1, num2, div);
        }
    }
}