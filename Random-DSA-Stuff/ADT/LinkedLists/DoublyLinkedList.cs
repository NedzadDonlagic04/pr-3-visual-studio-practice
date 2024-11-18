using Random_DSA_Stuff.ADT.Interfaces;

using System.Collections;

namespace Random_DSA_Stuff.ADT.LinkedLists
{
    internal class DoublyLinkedList<T> : ILinkedList<T>
    {
        #region Fields, constants, methods

        internal DoublyLinkedListNode<T>? Head { get; private set; }

        internal DoublyLinkedListNode<T>? Tail { get; private set; }

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

        public DoublyLinkedList() => (Head, Tail, Size) = (null, null, 0);

        public void AddFirst(T element)
        {
            if (Empty)
            {
                Head = new DoublyLinkedListNode<T>(element, null, null);
                Tail = Head;
            }
            else
            {
                DoublyLinkedListNode<T> newNode = new(element, null, Head);
                Head!.PreviousNode = newNode;
                Head = newNode;
            }

            ++Size;
        }

        public void AddLast(T element)
        {
            if (Empty)
            {
                Head = new DoublyLinkedListNode<T>(element, null, null);
                Tail = Head;
            }
            else
            {
                DoublyLinkedListNode<T> newNode = new(element, Tail, null);
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

            DoublyLinkedListNode<T> nextNode = GetNode(index);
            DoublyLinkedListNode<T> previousNode = nextNode.PreviousNode!;
            DoublyLinkedListNode<T> newNode = new(element, previousNode, nextNode);

            previousNode.NextNode = newNode;
            nextNode.PreviousNode = newNode;

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
            else
            {
                Head.PreviousNode = null;
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

            DoublyLinkedListNode<T> secondToLastNode = Tail!.PreviousNode!;
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

        private DoublyLinkedListNode<T> GetNode(int index)
        {
            ValidateIndex(index);

            return (index < Size / 2)? GetNodeStartingFromHead(index) : GetNodeStartingFromTail(index);
        }

        private DoublyLinkedListNode<T> GetNodeStartingFromHead(int index)
        {
            DoublyLinkedListNode<T> headCopy = Head!;

            for (int i = 0; i < index; ++i)
            {
                headCopy = headCopy!.NextNode!;
            }

            return headCopy;
        }

        private DoublyLinkedListNode<T> GetNodeStartingFromTail(int index)
        {
            DoublyLinkedListNode<T> tailCopy = Tail!;

            for (int i = Size - 1; i > index; --i)
            {
                tailCopy = tailCopy!.PreviousNode!;
            }

            return tailCopy;
        }

        #endregion
    }
}
