using System;

namespace WordInPlural
{
    class WordInPlural
    {
        static void Main()
        {
            string inputNoun = Console.ReadLine();
           

            if (inputNoun.EndsWith("y"))
            {
                inputNoun = inputNoun.Replace("y", "ies");
            }
            else if (inputNoun.EndsWith("o")
                || inputNoun.EndsWith("ch")
                || inputNoun.EndsWith("s")
                || inputNoun.EndsWith("sh")
                || inputNoun.EndsWith("x")
                || inputNoun.EndsWith("z"))
            {
                inputNoun += "es";
                
            }
            else
            {
                inputNoun += "s";
            }
            Console.WriteLine(inputNoun);

        }
    }
}
