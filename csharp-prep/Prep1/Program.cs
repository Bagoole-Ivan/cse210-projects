using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        string firstName = "What is your first name? ";
        Console.Write(firstName);
        string name1 = Console.ReadLine();
        string sirName = "What is your sir name? ";
        Console.Write(sirName);
        string name2 = Console.ReadLine();

        Console.WriteLine($"Your name is {name1}, {name2}  {name1}");

    }
}