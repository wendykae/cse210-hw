using Microsoft.VisualBasic;
using System;
public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // A special method, called a constructor that is
    //invoked using the new keyword followed by the
    //class name and parentheses.
    public Job()
    {
    }
    public void DisplayJobDetails()
    {
        Console.WriteLine ($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");

    }

    
}