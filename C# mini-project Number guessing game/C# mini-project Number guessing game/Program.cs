using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__mini_project_Number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int returnValue = random.Next(1, 100);

            int Guess = 0;

            Console.WriteLine("Guess the number from 1-100 ");

            while (Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess < returnValue)
                {
                    Console.WriteLine("No, the number is higher than " + Guess + ". Can you guess what it is?");
                }
                else if (Guess > returnValue)
                {
                    Console.WriteLine("No, the number I is lower than " + Guess + ". Can you guess what it is?");
                }

            }

            Console.WriteLine("Well done! The answer was " + returnValue);
            Console.ReadLine();





        }
    }
}
