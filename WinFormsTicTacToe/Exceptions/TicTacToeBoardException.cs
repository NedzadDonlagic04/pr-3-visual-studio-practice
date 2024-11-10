namespace WinFormsTicTacToe.Exceptions
{
    /// <summary>
    ///     Represents an error that occured during the
    ///     use of the TicTacToeBoard class
    /// </summary>
    internal class TicTacToeBoardException : Exception
    {
        /// <summary>
        ///     Constructs an instance of TicTacToeBoardException
        /// </summary>
        internal TicTacToeBoardException() { }

        /// <summary>
        ///     Constructs an instance of TicTacToeBoardException with a specified error message
        /// </summary>
        /// <param name="message">Error message</param>
        internal TicTacToeBoardException(string message) : base(message) { }

        /// <summary>
        ///     Constructs an instance of TicTacToeBoardException with a specified error message
        ///     and the reference to the exception that caused this one
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerXxception">Exception that is the cause of this exception</param>
        internal TicTacToeBoardException(string message, Exception innerXxception) : base(message, innerXxception) { }
    }
}