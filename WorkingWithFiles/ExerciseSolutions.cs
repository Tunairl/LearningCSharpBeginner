using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    internal class ExerciseSolutions
    {
        public static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }

        public static void Exercise1()
        {
            var path = @"C:\Users\tuna_\OneDrive\Masaüstü\kalem.txt";

            var fileContents = File.ReadAllText(path);
            var words = fileContents.Split(' ');

            var count = 0;
            foreach (var word in words)
            {
                count++;
            }
            Console.WriteLine(count);
        }

        public static void Exercise2()
        {
            var path = @"C:\Users\tuna_\OneDrive\Masaüstü\kalem.txt";
            var fileContents = File.ReadAllText(path);
            var words = fileContents.Split(' ');

            var maxNumOfLetter = 0;
            for (int i = 0; i< words.Length; i++)
            {
                var word = words[i];
                if (word.Length > maxNumOfLetter)
                {
                    maxNumOfLetter = word.Length;
                }
            }
            Console.WriteLine(maxNumOfLetter);
        }
    }
}
