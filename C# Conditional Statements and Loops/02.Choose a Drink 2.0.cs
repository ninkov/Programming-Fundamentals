using System;

namespace ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main()
        {
            /*	Water	Coffee	Beer	Tea
         Price 	0.70	1.00	1.70	1.20
            
            The {profession} has to pay {totalPrice}.
             
             */

            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = quantity;
            switch (profession)
            {
                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {totalPrice * 0.70:f2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {totalPrice * 1.00:f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {totalPrice * 1.70:f2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {totalPrice * 1.20:f2}.");
                    break;
            }


        }
    }
}
