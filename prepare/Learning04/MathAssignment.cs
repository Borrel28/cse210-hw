public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Notice the syntax here that the MathAssignment constructor has 4 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        // Here we set the MathAssignment specific variables
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}

//My program contain two classes one for a Job and one for the Resume itself, as follows:
public class Person
{
        // Keeps track of the company, job title, start year, and end year.
        student.Display();
        student1 ._ID = "Lmg52052";
        student1 ._School = "Lycée Moderdern Grand bassam";
        student1 ._StartYear = "2019"; 
        student1 ._EndYear = "2022";

        student.Display();
        student1 ._ID = "Lmg52052";
        student1 ._School = "Lycée Moderdern Grand bassam";
        student1 ._StartYear = "2019"; 
        student1 ._EndYear = "2022";

        // A method that displays the person's full name <family name, given name>.
        DisplayJobDetails()
        {
            Console.WriteLine($"{_ID}, {_School}, {_StartYear}, {_EndYear}");
        }

}
