using System;
using static System.Console;

namespace BigO
{
	public class NewNTimes
	{
		public NewNTimes()
		{
		}

        public void SayHiNTimes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                WriteLine("hi");
            }
        }

        public string[] ArrayOfHiNTimes(int n)
        {
            string[] hiArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                hiArray[i] = "hi";
            }
            return hiArray;
        }

        public int GetLargestItem(int[] items)
        {
            int largest = int.MinValue;
            foreach (int item in items)
            {
                if (item > largest)
                {
                    largest = item;
                }
            }
            return largest;
        }
    }
}

