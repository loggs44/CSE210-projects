// Logan Clark 1/17/23

using System;

class Program
{
    static void Main(string[] args)
    {
        Job lcJob1 = new Job();
        lcJob1._lcJobTitle = "Customer Service Rep.";
        lcJob1._lcCompany = "Zions BanCorp.";
        lcJob1._lcStartYear = "Fall 2020";
        lcJob1._lcEndYear = "Winter 2020";

        Job lcJob2 = new Job();
        lcJob2._lcJobTitle = "Sales Rep.";
        lcJob2._lcCompany = "Aptive Enviromental";
        lcJob2._lcStartYear = "Summer 2022";
        lcJob2._lcEndYear = "Fall 2022";

        Job lcJob3 = new Job();
        lcJob3._lcJobTitle = "Sales Rep.";
        lcJob3._lcCompany = "Zagg";
        lcJob3._lcStartYear = "Winter 2021";
        lcJob3._lcEndYear = "Current";        

        Resume lcResume = new Resume();
        lcResume._lcName = "Logan Clark";

        lcResume._lcJobs.Add(lcJob1);
        lcResume._lcJobs.Add(lcJob2);

        lcResume.Display();
    }
}