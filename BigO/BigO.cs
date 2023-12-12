using System;
using static System.Console;

namespace BigO
{
	public class BigO
	{
		public BigO()
		{
		}

		public void PrintFirstItem(int[] items)
		{
			WriteLine(items[0]);
		}

        public void PrintAllItems(int[] items)
        {
            foreach (var item in items)
            {
                WriteLine(item);
            }
        }

        public void PrintAllPossibleOrderedPairs(int[] items)
        {
            foreach (var firstItem in items)
            {
                foreach (var secondItem in items)
                {
                    WriteLine($"{firstItem}, {secondItem}");
                }
            }
        }
    }
}

