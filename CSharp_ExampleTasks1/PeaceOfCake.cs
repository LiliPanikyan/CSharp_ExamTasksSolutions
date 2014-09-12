using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeaceOfCake
{
    class PeaceOfCake
    {
        static void Main(string[] args)
        {
            decimal dcmlA;
            decimal dcmlB;
            decimal dcmlC;
            decimal dcmlD;
            parseInput(out dcmlA, out dcmlB, out dcmlC, out dcmlD);
            decimal result = (dcmlA / dcmlB) + (dcmlC / dcmlD);
            decimal output = (dcmlA * dcmlD) + (dcmlB * dcmlC);
            printTaskResult(dcmlB, dcmlD, result, output);
            Console.ReadLine();
        }

        private static void printTaskResult(decimal dcmlB, decimal dcmlD, decimal result, decimal output)
        {
            if (result >= 1)
            {
                Console.WriteLine(Math.Floor(result));
                Console.WriteLine((output + "/" + (dcmlB * dcmlD)));
            }
            else
            {
                Console.WriteLine("{0:F22}", result);
                Console.WriteLine(((output + "/" + (dcmlB * dcmlD))));
            }
        }

        private static void parseInput(out decimal dcmlA, out decimal dcmlB, out decimal dcmlC, out decimal dcmlD)
        {
            dcmlA = decimal.Parse(Console.ReadLine());
            dcmlB = decimal.Parse(Console.ReadLine());
            dcmlC = decimal.Parse(Console.ReadLine());
            dcmlD = decimal.Parse(Console.ReadLine());
        }
    }
}
