using System.ComponentModel;
using WinFormsTicTacToe.CustomControls;

namespace WinFormsTicTacToe.UserControls
{
    public enum TicTacToeGameState
    {
        PlayerXWon,
        PlayerOWon,
        Tie,
        GameOngoing,
    }

    public partial class TicTacToeBoard : UserControl
    {
        #region Fields and properties
        public TicTacToeGameState GameState { get; private set; }

        private const int BoardSize = 3;
        private readonly TicTacToeBoardPanel[] _boardPanels = new TicTacToeBoardPanel[BoardSize * BoardSize];

        private const string InitialSymbol = "X";
        private string _symbol = InitialSymbol;
        private string NextSymbol
        {
            get
            {
                string temp = _symbol;
                _symbol = (_symbol == "X") ? "O" : "X";
                return temp;
            }
        }

        public Color PlayerXColor = Color.Blue;
        public Color PlayerOColor = Color.Red;

        #endregion

        #region Custom events
        private EventHandler? _onGameOver;
        [Browsable(true)]
        public event EventHandler? OnGameOver
        {
            add => _onGameOver += value;
            remove => _onGameOver -= value;
        }

        #endregion

        #region Public methods
        public TicTacToeBoard()
        {
            InitializeComponent();

            InitializeSymbolLabels();
            ResetGame();

            InitializeAnimationPanel();
            ClearAnimationPanel();
        }

        public void ResetGame()
        {
            ResetBoard();
            ClearAnimationPanel();

            GameState = TicTacToeGameState.GameOngoing;
        }

        #endregion

        #region Private methods
        private void InitializeSymbolLabels()
        {
            for (int i = 0; i < _boardPanels.Length; ++i)
            {
                _boardPanels[i] = (TicTacToeBoardPanel)ticTacToeBoardPnlsFlwLytPnl.Controls[i];
                _boardPanels[i].Click += PlaceSymbol;
            }
        }

        private void ResetBoard()
        {
            foreach (TicTacToeBoardPanel boardPnl in _boardPanels)
            {
                boardPnl.Text = "";
            }
        }

        private Color GetColorForSymbol(string symbol)
            => (symbol == "X") ? PlayerXColor : PlayerOColor;

        private void PlaceSymbol(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            TicTacToeBoardPanel boardPnl = (TicTacToeBoardPanel)sender;

            if (boardPnl.Text != "")
            {
                return;
            }

            string symbol = NextSymbol;
            boardPnl.Text = symbol;
            boardPnl.ForeColor = GetColorForSymbol(symbol);

            if (DidXOrOWin() || IsGameBoardFull())
            {
                _onGameOver?.Invoke(this, EventArgs.Empty);
            }
        }

        private bool IsGameBoardFull()
        {
            foreach (TicTacToeBoardPanel boardPnl in _boardPanels)
            {
                if (boardPnl.Text == "")
                {
                    return false;
                }
            }

            GameState = TicTacToeGameState.Tie;
            return true;
        }

        private bool DidXOrOWin()
        {
            List<List<int>> winningPositions = new()
            {
                // Rows
                new() { 0, 1, 2 },
                new() { 3, 4, 5 },
                new() { 6, 7, 8 },                
                
                // Cols
                new() { 0, 3, 6 },
                new() { 1, 4, 7 },
                new() { 2, 5, 8 },                
                
                // Diagonals
                new() { 0, 4, 8 },
                new() { 2, 4, 6 },
            };

            foreach (var winningPosition in winningPositions)
            {
                string symbol = _boardPanels[winningPosition[0]].Text;

                if (symbol == "")
                {
                    continue;
                }

                bool winnerFound = winningPosition.TrueForAll(index => symbol == _boardPanels[index].Text);

                if (winnerFound)
                {
                    GameState = (symbol == "X") ? TicTacToeGameState.PlayerXWon : TicTacToeGameState.PlayerOWon;
                    DrawLine(winningPosition);
                    return true;
                }
            }

            return false;
        }

