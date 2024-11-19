namespace Random_DSA_Stuff.Classes
{
    internal static class Utils
    {
        #region Internal methods

        internal static void PrintIEnumerable<T>(string message, IEnumerable<T> list)
        {
            Console.WriteLine(message);
            foreach (var num in list)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }

        #endregion
    }
}
