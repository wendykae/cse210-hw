using System;

class Program
{static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayMessage();

        string name = PromptUserName();
        // Console.WriteLine ($" {name}");
        
        int number = PromptUserNumber();
        // Console.WriteLine ($" {number}");

        int square = SquareNumber(number);
            Console.WriteLine ($"{name}, the square of your number is {square}");
    }
    static void DisplayMessage()
    {
        Console.WriteLine ("Welcome to the program!");
    }

    static string PromptUserName ()
    {    
        Console.WriteLine ("What is your user name?");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber ()
    {
        Console.WriteLine ("What is your favorite number?");
        int usernumber = int.Parse (Console.ReadLine());
        
        return usernumber;
    }
    static int SquareNumber (int first)
    {
        int square = first * first;
        return square;
    }
    
}