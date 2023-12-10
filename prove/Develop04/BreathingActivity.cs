using System;

public class BreathingActivity : Activity {
   List<string> _breathingList = new List<string> { "Breath in...", "Breath out..." };
 public BreathingActivity()
    {
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
    }
    
  public void RunBreathingActivity(int seconds)
  {
      timer.DisplayReady();
      Console.WriteLine("");
      DateTime startTime = DateTime.Now;
      DateTime futureTime = startTime.AddSeconds(seconds);
      Thread.Sleep(500);
      int counter = 3;
      while(DateTime.Now < futureTime)
      {  
         foreach(string s in _breathingList)
         {
            Console.Write(s);
            timer.DisplayCount(counter);
            Console.Write("\n");
         }
         Console.WriteLine("");
         counter++;
      }
      DisplayEnd(seconds);
  }
}