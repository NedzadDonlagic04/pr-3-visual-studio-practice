using System.Drawing;
using TetrisGameLogic.Extensions;

namespace TetrisGameLogic.Classes
{
    public class TetrisGame
    {
        #region Fields, properties and constants

        private const int Rows = 15;
        private const int Cols = 11;
        private int _currentTetrominoIndex;
        private int _nextTetrominoIndex;
        private readonly List<Tetromino> _tetrominos = new()
        {
            new Tetromino(Enums.TetrominoType.I, 1),
            new Tetromino(Enums.TetrominoType.O, 2),
            new Tetromino(Enums.TetrominoType.T, 3),
            new Tetromino(Enums.TetrominoType.J, 4),
            new Tetromino(Enums.TetrominoType.L, 5),
            new Tetromino(Enums.TetrominoType.S, 6),
            new Tetromino(Enums.TetrominoType.Z, 7),
        };
        private static readonly Point StartingPlayerPos = new(3, 0);
        private Point _playerPos;

        public List<int> ClearedLines { get; init; } = new();
        private short[,] Board { get; init; } = new short[Rows, Cols];
        public bool IsGameOver { get; private set; }

        public Tetromino CurrentTetromino => _tetrominos[_currentTetrominoIndex];
        public Tetromino NextTetromino => _tetrominos[_nextTetrominoIndex];

        #endregion

        #region Public methods

        public void RestartGame()
        {
            Board.FillWith<short>(0);

            _currentTetrominoIndex = 0;
            _nextTetrominoIndex = 1;
            _playerPos = StartingPlayerPos;

            IsGameOver = false;
        }

        public void MoveTetrominoLeft()
        {
            --_playerPos.X;

            if (DoesTetrominoCollide())
            { 
                ++_playerPos.X;
            }
        }

        public void MoveTetrominoRight()
        {
            ++_playerPos.X;

            if (DoesTetrominoCollide())
            {
                --_playerPos.X;
            }
        }

        public void MoveTetrominoDown()
        {
            ++_playerPos.Y;

            if (DoesTetrominoCollide())
            {
                --_playerPos.Y;
                LockTetrominoIn();
                MoveToNextTetromino();
            }
        }

        #endregion

        #region Private methods

        private bool DoesTetrominoCollide()
        {
            return true;
        }

        private void LockTetrominoIn()
        {
            DrawTetromino();
            ClearFullRows();
        }

        private void DrawTetromino()
        {
        
        }

        private void ClearFullRows()
        { 
        
        }

        private void MoveToNextTetromino()
        {
            _playerPos = StartingPlayerPos;
            _currentTetrominoIndex = _nextTetrominoIndex;
            _nextTetrominoIndex = (_nextTetrominoIndex + 1) % _tetrominos.Count;
        }

        #endregion
    }
}
