public class Scripture : goals
{
    private double _scripture;

    public Scripture(string myGoals, double scripture) : base (myGoals)
    {
        _scripture = scripture;
    }

    public string describeGoal();

    string fileName = "myFile.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
       outputFile.WriteLine("Study two chapters of scripture a day");
        
        string myGoals = "set goals";
        outputFile.WriteLine($"What have you done to reach your {myGoals} ?");
    }

    public override double GetGoal()
    {
        Console.WriteLine("I have been able to reach my goal of studying the scriptures daily.");
    }
}