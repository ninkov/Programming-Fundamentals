using System;
namespace PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main()
        {
            int startConvertToAscii = int.Parse(Console.ReadLine());
            int endConvertToAscii = int.Parse(Console.ReadLine());
            string convertedAscii = string.Empty;
            for (int i = startConvertToAscii; i <= endConvertToAscii; i++)
            {
                convertedAscii = convertedAscii + (char)i + " ";
            }
            Console.WriteLine(convertedAscii);
        }
    }
}


