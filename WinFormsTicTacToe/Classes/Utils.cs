namespace WinFormsTicTacToe.Classes
{
    /// <summary>
    ///     Class that provides a set of utility methods
    /// </summary>
    internal static class Utils
    {
        #region Internal methods    

        /// <summary>
        ///     Returns a List<int> representing the range
        /// </summary>
        /// <param name="start">Start of the range</param>
        /// <param name="count">Range elements count</param>
        /// <param name="step">The step between each elements</param>
        /// <returns>A list of elements representing the range</returns>
        internal static List<int> Range(int start, int count, int step)
        {
            List<int> range = new(count);

            for (int i = 0; i < count; ++i, start += step)
            {
                range.Add(start);
            }

            return range;
        }

        #endregion
    }
}
