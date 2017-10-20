using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayofWeek
{
    class DayofWeek
    {
        static void Main()
        {
            int inputDays = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday ", "Friday", "Saturday ", "Sunday" };

            for (int i = 0; i < 7; i++)
            {
                if (i == inputDays-1)
                {
                    Console.WriteLine(daysOfWeek[i]);
                }
                if (inputDays > 7 || inputDays < 1)
                {
                    Console.WriteLine("Invalid Day!");
                    break;
                }

            }
        }
    }
}
