using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        // first job
        Job job1= new Job();
        job1._company= "apple";
        job1._jobTitle= "workerbee";
        job1._startYear= 2010;
        job1._endYear= 2020;

        //job2 company
        Job job2=new Job ();
        job2._company= "micro";
        job2._jobTitle= "helper";
        job2._startYear = 2008;
        job2._endYear= 2009;

        // call display method for each job
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
        
        // resume 
        Resume myResume= new Resume();
        myResume._name= "jane doe";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine($"First job title:{myResume._jobs[0]._jobTitle}");

        myResume.DisplayResume();



    
    }




}