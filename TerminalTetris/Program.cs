using TetrisGameLogic.Classes;

namespace TerminalTetris
{
    internal class Program
    {
        private readonly static TetrisGameDisplay _tetrisGameDisplay = new();
        private readonly static TetrisGame _tetrisGame = new();

        static void Main(string[] args)
        {
            ConsoleKeyInfo input = new('\0', ConsoleKey.None, false, false, false);

            _tetrisGameDisplay.ApplyConsoleSettings();
            _tetrisGame.AreShadowsEnabled = true;
            _tetrisGame.RestartGame();

            Task tetrisGameLoop = Task.Run(TetrisGameLoop);

            while (true)
            {
                while (!Console.KeyAvailable);
                input = Console.ReadKey(true);

                switch (input.Key)
                {
                    case ConsoleKey.Q:
                        Console.WriteLine("Exited the game");
                        return;
                    case ConsoleKey.R:
                        if (tetrisGameLoop.IsCompleted)
                        {
                            _tetrisGame.RestartGame();
                            tetrisGameLoop = Task.Run(TetrisGameLoop);
                        }
                        input = new('\0', ConsoleKey.None, false, false, false);
                        break;
                    case ConsoleKey.D:
                        lock (_tetrisGame)
                        {
                            _tetrisGame.MoveTetrominoRight();
                        }
                        break;
                    case ConsoleKey.S:
                        lock (_tetrisGame)
                        {
                            _tetrisGame.HardDropTetromino();
                        }
                        break;
                    case ConsoleKey.A:
                        lock (_tetrisGame)
                        {
                            _tetrisGame.MoveTetrominoLeft();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        lock (_tetrisGame)
                        {
                            _tetrisGame.RotateTetrominoLeft();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        lock (_tetrisGame)
                        {
                            _tetrisGame.RotateTetrominoRight();
                        }
                        break;
                }
            }
        }

        static void TetrisGameLoop()
        {
            while (true)
            {
                lock (_tetrisGame)
                {
                    _tetrisGame.MoveTetrominoDown();
                    _tetrisGameDisplay.DrawGameBoard(_tetrisGame);

                    if (_tetrisGame.IsGameOver)
                    {
                        Console.WriteLine("Game over, if you want to restart press \"r\"");
                        return;
                    }
                }
                Thread.Sleep(300);
            }
        }
    }
}
