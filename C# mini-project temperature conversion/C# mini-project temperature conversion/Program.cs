using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__mini_project_temperature_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
          
            Console.WriteLine("Choose F or C ");
            char Unit = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter temperature to convert to ");
            double Temp = Convert.ToDouble(Console.ReadLine());

            if (Unit == 'C' || Unit == 'c')
            {

                Temp = (Temp - 32) / 1.8;
                Console.WriteLine($"Temperature is {Temp} C");
            }
            else if (Unit == 'F' || Unit == 'f')
            {
                Temp = (1.8 * Temp) + 32.0;
                Console.WriteLine($"Temperature is {Temp} F");
            }
            else
            {
                Console.WriteLine("You didnt enter a valid character!");
            }

            Console.ReadLine();
        }
    }
}
