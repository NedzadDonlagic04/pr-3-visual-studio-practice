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
            int bestScore = int.MinValue;
            int oldBestScore = bestScore; 

            for (int i = 0; i < ticTacToeBoard.TotalSize; ++i)
            {
                if (ticTacToeBoard.IsSpotTaken(i))
                {
                    continue;
                }

                ticTacToeBoard.PlaceSymbol(i);

                int score = GetBestMoveRecursive(ticTacToeBoard, !isPlayingX);

                if (bestScore == int.MinValue)
                {
                    bestScore = score;
                }
                else
                {
                    bestScore = GetBestScoreForGivenPlayer(bestScore, score, isPlayingX);
                }

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
        ///     For the given scores and player returns the best score
        ///     for the given player
        /// </summary>
        /// <param name="score1"></param>
        /// <param name="score2"></param>
        /// <param name="isPlayingX"></param>
        /// <returns>Returns the best score for the player</returns>
        private static int GetBestScoreForGivenPlayer(int score1, int score2, bool isPlayingX)
        {
            /*
             * A bit of an explanation as to what is happening here with
             * the whacky condition.
             * 
             * Let's assume we're playing X
             * If X gets a choice between scores 1 and 3 it wants to take 1 because 
             * that means it's closer to a victory than 3. Because of the way it's
             * calculated (at least as of the time of writing this comment) the 
             * 3 result would mean that the depth to get to it was 3 moves while 
             * 1 would mean it took a single move for victory.
             * 
             * But if it gets scores like -8 and -5 it wants to pick -8 because even
             * if both imply loses for the player X it choosing the longer
             * route would give the opponent a chance to mess up and not achieve
             * victory.
             * 
             * That's why if it's the same sign we want to apply the Math.Min method
             * If the signs are different, like -6 and 5, we want the Math.Max result.
             * 
             * This same logic can be applied to the player O just switch up
             * the signs from the explanation above.
             * 
             * This could have been written in a single line or a bit less than what
             * I ended up sticking with. I didn't do that because it looked uglier than
             * the longer version.
             */
            bool isSameSign = (score1 < 0 && score2 < 0) || (score1 > 0 && score2 > 0);

            if (isPlayingX)
            {
                if (isSameSign)
                {
                    return Math.Min(score1, score2);
                }
                else
                {
                    return Math.Max(score1, score2);
                }
            }

            if (isSameSign)
            {
                return Math.Max(score1, score2);
            }
            else
            {
                return Math.Min(score1, score2);
            }
        }

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
            ++depth;

            TicTacToeGameState gameState = ticTacToeBoard.GameState;
            if (gameState != TicTacToeGameState.GameOngoing)
            {
                return GetScoreForGameState(gameState) * depth;
            }

            int bestScore = int.MinValue;

            for (int i = 0; i < ticTacToeBoard.TotalSize; ++i)
            {
                if (ticTacToeBoard.IsSpotTaken(i))
                {
                    continue;
                }

                ticTacToeBoard.PlaceSymbol(i);

                int score = GetBestMoveRecursive(ticTacToeBoard, !isPlayingX, depth + 1);

                if (bestScore == int.MinValue)
                {
                    bestScore = score;
                }
                else
                {
                    bestScore = GetBestScoreForGivenPlayer(bestScore, score, isPlayingX);
                }

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
        private static int GetScoreForGameState(TicTacToeGameState gameState) => gameState switch
        {
            TicTacToeGameState.PlayerXWon => 1,
            TicTacToeGameState.PlayerOWon => -1,
            TicTacToeGameState.Tie => 0,
            _ => throw new NotImplementedException($"Game state \"{gameState}\" not implemented")
        };

        #endregion
    }
}
