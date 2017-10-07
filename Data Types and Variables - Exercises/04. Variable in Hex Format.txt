using System;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string hexadecimalFormat = Console.ReadLine();

            Console.WriteLine(Convert.ToInt32(hexadecimalFormat,16));
        }
    }
}
