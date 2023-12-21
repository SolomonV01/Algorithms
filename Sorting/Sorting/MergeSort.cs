using System;
using static System.Console;

namespace Sorting
{
	public class MergeSort
	{
		public MergeSort()
		{
		}

        public void Start()
        {
            MergeNums();
        }

        static void MergeNums()
        {
            int[] numbers = {
            // ... (insert the provided numbers here)
        };

            WriteLine("Original Numbers:");
            PrintNumbers(numbers);

            MergeSorts(numbers);

            WriteLine("\nSorted Numbers:");
            PrintNumbers(numbers);
        }

        static void MergeSorts(int[] arr)
        {
            int n = arr.Length;

            if (n <= 1)
            {
                return;
            }

            int middle = n / 2;

            int[] left = new int[middle];
            int[] right = new int[n - middle];

            Array.Copy(arr, 0, left, 0, middle);
            Array.Copy(arr, middle, right, 0, n - middle);

            MergeSorts(left);
            MergeSorts(right);

            Merge(arr, left, right);
        }

        static void Merge(int[] arr, int[] left, int[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;

            int i = 0, j = 0, k = 0;

            while (i < leftLength && j < rightLength)
            {
                if (left[i] <= right[j])
                {
                    arr[k++] = left[i++];
                }
                else
                {
                    arr[k++] = right[j++];
                }
            }

            while (i < leftLength)
            {
                arr[k++] = left[i++];
            }

            while (j < rightLength)
            {
                arr[k++] = right[j++];
            }
        }

        static void PrintNumbers(int[] arr)
        {
            foreach (int number in arr)
            {
                Write(number + " ");
            }
            WriteLine();
        }
    }
}

