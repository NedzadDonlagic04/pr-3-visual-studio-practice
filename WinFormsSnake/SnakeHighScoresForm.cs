using WinFormsSnake.SnakeHighScoresManager;

namespace WinFormsSnake
{
    internal partial class SnakeHighScoresForm : Form
    {
        private readonly HighScoresManager _highScoresManager;

        internal SnakeGameAction NextAction { get; private set; }

        internal SnakeHighScoresForm(HighScoresManager highScoresManager)
        {
            InitializeComponent();

            _highScoresManager = highScoresManager;
        }
    }
}
