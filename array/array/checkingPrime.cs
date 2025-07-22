using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    
    

class PrimeInArray
    {
        static void Main()
        {
            int[] arr = { 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Console.WriteLine("Prime numbers in the array are:");

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        // Simple function to check for prime
        static bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }

}

