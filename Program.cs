//Orlando Huertas 

using System;

namespace Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a CAD increment value between 5 and 25 and press enter:"); //Get Console to tell the user to enter input 
            try
            {
                string input = Console.ReadLine(); //have using input something 
                int value_of_input = int.Parse(input); //turn input into int 

                if ((value_of_input >= 5) && (value_of_input <= 25)) //(if condition)if the input value is between 5 and 25 
                {
                    Console.WriteLine("Your conversion rates are as follows:"); //Read Line 
                    
                    for (int i = 0; i <= 200; i += value_of_input) //(for loop) i start at 0. for every i that is less than or equal to 200 add the input value to it 
                    {
                   
                        double US = i * 0.792367; // equation for US Dollar 
                        Console.WriteLine("The value of " + i + " CAD is converted to " + Math.Round(US, 2, MidpointRounding.ToZero) + " USD");
                        // Write line informing the customer of the canadian dollar value and it's value in US Dollar. use Math.round to round the number to 2 decimal places down. Ex 20 CAD is 15.84734 but since this is money we would round to 15.84 and not 15.85 
                    }
                }
                else
                {
                    Console.WriteLine("Enter a value between 5 and 25"); // Else condition if the value is not within 5 and 25 
                    Console.WriteLine("Please Any Button to Exit and Try Again");
                }
            }
            catch
            {
                Console.WriteLine("Invalid Value"); // Catch condition if value is not within 5 or 25 or an int 
                Console.WriteLine("Please Any Button to Exit and Try Again");
            }    
        }
    }
}
