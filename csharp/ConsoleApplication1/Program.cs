using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {

        private static string getDaysUntilBirthday(int difference)
        {
            return (difference < 0) ? (Math.Abs(difference).ToString()) : (365 - difference).ToString();
        }

        public static void Main(string[] args)
        {
            string article; // "a" or "an"
            string vowels = "aeiou";
            
            // Prompt user to type a name and birthday
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            name = name.ToLower();

            Console.Write("What's your birthday? (MM/DD) ");
            string birthday = Console.ReadLine();
            Console.WriteLine();
            
            // calculate number of days from today until next birthday
            int difference = DateTime.Today.Subtract(DateTime.Parse(birthday)).Days;
            string daysUntilBirthday = getDaysUntilBirthday(difference);
            
            // print out the cheer with appropriate "a" or "an" if the letter is a consonant or vowel
            foreach (char letter in name)
            {
                article = vowels.Contains(letter) ? "an" : "a";
                Console.WriteLine("Give me {0}..{1}", article, letter);
            }
            
            Console.WriteLine("\n{0} is.. GRAND\n", name.ToUpper());
            
            Console.WriteLine( (difference == 0) ? "Happy Birthday!!" : 
                "Your birthday is {0} days away.", daysUntilBirthday );

            Console.ReadLine();
        }
    }
}
