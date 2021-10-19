using System;

namespace Timetables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome user and ask which times table they would like to view
            Console.WriteLine("Welcome to Multiply-till-YouFly");
            Console.WriteLine("Which times table would you like to see?");
            string userChoice = Console.ReadLine();

            // Display the user's choice in a message before output is printed
            Console.WriteLine($"You have selected the {userChoice} times table");

            // Display the time table using the user's choice
            int table = int.Parse(userChoice);
            for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{i} x {table} = {i * table}");
                }
        }
    }
}
