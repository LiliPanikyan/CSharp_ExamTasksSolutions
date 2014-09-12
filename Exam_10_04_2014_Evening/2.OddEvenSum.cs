using System;

namespace _2.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int sumOdd = 0;
            int sumEven = 0;
            bool odd = true;
            for (int i = 0; i < 2 * n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (odd)
                {
                    sumOdd = sumOdd + input;
                }
                else
                {
                    sumEven = sumEven + input;
                }
                odd = !odd;
            }
            printResult(sumOdd, sumEven);
        }

        private static void printResult(int sumOdd, int sumEven)
        {
            if (sumOdd == sumEven)
            {
                Console.WriteLine("Yes, sum={0}", sumOdd);
            }
            else
            {
                int diff = Math.Abs(sumOdd - sumEven);
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }
}
