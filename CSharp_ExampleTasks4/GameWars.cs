using System;

class Program
{
    static void Main(string[] args)
    {
        int matchGames = int.Parse(Console.ReadLine());
        int firstStrength = 0;
        int secondStrenght = 0;
        int scoreFirst = 0;
        int scoreSecond = 0;
        bool firstPlayergetXcard = false;
        bool secondPlayerGetXcard = false;
        for (int i = 0; i < matchGames; i++)
        {
            for (int a = 0; i < 3; i++)
            {

                string firstPlayerSelection = Console.ReadLine();
                switch (firstPlayerSelection)
                {
                    case "A": firstStrength += 1;
                        break;
                    case "J": firstStrength += 11;
                        break;
                    case "K": firstStrength += 13;
                        break;
                    case "Q": firstStrength += 12;
                        break;
                    case "Z": secondStrenght *= 2;
                        break;
                    case "Y": secondStrenght -= 200;
                        break;
                    case "X": secondStrenght = true;
                        break;
                    default: firstStrength += 12 - int.Parse(firstPlayerSelection);
                        break;
                }
            }

            for (int b = 0; b <3; b++)
            {
                string secondPlayerSelection = Console.ReadLine();
                switch (secondPlayerSelection)
                {
                    case "A": secondStrenght += 1;
                        break;
                    case "J": secondStrenght += 11;
                        break;
                    case "K": secondStrenght += 13;
                        break;
                    case "Q": secondStrenght += 12;
                        break;
                    case "Z": secondStrenght *= 2;
                        break;
                    case "Y": secondStrenght -= 200;
                        break;
                    case "X": secondStrenght = true;
                        break;
                    default: secondStrenght += 12 - int.Parse(secondPlayerSelection);
                        break;
                }

            }
        }
        if (firstPlayergetXcard && secondPlayerGetXcard)
        {
            scoreFirst += 50;
            scoreSecond += 50;
        }
        else if (firstPlayergetXcard)
        {
            break;
        }
        else if (secondPlayerGetXcard)
        {
            break;
        }
        int countWons = 0;
        if (firstStrength > secondStrenght)
        {
            scoreFirst += firstStrength;
            countWons++;
        }
        else
        {
            scoreSecond += secondStrenght;
            countWons++;
        }
        firstStrength = 0;
        secondStrenght = 0;
        firstPlayergetXcard = false;
        secondPlayerGetXcard = false;
        if (firstPlayergetXcard)
        {
            Console.WriteLine("X card drawn! Player one wins the match!");
        }
        else if (secondPlayerGetXcard)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else if (scoreFirst > scoreSecond)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: " + scoreFirst);
            Console.WriteLine("Games won: " + countWons);
        }
        else if (scoreSecond > scoreFirst)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: " + scoreSecond);
            Console.WriteLine("Games won: " + countWons); 
        }
        else
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", scoreFirst);
        }
        Console.ReadLine();
    }
}

