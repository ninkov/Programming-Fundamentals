using System;

namespace Train
{
    class Train
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] countPeople = new int[n];
            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                countPeople[i] = people;
                sum += people;
            }
            Console.WriteLine(string.Join(' ',countPeople));
            Console.WriteLine(sum);
        }
    }
}

