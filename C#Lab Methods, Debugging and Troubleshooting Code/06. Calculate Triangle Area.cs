
namespace CalculateTriangleArea
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class CalculateTriangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, height);

            Console.WriteLine(area);

        }

        public static double GetTriangleArea(double width, double height)
        {
            var res = (width * height) / 2;
            return res;
        }
    }
}
