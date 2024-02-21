using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Delorean Time Machine");
        Console.WriteLine("Please enter your credentials");
        Console.Write("username: ");
        string userName = Console.ReadLine();
        Console.Write("password: ");
        string password = Console.ReadLine();
        Console.WriteLine(userName);
        Console.WriteLine(password);

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
