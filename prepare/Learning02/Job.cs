using systerm

public class Job
//My program contain two classes one for a Job and one for the Resume itself, as follows:
public class Job
{
        // Keeps track of the company, job title, start year, and end year.
        job1.Display();
        job1 ._JobTitle = "Software Engineer";
        job1 ._Company = "Microsoft";
        job1 ._StartYear = "2019"; 
        job1 ._EndYear = "2022";

        job2.Display();
        job2 ._JobTitle = "Techcnicien Engineer";
        job2 ._Company = "Autocad";
        job2 ._StartYear = "2006"; 
        job2 ._EndYear = "2022";

        // A method that displays the person's full name <family name, given name>.
        DisplayJobDetails()
        {
            Console.WriteLine($"{_JobTitle}, {_Company}, {_StartYear}, {_EndYear}");
        }

}
