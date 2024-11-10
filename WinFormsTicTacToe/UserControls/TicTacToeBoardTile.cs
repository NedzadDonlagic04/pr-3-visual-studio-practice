using System.ComponentModel;

namespace WinFormsTicTacToe.CustomControls
{
    /// <summary>
    ///     A control that represents a piece of
    ///     a tic tac toe board
    /// </summary>
    [DefaultEvent(nameof(Click))]
    internal partial class TicTacToeBoardTile : UserControl
    {
        #region Fields, constants and properties   

        /// <summary>
        ///     Sets the symbol for the tile
        /// </summary>
        [Browsable(true)]
        public char Symbol
        {
            get => symbolLbl.Text[0];
            set => symbolLbl.Text = value.ToString();
        }

        #endregion

        #region Delegates and events

        internal new event EventHandler? Click;

        #endregion

        #region Internal methods

        /// <summary>
        ///     Constructs an instance of TicTacToeBoardTile
        /// </summary>
        internal TicTacToeBoardTile()
        {
            InitializeComponent();

            symbolLbl.Click += SymbolLblClick;
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Event that invokes the Click event of the TicTacToeBoardTile
        ///     through the Click event of the symbolLbl control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SymbolLblClick(object? sender, EventArgs e) => Click?.Invoke(this, e);

        #endregion
    }
}