        #endregion

        #region Line animation related fields, properties and methods
        /*
         *  Put this in it's own region because it's a bit of a scuffed bit of code
         *  Not quite proud of it but it works for this case
         */

        private Graphics _animationPnlGraphics = null!;
        private Point _from;
        private Point _to;
        private Point _increment;
        private const int _step = 2;
        private SolidBrush _ellipseBrush = null!;
        private const int _ellipseRadius = 16;

        private void InitializeAnimationPanel()
        {
            _animationPnlGraphics = animationPnl.CreateGraphics();
        }

        private void ClearAnimationPanel()
        {
            animationPnl.Hide();
        }

        private void DrawLine(List<int> winningPosition)
        {
            int start = winningPosition.First();
            int end = winningPosition.Last();

            TicTacToeBoardPanel firstPnl = _boardPanels[start];
            TicTacToeBoardPanel lastPnl = _boardPanels[end];

            _ellipseBrush = new SolidBrush(firstPnl.ForeColor);

            // Col lines
            if (firstPnl.Location.X == lastPnl.Location.X)
            {
                int xAxisPos = firstPnl.Location.X + firstPnl.Width / 2 - _ellipseRadius / 2;

                DrawLineFromTo(
                    new Point(xAxisPos, 0),
                    new Point(xAxisPos, lastPnl.Location.Y + lastPnl.Height - _ellipseRadius)
                );
            }
            // Row lines
            else if (firstPnl.Location.Y == lastPnl.Location.Y)
            {
                int yAxisPos = firstPnl.Location.Y + firstPnl.Height / 2 - _ellipseRadius / 2;

                DrawLineFromTo(
                    new Point(0, yAxisPos),
                    new Point(lastPnl.Location.X + lastPnl.Width - _ellipseRadius, yAxisPos)
                );
            }
            // Main diagonal
            else if (firstPnl.Location.X < lastPnl.Location.X)
            {
                var panelSize = animationPnl.Size;

                DrawLineFromTo(
                    new Point(0, 0),
                    new Point(panelSize.Width - _ellipseRadius, panelSize.Height - _ellipseRadius)
                );
            }
            // Side diagonal
            else
            {
                var panelSize = animationPnl.Size;

                DrawLineFromTo(
                    new Point(panelSize.Width - _ellipseRadius, 0),
                    new Point(0, panelSize.Height - _ellipseRadius)
                );
            }
        }

        private void DrawLineFromTo(Point from, Point to)
        {
            _from = from;
            _to = to;

            _increment.X = (_from.X < _to.X) ? _step : -_step;
            _increment.Y = (_from.Y < _to.Y) ? _step : -_step;

            animationPnl.BringToFront();
            animationPnl.Show();
            animationTmr.Start();
        }

        private void DrawFilledEllipse()
        {
            _animationPnlGraphics.FillEllipse(_ellipseBrush, new Rectangle(_from.X, _from.Y, _ellipseRadius, _ellipseRadius));
        }

        private bool LineFinishedDrawing() => _from.X == _to.X && _from.Y == _to.Y;

        // Here we are essentially drawing a bunch of ellipses very close to one
        // another which creates this nice animation of a line being drawn
        private void DrawPartOfLine()
        {
            DrawFilledEllipse();

            _from.X += (_from.X != _to.X) ? _increment.X : 0;
            _from.Y += (_from.Y != _to.Y) ? _increment.Y : 0;

            if (LineFinishedDrawing())
            {
                animationTmr.Stop();
                return;
            }
        }

        private void AnimationFrame(object? sender, EventArgs e)
        {
            // Why is the 20 here?
            // I just put a random number off the top of my head
            // and the speed at which the line was drawn fit what I wanted
            // so I left it there
            for (int i = 0; i < 20; ++i)
            {
                DrawPartOfLine();
            }
        }

        #endregion
    }
}
