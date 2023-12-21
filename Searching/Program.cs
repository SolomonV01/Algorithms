using static System.Console;

namespace Searching;

class Program
{
    static void Main(string[] args)
    {
        BinarySearch binarySearch = new BinarySearch();
        binarySearch.Start();

        ReadLine();
        Clear();

        InterpolationSearch interpolationSearch = new InterpolationSearch();
        interpolationSearch.Start();

        ReadLine();
        Clear();

        LinearSearch linearSearch = new LinearSearch();
        linearSearch.Start();

        ReadLine();
    }
}

