using static System.Console;

namespace Sorting;
class Program
{
    static void Main(string[] args)
    {
        //Bubble Sort
        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.Start();

        ReadLine();
        Clear();

        //Insertion Sort
        InsertionSort insertionSort = new InsertionSort();
        insertionSort.Start();

        ReadLine();
        Clear();

        //Heap Sort
        HeapSort heapSort = new HeapSort();
        heapSort.Start();

        ReadLine();
        Clear();

        //Selection Sort
        SelectionSort selectionSort = new SelectionSort();
        selectionSort.Start();

        ReadLine();
        Clear();

        //Quick Sort
        QuickSort quickSort = new QuickSort();
        quickSort.Start();

        ReadLine();
        Clear();

        //Merge Sort
        MergeSort mergeSort = new MergeSort();
        mergeSort.Start();

        ReadLine();
    }
}
