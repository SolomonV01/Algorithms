using System;
using static System.Console;

namespace BigO
{
	public class Constants
	{
		public Constants()
		{
		}

        public void PrintAllItemsTwice(int[] items)
        {
            foreach (var item in items)
            {
                WriteLine(item);
            }

            foreach (var item in items)
            {
                WriteLine(item);
            }
        }

        public void PrintFirstItemThenFirstHalfThenSayHi100Times(int[] items)
        {
            WriteLine(items[0]);

            int middleIndex = items.Length / 2;
            int index = 0;

            while (index < middleIndex)
            {
                WriteLine(items[index]);
                index++;
            }

            for (int i = 0; i < 100; i++)
            {
                WriteLine("hi");
            }
        }

        public void PrintAllNumbersThenAllPairSums(int[] numbers)
        {
            WriteLine("these are the numbers:");
            foreach (var number in numbers)
            {
                WriteLine(number);
            }

            WriteLine("and these are their sums:");
            foreach (var firstNumber in numbers)
            {
                foreach (var secondNumber in numbers)
                {
                    WriteLine(firstNumber + secondNumber);
                }
            }
        }
    }
}

