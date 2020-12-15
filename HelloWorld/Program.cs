using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"[{DateTime.Now}] Today was a good day, {name}!)");
            Console.ReadLine();
        }
    }
}
