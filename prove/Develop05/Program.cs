using system

class program
{
    static void Main(string[]args)
    {
        AllPoints    allPoint = new AllPoints();
        int        userMainMenuSelection = 0;

        while (userMainMenuSelection !=6)
        {
            Menu menu = new Menu();
            menu.DisplayPoints(allPoints.getTotalPoints());
            menu.DisplayMainMenu();
            userMainMenuSelection = menu.DisplayMainMenu();

            switch (userMainMenuSelection)
            {
                
                case 1:
                    point = new SimplePoint();
                    point.DisplayGetPointName();
                    point.DisplayGetDescpition();
                    point.DisplayGetPointName();
                    break;

            }
            if (point := null)
            {
                AllPoints.addPoint(point);

            }
            break;
        case 2:
            allPoints.DisplayPoints();
            break;
        case 3:
            allPoints.SavePoints();
            break;
        case 4:
            allPoints.LoadPoints();
            break;
{
        Console.WriteLine("{allPoints}!");
}
        }
    }
}






