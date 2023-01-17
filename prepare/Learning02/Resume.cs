// Logan Clark 1/17/23

using System;

public class Resume
{
    public string _lcName;

    public List<Job> _lcJobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_lcName}");
        Console.WriteLine("Jobs:");

        foreach (Job lcJob in _lcJobs)
        {
            lcJob.Display();
        }
    }
}