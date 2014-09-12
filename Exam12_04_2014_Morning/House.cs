using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', 1));
            Console.WriteLine(new string('.', n / 2));
            int leftRight = n / 2 - 1;
            int center = 1;

            while (leftRight != 0)
            {
                Console.Write(new string('.', leftRight));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', center));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', leftRight));

                leftRight--;
                center += 2;
            }
            Console.WriteLine(new string('*', n));
            int wallDistance = n / 4;

            for (int i = n / 2 + 1; i < n - 1; i++)
            {
                Console.Write(new string('.', wallDistance));
                Console.Write(new string('*', 1));
                Console.Write(new string('.', n - 2 * wallDistance - 2));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('.', wallDistance));
            }

            Console.Write(new string('.', wallDistance));
            Console.Write(new string('*', n - 2 * wallDistance));
            Console.WriteLine(new string('.', wallDistance));
            Console.ReadLine();
        }

    }
}