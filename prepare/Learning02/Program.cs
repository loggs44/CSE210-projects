// Logan Clark 1/17/23

using System;

class Program
{
    static void Main(string[] args)
    {
        Job lcJob1 = new Job();
        lcJob1._lcJobTitle = "Customer Service Rep.";
        lcJob1._lcCompany = "Zions BanCorp.";
        lcJob1._lcStartYear = 2020;
        lcJob1._lcEndYear = 2020;

        Job lcJob2 = new Job();
        lcJob2._lcJobTitle = "Sales Rep.";
        lcJob2._lcCompany = "Zagg";
        lcJob2._lcStartYear = 2021;
        lcJob2._lcEndYear = 2023;

        Resume lcResume = new Resume();
        lcResume._lcName = "Logan Clark";

        lcResume._lcJobs.Add(lcJob1);
        lcResume._lcJobs.Add(lcJob2);

        lcResume.Display();
    }
}