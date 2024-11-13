using WinFormsTicTacToe.Classes;
using WinFormsTicTacToe.Enums;
using WinFormsTicTacToe.Forms;

namespace WinFormsTicTacToe
{
    internal partial class TicTacToeForm : Form
    {
        #region Fields, constants, properties    

        private TicTacToeGameSettings _gameSettings = new();

        private const string SettingsPath = "./settings.json";

        #endregion

        #region Internal methods

        internal TicTacToeForm()
        {
            InitializeComponent();
            
            if (File.Exists(SettingsPath))
            {
                LoadSettings();
            }

            ticTacToeBoard.ApplySettings(_gameSettings);
        }

        #endregion

        #region Private methods

        private void LoadSettings()
        {
            try
            {
                _gameSettings.LoadFromJSONFile(SettingsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePlayerScore(object? sender, EventArgs e)
        {
            switch (ticTacToeBoard.GameState)
            {
                case TicTacToeGameState.PlayerXWon:
                    ticTacToeScoreBoard.IncrementXScore();
                    resultLbl.ForeColor = ticTacToeBoard.XColor;
                    resultLbl.Text = "Player X Won";
                    break;
                case TicTacToeGameState.PlayerOWon:
                    ticTacToeScoreBoard.IncrementOScore();
                    resultLbl.ForeColor = ticTacToeBoard.OColor;
                    resultLbl.Text = "Player O Won";
                    break;
                case TicTacToeGameState.Tie:
                    resultLbl.ForeColor = Color.Black;
                    resultLbl.Text = "Tie";
                    break;
            }
        }

        private void ResetGameClick(object? sender, EventArgs e)
        {
            ticTacToeBoard.ResetGame();
            resultLbl.Text = "";
        }

        private void OpenSettingsForm(object? sender, EventArgs e)
        {
            using TicTacToeGameSettingsForm ticTacToeGameSettingsForm = new(_gameSettings);

            DialogResult result = ticTacToeGameSettingsForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                var settings = ticTacToeGameSettingsForm.Settings;
                if (settings == null)
                {
                    return;
                }

                _gameSettings = settings;
                _gameSettings.SaveToJSONFile(SettingsPath);

                ticTacToeBoard.ApplySettings(settings);
                ticTacToeScoreBoard.ResetScores();
                resultLbl.Text = "";
            }
        }

        #endregion
    }
}