using System.Drawing;
using TetrisGameLogic.Classes;

namespace TerminalTetris
{
    public class TetrisGameDisplay
    {
        #region Fields and properties

        private int _score;
        private int _linesCleared;
        private int _highScore;
        private int _highLinesCleared;

        public bool AreShadowsEnabled { get; set; }

        #endregion

        #region Public methods

        public TetrisGameDisplay()
        {
            (_highScore, _highLinesCleared) = GetHighScoreAndLinesCleared();
        }

        public void ApplyConsoleSettings()
        {
            Console.CursorVisible = false;
        }

        public void DrawGameBoard(TetrisGame tetrisGame)
        {
            AnimateClearedLines(tetrisGame.ClearedLines);

            Console.SetCursorPosition(0, 0);

            Point playerPos = tetrisGame.PlayerPos;
            Point shadowPos = tetrisGame.ShadowPos;

            for (int i = 0; i < TetrisGame.Rows; ++i)
            {
                for (int ii = 0; ii < TetrisGame.Cols; ++ii)
                {
                    ConsoleColor bgColor;

                    if (IsValidTetrominoBlock(i, ii, playerPos, tetrisGame.CurrentTetromino))
                    {
                        bgColor = GetColorForBlock(tetrisGame.CurrentTetromino[i - playerPos.Y, ii - playerPos.X]);
                    }
                    else if (AreShadowsEnabled && IsValidTetrominoBlock(i, ii, shadowPos, tetrisGame.CurrentTetromino))
                    {
                        bgColor = GetColorForBlock(8); // Set shadow bg color
                    }
                    else
                    {
                        bgColor = GetColorForBlock(tetrisGame.Board[i, ii]);
                    }

                    Console.BackgroundColor = bgColor;
                    Console.Write("  ");
                }
                Console.BackgroundColor = GetColorForBlock(101);    // Set bg color of terminal
                Console.WriteLine();
            }
        }

        public ConsoleColor GetColorForBlock(int blockId)
        {
            return blockId switch
            { 
                0 => ConsoleColor.DarkGray,
                1 => ConsoleColor.Red,
                2 => ConsoleColor.DarkYellow,
                3 => ConsoleColor.Green,
                4 => ConsoleColor.Blue,
                5 => ConsoleColor.Cyan,
                6 => ConsoleColor.DarkMagenta,
                7 => ConsoleColor.DarkBlue,
                8 => ConsoleColor.Black,
                100 => ConsoleColor.White,      // Color used when animating cleared lines
                101 => ConsoleColor.Black,       // Coloring the terminal outside game board
                _ => throw new NotImplementedException(),
            };
        }

        public void UpdateHighScoreAndLinesCleared()
        {

        }

        #endregion

        #region Private methods

        private bool IsValidTetrominoBlock(int row, int col, Point pos, Tetromino tetromino)
        {
            int size = tetromino.Size;
            bool isRowInRange = row >= pos.Y && row < pos.Y + size;
            bool isColInRange = col >= pos.X && col < pos.X + size;

            return isRowInRange && isColInRange && tetromino[row - pos.Y, col - pos.X] != 0;
        }

        private void AnimateClearedLines(List<int> clearedLines)
        {
            if (clearedLines.Count == 0)
            {
                return;
            }

            Console.BackgroundColor = GetColorForBlock(100);

            foreach (int row in clearedLines)
            {
                Console.SetCursorPosition(0, row);
                Console.Write(new string(' ', TetrisGame.Cols * 2));
            }

            Thread.Sleep(100);

            Console.BackgroundColor = GetColorForBlock(101);

            UpdateScore(clearedLines.Count);
        }

        private void UpdateScore(int linesCleared)
        {
            _linesCleared += linesCleared;
            _score += GetScoreForLinesCleared(linesCleared);
        }

        private int GetScoreForLinesCleared(int linesCleared)
        {
            return linesCleared switch
            {
                1 => 100,
                2 => 200,
                3 => 400,
                4 => 800,
                _ => throw new NotImplementedException($"No score for {linesCleared} lines cleared")
            };
        }

        private (int, int) GetHighScoreAndLinesCleared()
        {
            return (5, 5);
        }

        #endregion
    }
}
