using System;

/* Test Case 1 for Submission1
Simple script to introduce self.
Asking user name input and a simple greeting.
*/

namespace MyBiography
{
    class Sample
    {
        static void Main(string[] args)
        {
            string fullName = "Catherine Ata";
            int Age = 39;
            bool isFemale = true;
            float numberTerms = 4.5f;

            Console.WriteLine("My name is {0} .", fullName);
            Console.WriteLine("I am {0} years old.", Age);
            Console.WriteLine("Female: {0}", isFemale);
            Console.WriteLine("Student at CityU for {0} terms.", numberTerms);

        }
    }
}
