using System;

public class ListingActivity : Activity {
 List<string> _listingList = new List<string> {"Who are people that you appreciate?"
                                                ,"What are personal strengths of yours?"
                                                ,"Who are people that you have helped this week?"
                                                ,"When have you felt the Holy Ghost this month?"
                                                ,"Who are some of your personal heroes?"};
    public ListingActivity()
    {
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."; 
    }

    public void Introduce()
    {
        var randomIndex = random.Next(0, _listingList.Count());
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_listingList[randomIndex]} ---\n");
        Console.Write("You may begin in:");
        timer.DisplayCount(5);
    }
    public void RunListingActivity(int seconds)
    {
        timer.DisplayReady();
        Introduce();
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        Thread.Sleep(500);
        List<string> answers = new List<string>();
        string answer;
        while(DateTime.Now < futureTime)
        {  
            Console.Write("> ");
            answer = Console.ReadLine();
            answers.Add(answer);
        }
        Console.WriteLine($"You listed {answers.Count()} items!");
        DisplayEnd(seconds);
  }
}