namespace IndepedentQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalQuestion = 0;
            int score = 0;
            int correct = 0;

            Console.WriteLine("Quiz by Pratyush");
            Console.WriteLine("Welcome to my Quiz Game!");
            Console.WriteLine("Q1 out of Q5: True or False? The United States share border with 3 different countries");
            string user_type = Console.ReadLine().ToLower();
            if (user_type == "false")
            {
                Console.WriteLine("Correct Answer, you gained your very first point!");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer, it only borders with 2! (Canada and Mexico)");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q2 out of Q5: True or False? Mountain Everest is the highest mountain in the world");
            string user_type_2 = Console.ReadLine().ToLower();
            if (user_type_2 == "true")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer, it actually is the highest mountain is the world!");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q3 out of Q5: True or False? Shanghai is the capital of China");
            string user_type_3 = Console.ReadLine().ToLower();
            if (user_type_3 == "false")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer, it's actually Bejing!");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q4 out of Q5: True or False? The Sun rises from the east");
            string user_type_4 = Console.ReadLine().ToLower();
            if (user_type_4 == "true")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q5 out of Q5: True or False? Abraham Lincoln was the 3th president of the United States");
            string user_type_5 = Console.ReadLine().ToLower();
            if (user_type_5 == "false")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("No silly! He was the 16th President of the United States.");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);
            if (correct >= 0)
            {
                Console.WriteLine("Well done! You finished the quiz! You answered " + correct + " out of " + totalQuestion + " questions correctly!");
            }
            else
            {
                Console.WriteLine("Well done! You finished the quiz! You answered 0 out of " + totalQuestion + " questions correctly!");
            }

        }
    }
}