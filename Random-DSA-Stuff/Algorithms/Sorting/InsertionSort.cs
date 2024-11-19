using Random_DSA_Stuff.Algorithms.Interfaces;

namespace Random_DSA_Stuff.Algorithms.Sorting
{
    internal class InsertionSort : ISort<int>
    {
        #region Public method

        public IList<int> Sort(IList<int> list, bool descending = false)
        {
            bool compare(int a, int b) => descending && a < b || !descending && a > b;

            for (int i = 1; i < list.Count; ++i)
            {
                for (int ii = i; ii > 0 && compare(list[ii - 1], list[ii]); --ii)
                {
                    (list[ii], list[ii - 1]) = (list[ii - 1], list[ii]);
                }
            }

            return list;
        }

        #endregion
    }
}
