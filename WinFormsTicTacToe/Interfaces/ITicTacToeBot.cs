using WinFormsTicTacToe.Classes;

namespace WinFormsTicTacToe.Interfaces
{
    /// <summary>
    ///     Defines a way for TicTacToe bots to generate moves
    /// </summary>
    internal interface ITicTacToeBot
    {
        /// <summary>
        ///     Gets the index for the move to make
        ///     on the board
        /// </summary>
        /// <param name="ticTacToeBoard">Board on which the move will be made</param>
        /// <returns>Index which should be placed on the board</returns>
        int GetMoveIndex(TicTacToeBoard ticTacToeBoard);
    }
}
