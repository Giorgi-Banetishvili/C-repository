using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__mini_project_random_number_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rnd.Next(100));
            }


            Console.ReadLine();
        }
    }
}
