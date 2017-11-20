namespace CenterPoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class CenterPoint
    {
        static void Main()
        {
            double pointX1 = double.Parse(Console.ReadLine());
            double pointY1 = double.Parse(Console.ReadLine());
            double pointX2 = double.Parse(Console.ReadLine());
            double pointY2 = double.Parse(Console.ReadLine());

            // var result = new List<double>();
            var fDistance = DistancPointToCenter(pointX1, pointY1);
            var sDistance = DistancPointToCenter(pointX2, pointY2);

            if (fDistance < sDistance)
            {
                Console.WriteLine($"({pointX1}, {pointY1})");
            }
            else
            {
                Console.WriteLine($"({pointX2}, {pointY2})");
            }

        }
        public static double DistancPointToCenter(double x, double y)
        {
            double distance = Math.Pow(x, 2) + Math.Pow(y, 2);
            return distance;
        }
    }
}
