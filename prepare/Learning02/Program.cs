using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Machine Operator";
        job1._company = "Sagma Agencies";
        job1._duties = "Monitoring Transactions and traffic."
        job1._startDate = 2017;
        job1._endDate = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._duties = "Employee welfare";
        job2._company = "Explore I.T Technologies";
        job2._startDate = 2020;
        job2._endDate = 2023;

        Resume myResume = new Resume();
        myResume._name = "Bagoole Ivan";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}