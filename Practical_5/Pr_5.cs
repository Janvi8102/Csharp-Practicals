using System;

namespace Practical_5
{
    class Pr_5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            
                try
                {
                for (int i = 0; i < arr[4]; i++)
                {
                        Console.WriteLine(arr[i]);
                    }
                }
                catch(IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("This is finally Block");
                }
        }
    }
}