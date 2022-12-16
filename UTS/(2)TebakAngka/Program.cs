using System;

namespace TebakAngka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int number;
            String response;

            while(playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = rnd.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number betweem " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess : " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low !");
                    }
                    guesses++;
                }
                Console.WriteLine("Number : " + number);
                Console.WriteLine("You win !!");
                Console.WriteLine("Guesses : " + guesses);

                Console.WriteLine("Would you like to play again ? (y/n) : ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing !");

            Console.ReadKey();
        }
    }
}