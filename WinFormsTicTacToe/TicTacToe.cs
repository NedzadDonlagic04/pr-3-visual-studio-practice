using System.Media;
using WinFormsTicTacToe.CustomControls;

namespace WinFormsTicTacToe
{
    public partial class TicTacToeForm : Form
    {
        private string _symbol = "X";

        private const int TicTacToeBoardSize = 3;
        private readonly TicTacToeBoardButton[,] _ticTacToeBoardBtns = new TicTacToeBoardButton[TicTacToeBoardSize, TicTacToeBoardSize];

        private readonly SoundPlayer _lineDrawnSoundPlayer = new(Resources.SharpieLineDrawnSfx);

        private int _timesClicked = 0;

        // Animating tic tac toe board line related fields
        private readonly Graphics _ticTacToeBoardGraphics = null!;
        private Point _from;
        private Point _to;
        private Point _increment;
        private const int _step = 2;
        private readonly SolidBrush _ellipseBrush = new(Color.Red);
        private const int _ellipseRadius = 16;

        public TicTacToeForm()
        {
            InitializeComponent();

            SetTicTacToeBoardBtns();
            _ticTacToeBoardGraphics = ticTacToeBoardAnimationPanel.CreateGraphics();
            ticTacToeBoardAnimationPanel.Hide();

            ResetTicTacToeBoard();

            /*
             * Seems like LoadAsync removes the initial delay that playing the sound used to have
             * I assume it's because of what the docs say below
             * https://learn.microsoft.com/en-us/dotnet/api/system.media.soundplayer.load?view=net-8.0#remarks
             */
            _lineDrawnSoundPlayer.LoadAsync();

            playAgainBtn.Hide();
        }

        private void SetTicTacToeBoardBtns()
        {
            for (int i = 0; i < TicTacToeBoardSize; ++i)
            {
                for (int j = 0; j < TicTacToeBoardSize; ++j)
                {
                    Control control = ticTacToeBoardFlowLayoutPnl.Controls[TicTacToeBoardSize * i + j];
                    TicTacToeBoardButton btn = (TicTacToeBoardButton)control;
                    _ticTacToeBoardBtns[i, j] = btn;
                }
            }
        }

        private void ResetTicTacToeBoard()
        {
            _symbol = "X";
            for (int i = 0; i < TicTacToeBoardSize; ++i)
            {
                for (int j = 0; j < TicTacToeBoardSize; ++j)
                {
                    _ticTacToeBoardBtns[i, j].Enabled = true;
                    _ticTacToeBoardBtns[i, j].Text = "";
                }
            }
        }

        private void ResetGameClick(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            ResetTicTacToeBoard();

            ticTacToeBoardAnimationPanel.Hide();
            playAgainBtn.Hide();
        }

        private string GetNextSymbol()
        {
            string temp = _symbol;
            _symbol = (_symbol == "X") ? "O" : "X";
            return temp;
        }

        private void PlaceSymbol(object sender, EventArgs e)
        {
            ++_timesClicked;

            if (sender == null)
            {
                return;
            }

            TicTacToeBoardButton btn = (TicTacToeBoardButton)sender;

            btn.Text = GetNextSymbol();
            btn.Enabled = false;

            HandleGameOver();

            if (_timesClicked == 9)
            {
                playAgainBtn.Show();
                _timesClicked = 0;
            }
        }

        private void UpdatePlayerScores(string symbol)
        {
            // Could have also kept track of the scores as fields here
            Label scoreLbl = (symbol == "X") ? playerXScoreLbl : playerYScoreLbl;
            int newScore = int.Parse(scoreLbl.Text) + 1;
            scoreLbl.Text = newScore.ToString();
        }

        private void HandleGameOver()
        {
            if (HandleGameOverInDiagonal() || HandleGameOverInSideDiagonal())
            {
                return;
            }

            for (int i = 0; i < TicTacToeBoardSize; ++i)
            {
                if (HandleGameOverInRow(i) || HandlerGameOverInCol(i))
                {
                    return;
                }
            }
        }

