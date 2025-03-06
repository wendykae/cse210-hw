using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please give my your grade percentage:");
        int score = int.Parse(Console.ReadLine());
        
        string letter;
        string sign= "";
        int lastDigit= score % 10;

            if (score >= 90)
            {
                letter = "A";
            
            }
            else if (score >= 80)
            {
                letter = "B";
            }
            else if (score >= 70)
            {
                letter= "C";
            }
            else if (score>= 60)
            {
                letter = "D";
            }
            else 
            {
                letter = "F";
            }
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit<=3)
            {
                sign = "-";
            }

            Console.WriteLine ($"You got a {letter}{sign}");
            
            if (score>70)
            {
                Console.WriteLine ("You passed");
            }
            else
            {
                Console.WriteLine ("Sorry you didn't pass");
            }
    }
}