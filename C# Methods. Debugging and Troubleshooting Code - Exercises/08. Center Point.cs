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

            var result = new List<double>();
            var fDistance = DistancPointToCenter(pointX1, pointY1);
            var sDistance = DistancPointToCenter(pointX2, pointY2);

            if (fDistance<sDistance)
            {
                result.Add(pointX1);
                result.Add(pointY1);
            }
            else
            {
                result.Add(pointX2);
                result.Add(pointY2);
            }
            Console.Write("(");
            Console.Write(String.Join(", ", result));
            Console.WriteLine(")");
        }
        public static double DistancPointToCenter(double x, double y)
        {
            double distance = Math.Pow(x, 2) + Math.Pow(y, 2);
            return distance;
        }
    }
}
