using System;

/* Sample code for Submission1
Simple bio of myself.
*/
namespace MyBiography
{
    class Sample
    {
        static void Main(string[] args)
        {
            string Name = "Catherine";
            int Age = 39;
            bool isFemale = true;
            float MyFloat = 3.5f;

            Console.WriteLine("My name is {0}.", Name);
            Console.WriteLine("I am {0} years old.", Age);
            Console.WriteLine("Female: {0}", isFemale);
            Console.WriteLine("Sample float type: {0}", MyFloat);
        }
    }
}