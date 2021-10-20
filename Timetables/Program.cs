using System;

namespace Timetables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome user and ask which times table they would like to view
            Console.WriteLine("Welcome to Multiply till You Fly");
            Console.WriteLine("Which times table would you like to see?\n- \tall (to generate all 12 time tables), OR\n- \t1 to 12 (to view individual time tables)");
            string userChoice = Console.ReadLine();

            // Display all times table if selected, otherwise progress to the rest
            if (userChoice == "all")
            {
                Console.WriteLine(" Multiplication Tables");

                for (int i = 1; i <= 12; i++)
                {
                    for (int j = 1; j <= 12; j++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", i, j, i*j);
                    }
                }
            }

            // Display the user's choice in a message before output is printed
            else
            {
                Console.WriteLine($"You have selected the {userChoice} times table");

            // Display the time table using the user's choice
                int table = int.Parse(userChoice);
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{i} x {table} = {i * table}");
                }
            }
            
            // Ask user if another time table is needed
            bool incorrect = true;
            while (incorrect)
            {
                Console.WriteLine("Would you like to select another times table? (Y/N)");

                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key.ToString() == "Y")
                {
                    Console.WriteLine("\nWhich times table would you like to see next?");
                    string userChoice2 = Console.ReadLine();

                    Console.WriteLine($"\nYou have selected the {userChoice2} times table");

                    int table2 = int.Parse(userChoice2);
                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine($"{i} x {table2} = {i * table2}");
                    }
                }
                else
                {
                    Console.WriteLine("\nNo problem. Thank you for using our services!");
                    incorrect = false;
                }
            }
        }
    }
}
