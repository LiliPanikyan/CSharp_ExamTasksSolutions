using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareOnCodeStreet
{
    class NightmareOnCodeStreet
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int oddCount = 0;
            ulong oddSum = 0;

            for (int i = 1, length = text.Length; i < length; i += 2)// s i+=2 preskacha `etnite pozicii
            {
                if (text[i] > 47 && text[i] < 58)
                {
                    oddSum += text[i] - 48U;
                    oddCount++;
                }
            }
            Console.WriteLine(oddCount + " " + oddSum);
            Console.ReadLine();
        }
    }
}
