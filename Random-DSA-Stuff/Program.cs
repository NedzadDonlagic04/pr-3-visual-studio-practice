using Random_DSA_Stuff.ADT.LinkedLists;
using Random_DSA_Stuff.ADT_Tests;

namespace Random_DSA_Stuff
{
    internal class Program
    {

        static void Main()
        {
            LinkedListTests<SinglyLinkedList<int>>.RunTests();
            LinkedListTests<DoublyLinkedList<int>>.RunTests();
        }
    }
}