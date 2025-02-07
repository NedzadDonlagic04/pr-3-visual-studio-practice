using System;
using System.Drawing;
using TetrisGameLogic.Classes;

namespace TerminalTetris
{
    public class TetrisGameDisplay
    {
        #region Public methods

        public void ApplyConsoleSettings()
        {
            Console.CursorVisible = false;
        }

        public void DrawGameBoard(TetrisGame tetrisGame)
        {
            AnimateClearedLines(tetrisGame.ClearedLines);

            Console.SetCursorPosition(0, 0);

            Point playerPos = tetrisGame.PlayerPos;
            int tetrominoSize = tetrisGame.CurrentTetromino.Size;

            for (int i = 0; i < TetrisGame.Rows; ++i)
            {
                for (int ii = 0; ii < TetrisGame.Cols; ++ii)
                {
                    ConsoleColor bgColor;

                    bool isI_InRange = i >= playerPos.Y && i < playerPos.Y + tetrominoSize;
                    bool isII_InRange = ii >= playerPos.X && ii < playerPos.X + tetrominoSize;

                    if (isI_InRange && isII_InRange && tetrisGame.CurrentTetromino[i - playerPos.Y, ii - playerPos.X] != 0)
                    {
                        bgColor = GetColorForBlock(tetrisGame.CurrentTetromino[i - playerPos.Y, ii - playerPos.X]);
                    }
                    else
                    {
                        bgColor = GetColorForBlock(tetrisGame.Board[i, ii]);
                    }

                    Console.BackgroundColor = bgColor;
                    Console.Write("  ");
                }
                Console.WriteLine();
                Console.BackgroundColor = GetColorForBlock(101);
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
                100 => ConsoleColor.White,      // Color used when animating cleared lines
                101 => ConsoleColor.Black,       // Coloring the terminal outside game board
                _ => throw new NotImplementedException(),
            };
        }

        #endregion

        #region Private methods

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
        }

        #endregion
    }
}
