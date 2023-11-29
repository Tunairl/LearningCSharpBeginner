using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    internal class StringBuilderDemo
    {
        static void Main(string[] args)
        {
            var sBuilder = new StringBuilder("Hello World");

            sBuilder.Append('-', 10)
                    .Append("Header")
                    .AppendLine()
                    .Append('-', 10)
                    .AppendLine()
                    .Replace('-', '+')
                    .Remove(0, 10)
                    .Insert(0, new string('-', 10));

            Console.WriteLine(sBuilder);
            Console.WriteLine("First index: " + sBuilder[0]);
        }
    }
}
