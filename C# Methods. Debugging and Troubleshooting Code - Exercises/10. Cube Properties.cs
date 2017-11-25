namespace CubeProperties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class CubeProperties
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();
            double res = CalculateCube(Math.Abs(input), parameter);
            Console.WriteLine($"{res:f2}");

        }
        public static double CalculateCube(double input, string parameter)
        {
            double result = 0.0;
            switch (parameter)
            {
                case "face":
                    result = Math.Sqrt(2 * input * input);
                    break;
                case "space":
                    result = Math.Sqrt(3 * input * input);
                    break;
                case "volume":
                    result = Math.Pow(input, 3);
                    break;
                case "area":
                    result = 6 * input * input;
                    break;
            }
            return result;
        }

    }
}
