using systerm

public class Job
{
        // Keeps track of the company, job title, start year, and end year.
        public string _Company = "Microsoft";
        public string _JobTitle = "Software Engineer";
        public int _StartYear = "2019"; 
        public int _EndYear = "2022";
        
        public void Display()
         {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
         }


}
