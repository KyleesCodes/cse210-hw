using System;

class Program
{
    static void Main(string[] args)
    {   int counter = 0;
        string option = "";
        Activity activity = new Activity();
        string seconds_text = "";
        int seconds = 0;
        while(option != "quit")
        { 
            Console.Clear();
            Console.WriteLine(activity.DisplayMenu());
            option = Console.ReadLine();
            switch(option) 
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathactivity = new BreathingActivity();
                    Console.WriteLine(breathactivity.DisplayStart());
                    Console.WriteLine(breathactivity.DisplayDescription());;
                    Console.WriteLine();
                    Console.WriteLine(breathactivity.timer.RequestTime());
                    seconds_text = Console.ReadLine();
                    seconds = int.Parse(seconds_text);
                    breathactivity.RunBreathingActivity(seconds);
                    counter++;
                    break;
                case "2":
                    Console.Clear();
                    ReflectionActivity reeflectionactivity = new ReflectionActivity();
                    Console.WriteLine(reeflectionactivity.DisplayStart());
                    Console.WriteLine(reeflectionactivity.DisplayDescription());
                    Console.WriteLine();
                    Console.WriteLine(reeflectionactivity.timer.RequestTime());
                    seconds_text = Console.ReadLine();
                    seconds = int.Parse(seconds_text);
                    reeflectionactivity.RunReflectionActivity(seconds);
                    counter++;
                    break;
                case "3":
                    Console.Clear();
                    ListingActivity listingactivity = new ListingActivity();
                    Console.WriteLine(listingactivity.DisplayStart());
                    Console.WriteLine(listingactivity.DisplayDescription());
                    Console.WriteLine();
                    Console.WriteLine(listingactivity.timer.RequestTime());
                    seconds_text = Console.ReadLine();
                    seconds = int.Parse(seconds_text);
                    listingactivity.RunListingActivity(seconds);
                    counter++;
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine($"> You finished {counter} activities!");
                    activity.timer.DisplayLoad();
                    Console.WriteLine("Have a wonderful day!");
                    System.Environment.Exit(0); 
                    break;
                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }
        }
    }
}