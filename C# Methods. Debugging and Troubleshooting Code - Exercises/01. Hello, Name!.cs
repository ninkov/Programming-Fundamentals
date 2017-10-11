using System;

namespace HelloName
{
    class HelloName
    {
        static string PrintName(string name)
        {
            return name;
        }
        static void Main()
        {
            var name =
               Console.ReadLine();

            Console.WriteLine("Hello, " + PrintName(name)+"!");
        }
    }
}
