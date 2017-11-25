namespace LongerLine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class LongerLine
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double fDistance = DistancPointToCenter(x1, y1, x2, y2);
            double sDistance = DistancPointToCenter(x3, y3, x4, y4);
            if (fDistance >= sDistance)
            {
                ClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                ClosestPoint(x3, y3, x4, y4);
            }

        }


        public static double DistancPointToCenter(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
            return distance;
        }
        static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secound = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (first <= secound)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}