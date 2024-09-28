using WinFormsSnake.SnakeHighScoresManager;

namespace WinFormsSnake
{
    internal enum SnakeGameAction
    {
        RestartGame,
        QuitGame,
        GoToMainMenu
    }

    internal partial class SnakeMainMenuForm : Form
    {
        private const int MaxHighScores = 10;
        private readonly HighScoresManager _highScoresManager = new(MaxHighScores);

        internal SnakeMainMenuForm()
        {
            InitializeComponent();
        }

        private void QuitGame(object sender, EventArgs e) => Close();

        private void StartGame(object sender, EventArgs e)
        {
            Hide();

            using (SnakeGameplayForm snakeGameplayForm = new(_highScoresManager))
            {
                do
                {
                    snakeGameplayForm.RestartGame();
                    snakeGameplayForm.ShowDialog();
                } while (snakeGameplayForm.NextAction == SnakeGameAction.RestartGame);

                if (snakeGameplayForm.NextAction == SnakeGameAction.QuitGame)
                {
                    Close();
                    return;
                }
            }

            Show();
        }

        private void ShowHighScores(object sender, EventArgs e)
        {
            Hide();

            using (SnakeHighScoresForm snakeHighScoresForm = new(_highScoresManager))
            {
                snakeHighScoresForm.ShowDialog();

                if (snakeHighScoresForm.NextAction == SnakeGameAction.QuitGame)
                {
                    Close();
                    return;
                }
            }

            Show();
        }
    }
}