using System;
using static System.Console;

namespace BigO
{
	public class CodeEx
	{
		public CodeEx()
		{
		}

		//Constant
		//O(1)
		//The array is given 10, but in all cases of the O(1) notation, the algorithm will always execute in the same time regardless of if my input to tests is 0 or 10.
		public void Tester(int[] tests)
		{
			WriteLine(tests[10]);
		}

		//Linear
		//O(n)
		//Within my linear example, n stands for the number of items in the array. My array is blank, just to keep it simple and similar to the examples I tested for our notes as I figure out the differences in efficiency. O(n), right now, will perform the max amount of iterations possible.
		public void TestAll(int[] tests)
		{
			foreach (var test in tests)
			{
				WriteLine(test);
			}
		}

		//Quadratic
        //O(n^2)
		//Here, we have two nested loops, meaning the inner loop runs for each iteration of the outer loop. Each time my firstTest completes an iteration, secondTest runs n times.
        public void OrderPrint (int[] tests)
        {
            foreach (var firstTest in tests)
            {
                foreach (var secondTest in tests)
                {
                    WriteLine($"{firstTest}, {secondTest}");
                }
            }
        }
    }
}

