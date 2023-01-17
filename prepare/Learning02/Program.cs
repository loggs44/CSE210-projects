using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._lcJobTitle = "Customer Service Rep.";
        job1._lcCompany = "Zions BanCorp.";
        job1._lcStartYear = 2020;
        job1._lcEndYear = 2020;

        Job job2 = new Job();
        job2._lcJobTitle = "Sales Rep.";
        job2._lcCompany = "Zagg";
        job2._lcStartYear = 2021;
        job2._lcEndYear = 2023;

        Resume lcResume = new Resume();
        lcResume._lcName = "Logan Clark";

        lcResume._lcJobs.Add(job1);
        lcResume._lcJobs.Add(job2);

        lcResume.Display();
    }
}