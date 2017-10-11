using System;

class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double premision = 0.000001;
        bool isCompare = false;
        if (Math.Abs(a - b) <= premision)
        {
            Console.WriteLine(!isCompare);
        }
        else
        {
            Console.WriteLine(isCompare);
        }


    }
}

