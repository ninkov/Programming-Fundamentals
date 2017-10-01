using System;

namespace RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string typeOfPackage = Console.ReadLine();
            double pricePerNornalPackage = 500.0;
            double pricePerGoldPackage = 750.0;
            double pricePerPlatinumPackage = 1000.0;
            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");

            }
            else
            {

                if (groupSize <= 50)
                {
                    if (typeOfPackage == "Normal")
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:f2}$", ((pricePerNornalPackage + 2500) -
                            ((pricePerNornalPackage + 2500) * 0.05)) / groupSize);

                    }
                    else if (typeOfPackage == "Gold")
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:f2}$", (((pricePerGoldPackage + 2500) -
                            (pricePerGoldPackage + 2500) * 0.1)) / groupSize);
                    }
                    else if (typeOfPackage == "Platinum")
                    {
                        Console.WriteLine("We can offer you the Small Hall");
                        Console.WriteLine("The price per person is {0:f2}$", (((pricePerPlatinumPackage + 2500) -
                            (pricePerPlatinumPackage + 2500) * 0.15)) / groupSize);
                    }
                }
                if (groupSize > 50 && groupSize <= 100)
                {
                    if (typeOfPackage == "Normal")
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:f2}$", ((pricePerNornalPackage + 5000) -
                            ((pricePerNornalPackage + 5000) * 0.05)) / groupSize);

                    }
                    else if (typeOfPackage == "Gold")
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:f2}$", (((pricePerGoldPackage + 5000) -
                            (pricePerGoldPackage + 5000) * 0.1)) / groupSize);
                    }
                    else if (typeOfPackage == "Platinum")
                    {
                        Console.WriteLine("We can offer you the Terrace");
                        Console.WriteLine("The price per person is {0:f2}$", (((pricePerPlatinumPackage + 5000) -
                            (pricePerPlatinumPackage + 5000) * 0.15)) / groupSize);
                    }
                }
                if (groupSize > 100 && groupSize <= 120)
                {
                    if (typeOfPackage == "Normal")
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:f2}$", ((pricePerNornalPackage + 7500) -
                            ((pricePerNornalPackage + 7500) * 0.05)) / groupSize);

                    }
                    else if (typeOfPackage == "Gold")
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:f2}$", (((pricePerGoldPackage + 7500) -
                            (pricePerGoldPackage + 7500) * 0.1)) / groupSize);
                    }
                    else if (typeOfPackage == "Platinum")
                    {
                        Console.WriteLine("We can offer you the Great Hall");
                        Console.WriteLine("The price per person is {0:f2}$", (((pricePerPlatinumPackage + 7500) -
                            (pricePerPlatinumPackage + 7500) * 0.15)) / groupSize);
                    }
                }

            }
        }
    }
}
