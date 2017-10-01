using System;

namespace NeighbourWars
{
    class NeighbourWars
    {

        static void Main()
        {
            var counter = 1;
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var peshooHealthPoint = 100;
            var goshoHealthPoint = 100;

            while (true)
            {
                if (counter % 2 == 0)
                {
                    peshooHealthPoint -= goshoDamage;
                    if (goshoHealthPoint <= 0)
                    {
                        Console.WriteLine($"Pesho won in {counter}th round.");
                        break;
                    }
                    else if (peshooHealthPoint <= 0)
                    {
                        Console.WriteLine($"Gosho won in {counter}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshooHealthPoint} health.");
                }
                else
                {
                    goshoHealthPoint -= peshoDamage;
                    if (goshoHealthPoint <= 0)
                    {
                        Console.WriteLine($"Pesho won in {counter}th round.");
                        break;
                    }
                    else if (peshooHealthPoint <= 0)
                    {
                        Console.WriteLine($"Gosho won in {counter}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealthPoint} health.");
                }


                if (counter % 3 == 0)
                {
                    goshoHealthPoint += 10;
                    peshooHealthPoint += 10;
                }
                counter++;
            }

        }
    }
}
