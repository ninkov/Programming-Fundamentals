namespace GeometryCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class GeometryCalculator
    {
        static void Main()
        {
            string shape = Console.ReadLine().ToLower();
            if (shape == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", CalculateTriangleArea(side, height));
            }
            else if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}", CalculateSquareArea(side));
            }
            else if (shape == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:f2}", CalculateRectangleArea(width, height));
            }
            else if (shape=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f2}",CalculateCircleArea(radius));
            }
        }

        public static double CalculateSquareArea(double side)
        {
            double result = side * side;
            return result;
        }

        public static double CalculateRectangleArea(double width, double height)
        {
            double result = width * height;
            return result;
        }

        public static double CalculateTriangleArea(double side, double height)
        {
            double result = (side * height) * 0.5;
            return result;
        }

        public static double CalculateCircleArea(double radius)
        {
            double result = Math.PI * radius * radius;
            return result;
        }

    }
}
