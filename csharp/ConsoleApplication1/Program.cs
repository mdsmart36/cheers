using System;

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
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' }; // array of vowels

            // Prompt user to type a name and birthday
            Console.Write("Please enter your name: ");
            string input = Console.ReadLine();
            input = input.ToLower();

            Console.Write("What's your birthday? (MM/DD) ");
            string bday = Console.ReadLine();
            Console.WriteLine();

            // parse string into month and day
            string[] monthAndDay = bday.Split('/');

            // create DateTime object for birthday (Year, Month, Day)
            DateTime birthday = new DateTime(DateTime.Today.Year, int.Parse(monthAndDay[0]), int.Parse(monthAndDay[1]));

            // calculate difference between today and next birthday
            int difference = DateTime.Today.Subtract(birthday).Days;
            
            // print out the cheer with appropriate "a" or "an" if the letter is a consonant or vowel
            foreach (var letter in input)
            {
                article = Array.IndexOf(vowels, letter) < 0 ? "a" : "an";
                Console.WriteLine("Give me {0}..{1}", article, letter);
            }
            
            Console.WriteLine("\n{0} is.. GRAND\n", input.ToUpper());
            
            Console.WriteLine( (difference == 0) ? "Happy Birthday!!" : 
                "Your birthday is {0} days away.", getDaysUntilBirthday(difference) );

            Console.ReadLine();
        }
    }
}
