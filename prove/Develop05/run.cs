public class exercise : goal
{
    private double _length;
    private double _time;

    public Rectangle(string myGoals, double length, double time) : base (myGoals)
    {
        _length = length;
        _time = time;
    }

    public override double GetGoal()
    {
        return _length / _time;
    }
    Console.WriteLine($"I ran (GetGoal) per minute.");
}