        private bool HandleGameOverInRow(int targetRow)
        {
            TicTacToeBoardButton firstBtn = _ticTacToeBoardBtns[targetRow, 0];

            if (firstBtn.Text == "")
            {
                return false;
            }

            for (int i = 1; i < TicTacToeBoardSize; ++i)
            {
                if (firstBtn.Text != _ticTacToeBoardBtns[targetRow, i].Text)
                {
                    return false;
                }
            }

            TicTacToeBoardButton lastBtn = _ticTacToeBoardBtns[targetRow, TicTacToeBoardSize - 1];

            int yAxisPos = firstBtn.Location.Y + firstBtn.Height / 2 - _ellipseRadius / 2;

            DrawLineFromTo(
                new Point(0, yAxisPos),
                new Point(lastBtn.Location.X + lastBtn.Width - _ellipseRadius, yAxisPos)
            );

            UpdatePlayerScores(firstBtn.Text);

            return true;
        }

        private bool HandlerGameOverInCol(int targetCol)
        {
            TicTacToeBoardButton firstBtn = _ticTacToeBoardBtns[0, targetCol];

            if (firstBtn.Text == "")
            {
                return false;
            }

            for (int i = 1; i < TicTacToeBoardSize; ++i)
            {
                if (firstBtn.Text != _ticTacToeBoardBtns[i, targetCol].Text)
                {
                    return false;
                }
            }

            TicTacToeBoardButton lastBtn = _ticTacToeBoardBtns[TicTacToeBoardSize - 1, targetCol];

            int xAxisPos = firstBtn.Location.X + firstBtn.Width / 2 - _ellipseRadius / 2;

            DrawLineFromTo(
                new Point(xAxisPos, 0),
                new Point(xAxisPos, lastBtn.Location.Y + lastBtn.Height - _ellipseRadius)
            );

            UpdatePlayerScores(firstBtn.Text);

            return true;
        }

        private bool HandleGameOverInDiagonal()
        {
            TicTacToeBoardButton firstBtn = _ticTacToeBoardBtns[0, 0];

            if (firstBtn.Text == "")
            {
                return false;
            }

            for (int i = 1; i < TicTacToeBoardSize; ++i)
            {
                if (firstBtn.Text != _ticTacToeBoardBtns[i, i].Text)
                {
                    return false;
                }
            }

            var panelSize = ticTacToeBoardAnimationPanel.Size;

            DrawLineFromTo(
                new Point(0, 0),
                new Point(panelSize.Width - _ellipseRadius, panelSize.Height - _ellipseRadius)
            );

            UpdatePlayerScores(firstBtn.Text);

            return true;
        }

        private bool HandleGameOverInSideDiagonal()
        {
            TicTacToeBoardButton firstBtn = _ticTacToeBoardBtns[0, TicTacToeBoardSize - 1];

            if (firstBtn.Text == "")
            {
                return false;
            }

            for (int i = 1; i < TicTacToeBoardSize; ++i)
            {
                if (firstBtn.Text != _ticTacToeBoardBtns[i, TicTacToeBoardSize - 1 - i].Text)
                {
                    return false;
                }
            }

            var panelSize = ticTacToeBoardAnimationPanel.Size;

            DrawLineFromTo(
                new Point(panelSize.Width - _ellipseRadius, 0),
                new Point(0, panelSize.Height - _ellipseRadius)
            );

            UpdatePlayerScores(firstBtn.Text);

            return true;
        }

        private void DrawLineFromTo(Point from, Point to)
        {
            _from = from;
            _to = to;

            _increment.X = (_from.X < _to.X) ? _step : -_step;
            _increment.Y = (_from.Y < _to.Y) ? _step : -_step;

            ticTacToeBoardAnimationPanel.Show();
            lineAnimationTimer.Start();
            _lineDrawnSoundPlayer.Play();
        }

        private void DrawFilledEllipse()
        {
            _ticTacToeBoardGraphics.FillEllipse(_ellipseBrush, new Rectangle(_from.X, _from.Y, _ellipseRadius, _ellipseRadius));
        }

        /// <summary>
        ///     Here we are essentially drawing a bunch of ellipses very close to one
        ///     another which creates this nice animation of a line being drawn
        /// </summary>
        private void DrawPartOfLine()
        {
            DrawFilledEllipse();

            _from.X += (_from.X != _to.X) ? _increment.X : 0;
            _from.Y += (_from.Y != _to.Y) ? _increment.Y : 0;

            if (_from.X == _to.X && _from.Y == _to.Y)
            {
                lineAnimationTimer.Stop();
                playAgainBtn.Show();
                return;
            }
        }

        private void AnimationFrame(object sender, EventArgs e)
        {
            // Why is the 15 here?
            // I just put a random number off the top of my head
            // and the speed at which the line was drawn fit what I wanted
            // so I left it there
            for (int i = 0; i < 15; ++i)
            {
                DrawPartOfLine();
            }
        }
    }
}