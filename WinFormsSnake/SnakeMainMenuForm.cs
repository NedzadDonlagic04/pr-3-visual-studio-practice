namespace WinFormsSnake
{
    public enum SnakeGameAction 
    {
        RestartGame,
        QuitGame,
        GoToMainMenu
    }

    public partial class SnakeMainMenuForm : Form
    {
        public SnakeMainMenuForm()
        {
            InitializeComponent();
        }

        private void QuitGame(object sender, EventArgs e)
        {
            Close();
        }

        private void StartGame(object sender, EventArgs e)
        {
            Hide();

            using (SnakeGameplayForm snakeGameplayForm = new()) 
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
    }
}