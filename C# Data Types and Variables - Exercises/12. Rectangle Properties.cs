using System;
namespace RectangleProperties
{
    class RectangleProperties
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimetar = (2 * width + 2 * height);
            double area = (width * height);
            double diagonal = Math.Sqrt((width * width +height * height));
            Console.WriteLine(perimetar);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);

        }
    }
}
