using System;

namespace CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main()
        {
            //var cheese = 500;
            //var tomatoSauce = 150;
            //var salami = 600;
            //var pepper = 50;
            string product = string.Empty;
            var num = int.Parse(Console.ReadLine());
            var calories = 0;
            var totalCaloriesCheese = 0;
            var totalCaloriesTomato = 0;
            var totalCaloriesSalami = 0;
            var totalCaloriesPepper = 0;
            while (num > 0)
            {
                product = Console.ReadLine().ToLower();
                num--;
                if (product == "cheese")
                {
                    totalCaloriesCheese += calories + 500;
                }
                else if (product == "tomato sauce")
                {
                    totalCaloriesTomato += calories + 150;
                }
                else if (product == "salami")
                {
                    totalCaloriesSalami += calories + 600;
                }
                else if (product == "pepper")
                {
                    totalCaloriesPepper += calories + 50;
                }
            }



            var totalCaloriesAmount =
                totalCaloriesCheese +
                totalCaloriesPepper +
                totalCaloriesSalami +
                totalCaloriesTomato;
            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
