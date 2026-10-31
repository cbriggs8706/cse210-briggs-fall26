using System;

public class Assignment
{
  private string _studentName = "";
  private string _topic = "";

  public Assignment(string studentName, string topic)
  {
    _studentName = studentName;
    _topic = topic;
  }

  public string GetStudentName()
  {
    return _studentName;
  }
  // In the solution code it has this getter.  Is it just for potential use later? I don't see a need for it yet.
  // public string GetTopic()
  // {
  //    return _topic;
  // }
  public string GetSummary()
  {
    return $"{_studentName} - {_topic}";
  }
}