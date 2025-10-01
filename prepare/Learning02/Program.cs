using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Papa Johns";
        job1._jobTitle = "Shift Leader";
        job1._startYear = 2017;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Math Teacher";
        job2._company = "Brightmont Academy";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume resume = new Resume();
        resume._name = "Spencer Beals";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}