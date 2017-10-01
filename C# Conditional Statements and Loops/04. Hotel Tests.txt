using System;

namespace Hotel
{
    class Hotel
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceForStudio = 0.0;
            double priceForDouble = 0.0;
            double priceForSuite = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    priceForStudio = 50.0;
                    priceForDouble = 65.0;
                    priceForSuite = 75.0;
                    break;
                case "June":
                case "September":
                    priceForStudio = 60.0;
                    priceForDouble = 72.0;
                    priceForSuite = 82.0;
                    break;
                case "July":
                case "August":
                case "December":
                    priceForStudio = 68.0;
                    priceForDouble = 77.0;
                    priceForSuite = 89.0;
                    break;

            }
            if (nightsCount > 7 && (month == "May" || month == "October"))
            {
                priceForStudio *= 0.95;
            }
            else if (nightsCount > 14 && (month == "June" || month == "September"))
            {
                priceForDouble *= 0.9;
            }
            else if (nightsCount > 14 && (month == "July" || month == "August" || month == "December"))
            {
                priceForSuite *= 0.85;
            }

            double totalStudioPrice = priceForStudio * nightsCount;
            double totalDoublePrice = priceForDouble * nightsCount;
            double totalSuitePrice = priceForSuite * nightsCount;

            if (nightsCount > 7 && (month == "September" || month == "October"))
            {
                totalStudioPrice -= priceForStudio;
            }

            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
            Console.WriteLine($"Double: {totalDoublePrice:f2} lv.");
            Console.WriteLine($"Suite: {totalSuitePrice:f2} lv.");

        }
    }
}

