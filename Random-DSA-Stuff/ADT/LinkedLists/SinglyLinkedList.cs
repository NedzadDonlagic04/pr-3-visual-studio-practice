using Random_DSA_Stuff.ADT.Interfaces;

using System.Collections;

namespace Random_DSA_Stuff.ADT.LinkedLists
{
    internal class SinglyLinkedList<T> : ILinkedList<T>
    {
        #region Fields, constants, methods

        internal SinglyLinkedListNode<T>? Head { get; private set; }

        internal SinglyLinkedListNode<T>? Tail { get; private set; }

        internal int Size { get; private set; }

        internal bool Empty { get => Size == 0; }

        #endregion

        #region Internal methods

        internal void Clear()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        #endregion

        #region Public methods

        public SinglyLinkedList() => (Head, Tail, Size) = (null, null, 0);

        public void AddFirst(T element)
        {
            if (Empty)
            {
                Head = new SinglyLinkedListNode<T>(element, null);
                Tail = Head;
            }
            else
            {
                SinglyLinkedListNode<T> newNode = new(element, Head);
                Head = newNode;
            }

            ++Size;
        }

        public void AddLast(T element)
        {
            if (Empty)
            {
                Head = new SinglyLinkedListNode<T>(element, null);
                Tail = Head;
            }
            else
            {
                SinglyLinkedListNode<T> newNode = new(element, null);
                Tail!.NextNode = newNode;
                Tail = newNode;
            }

            ++Size;
        }

        public void InsertAt(T element, int index)
        {
            ValidateIndex(index);

            if (index == 0)
            {
                AddFirst(element);
                return;
            }
            else if (index == Size - 1)
            {
                AddLast(element);
                return;
            }

            SinglyLinkedListNode<T> previousNode = GetNode(index - 1);
            SinglyLinkedListNode<T> newNode = new(element, previousNode.NextNode);

            previousNode.NextNode = newNode;

            ++Size;
        }

        public void RemoveFirst()
        {
            if (Empty)
            {
                throw new InvalidOperationException("Cannot remove an element from an empty list");
            }

            Head = Head?.NextNode;

            if (Head == null)
            {
                Tail = null;
            }

            --Size;
        }

        public void RemoveLast()
        {
            if (Empty)
            {
                throw new InvalidOperationException("Cannot remove an element from an empty list");
            }
            else if (Size == 1)
            {
                Clear();
                return;
            }

            SinglyLinkedListNode<T> secondToLastNode = GetNode(Size - 2);
            secondToLastNode.NextNode = null;
            Tail = secondToLastNode;

            --Size;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var node = Head; node != null; node = node.NextNode)
            {
                yield return node.Value;
            }
        }

        #endregion

        #region Private methods

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= Size)
            {
                throw new ArgumentOutOfRangeException($"Index {index} is outside the valid range [0, {Size})");
            }
        }

        private SinglyLinkedListNode<T> GetNode(int index)
        {
            ValidateIndex(index);

            SinglyLinkedListNode<T> headCopy = Head!;

            for (int i = 0; i < index; ++i)
            {
                headCopy = headCopy!.NextNode!;
            }

            return headCopy;
        }

        #endregion
    }
}
