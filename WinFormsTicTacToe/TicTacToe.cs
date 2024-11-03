using WinFormsTicTacToe.UserControls;

namespace WinFormsTicTacToe
{
    public partial class TicTacToeForm : Form
    {
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void UpdatePlayerScore(object? sender, EventArgs e)
        {
            switch (ticTacToeBoard.GameState)
            {
                case TicTacToeGameState.PlayerXWon:
                    ticTacToePlayerScoresTracker.IncrementXScore();
                    resultLbl.ForeColor = ticTacToeBoard.PlayerXColor;
                    resultLbl.Text = "Player X Won";
                    break;
                case TicTacToeGameState.PlayerOWon:
                    ticTacToePlayerScoresTracker.IncrementYScore();
                    resultLbl.ForeColor = ticTacToeBoard.PlayerOColor;
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
    }
}