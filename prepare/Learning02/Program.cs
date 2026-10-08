using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2022;
        job1._endYear = 2026;
        Job job2 = new Job();
        job2._jobTitle = "Marketing Intern";
        job2._company = "Apple";
        job2._startYear = 2009;
        job2._endYear = 2012;
        // Console.WriteLine($"{job1._company}");
        // Console.WriteLine($"{job2._company}");
        job1.Display();
        job2.Display();
        Resume myResume = new Resume();
        myResume._name = "Cameron Briggs";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}