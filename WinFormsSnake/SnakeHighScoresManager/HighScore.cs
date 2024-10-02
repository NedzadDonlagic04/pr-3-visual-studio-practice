using System.Text.Json.Serialization;

namespace WinFormsSnake.SnakeHighScoresManager
{
    internal readonly struct HighScore : IComparable
    {
        public int Score { get; }
        public DateTime DateTimeOfScore { get; } = DateTime.Now;

        public HighScore(int score) => Score = score;

        [JsonConstructor]
        public HighScore(int score, DateTime dateTimeOfScore) => (Score, DateTimeOfScore) = (score, dateTimeOfScore);

        public override string ToString() => $"Score: {Score} - DateTime: {DateTimeOfScore}";

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }
            else if (obj is not HighScore)
            {
                throw new ArgumentException("Object is not a HighScore");
            }

            HighScore rhs = (HighScore)obj;
            int scoreCompareRes = Score.CompareTo(rhs.Score);

            if (scoreCompareRes != 0)
            {
                return scoreCompareRes;
            }

            return DateTimeOfScore.CompareTo(rhs.DateTimeOfScore);
        }
    }
}
