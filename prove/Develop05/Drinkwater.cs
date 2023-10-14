public class Drinkwater : goal
{
    private string _litres;

    public Drinkwater(string myGoals, double litres) : base (myGoals)
    {
        _litres = litres;
    }

    string fileName = "myFile.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
        string myGoals = "set goals";
        outputFile.WriteLine($"Drink 3 litres of water a day is my {myGoals}");
    }

    public override double GetGoal()
    {
        Console.WriteLine("I managed to drink the required litres of water needed for my body.");
    }
}