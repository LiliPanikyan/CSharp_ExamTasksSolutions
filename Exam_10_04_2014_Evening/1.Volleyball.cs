using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindYear = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int hometown = int.Parse(Console.ReadLine());

            int playWeekends = 48- hometown;
            double playHolidays = holidays * 2.0 / 3.0;
            double playHome = hometown * 1.0;
            double weekendPlays = playWeekends * 3.0 / 4.0;
            double totalGame = playHolidays + playHome + weekendPlays;

            if (kindYear == "leap")
            {
                totalGame = totalGame * 1.15;
                Console.WriteLine((int)totalGame);
            }
            else
            {
                Console.WriteLine((int)totalGame);
            }
        }
    }
}