using System;

namespace Pr7_LSP

{
    public class Bird
    {
        public void fly()
        {

            Console.WriteLine("I can Fly");

        }
    }
    public class Duck : Bird
    {
        public void duck()
        {
            Console.WriteLine("I Like Water, I am a Duck");
        }
    }

    public class Swan : Duck
    {
        public void swan()
        {
            Console.WriteLine("I also like Water, I am a Swan");
        }
    }
    public class Penguin : Bird
    {
        public void penguin()
        {
            Console.WriteLine("I Like Ice,I am Penguin");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Swan s = new Swan();
            s.fly();
            s.duck();
            s.swan();
           Penguin p = new Penguin();
            p.penguin();
        }
    }
}