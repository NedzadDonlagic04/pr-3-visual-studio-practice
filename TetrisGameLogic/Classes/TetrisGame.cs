﻿using System.Drawing;
using TetrisGameLogic.Extensions;
using TetrisGameLogic.Structs;

namespace TetrisGameLogic.Classes
{
    public class TetrisGame
    {
        #region Fields, properties and constants

        public const int Rows = 15;
        public const int Cols = 11;
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
        private Point _shadowPos;
        private readonly HighScoreManager _highScoreManager = new();

        public Point PlayerPos { get => _playerPos; }
        public Point ShadowPos { get => _shadowPos; }
        public List<int> ClearedLines { get; init; } = new();
        public short[,] Board { get; init; } = new short[Rows, Cols];
        public bool IsGameOver { get; private set; }
        public int Score { get; private set; }
        public int TotalClearedLines { get; private set; }

        public Tetromino CurrentTetromino => _tetrominos[_currentTetrominoIndex];
        public Tetromino NextTetromino => _tetrominos[_nextTetrominoIndex];

        #endregion

        #region Public methods

        public void RestartGame()
        {
            IsGameOver = false;

            Board.FillWith<short>(0);

            _currentTetrominoIndex = 0;
            _nextTetrominoIndex = 1;

            Score = 0;
            TotalClearedLines = 0;
            ClearedLines.Clear();

            _playerPos = StartingPlayerPos;
            _shadowPos = FindHardDropPlayerPos();
        }

        public void RotateTetrominoLeft()
        {
            CurrentTetromino.RotateLeft();

            if (DoesTetrominoCollide(_playerPos))
            {
                CurrentTetromino.RotateRight();
            }
            else
            {
                _shadowPos = FindHardDropPlayerPos();
            }
        }

        public void RotateTetrominoRight()
        {
            CurrentTetromino.RotateRight();

            if (DoesTetrominoCollide(_playerPos))
            {
                CurrentTetromino.RotateLeft();
            }
            else
            {
                _shadowPos = FindHardDropPlayerPos();
            }
        }

        public void MoveTetrominoLeft()
        {
            --_playerPos.X;

            if (DoesTetrominoCollide(_playerPos))
            { 
                ++_playerPos.X;
            }
            else
            {
                _shadowPos = FindHardDropPlayerPos();
            }
        }

        public void MoveTetrominoRight()
        {
            ++_playerPos.X;

            if (DoesTetrominoCollide(_playerPos))
            {
                --_playerPos.X;
            }
            else
            {
                _shadowPos = FindHardDropPlayerPos();
            }
        }

        public void MoveTetrominoDown()
        {
            ClearedLines.Clear();

            ++_playerPos.Y;

            if (DoesTetrominoCollide(_playerPos))
            {
                --_playerPos.Y;

                LockTetrominoIn();
                MoveToNextTetromino();
            }
        }

        public void HardDropTetromino()
        {
            _playerPos = FindHardDropPlayerPos();
        }

        #endregion

        #region Private methods

        private bool DoesTetrominoCollide(Point pos)
        {
            int size = CurrentTetromino.Size;

            for (int i = 0; i < size; ++i)
            {
                for (int ii = 0; ii < size; ++ii)
                {
                    int x = pos.X + ii;
                    int y = pos.Y + i;
                    bool isBlockOutOfBounds = x < 0 || x >= Cols || y < 0 || y >= Rows;

                    if (CurrentTetromino[i, ii] != 0 && (isBlockOutOfBounds || Board[y, x] != 0))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void LockTetrominoIn()
        {
            DrawTetromino();
            ClearFullRows();
        }

        private void DrawTetromino()
        {
            int size = CurrentTetromino.Size;

            for (int i = 0; i < size; ++i)
            {
                for (int ii = 0; ii < size; ++ii)
                {
                    int x = _playerPos.X + ii;
                    int y = _playerPos.Y + i;
                    bool isBlockInBounds = x >= 0 && x < Cols && y >= 0 && y < Rows;

                    if (isBlockInBounds && CurrentTetromino[i, ii] != 0)
                    {
                        Board[y, x] = CurrentTetromino[i, ii];
                    }
                }
            }
        }

        private void ClearFullRows()
        {
            int clearedLines = 0;

            for (int i = Rows - 1; i >= 0; --i)
            {
                if (IsRowFull(i))
                {
                    // Fills row with 0s
                    for (int ii = 0; ii < Cols; ++ii)
                    {
                        Board[i, ii] = 0;
                    }
                    ++clearedLines;
                    ClearedLines.Add(i);
                }
                else if (clearedLines > 0)
                {
                    // Moves the not full row down with the help of the clearedLines counter
                    for (int ii = 0; ii < Cols; ++ii)
                    {
                        Board[i + clearedLines, ii] = Board[i, ii];
                        Board[i, ii] = 0;
                    }
                }
            }

            if (clearedLines != 0)
            {
                UpdateScore(clearedLines);
            }
        }

        private bool IsRowFull(int row)
        {
            for (int i = 0; i < Cols; ++i)
            {
                if (Board[row, i] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private Point FindHardDropPlayerPos()
        {
            Point temp = _playerPos;

            while (!DoesTetrominoCollide(temp) && temp.Y < Rows - 1)
            {
                ++temp.Y;
            }

            --temp.Y;

            return temp;
        }

        private void MoveToNextTetromino()
        {
            _playerPos = StartingPlayerPos;

            CurrentTetromino.ResetRotation();

            _currentTetrominoIndex = _nextTetrominoIndex;
            _nextTetrominoIndex = (_nextTetrominoIndex + 1) % _tetrominos.Count;

            _shadowPos = FindHardDropPlayerPos();

            if (DoesTetrominoCollide(_playerPos))
            {
                IsGameOver = true;
                PlayerHighScore playerHighScore = new(Score, TotalClearedLines, DateTime.Now);
                _highScoreManager.AddScore(playerHighScore);
            }
        }

        private void UpdateScore(int linesCleared)
        {
            TotalClearedLines += linesCleared;
            Score += GetScoreForLinesCleared(linesCleared);
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

        #endregion
    }
}
