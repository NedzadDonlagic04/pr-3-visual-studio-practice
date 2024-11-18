using Random_DSA_Stuff.ADT.Interfaces;
using Random_DSA_Stuff.Extensions;

namespace Random_DSA_Stuff.ADT_Tests
{
    internal static class LinkedListTests<LinkedListType> 
    where LinkedListType : ILinkedList<int>, new()
    {
        #region Fields, properties, constants

        private const string Separator = "--------------------------";

        #endregion

        #region Internal methods

        internal static void RunTests()
        {
            CallingAllMethodsRandomlyTest();
        }

        #endregion

        #region Private methods

        private static void PrintList(string message, LinkedListType linkedList)
        {
            Console.Write(message);
            foreach (var value in linkedList)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine();
        }

        private static void CallingAllMethodsRandomlyTest()
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name ?? "";
            string formattedTypeName = typeof(LinkedListType).GetFormattedName();

            Console.WriteLine(Separator);
            Console.WriteLine($"{methodName} Method Start For {formattedTypeName}");
            Console.WriteLine();

            LinkedListType linkedList = new();
            Console.WriteLine("Initial list is empty");

            linkedList.AddFirst(2);
            PrintList("AddFirst(2)       Called -> ", linkedList);

            linkedList.AddFirst(4);
            PrintList("AddFirst(4)       Called -> ", linkedList);

            linkedList.AddLast(5);
            PrintList("AddLast(5)        Called -> ", linkedList);

            linkedList.AddLast(7);
            PrintList("AddLast(7)        Called -> ", linkedList);

            linkedList.AddLast(9);
            PrintList("AddLast(9)        Called -> ", linkedList);

            linkedList.InsertAt(1, 1);
            PrintList("InsertAt(1, 1)    Called -> ", linkedList);

            linkedList.InsertAt(3, 0);
            PrintList("InsertAt(3, 0)    Called -> ", linkedList);

            linkedList.InsertAt(0, 5);
            PrintList("InsertAt(0, 5)    Called -> ", linkedList);

            linkedList.RemoveLast();
            PrintList("RemoveLast()      Called -> ", linkedList);

            linkedList.RemoveFirst();
            PrintList("RemoveFirst()     Called -> ", linkedList);

            linkedList.RemoveFirst();
            PrintList("RemoveFirst()     Called -> ", linkedList);

            linkedList.RemoveLast();
            PrintList("RemoveLast()      Called -> ", linkedList);

            Console.WriteLine();
            Console.WriteLine($"{methodName} Method End For {formattedTypeName}");
            Console.WriteLine(Separator);
        }

        #endregion
    }
}
