using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__mini_project_Credit_Card_validator
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            int result = 0;
            Console.WriteLine("Enter a Credit Card # ");
            string cardNumber = Console.ReadLine();
            

            result =  sumEvenDigits(ref cardNumber) + sumOddDigits(ref cardNumber);

            if (result % 10 == 0)
            {

                Console.WriteLine($"{cardNumber} is valid");
            }
            else
            {
                Console.WriteLine($"{cardNumber} is not valid");
            }
            
          
        int getDigit(int number)
{

    return number % 10 + (number / 10 % 10);
}
    int sumOddDigits(ref string num)
    {
                cardNumber = num;
                int sum = 0;

        for (int i = cardNumber.Length - 1; i >= 0; i -= 2)
        {

            sum += cardNumber[i] - '0';
        }

        return sum;
    }
    int sumEvenDigits(ref string  num)
    {
                cardNumber = num;
                int sum = 0;

        for (int i = cardNumber.Length - 2; i >= 0; i -= 2)
        {

            sum += getDigit((cardNumber[i] - '0') * 2);
        }

        return sum;
    }
            Console.ReadLine();
}
    }
}
