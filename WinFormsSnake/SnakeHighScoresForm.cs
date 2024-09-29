using WinFormsSnake.SnakeHighScoresManager;

namespace WinFormsSnake
{
    internal partial class SnakeHighScoresForm : Form
    {
        private readonly HighScoresManager _highScoresManager;

        internal SnakeGameAction NextAction { get; private set; } = SnakeGameAction.QuitGame;

        internal SnakeHighScoresForm(HighScoresManager highScoresManager)
        {
            InitializeComponent();

            _highScoresManager = highScoresManager;
        }

        private void GoToMainMenu(object sender, EventArgs e)
        {
            NextAction = SnakeGameAction.GoToMainMenu;
            Close();
        }
    }
}
