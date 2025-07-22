using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    

class UniqueElements
    {
        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

            Console.WriteLine("Unique elements in the array are:");

            for (int i = 0; i < arr.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }

}

