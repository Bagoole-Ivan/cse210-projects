using System;

using System.Text;
namespace Word
{
    class User
    {
        public string _text = "D & C 58 : 4 - For after much tribulation come the blessings. Wherefore the day cometh that ye shall be crowned with much glory; the hour is not yet, but is nigh at hand."; 
        private string location;
       private string name;
       public string Location
       {
          get
          {
             return location;
          }
          set
          {
             location = value;
          }
       }
       public string Name
       {
         get
         {
             return name;
         }
         set
         {
            name = value;
         }
       }
       
    }
    class Program
    {
       static void Main(string[] args)
       {
          User u = new User();
 
          // set accessor will invoke
          u.Name = "Suresh Dasari";
          // set accessor will invoke
          u.Location = "Hyderabad";
          // get accessor will invoke
          Console.WriteLine("Name: " + u.Name);
          // get accessor will invoke
          Console.WriteLine("Location: " + u.Location);
          Console.WriteLine("\nPress Enter Key to Exit..");
          Console.WriteLine("D & C 58 : 4 - For after much tribulation come the blessings. Wherefore the day cometh that ye shall be crowned with much glory; the hour is not yet, but is nigh at hand.");
          Console.ReadLine();
       }
    }
}