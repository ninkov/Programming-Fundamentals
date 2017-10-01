using System;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main()
        {
            var count = 0;
            while (true)
            {
                string ingredients = Console.ReadLine();
                if (ingredients == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.",count);
                    break;
                }
                count++;
                Console.WriteLine($"Adding ingredient {ingredients}.");
            }
        }
    }
}
