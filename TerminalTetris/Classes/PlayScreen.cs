using TerminalTetris.Interfaces;
using TetrisGameLogic.Classes;

namespace TerminalTetris.Classes
{
    public class PlayScreen : Screen
    {
        #region Fields and properties

        private readonly TetrisGameDisplay _tetrisGameDisplay = new();
        private readonly TetrisGame _tetrisGame = new();
        private readonly List<string> _options = new()
        {
            "Play again",
            "Main menu",
        };
        private int _optionIndex = 0;

        #endregion

        #region Public methods

        public void Display()
        {
            ConsoleKeyInfo input;
            ConsoleKeyInfo emptyInput = new('\0', ConsoleKey.None, false, false, false);

            _tetrisGame.RestartGame();

            do
            {
                input = emptyInput;
                if (Console.KeyAvailable)
                {
                    input = Console.ReadKey(true);
                }

                HandleKeyInput(input.Key);
                DrawTetrisBoardLoop();
            } while (input.Key != ConsoleKey.Enter || _optionIndex != _options.Count - 1);
        }

        #endregion

        #region Private methods

        private void HandleKeyInput(ConsoleKey key)
        {
            bool isGameOver = _tetrisGame.IsGameOver;

            switch (key)
            {
                case ConsoleKey.A:
                    _tetrisGame.MoveTetrominoLeft();
                    break;
                case ConsoleKey.S:
                    _tetrisGame.HardDropTetromino();
                    break;
                case ConsoleKey.D:
                    _tetrisGame.MoveTetrominoRight();
                    break;
                case ConsoleKey.T:
                    _tetrisGameDisplay.AreShadowsEnabled = !_tetrisGameDisplay.AreShadowsEnabled;
                    break;
                case ConsoleKey.K:
                    _tetrisGame.RotateTetrominoLeft();
                    break;
                case ConsoleKey.L:
                    _tetrisGame.RotateTetrominoRight();
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.RightArrow:
                    if (isGameOver)
                    {
                        MoveOptionIndex();
                        RefreshText();
                    }
                    break;
                case ConsoleKey.Enter:
                    if (isGameOver && _optionIndex == 0)
                    {
                        Console.Clear();
                        _tetrisGame.RestartGame();
                    }
                    break;
            }
        }

        private void MoveOptionIndex()
            => _optionIndex = (_optionIndex == 0) ? 1 : 0;

        private void DrawTetrisBoardLoop()
        {
            if (_tetrisGame.IsGameOver)
            {
                return;
            }

            _tetrisGame.MoveTetrominoDown();
            _tetrisGameDisplay.DrawGameBoard(_tetrisGame);
            Thread.Sleep(300);

            if (_tetrisGame.IsGameOver)
            {
                Console.Clear();
                RefreshText();
                return;
            }
        }

        private void RefreshText()
        {
            Console.SetCursorPosition(0, 0);

            // https://manytools.org/hacker-tools/ascii-banner/
            Console.WriteLine("██████╗  █████╗ ███╗   ███╗███████╗     ██████╗  ██╗   ██╗███████╗██████╗ ");
            Console.WriteLine("██╔════╝ ██╔══██╗████╗ ████║██╔════╝    ██╔═══██╗██║   ██║██╔════╝██╔══██╗");
            Console.WriteLine("██║  ███╗███████║██╔████╔██║█████╗      ██║   ██║██║   ██║█████╗  ██████╔╝");
            Console.WriteLine("██║   ██║██╔══██║██║╚██╔╝██║██╔══╝      ██║   ██║╚██╗ ██╔╝██╔══╝  ██╔══██╗");
            Console.WriteLine("╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗    ╚██████╔╝ ╚████╔╝ ███████╗██║  ██║");
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝     ╚═════╝   ╚═══╝  ╚══════╝╚═╝  ╚═╝");

            PrintOptions();
        }

        private void PrintOptions()
        {
            char selected;
            string delimiter = new(' ', 4);
            Console.Write("\t\t\t");
            for (int i = 0; i < _options.Count; ++i)
            {
                selected = (i == _optionIndex) ? '>' : '\0';
                Console.Write($"[{selected}] {_options[i]}{delimiter}");
            }
            Console.WriteLine();
        }

        #endregion
    }
}
