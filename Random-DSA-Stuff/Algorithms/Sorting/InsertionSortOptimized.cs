using Random_DSA_Stuff.Algorithms.Interfaces;

namespace Random_DSA_Stuff.Algorithms.Sorting
{
    internal class InsertionSortOptimized : ISort<int>
    {
        #region Public method

        public IList<int> Sort(IList<int> list, bool descending)
        {
            bool compare(int a, int b) => descending && a < b || !descending && a > b;

            int temp;
            for (int i = 1; i < list.Count; ++i)
            {
                temp = list[i];
                int ii = i;
                while (ii > 0 && compare(list[ii - 1], temp))
                {
                    list[ii] = list[ii - 1];
                    --ii;
                }
                list[ii] = temp;
            }

            return list;
        }

        #endregion
    }
}
