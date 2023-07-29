using System;
using System.Reflection.Metadata;
//System is a toolbox and you telling toolbox to write our code

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 16;
            //string name = "Patrick";
           //double mathScore = 90.5;

            //Console.WriteLine("My name is " + name);
            //Console.WriteLine("I am " + age + " years old");
            //Console.WriteLine("I scored " + mathScore + " on my math test yesterday. ");
            //IDE = Integraded Development Environment
            //Namespace is group that names our code
            //Method is a tool for programming (you need it).
            int totalQuestion = 0;
            int score = 0;
            Console.WriteLine("Group 5 Team Members: Pratyush Khatri, Erina Munir, Rachit Pandeya, Kushal BC");
            Console.WriteLine("Welcome to our Quiz Game!!!");
            Console.WriteLine("Q1 out of Q4: True or False? 5 times 5 = 25");
            string user_type = Console.ReadLine().ToLower();
            if(user_type == "true")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q2 out of Q4: True or False? Elephants are the biggest animals in the world");
            string user_type_2 = Console.ReadLine().ToLower();
            if (user_type_2 == "false")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q3 out of Q4: True or False? Zebras are known for having orange stripes");
            string user_type_3 = Console.ReadLine().ToLower();
            if (user_type_3 == "false")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);


            Console.WriteLine("Q4 out of Q4: True or False? Ronaldo plays golf");
            string user_type_4 = Console.ReadLine().ToLower();
            if (user_type_4 == "false")
            {
                Console.WriteLine("Correct Answer");
                score++; //Increase the score by 1
            }
            else
            {
                Console.WriteLine("Incorrect Answer");
                score--; //Decreases by 1
            }
            totalQuestion++;
            Console.WriteLine("Your score is at " + score);
            Console.WriteLine("Well done! You finished the quiz! You answered " + score + " out of " + totalQuestion + " questions correctly!");




            //Console.WriteLine(num1 * num2);
            //score++ means plus 1
        }
    }
}
