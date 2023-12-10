using System;

public class WaitingTimer {
  protected int _waitingTime = 0;
  private List<string> waitingCharacters = new List<string>();
 
  public void DisplayLoad()
  {
   waitingCharacters.Add("|");
   waitingCharacters.Add("/");
   waitingCharacters.Add("-");
   waitingCharacters.Add("\\");
   waitingCharacters.Add("|");
   waitingCharacters.Add("/");
   waitingCharacters.Add("-");
   waitingCharacters.Add("\\");
   foreach(string s in waitingCharacters)
   {
      Console.Write(s);
      Thread.Sleep(500);
      Console.Write("\b \b");
   }
  }

  public void DisplayReady()
  {
    Console.Clear();
    Console.WriteLine("Get Ready...");
    DisplayLoad();
  }
  public string RequestTime()
  {
   return "How long, in seconds, would you like for your session?";
  }
  public void DisplayCount(int seconds)
  {
    for(int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b"); 
    }
  }
  
}