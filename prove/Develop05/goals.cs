// See the comment below about the abstract method. Because we have an abstract method,
// this class must also be declared as an abstract class.
public abstract class Shape
{
    private string _myGoals;

    public goal(string myGoals)
    {
        _myGoals = myGoals;
    }

    public string describeGoal();

    string fileName = "myFile.txt";

    using (StreamWriter outputFile = new StreamWriter(filename))
    {
       outputFile.WriteLine("You will make goals to help you succeed while having fun.");
        
        string myGoals = "set goals";
        outputFile.WriteLine($"I have finally written down my ideas to {myGoals}");
    }
}