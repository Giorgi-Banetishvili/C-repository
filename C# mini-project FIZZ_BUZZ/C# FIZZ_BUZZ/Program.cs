﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__FIZZ_BUZZ
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }









            

                Console.ReadLine();
            }
        }
    }

