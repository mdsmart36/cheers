using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string article;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            // Prompt user to type a name
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();
            

            // print out the cheer
            // for each character in the name
            //     print out the line for the appropriate cheer

            for (int i = 0; i < input.Length; i++)
            {
                article = Array.IndexOf(vowels, input[i]) < 0 ? "a" : "an";
                Console.WriteLine("Give me {0}..{1}", article, input[i]);
            }
            
            // print out final line with name in uppercase
            Console.WriteLine("{0} is.. GRAND", input.ToUpper());

            Console.ReadLine();
        }
    }
}
