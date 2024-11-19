using Random_DSA_Stuff.Algorithms.Interfaces;

namespace Random_DSA_Stuff.Algorithms.Sorting
{
    internal class SelectionSort : ISort<int>
    {
        public IList<int> Sort(IList<int> list, bool descending = false)
        {
            bool compare(int a, int b) => descending && a < b || !descending && a > b;

            for (int i = 0; i < list.Count - 1; ++i)
            {
                int swapIndex = i;
                
                for (int ii = i + 1; ii < list.Count; ++ii)
                {
                    if (compare(list[swapIndex], list[ii]))
                    {
                        swapIndex = ii;
                    }
                }

                (list[swapIndex], list[i]) = (list[i], list[swapIndex]);
            }
            
            return list;
        }
    }
}
