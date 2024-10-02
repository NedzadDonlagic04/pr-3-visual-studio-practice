using System.Text;
using System.Text.Json;

namespace WinFormsSnake.SnakeHighScoresManager
{
    internal class HighScoresManager
    {
        private readonly int _maxHighScores;
        private SortedSet<HighScore> _highScores = new();
        public SortedSet<HighScore> HighScores { get => _highScores; }

        private const string HighScoresJSONPath = "./highScores.json"; 

        public HighScoresManager(int maxHighScores)
        {
            _maxHighScores = maxHighScores;
        }

        private void GenerateRandomHighScores()
        {
            Random random = new();

            for (int i = 0; i < _maxHighScores; i++)
            {
                AddScore(random.Next(0, 100));
            }
        }

        internal void AddScore(int score)
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

        private string GenerateTempFilePath()
        {
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(HighScoresJSONPath);
            var fileExtension = Path.GetExtension(HighScoresJSONPath);

            return $"./{fileNameWithoutExtension}-{Guid.NewGuid()}{fileExtension}";
        }

        private void MoveHighScoresJSONToTempFile()
        {
            var tempFilePath = GenerateTempFilePath();

            try
            {
                File.Move(HighScoresJSONPath, tempFilePath);
                MessageBox.Show("Your high scores have been corrupted, if you wish to recover" + 
                " the corrupted file it's content is now located inside the file " +
                tempFilePath, "High Scores JSON Corrupted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Your high scores have been corrupted and can't be recovered", 
                "High Scores JSON Corrupted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CreateEmptyHighScoreJSONFile();
            }
        }

        private void CreateEmptyHighScoreJSONFile()
        {
            File.WriteAllText(HighScoresJSONPath, "[]");
        }

        internal void LoadHighScoresFromJSON()
        {
            if (!File.Exists(HighScoresJSONPath))
            {
                CreateEmptyHighScoreJSONFile();
                return;
            }

            var highScoresJsonStr = File.ReadAllText(HighScoresJSONPath);

            try
            {
                _highScores = JsonSerializer.Deserialize<SortedSet<HighScore>>(highScoresJsonStr) ?? new();
            }
            catch (JsonException)
            {
                MoveHighScoresJSONToTempFile();
                CreateEmptyHighScoreJSONFile();
            }
            catch(Exception exception) 
            { 
                System.Diagnostics.Debug.WriteLine(exception);
            }
        }

        internal void SaveHighScoresToJSON()
        {
            File.WriteAllText(HighScoresJSONPath, JsonSerializer.Serialize(_highScores));
        }
    }
}
