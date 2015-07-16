using System;

namespace ConsoleApplication1
{
    class Program
    {

        public static string getDaysUntilBirthday(int difference)
        {
            if (difference < 0)
            {
                return (Math.Abs(difference)).ToString();
            } else
            {
                return (365 - difference).ToString();
            }
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

            // create DateTime object for birthday
            DateTime birthday = new DateTime(DateTime.Today.Year, int.Parse(monthAndDay[0]), int.Parse(monthAndDay[1]));

            // calculate difference between today and next birthday
            int difference = DateTime.Today.Subtract(birthday).Days;
            
            // print out the cheer
            // for each character in the name
            //     print out the line for the appropriate cheer

            for (int i = 0; i < input.Length; i++)
            {
                // is this character a member of the vowel array?
                article = Array.IndexOf(vowels, input[i]) < 0 ? "a" : "an";
                Console.WriteLine("Give me {0}..{1}", article, input[i]);
            }
            
            // print out final line with name in uppercase
            Console.WriteLine("\n{0} is.. GRAND\n", input.ToUpper());
            

            if (difference == 0)
            {
                Console.WriteLine("Happy Birthday!!");
            }
            else
            {
                Console.WriteLine("Your birthday is {0} days away.", getDaysUntilBirthday(difference));
            }

            Console.ReadLine();
        }
    }
}
