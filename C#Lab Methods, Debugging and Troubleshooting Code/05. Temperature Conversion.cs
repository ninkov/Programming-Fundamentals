namespace TemperatureConversion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class TemperatureConversion
    {
        static void Main()
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            var celsius = PrintFahrenheitToCelsius(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }

        public static double PrintFahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) * 5 / 9;
            return result;
        }
    }
}
