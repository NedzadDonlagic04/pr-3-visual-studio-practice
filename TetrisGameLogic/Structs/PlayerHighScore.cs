namespace TetrisGameLogic.Structs
{
    public readonly struct PlayerHighScore
    {
        #region Fields and properties

        public int Score { get; private init; }
        public int LinesCleared { get; private init; }
        public DateTime DateTime { get; private init; }

        #endregion

        #region Public methods

        public PlayerHighScore(int score = 0, int linesCleared = 0, DateTime dateTime = default)
        {
            ValidateParams(score, linesCleared);

            Score = score;
            LinesCleared = linesCleared;
            DateTime = dateTime;
        }

        public static bool operator>(PlayerHighScore lhs, PlayerHighScore rhs)
            => lhs.Score > rhs.Score;

        public static bool operator<(PlayerHighScore lhs, PlayerHighScore rhs)
            => lhs.Score < rhs.Score;

        #endregion

        #region Private methods

        private void ValidateParams(int score, int linesCleared)
        {
            string paramName;

            if (score < 0)
            {
                paramName = nameof(score);
                throw new ArgumentOutOfRangeException(paramName, $"{paramName} cannot be a value less than 0");
            }
            else if (linesCleared < 0)
            {
                paramName = nameof(linesCleared);
                throw new ArgumentOutOfRangeException(paramName, $"{paramName} cannot be a value less than 0");
            }
        }

        #endregion
    }
}
