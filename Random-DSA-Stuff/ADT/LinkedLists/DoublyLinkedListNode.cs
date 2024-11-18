namespace Random_DSA_Stuff.ADT.LinkedLists
{
    internal class DoublyLinkedListNode<T>
    {
        #region Fields, constants, methods

        internal T Value { get; set; }

        internal DoublyLinkedListNode<T>? PreviousNode { get; set; }
        
        internal DoublyLinkedListNode<T>? NextNode { get; set; }

        #endregion

        #region Internal methods

        internal DoublyLinkedListNode(T value, DoublyLinkedListNode<T>? previousNode, DoublyLinkedListNode<T>? nextNode)
        {
            Value = value;
            PreviousNode = previousNode;
            NextNode = nextNode;
        }

        #endregion

        #region Public methods

        public override string? ToString() => Value?.ToString();

        #endregion
    }
}
