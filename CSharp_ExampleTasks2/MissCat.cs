using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int[]catsScore = new int[11];
            
            for (int i = 0; i < person; i++)
            {
                byte vote = byte.Parse(Console.ReadLine());
                catsScore[vote]++;
            }
            int bestCatScore = 0;
            int indexOfBestCat = 1;
            for (int y = 1; y <=10; y++)
            {
                if (catsScore[y]> bestCatScore)
                {
                    bestCatScore = catsScore[y];
                    indexOfBestCat = y;
                }
            }
            Console.WriteLine(indexOfBestCat);
            Console.ReadLine();
        }
    }
}
