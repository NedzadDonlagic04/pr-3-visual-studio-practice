namespace TetrisGameLogic.Classes
{
    public class TetrisGame
    {
        #region Fields, properties and constants

        private int _currentTetrominoIndex;
        private int _nextTetrominoIndex;

        private List<Tetromino> Tetrominos = new()
        {
            new Tetromino(Enums.TetrominoType.I),
            new Tetromino(Enums.TetrominoType.O),
            new Tetromino(Enums.TetrominoType.T),
            new Tetromino(Enums.TetrominoType.J),
            new Tetromino(Enums.TetrominoType.L),
            new Tetromino(Enums.TetrominoType.S),
            new Tetromino(Enums.TetrominoType.Z),
        };

        public Tetromino CurrentTetromino => Tetrominos[_currentTetrominoIndex];
        public Tetromino NextTetromino => Tetrominos[_nextTetrominoIndex];

        #endregion

        #region Public methods

        #endregion

        #region Private methods

        private void MoveToNextTetromino()
        {
            _currentTetrominoIndex = _nextTetrominoIndex;
            _nextTetrominoIndex = (_nextTetrominoIndex + 1) % Tetrominos.Count;
        }

        #endregion
    }
}
