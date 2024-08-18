using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__mini_project_Password_Conformation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Password: ");
            string password = Console.ReadLine();




            Console.WriteLine("Enter your Password again: ");
            string passwordC = Console.ReadLine();


            if (!password.Equals(string.Empty))
            {
                if (!passwordC.Equals(string.Empty))
                {
                    if (password.Length >= 6 && passwordC.Length >= 6)
                    {
                        if (password.Equals(passwordC))
                        {
                            Console.WriteLine("Passwords match");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                        }

                    } else
                    {
                        Console.WriteLine("Please enter 6 or more characters");
                    }
                       
                    } else
                    {
                        Console.WriteLine("Please enter a password confirmation");
                    }
            } else
            {
                Console.WriteLine("Please enter a password");
            }

                            Console.ReadLine();
        }
    }
}
