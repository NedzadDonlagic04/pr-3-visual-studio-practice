namespace WinFormsSnake
{
    public partial class SnakeGameplayForm : Form
    {
        public SnakeGameplayForm()
        {
            InitializeComponent();
        }

        public void RestartGame()
        {

        }

        public SnakeGameAction NextAction { get; private set; }

        private void QuitGame(object sender, EventArgs e)
        {
            Hide();

            using (SnakeGameOverForm snakeGameOverForm = new())
            {
                snakeGameOverForm.ShowDialog();
                NextAction = snakeGameOverForm.NextAction;

                if (NextAction == SnakeGameAction.QuitGame || NextAction == SnakeGameAction.GoToMainMenu)
                {
                    Close();
                    return;
                }
            }

            RestartGame();
            Show();
        }

        private void FormShownEvent(object sender, EventArgs e)
        {
            NextAction = SnakeGameAction.QuitGame;
        }
    }
}
