using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check the size of your Snake");
            Console.WriteLine("Enter letters as much as you can:");
            string size = Console.ReadLine();
            Console.WriteLine("The length of your snake is: " + size.Length);
        }
    }
}
