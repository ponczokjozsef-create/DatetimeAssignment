using System;

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Get the current date and time from the computer's clock
            DateTime now = DateTime.Now;

            // Print the current date and time to the console
            Console.WriteLine("The current date and time is: " + now);

            // 2. Ask the user for a number of hours
            Console.WriteLine("\nPlease enter a number of hours:");

            // Read the input as text and convert it to a whole number
            int hours = Convert.ToInt32(Console.ReadLine());

            // 3. AddHours() returns a new DateTime that is 'hours' hours later than 'now'
            DateTime futureTime = now.AddHours(hours);

            // Print the exact time it will be in X hours
            Console.WriteLine("In " + hours + " hours it will be: " + futureTime);

            // Keep the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}