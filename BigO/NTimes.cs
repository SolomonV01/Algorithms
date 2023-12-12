using System;
using static System.Console;

namespace BigO
{
	public class NTimes
	{
		public NTimes()
		{
		}

        public void SayHiNTimes(int n)
        {
            for (int i = 0; i < n; i++)
            {
                WriteLine("hi");
            }
        }

        public void PrintAllItems(int[] items)
        {
            foreach (var item in items)
            {
                WriteLine(item);
            }
        }

        public void PrintAllItemsTwice(int[] items)
        {
            foreach (var item in items)
            {
                WriteLine(item);
            }

            // Once more, with feeling
            foreach (var item in items)
            {
                WriteLine(item);
            }
        }


    }
}

