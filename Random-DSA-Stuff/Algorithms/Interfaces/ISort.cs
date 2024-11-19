namespace Random_DSA_Stuff.Algorithms.Interfaces
{
    internal interface ISort<T>
    {
        IList<T> Sort(IList<T> list, bool descending = false);
    }
}
