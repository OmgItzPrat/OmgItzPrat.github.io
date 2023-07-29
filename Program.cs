using System.ComponentModel.Design;

namespace NumberGuesser // Namespaces are used in C# to organize and provide a lvl of separation of code
{
    internal class Program
    {
        static void Main(string[] args) // The main method is the entry point of a C# application. When the application is started
        {
            // The objective of the game is to guess the correct random number from a range of 1 to 100
            Console.WriteLine("Welcome to my Guessing Game!");
            Console.WriteLine("Try to guess a number from 1 to 100");
            // Console.WriteLine() is used yo print stuff to the console

            //console = class, writeline = method
            //random = class, next = method

            // Generate a random number from 1 to 100
            Random randomGenerator = new Random(); // This lets us use a specific method from the Random class
            int secretNumber = randomGenerator.Next(1, 101); // 1 and 101 count as 'arguments' for this method.
            // secretNumber generates a random number from randomGenerator, the range is 1 inclusive to 101 exclusive. Next is the method of Random Numbers

            // These are the variables that I created
            int guess;
            bool correctGuess = false;
            int lives = 10;

            // Allow the user to keep going until they reach the correct number
            while (!correctGuess) // While correctGuess is false (because of the exclamation mark)
            {
                Console.WriteLine();
                Console.WriteLine("Enter your guess: ");
                string userInput = Console.ReadLine();

                // Check if the user input guess a string or number
                if (!int.TryParse(userInput, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    lives--;
                    continue;
                }

                // Check if guess was correct

                if (guess == secretNumber) // You can only compare integers with integers
                {
                    Console.WriteLine();
                    Console.WriteLine("Great Job, you guessed the right number!");
                    correctGuess = true; // This helps to stop the while loop
                    Console.WriteLine("Thanks for Playing!");
                    Console.WriteLine();
                    Console.WriteLine("Do you want to play again? (Y/N) ");

                    string userInput3 = Console.ReadLine().ToLower();

                    if (userInput3 == "y")
                    {
                        correctGuess = false;
                        secretNumber = randomGenerator.Next(1, 101);
                        lives = 10;
                    }

                    else if (userInput3 == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Game!");
                    }

                }

                else if (guess > secretNumber) // if the guessed number is greater than the secret number, do this.
                {
                    Console.WriteLine();
                    Console.WriteLine("It's too high");
                    lives--;
                }

                else if (guess < secretNumber) // if the guessed number is greater than the secret number, do this.
                {
                    Console.WriteLine();
                    Console.WriteLine("It's too low");
                    lives--;
                }

                if (lives == 0)
                {
                    correctGuess = true;
                    Console.WriteLine();
                    Console.WriteLine("You're out of lives, do you want to play again? (Y/N) ");

                    string userInput2 = Console.ReadLine().ToLower();

                    if (userInput2 == "y")
                    {
                        correctGuess = false;
                        secretNumber = randomGenerator.Next(1, 101);
                        lives = 10;
                    }

                    else if (userInput2 == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Good Game!");
                    }
                }
            }
            

            // Challenge: Give user any amount of lives, if they fail

        }
    }
}