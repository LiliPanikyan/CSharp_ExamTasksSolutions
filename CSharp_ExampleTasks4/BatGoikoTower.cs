using System;

class BatGoikoTower
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Console.Write(new string('.', N - 1));
        Console.Write("/");
        Console.Write("\\");
        Console.WriteLine(new string('.', N - 1));
        for (int i = 1; i < N; i++)
        {
            if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
            {
                Console.Write(new string('.', (N - i) - 1));
                Console.Write("/");
                Console.Write(new string('-', i + i));
                Console.Write("\\");
                Console.Write(new string('.', (N - i) - 1));
            }

            else
            {
                Console.Write(new string('.', (N - i) - 1));
                Console.Write("/");
                Console.Write(new string('.', i * 2));
                Console.Write("\\");
                Console.Write(new string('.', (N - i) - 1));
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

