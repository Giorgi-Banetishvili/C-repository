using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__mini_project_random_event_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

               
       

            switch ((rnd.Next(5) + 1))
            {
                case 1:
                    Console.WriteLine("You won a mushroom pizaa!");
                    break;
                case 2:
                    Console.WriteLine("You won a washing machine!!!"); ;
                    break;
                case 3:
                    Console.WriteLine("You won a jet!!!!!");
                    break;
                case 4:
                    Console.WriteLine("You won absolutley nothing!!!!!!!!!!");
                    break;
                case 5:
                    Console.WriteLine("You lost 1000$!!!!!!!!!!!!!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
