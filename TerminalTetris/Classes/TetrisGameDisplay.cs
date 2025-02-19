using TetrisGameLogic.Classes;

namespace TerminalTetris.Classes
{
    public class TetrisGameDisplay
    {
        #region Fields and properties

        private const int AnimationBgColor = 100;
        private const int TerminalBgColor = 101;
        private const string Block = "  ";

        public bool AreShadowsEnabled { get; set; }

        #endregion

        #region Public methods

        public void DrawGameBoard(TetrisGame tetrisGame)
        {
            AnimateClearedLines(tetrisGame.ClearedLines);

            Console.SetCursorPosition(0, 0);

            PrintScore(tetrisGame.Score, tetrisGame.TotalClearedLines);
            PrintBoard(tetrisGame);
            PrintTetrominoShadow(tetrisGame);
            PrintTetromino(tetrisGame);
        }

        #endregion

        #region Private methods

        private void PrintScore(int score, int linesCleared)
        {
            Console.BackgroundColor = GetColorForBlock(TerminalBgColor);    
            Console.WriteLine($"Score: {score}");
            Console.WriteLine($"Lines cleared: {linesCleared}");
        }

        private void PrintBoard(TetrisGame tetrisGame)
        {
            for (int i = 0; i < TetrisGame.Rows; ++i)
            {
                for (int ii = 0; ii < TetrisGame.Cols; ++ii)
                {
                    Console.BackgroundColor = GetColorForBlock(tetrisGame.Board[i, ii]);
                    Console.Write(Block);
                }
                Console.BackgroundColor = GetColorForBlock(TerminalBgColor);    
                Console.WriteLine();
            }
        }

        private void PrintTetrominoShadow(TetrisGame tetrisGame)
        {
            int x = tetrisGame.ShadowPos.X;
            int y = tetrisGame.ShadowPos.Y;
            Tetromino tetromino = tetrisGame.CurrentTetromino;

            for (int i = y; i < y + tetromino.Size; ++i)
            {
                for (int ii = x; ii < x + tetromino.Size; ++ii)
                {
                    if (AreIndexesInRange(i, ii, tetromino) && tetromino[i - y, ii - x] != 0)
                    {
                        Console.SetCursorPosition(ii * 2, i + 2);
                        //                                  ^ this is here because of the PrintBoard call adding 2 lines
                        Console.BackgroundColor = GetColorForBlock(TerminalBgColor);
                        Console.Write(Block);
                    }
                }
            }

            Console.BackgroundColor = GetColorForBlock(TerminalBgColor);    // Set bg color of terminal
        }

        private void PrintTetromino(TetrisGame tetrisGame)
        { 
            int x = tetrisGame.PlayerPos.X;
            int y = tetrisGame.PlayerPos.Y;
            Tetromino tetromino = tetrisGame.CurrentTetromino;

            for (int i = y; i < y + tetromino.Size; ++i)
            {
                for (int ii = x; ii < x + tetromino.Size; ++ii)
                {
                    if (AreIndexesInRange(i, ii, tetromino) && tetromino[i - y, ii - x] != 0)
                    {
                        Console.SetCursorPosition(ii * 2, i + 2);
                        //                                  ^ this is here because of the PrintBoard call adding 2 lines
                        Console.BackgroundColor = GetColorForBlock(tetromino[i - y, ii - x]);
                        Console.Write(Block);
                    }
                }
            }

            Console.BackgroundColor = GetColorForBlock(TerminalBgColor);    // Set bg color of terminal
        }

        private ConsoleColor GetColorForBlock(int blockId)
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
                AnimationBgColor => ConsoleColor.White,      // Color used when animating cleared lines
                TerminalBgColor => ConsoleColor.Black,       // Coloring the terminal outside game board
                _ => throw new NotImplementedException(),
            };
        }

        private bool AreIndexesInRange(int row, int col, Tetromino tetromino)
        {
            bool isRowValid = row >= 0 && row < TetrisGame.Rows;
            bool isColValid = col >= 0 && col < TetrisGame.Cols;

            return isRowValid && isColValid;
        }

        public void AnimateClearedLines(List<int> clearedLines)
        {
            if (clearedLines.Count == 0)
            {
                return;
            }

            Console.BackgroundColor = GetColorForBlock(AnimationBgColor);

            foreach (int row in clearedLines)
            {
                Console.SetCursorPosition(0, row + 2);
                //                               ^ this is here because of the PrintBoard call adding 2 lines
                Console.Write(new string(' ', TetrisGame.Cols * 2));
            }

            Thread.Sleep(100);

            Console.BackgroundColor = GetColorForBlock(TerminalBgColor);
        }

        #endregion
    }
}
