using System;

public class BreathingActivity: Activity
{
  


public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
{
}
public void Run()
  {
    DisplayStart();
    int duration = GetDuration();
    DateTime endTime = DateTime.Now.AddSeconds(duration);

    while (DateTime.Now < endTime)
    {
      Console.Write("Breathe in...");
      Countdown(5);
      Console.WriteLine();
      if (DateTime.Now >= endTime)
      {
        break;
      }

      Console.Write("Now breathe out...");
      Countdown(5);
      Console.WriteLine();
      Console.WriteLine();

    }
    
    DisplayEnd();
  }
}