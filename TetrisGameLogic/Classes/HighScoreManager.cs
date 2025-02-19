using System.Text.Json;
using TetrisGameLogic.Structs;

namespace TetrisGameLogic.Classes
{
    public class HighScoreManager
    {
        #region Fields and properties

        private List<PlayerHighScore> HighScores;
        private readonly string _pathToHighScores;

        #endregion

        #region Public methods

        public HighScoreManager(string pathToHighScores = ".\\highScores.json")
        {
            _pathToHighScores = pathToHighScores;
            try 
            {
                LoadScoresFromJson();
            }
            catch
            {
                LoadDefaultScores();   
            }
        }

        public void AddScore(PlayerHighScore playerScore)
        {
            PlaceScoreIntoList(playerScore);    
            SaveScoresToJson();
        }

        #endregion

        #region Private methods

        private void PlaceScoreIntoList(PlayerHighScore playerScore)
        {
            int moveIndex = -1;
            for (int i = 0; i < HighScores.Count; ++i)
            {
                if (playerScore > HighScores[i])
                {
                    moveIndex = i;
                    break;
                }
            }

            if (moveIndex == -1)
            {
                return;
            }

            for (int i = moveIndex + 1; i < HighScores.Count; ++i)
            {
                HighScores[i] = HighScores[i - 1];
            }
            HighScores[moveIndex] = playerScore;
        }

        private void SaveScoresToJson()
        {
            string json = JsonSerializer.Serialize(HighScores);
            File.WriteAllText(_pathToHighScores, json);
        }

        private void LoadScoresFromJson()
        {
            string json = File.ReadAllText(_pathToHighScores);
            HighScores = JsonSerializer.Deserialize<List<PlayerHighScore>>(json);

            if (HighScores == null)
            {
                throw new ArgumentNullException("High scores list can't be null");
            }
        }

        private void LoadDefaultScores()
        {
            HighScores = new();
        }

        #endregion
    }
}
