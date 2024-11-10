using WinFormsTicTacToe.Interfaces;

namespace WinFormsTicTacToe.Classes
{
    /// <summary>
    ///     Very basic tic tac toe bot that just
    ///     randomly places a move on the board
    /// </summary>
    internal class EasyTicTacToeBot : ITicTacToeBot
    {
        #region Public methods

        public int GetMoveIndex(TicTacToeBoard ticTacToeBoard)
        {
            Random random = new();
            List<int> validBoardIndexes = new();

            for (int i = 0; i < ticTacToeBoard.TotalSize; ++i)
            {
                if (!ticTacToeBoard.IsSpotTaken(i))
                {
                    validBoardIndexes.Add(i);
                }
            }

            int index = random.Next(0, validBoardIndexes.Count);
            return validBoardIndexes[index];
        }

        #endregion
    }
}
