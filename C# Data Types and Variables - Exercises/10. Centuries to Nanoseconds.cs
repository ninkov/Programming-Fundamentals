using System;
using System.Numerics;
namespace CenturiestoNanoseconds
{
    class CenturiestoNanoseconds
    {
        static void Main()
        {
            // double year = 365.2422;

            decimal input = decimal.Parse(Console.ReadLine());
            decimal years = input * 100;
            decimal days = Math.Floor(years * 365.2422m);
            decimal hours = Math.Floor(days * 24);
            decimal minutes = Math.Floor(hours * 60);
            decimal seconds = Math.Floor(minutes * 60);
            decimal milliseconds = Math.Floor(seconds * 1000);
            decimal microseconds = Math.Floor(milliseconds * 1000000);

            Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {milliseconds*1000} microseconds = {microseconds} nanoseconds");
        }
    }
}
