using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPrimeNum
{
   class CheckForPrime
    {
        public int reverseNum(int target)
        {
            int remainder;
            int reversed = 0;

            while(target != 0)
            {
                remainder = target % 10;
                reversed = reversed * 10 + remainder;
                target /= 10; //Breaking out of while loop
            }
            int i = 1;
            int[] reverseArr = new int[1];
            reverseArr[i] = reversed;
            i++;
            return reversed;
        }

        public void CheckIfPrime(int target)
        {
            int flag = 0;
            for(int i =2; i < (target / 2); i++)
            {
                if(target % i == 0)
                {
                    Console.WriteLine(target + " is not a prime number.");
                    Console.WriteLine();

                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine(target + " is a prime number.");
                Console.WriteLine("Commencing reversal now....");
                int newTarget = reverseNum(target);
                Console.WriteLine("Reversed number is: " + newTarget);
                Console.WriteLine(newTarget + " is stored.");
                
                Console.WriteLine();
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            CheckForPrime primeCheck = new CheckForPrime();
            Random rand = new Random();
            int target = rand.Next(1, 100);

            primeCheck.CheckIfPrime(target);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
