using System;

class TheSecretsOfNumbers
{
    static void Main(string[] args)
    {
        string numberAsString = Console.ReadLine();
        int sum = 0;
        int isOddOrEven = 1;

        for (int i = 1; i <= numberAsString.Length; i++)
        {
            if (numberAsString[numberAsString.Length - i] == '.' || numberAsString[numberAsString.Length - i] == '-')
            {
                continue;
            }
            if (isOddOrEven % 2 == 1)
            {
                int currentLastDigit = int.Parse(numberAsString[numberAsString.Length - i].ToString());
                sum += currentLastDigit * ((i) * (i));
                isOddOrEven++;
                continue;
            }
            else
            {
                sum += ((int)Math.Pow(int.Parse(numberAsString[numberAsString.Length - i].ToString()), 2)) * (i);
                isOddOrEven++;
                continue;
            }
        }
        int specialNumberR = sum % 26;

        Console.WriteLine(sum);
        if (sum % 10 > 0)
        {

            for (int i = 1; i <= sum % 10; i++)
            {
                int symbol = specialNumberR + i + 64;
                if (symbol > 90)
                {
                    symbol = symbol - 26;
                }
                Console.Write((char)(symbol));
            }
        }
        else
        {
            Console.WriteLine("{0} has no secret alpha-sequence", numberAsString);
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
