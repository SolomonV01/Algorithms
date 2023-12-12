using System;
using System.Linq;
using static System.Console;

namespace Shuffle;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 50, 88, 36, 20, 99 };
        ShuffleArray(array);

        WriteLine("Shuffled Array:");
        foreach(int num in array)
        {
            Write(num + " ");   
        }
    }

    static void ShuffleArray(int[] intArray)
    {
        Random rnd = new Random();
        int n = intArray.Length;

        for(int i = n - 1; i > 0; i--)
        {
            int r = rnd.Next(0, i + 1);

            int swap = intArray[i];
            intArray[i] = intArray[r];
            intArray[r] = swap;
        }
    }
}

