using TetrisGameLogic.Enums;

namespace TetrisGameLogic.Classes
{
    public class Tetromino
    {
        #region Fields, properties and constants
        
        private int _rotationCounter;

        private byte[,] Shape { get; init; } = null!;
        public TetrominoType Type { get; init; }
        
        public int Size => Shape.GetLength(0);

        #endregion

        #region Public methods

        public Tetromino(TetrominoType type)
        {
            Shape = GetShapeForType(type);
            Type = type;
            _rotationCounter = 0;
        }

        public byte this[int row, int col]
        {
            get => _rotationCounter switch 
            { 
                0 => Shape[row, col],
                1 => Shape[Size - 1 - col, row],
                2 => Shape[Size - 1 - row, Size - 1 - col],
                3 => Shape[col, Size - 1 - row],
                _ => throw new NotImplementedException(),
            };
        }

        public void RotateLeft()
        {
            --_rotationCounter;

            if (_rotationCounter < 0)
            {
                _rotationCounter = 3;
            }
        }

        public void RotateRight()
        {
            ++_rotationCounter;

            if (_rotationCounter > 3)
            {
                _rotationCounter = 0;
            }
        }

        #endregion

        #region Private methods

        private byte[,] GetShapeForType(TetrominoType type)
        {
            return type switch
            {
                TetrominoType.I => new byte[,] 
                { 
                    { 0, 0, 0, 0 }, 
                    { 1, 1, 1, 1 }, 
                    { 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0 } 
                },
                TetrominoType.O => new byte[,]
                { 
                    { 1, 1 }, 
                    { 1, 1 }, 
                },
                TetrominoType.T => new byte[,]
                {
                    { 0, 1, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                },
                TetrominoType.J => new byte[,]
                {
                    { 1, 0, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                },
                TetrominoType.L => new byte[,]
                {
                    { 0, 0, 1 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                },
                TetrominoType.S => new byte[,]
                {
                    { 0, 1, 1 },
                    { 1, 1, 0 },
                    { 0, 0, 0 },
                },
                TetrominoType.Z => new byte[,]
                {
                    { 1, 1, 0 },
                    { 0, 1, 1 },
                    { 0, 0, 0 },
                },
                _ => throw new NotImplementedException(),
            };
        }

        #endregion
    }
}
