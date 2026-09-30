using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2004;
        job1._endYear = 2015;

        Job job2 = new Job();
        job2._jobTitle = "Data Analist";
        job2._company = "Apple";
        job2._startYear = 2009;
        job2._endYear = 2017;

        job2.DisplayJobDetails();
    }
}