using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is the grade? ");
        int grade = Console.Read();
        if (grade < 60)
        {
            Console.WriteLine("The grade is F");
        }
        else if (grade == 60)
        {
            Console.WriteLine("The grade is D");
        }
        else if(grade > 60 && grade < 65)
        {
            Console.WriteLine("The grade is D+");
        }
        else if(grade > 65 && grade <70)
        {
            Console.WriteLine("The grade is C-");
        }
        else if(grade == 70)
        {
            Console.WriteLine("The grade is C");
        }
        else if(grade > 70 && grade <75)
        {
            Console.WriteLine("The grade is C+");
        }
        else if(grade > 75 && grade <80)
        {
            Console.WriteLine("The grade is B-");
        }
        else if(grade == 80)
        {
            Console.WriteLine("The grade is B");
        }
        else if(grade > 80 && grade <85)
        {
            Console.WriteLine("The grade is B+");
        }
        else if(grade > 85 && grade < 90)
        {
            Console.WriteLine("The grade is A-");
        }
        else if(grade >= 90 && grade < 100 )
        {
            Console.WriteLine("The grade is A");
        }
        else
        {
            Console.WriteLine("Input the right grade.");
        }

        while (grade >= 70)
        {
            Console.WriteLine("Congratulations you made it.");
        }
        while (grade < 70)
        {
            Console.WriteLine("Retake the course for better grades.");
        }
    }
}