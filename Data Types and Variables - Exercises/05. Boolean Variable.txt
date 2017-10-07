using System;
namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            string entryText = Console.ReadLine().ToLower();
            Convert.ToBoolean(entryText);
          
            if (entryText=="true")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
