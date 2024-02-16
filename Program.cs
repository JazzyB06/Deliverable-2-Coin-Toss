using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace HeadsTails
{
    class Program
    {

        static void Main(string[] args)
        {
            info();
            Random();
        }
        static void info()
        {
            Console.WriteLine("Welcome the COIN FLIP CHALLENGE!");
            Console.WriteLine();
            Console.WriteLine("My program will flip a coin for you and then you will try to guess which side the coin lands on. You will have 10 tries.");
            Console.WriteLine();
            Console.WriteLine("If you guess correctly 6 or more times, you're a winner.");
            Console.WriteLine("If you guess correctly 5 times, you're allowed to play again.");
            Console.WriteLine("If you guess correctly less than 5 times, you lose the game.");
            Console.WriteLine();
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome," + userName + "!");
            Console.WriteLine("Do you want to do the COIN FLIP CHALLENGE? Yes/No");
            String answer = Console.ReadLine();
            if (answer.Equals("Yes"))
            {
                Console.WriteLine("Let's begin the challenge!");
            }
            else if (answer.Equals("No"))
            {
                Console.WriteLine("You're a coward," + userName + "!");
                Console.WriteLine("Press Enter to exit...");
                Console.ReadKey();
                
            }
                Console.ReadLine();
           
        }

        static void Random()
        {
           
            int rand;
            int choice;
            int success = 0;
            Random randoms = new Random();
            for (int i = 1; i <=10; i ++)
            {
                rand = randoms.Next(0, 2);

                Console.WriteLine("Rand is " + rand + " and you are in section " + i + " of the loop.");
                Console.WriteLine("0 is for Tails and 1 is for Heads");
                Console.WriteLine("Please guess Heads or Tails by selecting 0 for Tails and 1 for Heads!");
                choice = int.Parse(Console.ReadLine());

                if (rand == choice)
                {
                    Console.WriteLine("Great job "  + "!!!");
                    success = success + 1;
                }
                else
                {
                    Console.WriteLine("Better luck next time " +  "!!!");
                }
            }
            if (success >= 6)
            {
                Console.WriteLine("Awesome " +  ", you won! You had " + success + " successes.");
                Console.ReadLine();
            }
            if (success == 5)
            {
                Console.WriteLine("Oh no!!! " +  ", let's play again!");
                Console.ReadLine();
                Random();
            }
            if (success < 5)
            {
                Console.WriteLine("OMG!!! "  + ", you lose!");
                Console.ReadLine();
            }
        }
    }
}

