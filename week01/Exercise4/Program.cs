using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers= new List<int>();
        
 
        Console.WriteLine("Please give me a series of numbers. Enter 0 to end it:");
        

        int userInput = -1;
     
        while (userInput != 0)
        {
            Console.WriteLine ("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        int totalSum = 0;
        foreach (int num in numbers)
        {
            totalSum+= num;
            

        }
        Console.WriteLine ($"The total is {totalSum}"); 
        
        if (numbers.Count>0)  
        {
            double average = (double)totalSum / numbers.Count;
            Console.WriteLine ($"The average is {average}");
        }
        else
        {
            Console.WriteLine ("Sorry, no numbers");
        }

        int largest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine ($"The largest number is {largest}");

        
        

        
                
         
            
           

        
    }

    
    
        
    
}