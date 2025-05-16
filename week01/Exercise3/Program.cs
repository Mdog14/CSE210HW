using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("What is your magic number?" 1 - 100);
        string input = Console.ReadLine();
        int playerNumber = int.Parse(input);*/


        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;


        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}