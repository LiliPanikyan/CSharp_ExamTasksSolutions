using System;

namespace Garden
{
    class Garden
    {
        static void Main(string[] args)
        {
            double tomatoAmount = double.Parse(Console.ReadLine());
            double tomatoArea = double.Parse(Console.ReadLine());
            double cucumberAmount = double.Parse(Console.ReadLine());
            double cucumberArea = double.Parse(Console.ReadLine());
            double potatoAmount = double.Parse(Console.ReadLine());
            double potatoArea = double.Parse(Console.ReadLine());
            double carrotAmount = double.Parse(Console.ReadLine());
            double carrotArea = double.Parse(Console.ReadLine());
            double cabbageAmount = double.Parse(Console.ReadLine());
            double cabbageArea = double.Parse(Console.ReadLine());
            double beansAmount = double.Parse(Console.ReadLine());
            double tomatoPrice = tomatoAmount * 0.5;
            double cucumberPrice = cucumberAmount * 0.4;
            double potatoPrice = potatoAmount * 0.25;
            double carrotPrice = carrotAmount * 0.6;
            double cabbagePrice = cabbageAmount * 0.3;
            double beansPrice = beansAmount * 0.4;
            double totalCoast = tomatoPrice + cucumberPrice + potatoPrice + carrotPrice + cabbagePrice + beansPrice;
            double sumArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            Console.WriteLine("Total costs: {0:0.00}", totalCoast);
            if (sumArea> 250)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (sumArea == 250)
            {
                Console.WriteLine("No area for beans"); 
            }
            else if (sumArea< 250)
            {
                Console.WriteLine("Beans area: {0}", (250 - sumArea));
            }
            Console.ReadLine();
        }
    }
}
