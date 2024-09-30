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

            InitializeHighScoresListBox();
        }

        private void InitializeHighScoresListBox()
        {
            var highScores = _highScoresManager.HighScores;

            for (int i = highScores.Count - 1; i >= 0; --i)
            {
                highScoresListBox.Items.Add($"{highScores.Count - i}. {highScores.ElementAt(i)}");
            }
        }

        private void GoToMainMenu(object sender, EventArgs e)
        {
            NextAction = SnakeGameAction.GoToMainMenu;
            Close();
        }
    }
}
