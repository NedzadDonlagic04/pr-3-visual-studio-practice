using System.Text;

namespace WinFormsSnake.SnakeHighScoresManager
{
    internal class HighScoresManager
    {
        private readonly int _maxHighScores;
        private readonly SortedSet<HighScore> _highScores = new();

        public SortedSet<HighScore> HighScores { get => _highScores; }

        public HighScoresManager(int maxHighScores)
        {
            _maxHighScores = maxHighScores;
        }

        public void AddScore(int score)
        {
            _highScores.Add(new HighScore(score));

            if (_highScores.Count > _maxHighScores)
            {
                _highScores.Remove(_highScores.First());
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();

            foreach (HighScore highScore in _highScores)
            {
                stringBuilder.AppendLine(highScore.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
