using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int frameWidth = 2 * height;//'*'
            int bridgeSize = height - 1;// '-'
            int spaceSize = height - 1;
            int lensesWidth = 2 * height - 2;// '/'
            
            string asterix = new string('*',1);
            string middle = new string('/', lensesWidth);
            string bridge = new string('-', bridgeSize);
            string spaceBetween = new string(' ', bridgeSize);
            for (int i = 0; i < height; i++)
            {
                if (i==0 || i==height-1)
                {
                    string topBottom = new string('*', frameWidth-2);
                    string space = new string(' ', 1);
                    Console.WriteLine(space + topBottom + space + spaceBetween + space+topBottom+space );
                }
                else if (i== height/2)
	            {
                    Console.WriteLine(asterix + middle+ asterix + bridge + asterix + middle + asterix);
	            }
                else
                {
                    
                    Console.WriteLine(asterix + middle + asterix + spaceBetween + asterix + middle + asterix);
                }
            }
        }
    }
}