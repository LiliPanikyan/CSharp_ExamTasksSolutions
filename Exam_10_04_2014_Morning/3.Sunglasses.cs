using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int height = n;

        string bridge = new string('|', n);
        string lenses = new string('/', 2 * n - 2);
        string spaceBetween = new string(' ', n);
        string topBottomFrames = new string('*', 2 * n);
        string asterix = new string('*', 1);
        string midle = asterix + lenses + asterix;
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || i == n - 1)
            {
                Console.WriteLine(topBottomFrames + spaceBetween + topBottomFrames);
            }
            else if (i == n / 2)
            {
                Console.WriteLine(midle + bridge + midle);
            }
            else
            {
                Console.WriteLine(midle + spaceBetween + midle);
            }
        }
    }
}