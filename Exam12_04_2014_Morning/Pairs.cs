using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs
{
    class Pairs
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] masiv = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            List<int> result = new List<int>();
            int sum = 0;
            for (int i = 0; i < masiv.Count(); i++)
            {
                int f = masiv[i];
                int l = masiv[i + 1];
                sum = f + l;
                result.Add(sum);
                
                i += 1;
            }

            int maxDiff = 0;
            for (int y = 0; y < result.Count-1; y++)
			{
                int differences = (Math.Abs(result[y + 1] - result[y]));
                maxDiff = Math.Max(differences, maxDiff);
			}
           
			    if (maxDiff ==0)
                {
                    Console.WriteLine("Yes, value={0}", sum);
                }
                else
                {
                    
                    Console.WriteLine("No, maxdiff={0}", maxDiff);
                }
            
        }

    }
}


