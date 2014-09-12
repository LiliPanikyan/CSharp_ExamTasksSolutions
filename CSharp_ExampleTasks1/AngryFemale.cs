using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryFemale
{
    class AngryFemale
    {
        static void Main(string[] args)
        {
            string numberN= Console.ReadLine();
            int sumEven;
            int sumOdd;
            sumNumbers(numberN, out sumEven, out sumOdd);
            printResult(sumEven, sumOdd);

            Console.ReadLine();
        }

        private static void sumNumbers(string numberN, out int sumEven, out int sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            for (int i = 0; i < numberN.Length; i++)
            {
                switch (numberN[i])
                {
                    case '1': sumOdd += 1;
                        break;
                    case '2': sumEven += 2;
                        break;
                    case '3': sumOdd += 3;
                        break;
                    case '4': sumEven += 4;
                        break;
                    case '5': sumOdd += 5;
                        break;
                    case '6': sumEven += 6;
                        break;
                    case '7': sumOdd += 7;
                        break;
                    case '8': sumEven += 8;
                        break;
                    case '9': sumOdd += 9;
                        break;

                    default:
                        break;
                }
            }
        }

        private static void printResult(int sumEven, int sumOdd)
        {
            if (sumOdd > sumEven)
            {
                Console.WriteLine("Left {0}", sumOdd);
            }
            else if (sumEven > sumOdd)
            {
                Console.WriteLine("Right {0}", sumEven);
            }
            else if (sumEven == sumOdd)
            {
                Console.WriteLine("Straight {0}", sumEven);
            }
        }
    }
}
