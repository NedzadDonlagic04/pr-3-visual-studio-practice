namespace CharMatrixExtensions
{
    public static class CharMatrixExtensions
    {
        public static char[,] Fill(this char[,] matrix, char value) {
            for (int i = 0; i < matrix.GetLength(0); ++i) {
                for (int ii = 0; ii < matrix.GetLength(1); ++ii) {
                    matrix[i, ii] = value;
                }
            }

            return matrix;
        }
    }
}
