namespace WinFormsSnake
{
    internal partial class SnakeGameOverForm : Form
    {
        internal SnakeGameOverForm()
        {
            InitializeComponent();
        }

        internal SnakeGameAction NextAction { get; private set; }

        private void PlayAgain(object sender, EventArgs e)
        {
            NextAction = SnakeGameAction.RestartGame;
            Close();
        }

        private void GoToMainMenu(object sender, EventArgs e)
        {
            NextAction = SnakeGameAction.GoToMainMenu;
            Close();
        }

        private void QuitGame(object sender, EventArgs e)
        {
            NextAction = SnakeGameAction.QuitGame;
            Close();
        }

        private void FormShownEvent(object sender, EventArgs e) => NextAction = SnakeGameAction.QuitGame;
    }
}
