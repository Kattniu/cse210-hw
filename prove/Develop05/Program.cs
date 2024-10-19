using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program.");
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");


            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Start();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Start();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Start();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using the program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
