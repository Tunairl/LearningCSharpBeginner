using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow.Exercises
{
    internal class RandomExercises
    {
        public static void Main(string[] args)
        {

            //Exercise1();
            //Exercise2();
            //Exercise3();
            Exercise4();
            //Exercise5();
        }

        public static void Exercise1()
        {
            int count = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public static void Exercise2()
        {
            double sum = 0;

            while (true)
            {

                Console.WriteLine("Enter a number or enter 'ok' to exit.");
                var input = Console.ReadLine();
                if (input is "ok")
                {
                    break;
                }
                else
                {
                    sum = sum + Convert.ToDouble(input);
                }

            }
            Console.WriteLine(sum);

        }

        public static void Exercise3()
        {

            Console.WriteLine("Enter a number, I'll give you the factorial of it.");
            var input = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= input; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }

        public static void Exercise4()
        {
            var rand = new Random();
            int randNum = rand.Next(1, 10);
            int chanceLeft = 4;

            Console.WriteLine("Guess the number between [1-10]. You have 4 chances.");

            for (int i = 0; i < chanceLeft;)
            {

                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == randNum)
                {
                    Console.WriteLine("Correct! You found it! \n\nExiting...");
                    break;
                }
                else if (userGuess != randNum && --chanceLeft != 0)
                {
                    Console.WriteLine($"Try again! You have {chanceLeft} chance(s) left.");
                }
                else if (chanceLeft == 0)
                {
                    Console.WriteLine("No more chances left. \n\nExiting...");
                }
            }

        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter a series of numbers separated by a comma. I'll find the maximum.");

            var input = Console.ReadLine();

            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]); 

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);

                if (number > max)
                {
                    max = number;
                }
                Console.WriteLine("Max number is: " + number);
            }
        }

    }
}
