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
            Console.WriteLine("Q1 out of Q5: How many countries share borders with the United States?");
            Console.WriteLine("A. 1");
            Console.WriteLine("B. 2");
            Console.WriteLine("C. 3");
            Console.WriteLine("D. 5");
            Console.WriteLine("Choose a letter as a answer!");
            Console.WriteLine();
            string user_type = Console.ReadLine().ToLower();

            if (user_type == "b")
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


            Console.WriteLine("Q2 out of Q5: What's the biggest country in the world?");
            Console.WriteLine("A. China");
            Console.WriteLine("B. USA");
            Console.WriteLine("C. Russia");
            Console.WriteLine();
            string user_type_2 = Console.ReadLine().ToLower();

            if (user_type_2 == "c")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer, it is Russia.");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q3 out of Q5: What is the capital of China");
            Console.WriteLine("A. Shanghai");
            Console.WriteLine("B. Hong Kong");
            Console.WriteLine("C. London");
            Console.WriteLine("D. Bejing");
            Console.WriteLine();
            string user_type_3 = Console.ReadLine().ToLower();

            if (user_type_3 == "d")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer, it's actually Bejing.");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q4 out of Q5: How old is the Sun?");
            Console.WriteLine("A. 4.6 billion years");
            Console.WriteLine("B. 2.3 billion years");
            Console.WriteLine("C. 2023 years");
            Console.WriteLine();
            string user_type_4 = Console.ReadLine().ToLower();

            if (user_type_4 == "a")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer, it is 4.6 billion years old.");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q5 out of Q5: Who was the 16th president of the US?");
            Console.WriteLine("A. George Washington");
            Console.WriteLine("B. Abraham Lincoln");
            Console.WriteLine("C. Thomas Jefferson");
            Console.WriteLine("Choose a letter as a answer!");
            string user_type_5 = Console.ReadLine().ToLower();

            Console.WriteLine();
            if (user_type_5 == "b")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
                correct++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer, Abraham Lincoln was the 16th President of the United States.");
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
