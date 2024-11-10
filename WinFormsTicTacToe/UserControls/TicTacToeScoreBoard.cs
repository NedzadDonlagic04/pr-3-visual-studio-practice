namespace WinFormsTicTacToe.UserControls
{
    /// <summary>
    ///     Class that represents a control that shows 
    ///     the score board in a game of tic tac toe
    /// </summary>
    internal partial class TicTacToeScoreBoard : UserControl
    {
        #region Internal methods

        /// <summary>
        ///     Constructs a TicTacToePlayerScoreBoard
        /// </summary>
        internal TicTacToeScoreBoard()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Resets the scores to 0 for both players
        /// </summary>
        internal void ResetScores()
        {
            xScoreLbl.Text = "0";
            oScoreLbl.Text = "0";
        }

        /// <summary>
        ///     Sets the score for player X
        /// </summary>
        /// <param name="score">Score that will be displayed</param>
        internal void SetXScore(int score) => SetScore(score);

        /// <summary>
        ///     Sets the score for player O
        /// </summary>
        /// <param name="score">Score that will be displayed</param>
        internal void SetOScore(int score) => SetScore(score, false);

        /// <summary>
        ///     Increments the current score of player X by 1
        /// </summary>
        internal void IncrementXScore() => IncrementScore();

        /// <summary>
        ///     Increments the current score of player O by 1
        /// </summary>
        internal void IncrementOScore() => IncrementScore(false);

        #endregion

        #region Private methods

        /// <summary>
        ///     Sets the score for player X or O depending on the passed arguments
        /// </summary>
        /// <param name="score">Score that will be displayed</param>
        /// <param name="isX">Decides weather it will be set for player X or O</param>
        /// <exception cref="FormatException"></exception>
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

        /// <summary>
        ///     Increments the current score of player X or player O by 1
        ///     depending on the passed arguments
        /// </summary>
        /// <param name="isX">
        ///     Decides weather it will be incremented for player X or O
        /// </param>
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
