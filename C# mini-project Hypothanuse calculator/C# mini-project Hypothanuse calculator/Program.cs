using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__mini_project_Hypothanuse_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
          
          


            Console.WriteLine("Enter side a: ");
             double a =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));


            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
