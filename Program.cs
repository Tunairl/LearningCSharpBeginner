using System.Security.Cryptography.X509Certificates;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var seanson = Season.Summer;

            switch (seanson) {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("Sale is available.");
                    break;

                case Season.Spring:
                    Console.WriteLine("It's spring time.");
                    break;

                case Season.Winter:
                    Console.WriteLine("It's winter time.");
                    break;

                default: 
                    Console.WriteLine("I don't understand that season.");
                    break;
            }


        }

        

    }
}