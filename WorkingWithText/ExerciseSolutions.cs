using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace WorkingWithText
{
    internal class ExerciseSolutions
    {
        static void Main(string[] args)
        {
            Exercise5();
        }

        public static void Exercise1()
        {
            var numbersList = new List<int>();

            Console.WriteLine("Enter a few numbers separated by a hyphen.");
            var userInput = Console.ReadLine();


            var numbers = userInput.Split('-').Select(int.Parse).ToList();

            bool isConsecutive = !numbers.Select((i, j) => i - j).Distinct().Skip(1).Any() ||
                !numbers.Select((i, j) => i + j).Distinct().Skip(1).Any();

            Console.WriteLine(isConsecutive ? "Consecutive" : "Not Consecutive");
        }

        public static void Exercise2()
        {

            Console.WriteLine("Enter a few numbers separated by a hyphen.");

            var userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput))
            {
                return;
            }

            var numbers = userInput.Split('-').Select(int.Parse).ToList();

            if (numbers.Count != numbers.Distinct().Count())
            {
                Console.WriteLine("Duplicate");
            }

        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a time value in a 24 hour format.");
            var userInput = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = userInput.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                {
                    Console.WriteLine("Ok!");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }

        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter a few words separated by a whitespace.");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Run the program and try again.");
            }

            var words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (word.Length > 0)
                {
                    var firstChar = char.ToUpper(word[0]);
                    var restChars = word.Substring(1).ToLower();

                    words[i] = firstChar + restChars;
                }
            }
            var output = string.Join("", words);
            Console.WriteLine(output);
        }

        public static void Exercise5()
        {
            try
            {
                Console.WriteLine("Enter a word in English");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Run the program and try again.");
                }

                var countVowel = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    switch (input[i])
                    {
                        case 'a':
                            {
                                countVowel++;
                                break;
                            }
                        case 'e':
                            {
                                countVowel++;
                                break;
                            }
                        case 'i':
                            {
                                countVowel++;
                                break;
                            }
                        case 'u':
                            {
                                countVowel++;
                                break;
                            }
                        case 'o':
                            {
                                countVowel++;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                Console.WriteLine(countVowel);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}

