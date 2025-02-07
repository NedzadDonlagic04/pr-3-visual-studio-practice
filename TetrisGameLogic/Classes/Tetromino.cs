using TetrisGameLogic.Enums;

namespace TetrisGameLogic.Classes
{
    public class Tetromino
    {
        #region Fields, properties and constants
        
        private int _rotationCounter;
        private readonly short _id;

        private short[,] Shape { get; init; } = null!;
        public TetrominoType Type { get; init; }
        
        public int Size => Shape.GetLength(0);

        #endregion

        #region Public methods

        public Tetromino(TetrominoType type, short id)
        {
            Shape = GetShapeForType(type);
            Type = type;
            _rotationCounter = 0;
            _id = id;
        }

        public short this[int row, int col]
        {
            get => _rotationCounter switch 
            { 
                0 => Shape[row, col] == 1? _id : (short)0,
                1 => Shape[Size - 1 - col, row] == 1? _id : (short)0,
                2 => Shape[Size - 1 - row, Size - 1 - col] == 1? _id : (short)0,
                3 => Shape[col, Size - 1 - row] == 1? _id : (short)0,
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

        private short[,] GetShapeForType(TetrominoType type)
        {
            return type switch
            {
                TetrominoType.I => new short[,] 
                { 
                    { 0, 0, 0, 0 }, 
                    { 1, 1, 1, 1 }, 
                    { 0, 0, 0, 0 }, 
                    { 0, 0, 0, 0 } 
                },
                TetrominoType.O => new short[,]
                { 
                    { 1, 1 }, 
                    { 1, 1 }, 
                },
                TetrominoType.T => new short[,]
                {
                    { 0, 1, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                },
                TetrominoType.J => new short[,]
                {
                    { 1, 0, 0 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                },
                TetrominoType.L => new short[,]
                {
                    { 0, 0, 1 },
                    { 1, 1, 1 },
                    { 0, 0, 0 },
                },
                TetrominoType.S => new short[,]
                {
                    { 0, 1, 1 },
                    { 1, 1, 0 },
                    { 0, 0, 0 },
                },
                TetrominoType.Z => new short[,]
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
