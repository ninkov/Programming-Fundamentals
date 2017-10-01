using System;

namespace ChooseADrink
{
    class ChooseADrink
    {
        static void Main()
        {
            string drink = Console.ReadLine();
            switch (drink)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
