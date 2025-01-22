using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Layout Maintainance Specialst";
        job1._company = "SAS Retail Services";
        job1._startYear = 2020;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Product Lister & Shipping Manager";
        job2._company = "eAsset Solutions LLC";
        job2._startYear = 2016;
        job2._endYear = 2019;

        Resume myResume = new Resume();
        myResume._name = "Johnny Thoeun";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}