using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string asterix = "*";
            for (int i = 1; i <= n; i++)
            {
                if (i == 1)
                {
                    string dots = new string('.', n - 1);
                    Console.Write(asterix);
                    Console.Write(dots);
                    Console.WriteLine();
                }
                else if (i < n)
                {
                    string leftDots = new string('.', i - 1);
                    string rightDots = new string('.', n - i);
                    Console.Write(leftDots);
                    Console.Write(asterix);
                    Console.Write(rightDots);
                    Console.WriteLine();
                }
                else
                {
                    string dots = new string('.', n - 1);
                    Console.Write(dots);
                    Console.Write(asterix);
                    Console.WriteLine();
                }
            }
            for (int y = 1; y <= n - 1; y++)
            {
                if (y != n - 1)
                {
                    string right = new string('.', y);
                    string left = new string('.', n-y-1);
                    Console.Write(left);
                    Console.Write(asterix);
                    Console.Write(right);
                    Console.WriteLine();
                }
                else
                {
                    string dots = new string('.', n - 1);
                    Console.Write(asterix);
                    Console.Write(dots);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}