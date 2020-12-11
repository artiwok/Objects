using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class PrimeNumber
    {

        public bool SetPrimeNumberRange(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void PrintPrimeNumberRange()
        {
            Console.Write("Enter a number: ");

            int val = int.Parse(Console.ReadLine());

            if (val < 2)
            {
                Console.WriteLine("Not a prime number!");
            }
            else
            {
                Console.WriteLine("The prime numbers' set is: ");

                for (int i = 0; i < val; i++)
                {
                    if (SetPrimeNumberRange(i))
                    {
                        Console.WriteLine($"\t\t\t\t{i}\n");
                    }
                }
            }
        }
    }
}

