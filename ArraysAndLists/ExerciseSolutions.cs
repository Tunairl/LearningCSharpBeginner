using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    internal class ExerciseSolutions
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
        }

        public static void Exercise1()
        {
            var friendsList = new List<string>();

            Console.WriteLine("Enter a name.");
            string nameInput = Console.ReadLine();

            while (!String.IsNullOrEmpty(nameInput))
            {
                friendsList.Add(nameInput);

                switch (friendsList.Count)
                {
                    case 0:

                        Console.WriteLine();
                        break;

                    case (1):

                        Console.WriteLine($"{friendsList[0]} liked your post.");
                        break;


                    case (2):

                        Console.WriteLine($"{friendsList[0]} and {friendsList[1]} liked your post.");
                        break;

                    default:

                        Console.WriteLine($"{friendsList[0]}, {friendsList[1]} and {friendsList.Count - 2} other(s) liked your post.");
                        break;
                }
                nameInput = Console.ReadLine();
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter your name. I'll reverse it.");
            string name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }

            //name.ToCharArray();
            //var reversedName = name.Reverse();

            //foreach (char c in reversedName)
            //{
            //    Console.Write(c);
            //}
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter 5 different numbers.");
            var numbersList = new List<int>();

            while (numbersList.Count < 5)
            {
                var userInput = Int32.Parse(Console.ReadLine());

                if (numbersList.Contains(userInput))
                {
                    Console.WriteLine("Enter a unique number. Try again.");
                    continue;
                }
                numbersList.Add(userInput);
            }

            numbersList.Sort();
            Console.WriteLine();

            foreach (int i in numbersList)
            {
                Console.WriteLine(i);
            }

        }

        public static void Exercise4()
        {
            var numbersList = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number.");
                var userInput = Console.ReadLine();

                if (!Int32.TryParse(userInput, out int number))
                {
                    break;
                }
                numbersList.Add(number);
            }
            foreach (int i in numbersList.Distinct())
            {
                Console.WriteLine(i);
            }
        }
    }
}
