using WinFormsTicTacToe.Enums;
using WinFormsTicTacToe.Interfaces;

namespace WinFormsTicTacToe.Classes
{
    /// <summary>
    ///     Tic tac toe bot that tries to go through all
    ///     the possible moves and choose the one which
    ///     gives it the highest chance of victory
    /// </summary>
    internal class HardTicTacToeBot : ITicTacToeBot
    {
        #region Public methods

        public int GetMoveIndex(TicTacToeBoard ticTacToeBoard)
        {
            bool isPlayingX = ticTacToeBoard.Symbol == 'X';

            int moveIndex = -1;
            int bestScore = isPlayingX ? int.MinValue : int.MaxValue;
            int oldBestScore = bestScore; 

            for (int i = 0; i < ticTacToeBoard.TotalSize; ++i)
            {
                if (ticTacToeBoard.IsSpotTaken(i))
                {
                    continue;
                }

                ticTacToeBoard.PlaceSymbol(i);

                int score = GetBestMoveRecursive(ticTacToeBoard, !isPlayingX);

                bestScore = isPlayingX ? Math.Max(bestScore, score) : Math.Min(bestScore, score);

                if (oldBestScore != bestScore)
                {
                    oldBestScore = bestScore;
                    moveIndex = i;
                }

                ticTacToeBoard.UndoLastSymbolPlace();
            }

            return moveIndex;
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Searches for the best outcome through the use of 
        ///     recursion and a for loop
        /// </summary>
        /// <param name="ticTacToeBoard"></param>
        /// <param name="isPlayingX"></param>
        /// <param name="depth"></param>
        /// <returns>The best move to make for a given board</returns>
        /// <inheritdoc cref="GetScoreForGameState"/>
        /// <inheritdoc cref="TicTacToeBoard.PlaceSymbol"/>
        /// <inheritdoc cref="TicTacToeBoard.UndoLastSymbolPlace"/>
        private int GetBestMoveRecursive(TicTacToeBoard ticTacToeBoard, bool isPlayingX, int depth = 0)
        {
            TicTacToeGameState gameState = ticTacToeBoard.GameState;
            if (gameState != TicTacToeGameState.GameOngoing)
            {
                return GetScoreForGameState(gameState, depth);
            }

            int bestScore = isPlayingX? int.MinValue : int.MaxValue;

            for (int i = 0; i < ticTacToeBoard.TotalSize; ++i)
            {
                if (ticTacToeBoard.IsSpotTaken(i))
                {
                    continue;
                }

                ticTacToeBoard.PlaceSymbol(i);

                int score = GetBestMoveRecursive(ticTacToeBoard, !isPlayingX, depth + 1);

                bestScore = isPlayingX ? Math.Max(bestScore, score) : Math.Min(bestScore, score);

                ticTacToeBoard.UndoLastSymbolPlace();
            }

            return bestScore;
        }

        /// <summary>
        ///     Gets a score for the current state of the game
        /// </summary>
        /// <param name="gameState"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException">
        ///     Thrown if a given game state is not implemented
        /// </exception>
        private static int GetScoreForGameState(TicTacToeGameState gameState, int depth) => gameState switch
        {
            TicTacToeGameState.PlayerXWon => 10 - depth,
            TicTacToeGameState.PlayerOWon => depth - 10,
            TicTacToeGameState.Tie => 0,
            _ => throw new NotImplementedException($"Game state \"{gameState}\" not implemented")
        };

        #endregion
    }
}
