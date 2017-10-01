using System;

namespace CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main()
        {
            var count = 0;
            try
            {
                while (true)
                {

                    int num = int.Parse(Console.ReadLine());
                   
                    count++;
                }
            }
            catch (Exception)
            {

                Console.WriteLine(count);
            }
        }
    }
}
