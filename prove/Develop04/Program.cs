class Program
{
    static void Main(string[] args)
    {
        Fitness Fitness = new Fitness();
        int quit = 0;
        while (quit != 4){
            Console.Clear();
            Console.WriteLine("Welcome to the Moroni's Fitness Place!");
            Console.WriteLine("Please select from our menu of Moroni's Fitness activities!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listening Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            quit = int.Parse(Console.ReadLine());
            Console.Clear();

            if (quit == 1)
            {
                Breathing breathing = new Breathing();
                breathing.StartMessage("Slow and fast breathing will help your body revive sences.");
                breathing.RunActivity("Breath in, Breath out");
                breathing.EndMessage("Great breathing for the day.");
            }

            else if (quit == 2)
            {
                Listing listing = new Listing();
                listing.StartMessage("It is always hard when someone speaks and you can not hear.");
                listing.RunActivity("Stop and listen");
                listing.EndMessage("Improve your hearing");
            }

            else if (quit == 3)
            {
                Reflecting reflecting = new Reflecting();
                reflecting.StartMessage("Improve your reasoning and judgement.");
                reflecting.RunActivity("Think about what you have heard");
                reflecting.EndMessage("Ponder");
            }

            else
            {
                Console.WriteLine("Thank you for visiting Moroni's Fitness!");
                break;
            }
        }
    }
}