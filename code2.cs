using System;
using static System.Console;

namespace WarnLevel
{
    class Program
    {
        // Defined class level constant variables of int type. 
        // values initialized are gas in gallons
        const int fullTank = 12; 
        const int halfTank = 6, quarterTank = 3, emptyTank= 0;        

        public static void Main(string[] args)
        {
            int fuel = fullTank; 
            ShowLevel(fuel); // calling the ShowLevel () method with variable fullTank - default condition
            fuel = halfTank;
            ShowLevel(fuel); // calling the ShowLevel () method with variable halfTank
            fuel = quarterTank;
            ShowLevel(fuel); // calling the ShowLevel () method with variable quarterTank
            fuel = emptyTank;
            ShowLevel(fuel); // calling the ShowLevel () method with variable emptyTank

            ReadLine();
        }
        public static void ShowLevel(int fuel)
        {
            Write("Fuel in gallons:" + fuel + ". ");

            if (fuel == emptyTank)
            {
                WriteLine("Gas tank is empty: Get gas now!");
            }
            else if (fuel == quarterTank)
            {
                WriteLine("Gas tank is almost empty: Look for gas station.");
            }
            else if (fuel == halfTank)
            {
                WriteLine("Gas tank is half full.");
            }
            else
            {
                WriteLine("Gas tank is full.");   // default condition
            }
        }
    }
}