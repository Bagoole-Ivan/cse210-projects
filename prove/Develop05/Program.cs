using System;

class Program
{
    static void Main(string[] args)
    {
        List<goals> goals = new List<goals>();

        Drinkwater s1 = new Drinkwater("How many litres of water did you drink?", 3);
        myGoals.Add(s1);

        run s2 = new run("Run 40 km in 3 hours", 20, 80);
        myGoals.Add(s2);

        Scripture s3 = new Scripture("Did you remember to study your scriptures today?");
        myGoals.Add(s3);

        foreach (goal s in goals)
        {
            string myGoals = s.GetMyGoals();

            double area = s.GetGoal();

            Console.WriteLine($"{myGoals} blessed to be able to {area}.");
        }
    }
}