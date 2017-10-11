using System;
namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main()
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());


            float time = (hours * 3600 + minutes * 60 + seconds);

            float metersPerSec = (distance / time);
            float kilometersPerHour = ((distance / 1000) / (time / 3600));
            float milesPerHour = ((distance / 1609) / (time / 3600));


            Console.WriteLine($"{metersPerSec}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");

        }
    }
}
