using System;

// My Own codes from Assignment

class Program{
    static void Main(string[] args)
    {
        // the user Name
        Console.write("What is your Name? ");
        string answer2 = Console.ReadLine();
        // the grade percentage
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string Name = "";
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
            if (percent >= 81)
            {
                letter = "A-"
            }
        }
        else if (percent >= 80)
        {
            letter = "B";
            if (percent >= 71)
            {
                letter = "B-"
            }
        }
        else if (percent >= 70)
        {
            letter = "C";
            if (percent >= 61)
            {
                letter = "C-"
            }
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F+";
            if (percent >= 50)
            {
                letter = "F"
            }
            else
            {
                letter = "F-"
            }
            
        }

        Console.WriteLine($"Hello {Name}!");
        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulation! You passed!");
        }
        else
        {
            Console.WriteLine("Wish you Good luck next time!");
        }
    }
}


