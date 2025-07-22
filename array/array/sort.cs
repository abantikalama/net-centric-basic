using System;

internal class SortExample
{
    static void Main()
    {
        int[] x = { 4, 2, 1, 3 };

        Array.Sort(x); // Sort the entire array in-place

        foreach (int i in x)
        {
            Console.WriteLine(i);
        }
    }
}
