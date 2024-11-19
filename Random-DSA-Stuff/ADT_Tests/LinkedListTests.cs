using Random_DSA_Stuff.ADT.Interfaces;

using Random_DSA_Stuff.Classes;
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
            AreAllMethodsWorkingProperlyTest();
        }

        #endregion

        #region Private methods

        private static void AreAllMethodsWorkingProperlyTest()
        {
            string methodName = System.Reflection.MethodBase.GetCurrentMethod()?.Name ?? "";
            string formattedTypeName = typeof(LinkedListType).GetFormattedName();

            Console.WriteLine(Separator);
            Console.WriteLine($"{methodName} Method Start For {formattedTypeName}");
            Console.WriteLine();

            LinkedListType linkedList = new();
            Console.WriteLine("Initial list is empty");

            linkedList.AddFirst(2);
            Utils.PrintList("AddFirst(2)       Called -> ", linkedList);

            linkedList.AddFirst(4);
            Utils.PrintList("AddFirst(4)       Called -> ", linkedList);

            linkedList.AddLast(5);
            Utils.PrintList("AddLast(5)        Called -> ", linkedList);

            linkedList.AddLast(7);
            Utils.PrintList("AddLast(7)        Called -> ", linkedList);

            linkedList.AddLast(9);
            Utils.PrintList("AddLast(9)        Called -> ", linkedList);

            linkedList.InsertAt(1, 1);
            Utils.PrintList("InsertAt(1, 1)    Called -> ", linkedList);

            linkedList.InsertAt(3, 0);
            Utils.PrintList("InsertAt(3, 0)    Called -> ", linkedList);

            linkedList.InsertAt(0, 5);
            Utils.PrintList("InsertAt(0, 5)    Called -> ", linkedList);

            linkedList.RemoveLast();
            Utils.PrintList("RemoveLast()      Called -> ", linkedList);

            linkedList.RemoveFirst();
            Utils.PrintList("RemoveFirst()     Called -> ", linkedList);

            linkedList.RemoveFirst();
            Utils.PrintList("RemoveFirst()     Called -> ", linkedList);

            linkedList.RemoveLast();
            Utils.PrintList("RemoveLast()      Called -> ", linkedList);

            Console.WriteLine();
            Console.WriteLine($"{methodName} Method End For {formattedTypeName}");
            Console.WriteLine(Separator);
        }

        #endregion
    }
}
