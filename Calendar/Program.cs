using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2019;

            for (int month = 1; month <= 12; month++)
            {
                DateTime currentMonth = new DateTime(year, month, 1);

                Console.WriteLine(currentMonth.ToString("MMMM yyyy"));
                Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

                int daysInMonth = DateTime.DaysInMonth(year, month);

                for (int i = 0; i < (int)currentMonth.DayOfWeek; i++)
                {
                    Console.Write("    ");
                }

                for (int day = 1; day <= daysInMonth; day++)
                {
                    Console.Write($"{day,3} ");

                    if ((int)currentMonth.AddDays(day).DayOfWeek == 0)
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine("\n");
                
            }
            Console.ReadKey();
        }
    }
}
