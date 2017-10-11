using System;
namespace IntegertoHexandBinary
{
    class IntegertoHexandBinary
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string numToHexa = Convert.ToString(number, 16).ToUpper();
            string numToBinary = Convert.ToString(number,2).ToUpper();

            Console.WriteLine(numToHexa);
            Console.WriteLine(numToBinary);
        }
    }
}
