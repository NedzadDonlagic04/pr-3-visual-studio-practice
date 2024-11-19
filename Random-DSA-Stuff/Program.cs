using Random_DSA_Stuff.ADT.LinkedLists;
using Random_DSA_Stuff.ADT_Tests;

using Random_DSA_Stuff.Algorithms.Sorting;
using Random_DSA_Stuff.Algorithms_Tests;
using Random_DSA_Stuff.Classes;

namespace Random_DSA_Stuff
{
    internal class Program
    {
        private static void Main()
        {
            RunDSATests();
            Console.WriteLine();
            RunSortingAlgorithmTests();
        }

        private static void RunDSATests()
        {
            LinkedListTests<SinglyLinkedList<int>>.RunTests();
            LinkedListTests<DoublyLinkedList<int>>.RunTests();
        }

        private static IList<int> GenerateRandomList(int listSize = 10)
        {
            IList<int> list = new List<int>(10);
            Random random = new();

            for (int i = 0; i < listSize; ++i)
            {
                int num = random.Next(-100, 101);
                list.Add(num);
            }

            return list;
        }

        private static void RunSortingAlgorithmTests()
        {
            var list = GenerateRandomList(10_000);
            bool descending = false;
            bool printList = false;

            if (printList)
            {
                Utils.PrintIEnumerable("Initial list:", list);
            }

            SortingAlgorithmsTests<BubbleSort>.RunTests(new List<int>(list), descending, printList);
            SortingAlgorithmsTests<BubbleSortOptimized>.RunTests(new List<int>(list), descending, printList);
        }
    }
}