using System;

/* Test Case 1 for Submission1
Simple script to introduce self.
Asking user name input and a simple greeting.
*/

namespace TestCase1
{

    class Greet_User

    {
        static void Main()
        {
            string firstName = "Catherine";
            int Age = 39;
            bool isFemale = true;
            float numberTerms = 4.5f;

                      
            // Ask user to input name
            Console.WriteLine("May I know your name?");

            // Create a string variable and get user input from the keyboard then store it in a variable
            string userName = Console.ReadLine();

            // Print the inputted value of the userName variable along with the greeting.
            Console.WriteLine("Hello {0}, it is nice to meet you!", userName);

            Console.WriteLine("My name is {0} .", firstName);
            Console.WriteLine("I am {0} years old.", Age);
            Console.WriteLine("Female: {0}", isFemale);
            Console.WriteLine("Student at CityU for {0} terms.", numberTerms);
        }
    }
}
