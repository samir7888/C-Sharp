using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check the size of your D");
            Console.WriteLine("Enter letters as much as you can:");
            string size = Console.ReadLine();
            Console.WriteLine("The length of your input is: " + size.Length);
        }
    }
}
