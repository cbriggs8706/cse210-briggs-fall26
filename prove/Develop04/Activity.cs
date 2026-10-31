using System;

public class Activity
{
  private string _activityName = "";
  private string _description = "";
  private int _duration = 0;

  public Activity(string activityName, string description)
  {
    _activityName = activityName;
    _description = description;
  }


public void DisplayStart()
{
  Console.WriteLine($"Welcome to the {_activityName} Activity.");
  Console.WriteLine(_description);
  Console.Write("How long, in seconds, would you like for your session? ");
  _duration = int.Parse(Console.ReadLine());

  Console.WriteLine("Get ready...");
  Spinner(3);
  Console.WriteLine();
}
public int GetDuration()
  {
    return _duration;
  }
public void DisplayEnd()
{
  Console.WriteLine("Well done!");
  Spinner(3);
  Console.WriteLine();
  Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
  Spinner(3);
  Console.WriteLine();
}
public void Countdown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);

      for (int j = 0; j < i.ToString().Length; j++)
      {
        Console.Write("\b \b");
      }
    }

  }
public void Spinner(int seconds)
{
    string[] spinner = { "|", "/", "-", "\\" };

    DateTime endTime = DateTime.Now.AddSeconds(seconds);

    int i = 0;

    while (DateTime.Now < endTime)
    {
        Console.Write(spinner[i]);
        Thread.Sleep(250);
        Console.Write("\b \b");

        i++;

        if (i >= spinner.Length)
        {
            i = 0;
        }
    }
}

}