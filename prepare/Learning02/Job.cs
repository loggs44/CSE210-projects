// Logan Clark 1/17/23

using System;

public class Job
{
    public string _lcJobTitle;
    public string _lcCompany;
    public string _lcStartYear;
    public string _lcEndYear;

    public void Display()
    {
        Console.WriteLine($"{_lcJobTitle} ({_lcCompany}) {_lcStartYear}-{_lcEndYear}");
    }
}