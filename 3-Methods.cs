using System;

class Program
{
    static int MyMethod(int name, int age = 22)
    {
        return name + age;
    }
    static void Main(string[] args)
    {


        Console.WriteLine(MyMethod(11, 22));
    }
}