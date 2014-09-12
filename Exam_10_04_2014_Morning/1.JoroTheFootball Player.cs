using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            string kindYear = Console.ReadLine();
            int numHolidays = int.Parse(Console.ReadLine());
            int numHome = int.Parse(Console.ReadLine());

            double playHoliday = numHolidays / 2;
            double playHome = numHome * 1d;
            double playWeekends = (52 - numHome) * 2d / 3d;
            double totalGame = playHoliday + playHome + playWeekends;
            if (kindYear=="t")
            {
                totalGame += 3;
                Console.WriteLine((int)totalGame);
            }
            else
            {
                Console.WriteLine((int)totalGame);
            }
        }
    }
}