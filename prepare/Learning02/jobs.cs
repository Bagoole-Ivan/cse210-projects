using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public string _duties;
    public int _startDate;
    public int _endDate;

    public void Display()
    {
        Console.WriteLine($"({_company})({_jobTitle})({_duties}){_startDate}{_endDate}");
    }

}
