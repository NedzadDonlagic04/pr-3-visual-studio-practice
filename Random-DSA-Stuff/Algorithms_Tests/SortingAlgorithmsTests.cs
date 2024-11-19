using Random_DSA_Stuff.Algorithms.Interfaces;

using Random_DSA_Stuff.Classes;
using Random_DSA_Stuff.Extensions;

using System.Diagnostics;

namespace Random_DSA_Stuff.Algorithms_Tests
{
    internal static class SortingAlgorithmsTests<SortingType>
    where SortingType : ISort<int>, new()
    {
        #region Fields, properties, constants

        private const string Separator = "--------------------------";

        #endregion

        #region Internal methods

        internal static void RunTests(IList<int> list, bool descending = false, bool printList = false)
        {
            TestSort(list, descending, printList);
        }

        #endregion

        #region Private methods

        private static void TestSort(IList<int> list, bool descending, bool printList)
        {
            string formattedTypeName = typeof(SortingType).GetFormattedName();

            Console.WriteLine(Separator);

            Stopwatch stopwatch = new();
            SortingType sort = new();

            stopwatch.Start();
            var sortedList = sort.Sort(list, descending);
            stopwatch.Stop();

            string descOrAscStr = descending ? "descending" : "ascending";
            if (printList)
            {
                Utils.PrintIEnumerable($"List after {formattedTypeName} sorting {descOrAscStr}:", sortedList);
            }

            Console.WriteLine($"{formattedTypeName} took {stopwatch.ElapsedMilliseconds}ms to sort {descOrAscStr}");
            Console.WriteLine(Separator);
        }

        #endregion
    }
}
