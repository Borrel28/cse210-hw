using System;

public class Resume
{
       // Keeps track of the person's name and a list of their jobs.
        public string _givenName = "Assi";
        public string _familyName = "Adji"; 
        public string _Company = "Microsoft"; 
        public string _JobTitle ="Software Engineer";
        public string _StartYear = "2019"; 
        public string _EndYear = "2022";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Resume()
        {
        }

       // A method that displays the person's full name as used in eastern 
       // countries or <family name, given name>.

        public void Display()
       {
           Console.WriteLine($"{_givenName}, {_familyName}, {_Company}, {_JobTitle}, {_StartYear}, {_EndYear}");
       }

       


    
    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
            
        }
    }
    


    Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Adji Borrel";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



}
