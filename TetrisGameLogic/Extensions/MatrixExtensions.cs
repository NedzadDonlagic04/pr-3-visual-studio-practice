namespace TetrisGameLogic.Extensions
{
    public static class MatrixExtensions
    {
        #region Public methods

        public static MatrixType[,] FillWith<MatrixType>(this MatrixType[,] matrix, MatrixType value)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int ii = 0; ii < matrix.GetLength(1); ++ii)
                {
                    matrix[i, ii] = value;
                }
            }

            return matrix;
        }

        #endregion
    }
}
