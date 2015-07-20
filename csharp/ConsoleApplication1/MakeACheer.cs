using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class MakeACheer
    {

        public static void Go()
        {
            string name, birthday, daysUntilBirthday;

            name = getUserName();
            birthday = getBirthday();
            daysUntilBirthday = getDaysUntilBirthday(getDaysFromToday(birthday));
            Cheer(name, daysUntilBirthday);

            Console.ReadLine();
        }

        private static void Cheer(string name, string daysUntilBirthday)
        {
            // print out the cheer with appropriate "a" or "an" if the letter is a consonant or vowel
            string softSounds = "halfnorsemix", article;
            Console.WriteLine();
            foreach (char letter in name)
            {
                article = softSounds.Contains(letter) ? "an" : "a";
                Console.WriteLine("Give me {0}..{1}", article, letter);
            }

            Console.WriteLine("\n{0} is.. GRAND\n", name.ToUpper());
            Console.WriteLine((int.Parse(daysUntilBirthday) == 0) ? "Happy Birthday!!" :
                "Your birthday is {0} days away.", daysUntilBirthday);
        }

        private static string getUserName()
        {
            // Prompt user to type a name
            Console.Write("Please enter your name: ");
            return (Console.ReadLine()).ToLower();
        }

        private static string getBirthday()
        {
            // Prompt user to type a birthday
            Console.Write("What's your birthday? (MM/DD) ");
            return Console.ReadLine();
        }

        private static string getDaysUntilBirthday(int difference)
        {
            // return the number of days until your next birthday
            return (difference < 0) ? (Math.Abs(difference).ToString()) : (365 - difference).ToString();
        }

        private static int getDaysFromToday(string birthday)
        {
            // get the number of days from today, positive (past) or negative (future)
            return DateTime.Today.Subtract(DateTime.Parse(birthday)).Days;
        }
    }
}
