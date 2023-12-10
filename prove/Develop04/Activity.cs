using System;

public class Activity {
  protected string _activityName = "";
  private List<String> _activityList = new List<String>();
  protected string _activityDescription = "";
  public WaitingTimer timer = new WaitingTimer();
  protected Random random = new Random();
  
public Activity()
    {
      _activityName = "";
      _activityDescription = "";
        
    }

public Activity(string activityName,string activityDescription)
    {
      _activityName = activityName;
      _activityDescription = activityDescription;
        
    }

   public string DisplayStart()
   {
    return $"Welcome to the {_activityName} activity\n";
  }

  public string DisplayMenu()
  { 
  
   return "\nMenu Option:\n1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit\nSelect a choice from the menu:";
  }
  public string DisplayDescription()
  {
    return _activityDescription;
  }

  public void DisplayEnd(int seconds){
    Console.WriteLine("");
    Console.WriteLine("Well Done!!\n");
    timer.DisplayLoad();
    Console.WriteLine($"You have completed another {seconds} seconds of the {_activityName} Activity");
    timer.DisplayLoad();
  }
}