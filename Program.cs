using FirstCSharpProgram;
using System;
using System.Threading;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Create users for Doc and Marty
        User Marty = new User("Marty", "your_kids_are_gonna_love_it");
        User Doc = new User("Doc_Brown", "great_scott");
        User[] users = { Marty, Doc };

        bool carRunning = true;

        while(carRunning)
        {
            Console.Clear(); // Clear the console
            Console.WriteLine("Welcome to the Delorean Time Machine");
            Console.WriteLine("Please enter your credentials");
            Console.Write("username: ");
            string userName = Console.ReadLine();
            Console.Write("password: ");
            string password = Console.ReadLine();
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].UserName == userName && users[i].Password == password)
                {
                    bool goingToDrive = true;
                    bool initialStartUp = true;
                    while (goingToDrive)
                    {
                        if (initialStartUp)
                        {
                            Console.WriteLine($"Welcome, {userName}");
                            Console.Write($"What year would you like to visit today? ");
                        }
                        else
                        {
                            Console.Write($"What year would you like to visit? ");
                        }
                        string year = Console.ReadLine();
                        string yearPattern = @"^\d{4}$";
                        Match yearMatch = Regex.Match(year, yearPattern);
                        if (yearMatch.Success)
                        {
                            Console.WriteLine("Buckle Up!");
                            for (int j = 0; j <= 5; j++)
                            {
                                Console.Clear(); // Clear the console
                                Console.WriteLine($"Speedometer: {j} mph"); // Display new content
                                Thread.Sleep(150); // Wait for .15 seconds
                            }
                            for (int k = 6; k <= 15; k++)
                            {
                                Console.Clear(); // Clear the console
                                Console.WriteLine($"Speedometer: {k} mph"); // Display new content
                                Thread.Sleep(100); // Wait for .1 seconds
                            }
                            for (int l = 16; l <= 30; l++)
                            {
                                Console.Clear(); // Clear the console
                                Console.WriteLine($"Speedometer: {l} mph"); // Display new content
                                Thread.Sleep(50); // Wait for .05 seconds
                            }
                            for (int m = 31; m <= 50; m++)
                            {
                                Console.Clear(); // Cmear the consome
                                Console.WriteLine($"Speedometer: {m} mph"); // Dispmay new content
                                Thread.Sleep(20); // Wait for .020 seconds
                            }
                            for (int n = 51; n <= 88; n++)
                            {
                                Console.Clear(); // Cmear the consome
                                Console.WriteLine($"Speedometer: {n} mph"); // Dispmay new content
                                Thread.Sleep(15); // Wait for .015 seconds
                            }
                            string woosh = "WWWWWWOOOOOOOOOOOOOOOOOSSSSSSSSHHHHHHHHHHHHH!!!!!!!!";
                            Thread.Sleep(600);
                            for (int o = 0; o < woosh.Length; o++)
                            {
                                Console.Write(woosh[o]);
                                Thread.Sleep(40);
                            }
                            Console.WriteLine("");
                            Thread.Sleep(600);
                            Console.WriteLine($"Welcome to the year {year}, {userName}");
                            Console.Write("Would you like to visit another year? (Y/N) ");
                            string visitAnotherYear = Console.ReadLine();
                            if (visitAnotherYear == "Y")
                            {
                                initialStartUp = false;
                                continue;
                            }
                            else
                            {
                                goingToDrive = false;
                            }
                            Console.Write("Would you like to start over (LogOff) or exit vehicle (exit)? ");    
                            string keepCarRunning = Console.ReadLine();
                            if (keepCarRunning == "LogOff") 
                            {
                                break;
                            }
                            else
                            {
                                carRunning = false;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("That's not a year!");
                        }
                    }
                }
            }
        }
        

        /*
        for (int i = 0; i <= 10; i++)
        {
            Console.Clear(); // Clear the console
            Console.WriteLine($"Counter: {i}"); // Display new content
            Thread.Sleep(1000); // Wait for a second
        }
        */
    }
}
