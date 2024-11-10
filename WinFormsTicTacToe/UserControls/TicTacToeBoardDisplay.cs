using System.ComponentModel;

using WinFormsTicTacToe.Classes;
using WinFormsTicTacToe.CustomControls;
using WinFormsTicTacToe.Enums;
using WinFormsTicTacToe.Interfaces;

namespace WinFormsTicTacToe.UserControls
{
    /// <summary>
    ///     Control that displays the contents of an inner
    ///     TicTacToeBoard object
    /// </summary>
    internal partial class TicTacToeBoardDisplay : UserControl
    {
        #region Fields and properties

        private const int BoardSize = 3;
        private readonly TicTacToeBoard _ticTacToeBoard = new(BoardSize);

        internal TicTacToeGameState GameState { get => _ticTacToeBoard.GameState; }

        public Color XColor { get; private set; }

        public Color OColor { get; private set; }

        private ITicTacToeBot? _ticTacToeBot = null;

        private bool _botGoesFirst = false;

        #endregion

        #region Delegates and events

        private EventHandler? _onGameOver;

        [Browsable(true)]
        internal event EventHandler? OnGameOver
        {
            add => _onGameOver += value;
            remove => _onGameOver -= value;
        }

        #endregion

        #region Internal methods

        /// <summary>
        ///     Constructs an instance of TicTacToeBoardDisplay
        /// </summary>
        internal TicTacToeBoardDisplay()
        {
            InitializeComponent();
            InitializeBoardTiles();
            
            ResetGame();
        }

        /// <summary>
        ///     Resets the board and removes line drawn during
        ///     animation
        /// </summary>
        internal void ResetGame()
        {
            ResetBoard();
            lineAnimationPnl.Hide();
        }

        /// <summary>
        ///     Applies configuration inside settings object onto the game
        /// </summary>  
        /// <param name="settings"></param>
        internal void ApplySettings(TicTacToeGameSettings settings)
        {
            XColor = settings.XColor;
            OColor = settings.OColor;
            _botGoesFirst = settings.IsBotPlayingFirst;

            switch (settings.BotDifficulty)
            {
                case BotDifficulty.Easy:
                    _ticTacToeBot = new EasyTicTacToeBot();
                    break;
                case BotDifficulty.Hard:
                    _ticTacToeBot = new HardTicTacToeBot();
                    break;
                case null:
                    _ticTacToeBot = null;
                    break;
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Gets the tile for the given index on the board
        /// </summary>
        /// <param name="index">Index for the board</param>
        /// <returns>Tile on the board</returns>
        private TicTacToeBoardTile GetBoardTileForIndex(int index)
            => (TicTacToeBoardTile)ticTacToeBoardTilesFlwLytPnl.Controls[index];

        /// <summary>
        ///     Initializes the board tiles by giving each tile
        ///     it's corresponding index in the Tag property
        /// </summary>
        private void InitializeBoardTiles()
        {
            for (int i = 0; i < _ticTacToeBoard.TotalSize; ++i)
            {
                TicTacToeBoardTile tile = GetBoardTileForIndex(i);
                tile.Tag = i;
            }
        }

        private void ResetBoard()
        {
            for (int i = 0; i < _ticTacToeBoard.TotalSize; ++i)
            {
                TicTacToeBoardTile tile = GetBoardTileForIndex(i);
                tile.Symbol = TicTacToeBoard.EmptyBoardValue;
            }

            _ticTacToeBoard.ResetBoard();

            if (_ticTacToeBot != null && _botGoesFirst)
            {
                BotMove();
            }
        }

        /// <summary>
        ///     Gets the color for the current 
        ///     tic tac toe board symbol
        /// </summary>
        /// <returns>Color for the current symbol</returns>
        private Color GetColorForSymbol() => (_ticTacToeBoard.Symbol == 'X') ? XColor : OColor;

        /// <summary>
        ///     Places the current symbol on the board and 
        ///     updates the UI
        /// </summary>
        /// <param name="index">
        ///     Index for the tile on which the symbol will be places
        /// </param>
        private void MakeMove(int index)
        {
            TicTacToeBoardTile boardTile = GetBoardTileForIndex(index);
            boardTile.ForeColor = GetColorForSymbol();
            boardTile.Symbol = _ticTacToeBoard.PlaceSymbol(index);

            if (GameState != TicTacToeGameState.GameOngoing)
            {
                if (GameState != TicTacToeGameState.Tie)
                {
                    DrawLine(_ticTacToeBoard.WinningPosition!);
                }

                _onGameOver?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        ///     Places the index on the board tile the player clicked
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void PlayerMove(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            TicTacToeBoardTile boardTile = (TicTacToeBoardTile)sender;
            int index = (int)boardTile.Tag;

            if (_ticTacToeBoard.IsSpotTaken(index))
            {
                return;
            }

            MakeMove(index);

            if (_ticTacToeBot != null && GameState == TicTacToeGameState.GameOngoing)
            {
                BotMove();
            }
        }

        /// <summary>
        ///     Calls MakeMove with the index the bot picked
        /// </summary>
        private void BotMove()
        {
            int index = _ticTacToeBot!.GetMoveIndex(_ticTacToeBoard);

            MakeMove(index);
        }

        /// <summary>
        ///     Draws line over the winning position
        /// </summary>
        /// <param name="winningPosition"></param>
        private void DrawLine(List<int> winningPosition)
        {
            int start = winningPosition.First();
            int end = winningPosition.Last();

            TicTacToeBoardTile firstTile = GetBoardTileForIndex(start);
            TicTacToeBoardTile lastTile = GetBoardTileForIndex(end);

            Color brushColor = (_ticTacToeBoard.GameState == TicTacToeGameState.PlayerXWon) ? XColor : OColor;

            lineAnimationPnl.EllipseBrush = new SolidBrush(brushColor);
            lineAnimationPnl.BringToFront();

            // Col lines
            if (firstTile.Location.X == lastTile.Location.X)
            {
                int xAxisPos = firstTile.Location.X + firstTile.Width / 2 - lineAnimationPnl.EllipseRadius / 2;

                lineAnimationPnl.DrawLineFromTo(
                    new Point(xAxisPos, 0),
                    new Point(xAxisPos, lastTile.Location.Y + lastTile.Height - lineAnimationPnl.EllipseRadius)
                );
            }
            // Row lines
            else if (firstTile.Location.Y == lastTile.Location.Y)
            {
                int yAxisPos = firstTile.Location.Y + firstTile.Height / 2 - lineAnimationPnl.EllipseRadius / 2;

                lineAnimationPnl.DrawLineFromTo(
                    new Point(0, yAxisPos),
                    new Point(lastTile.Location.X + lastTile.Width - lineAnimationPnl.EllipseRadius, yAxisPos)
                );
            }
            // Main diagonal
            else if (firstTile.Location.X < lastTile.Location.X)
            {
                var panelSize = lineAnimationPnl.Size;

                lineAnimationPnl.DrawLineFromTo(
                    new Point(0, 0),
                    new Point(panelSize.Width - lineAnimationPnl.EllipseRadius, panelSize.Height - lineAnimationPnl.EllipseRadius)
                );
            }
            // Side diagonal
            else
            {
                var panelSize = lineAnimationPnl.Size;

                lineAnimationPnl.DrawLineFromTo(
                    new Point(panelSize.Width - lineAnimationPnl.EllipseRadius, 0),
                    new Point(0, panelSize.Height - lineAnimationPnl.EllipseRadius)
                );
            }
        }

        #endregion
    }
}
