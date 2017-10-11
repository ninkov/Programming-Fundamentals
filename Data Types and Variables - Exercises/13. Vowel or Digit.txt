using System;
namespace VowelorDigit
{
    class VowelorDigit
    {
        static void Main()
        {
            string entry = Console.ReadLine();

            switch (entry)
            {
                case "1" :
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":

                    Console.WriteLine("digit");
                    break;
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                case "y":

                    Console.WriteLine("vowel");
                    break;

                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
