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
            Utils.PrintIEnumerable("AddFirst(2)       Called -> ", linkedList);

            linkedList.AddFirst(4);
            Utils.PrintIEnumerable("AddFirst(4)       Called -> ", linkedList);

            linkedList.AddLast(5);
            Utils.PrintIEnumerable("AddLast(5)        Called -> ", linkedList);

            linkedList.AddLast(7);
            Utils.PrintIEnumerable("AddLast(7)        Called -> ", linkedList);

            linkedList.AddLast(9);
            Utils.PrintIEnumerable("AddLast(9)        Called -> ", linkedList);

            linkedList.InsertAt(1, 1);
            Utils.PrintIEnumerable("InsertAt(1, 1)    Called -> ", linkedList);

            linkedList.InsertAt(3, 0);
            Utils.PrintIEnumerable("InsertAt(3, 0)    Called -> ", linkedList);

            linkedList.InsertAt(0, 5);
            Utils.PrintIEnumerable("InsertAt(0, 5)    Called -> ", linkedList);

            linkedList.RemoveLast();
            Utils.PrintIEnumerable("RemoveLast()      Called -> ", linkedList);

            linkedList.RemoveFirst();
            Utils.PrintIEnumerable("RemoveFirst()     Called -> ", linkedList);

            linkedList.RemoveFirst();
            Utils.PrintIEnumerable("RemoveFirst()     Called -> ", linkedList);

            linkedList.RemoveLast();
            Utils.PrintIEnumerable("RemoveLast()      Called -> ", linkedList);

            Console.WriteLine();
            Console.WriteLine($"{methodName} Method End For {formattedTypeName}");
            Console.WriteLine(Separator);
        }

        #endregion
    }
}
