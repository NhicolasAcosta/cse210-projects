using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "community manager";
        job1._company = "Mercado Libre";
        job1._startYear = 2014;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._jobTitle = "Marketing manager";
        job2._company = "Mercado Libre";
        job2._startYear = 2016;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Jimena Rodriguez";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}