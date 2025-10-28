using System.Text;
using System;
namespace Assignment01;

public class Exercise03
{
    public void FizzBuzz(ushort num)
    {
        for (ushort i = 0; i < num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public void GuessMyNumber()
    {
        int guessedNumber = -1;
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Enter a number between 1 and 3: ");
        while (true)
        {
            try
            {
                guessedNumber= int.Parse(Console.ReadLine());
                if (guessedNumber < 1 || guessedNumber > 3)
                {
                    Console.WriteLine("Enter a number between 1 and 3: ");
                }
                else{
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Write a valid integer:");
            }
        }
        
        Console.WriteLine(correctNumber == guessedNumber ? 
            "you guessed correctly" :$"you guessed wrong. you chose {guessedNumber}, I chose {correctNumber}");
    }

    
    public void PrintAPyramid()
    {

        int row = 5;
        
        /* looking at the pyramid follows 2 * rowNum + 1 stars per row.
         */
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row - i - 1 ; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2*(i+1)-1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
        }
    }
    
    public void BirthDateAnniversary()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Please enter your birth year: ");
        ushort birthYear = ushort.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your birth month: ");
        byte birthMonth = byte.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your birth day: ");
        byte birthDay = byte.Parse(Console.ReadLine());
        
        DateTime birthdate = new DateTime(birthYear, birthMonth, birthDay);

        TimeSpan difference = today - birthdate;
        Console.WriteLine($"you are {difference.Days} days old ");

        int daysToNextAnniversary = 10000 - (difference.Days % 10000);
        Console.WriteLine($"your 10000 day aniversary is in {daysToNextAnniversary}");
    }

    public void Greetings()
    {
        DateTime today = DateTime.Now;
        if (today.Hour >= 6 && today.Hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (today.Hour >= 12 && today.Hour < 18)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (today.Hour >= 18 && today.Hour < 24)
        {
            Console.WriteLine("Good Evening");
        }
        if (today.Hour >= 0 && today.Hour < 6)
        {
            Console.WriteLine("Good Night");
        }
    }

    public void Counting()
    {
        for (int i = 1; i < 5; i++)
        {
            for (int j = 0; j <= 24; j+=i)
            {
                Console.Write(j);
                if (j + 1 == 25)
                {
                    continue;
                }
                Console.Write(", ");
            }
            Console.WriteLine("");
        }
    }
}