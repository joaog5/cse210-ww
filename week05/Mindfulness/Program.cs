using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Run();
                    break;
                case 2:
                    new ReflectionActivity().Run();
                    break;
                case 3:
                    new ListingActivity().Run();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress ENTER to return to the main menu...");
                Console.ReadLine();
            }
        }
    }
}