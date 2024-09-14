namespace WinFormsSnake
{
    public partial class SnakeGameplayForm : Form
    {
        public SnakeGameplayForm()
        {
            InitializeComponent();
            ApplySharedTheme();
        }

        private void ApplySharedTheme()
        {
            BackColor = Color.FromName(Properties.Resources.mainBackColor);
            ForeColor = Color.FromName(Properties.Resources.mainForeColor);
        }

        private void ResetGrassTiles()
        {
            foreach (PictureBox pictureBox in snakeTilesFlowLayoutPanel.Controls)
            {
                pictureBox.BackColor = Color.FromName(Properties.Resources.mainBackColor);
            }
        }

        public void RestartGame()
        {
            ResetGrassTiles();
        }

        public SnakeGameAction NextAction { get; private set; }

        private void StartPlayerDiedEvent()
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
