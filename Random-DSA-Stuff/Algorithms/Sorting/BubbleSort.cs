using Random_DSA_Stuff.Algorithms.Interfaces;

namespace Random_DSA_Stuff.Algorithms.Sorting
{
    internal class BubbleSort : ISort<int>
    {
        #region Public methods

        public IList<int> Sort(IList<int> list, bool descending = false)
        {
            bool compare(int a, int b) => descending && a < b || !descending && a > b;

            for (int i = 0; i < list.Count - 1; ++i)
            {
                for (int ii = 0; ii < list.Count - 1 - i; ++ii)
                {
                    if (compare(list[ii], list[ii + 1]))
                    {
                        (list[ii], list[ii + 1]) = (list[ii + 1], list[ii]);
                    }
                }
            }

            return list;
        }

        #endregion
    }
}
