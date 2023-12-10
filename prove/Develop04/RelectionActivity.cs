using System;

public class ReflectionActivity: Activity {
    List<string> _reflectionList = new List<string> { "Think of a time when you stood up for someone else."
                                                ,"Think of a time when you did something really difficult."
                                                ,"Think of a time when you helped someone in need."
                                                ,"Think of a time when you did something truly selfless."};
    List<string> _reflectionQuestion = new List<string>{"Why was this experience meaningful to you?"
                                                ,"Have you ever done anything like this before?"
                                                ,"How did you get started?"
                                                ,"How did you feel when it was complete?"
                                                ,"What made this time different than other times when you were not as successful?"
                                                ,"What is your favorite thing about this experience?"
                                                ,"What could you learn from this experience that can be applied to other situations?"
                                                ,"What did you learn about yourself through this experience?"
                                                ,"What can you do to remember this experience in the future?"};
    public ReflectionActivity()
    {
        _activityName = "Reflection";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."; 
    }
    public void Intodruce()
    {
        var randomIndex = random.Next(0, _reflectionList.Count());
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {_reflectionList[randomIndex]} ---\n");
        Console.WriteLine("When you have somerhing in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in:");
        timer.DisplayCount(5);
        Console.Clear();
    }
    public void RunReflectionActivity(int seconds)
    {
        timer.DisplayReady();
        Intodruce();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        Thread.Sleep(500);
        var randomIndex = 0;
        var randomIndexOld = 1;
        while(DateTime.Now < futureTime)
        {  
            randomIndex = random.Next(0, _reflectionQuestion.Count());
            if(randomIndex != randomIndexOld)
            {
                Console.Write($"> {_reflectionQuestion[randomIndex]} ");
                timer.DisplayLoad();
                Console.Write("\n");
                randomIndexOld = randomIndex;
            }
        } 
        DisplayEnd(seconds);
    }
}