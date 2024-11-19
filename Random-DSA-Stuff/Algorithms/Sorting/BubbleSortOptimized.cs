using Random_DSA_Stuff.Algorithms.Interfaces;

namespace Random_DSA_Stuff.Algorithms.Sorting
{
    internal class BubbleSortOptimized : ISort<int>
    {
        #region Public methods

        public IList<int> Sort(IList<int> list, bool descending = false)
        {
            bool compare(int a, int b) => descending && a < b || !descending && a > b;

            int size = list.Count;
            bool continueSorting;

            do
            {
                continueSorting = false;
                --size;

                for (int i = 0; i < size; ++i)
                {
                    if (compare(list[i], list[i + 1]))
                    {
                        continueSorting = true;
                        (list[i], list[i + 1]) = (list[i + 1], list[i]);
                    }
                }
            } while (continueSorting);

            return list;
        }

        #endregion
    }
}
