namespace WinFormsTicTacToe.UserControls
{
    public partial class TicTacToePlayerScoresTracker : UserControl
    {
        #region Public methods
        public TicTacToePlayerScoresTracker()
        {
            InitializeComponent();
        }

        public void ResetScores()
        {
            xScoreLbl.Text = "0";
            oScoreLbl.Text = "0";
        }

        public void SetXScore(int score) => SetScore(score);

        public void SetYScore(int score) => SetScore(score, false);

        public void IncrementXScore() => IncrementScore();

        public void IncrementYScore() => IncrementScore(false);

        #endregion

        #region Private methods
        private void SetScore(int score, bool isX = true)
        {
            if (score < 0)
            {
                throw new FormatException("Only allowed to set a score that's greater or equal to 0");
            }
            else if (isX)
            {
                xScoreLbl.Text = score.ToString();
            }
            else
            {
                oScoreLbl.Text = score.ToString();
            }
        }

        private void IncrementScore(bool isX = true)
        {
            Label scoreLbl = isX ? xScoreLbl : oScoreLbl;
            
            int currentScore = int.Parse(scoreLbl.Text);
            int newScore = currentScore + 1;
            scoreLbl.Text = newScore.ToString();
        }

        #endregion
    }
}
