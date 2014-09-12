using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            byte digit = byte.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                long inputs = long.Parse(Console.ReadLine());
                string binary = Convert.ToString(inputs, 2);
                sum = sumDigits(digit, sum, binary);
                arr[i] = sum;
            }
            printResult(arr);
            Console.ReadLine();
        }

        private static void printResult(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static int sumDigits(byte digit, int sum, string binary)
        {
            for (int check = 0; check < binary.Length; check++)
            {
                char digitCh = binary[check];

                if ((digitCh == '0') && (digit == 0))
                {
                    sum += 1;
                }
                else if ((digitCh == '1') && (digit == 1))
                {
                    sum += 1;
                }
            }
            return sum;
        }
    }
}
