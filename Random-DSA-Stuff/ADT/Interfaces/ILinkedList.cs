namespace Random_DSA_Stuff.ADT.Interfaces
{
    internal interface ILinkedList<T> : IEnumerable<T>
    {
        void AddFirst(T element);

        void AddLast(T element);

        void InsertAt(T element, int index);

        void RemoveFirst();

        void RemoveLast();
    }
}
