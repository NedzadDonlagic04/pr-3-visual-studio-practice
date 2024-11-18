namespace Random_DSA_Stuff.ADT.LinkedLists
{
    internal class SinglyLinkedListNode<T>
    {
        #region Fields, constants, methods

        internal T Value { get; set; }

        internal SinglyLinkedListNode<T>? NextNode { get; set; }

        #endregion

        #region Internal methods

        internal SinglyLinkedListNode(T value, SinglyLinkedListNode<T>? nextNode)
        {
            Value = value;
            NextNode = nextNode;
        }

        #endregion

        #region Public methods

        public override string? ToString() => Value?.ToString();

        #endregion
    }
}
