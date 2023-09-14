using System;
using System.Collections.Generic;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess a number between 1 and 10!");

            Random rnd = new Random(); int num = rnd.Next(1, 10);

            int userGuess = Convert.ToInt32(Console.ReadLine());
            int difference = Math.Abs(userGuess - num);

            if (userGuess == num)
            {
                Console.WriteLine("You Guessed Right!");
            }
            else if(userGuess > num)
            {
                Console.WriteLine($"Arrrh... too high... the number was {num}. Try again?");
            }
            else if (userGuess < num)
            {
                Console.WriteLine($"Oh no, it seems you came short, the number was {num}, and you were just {difference} away! Do better next time.");
            }
            else
            {
                Console.WriteLine("Sorry! as a program, i could not understand what you were saying. did it have anything to do with sprinkles?");
            }




    }
    }
}