namespace WinFormsTicTacToe.CustomControls
{
    /// <summary>
    ///     Transparent panel that inherits panel
    ///     (who would have guessed)
    /// </summary>
    internal partial class TransparentPanel : Panel
    {
        #region Fields and properties 

        private const int WS_EX_TRANSPARENT = 0x00000020;

        #endregion

        #region Internal methods

        /// <summary>
        ///     Constructs an instance of TransparentPanel
        /// </summary>
        internal TransparentPanel()
        {
            InitializeComponent();
        }

        #endregion

        #region Protected methods

        /// <summary>
        ///     Had to override this so the panel would be truly
        ///     transparent
        /// </summary>
        protected override CreateParams CreateParams 
        {
            get 
            {
                CreateParams baseParams = base.CreateParams;
                baseParams.ExStyle |= WS_EX_TRANSPARENT;
                return baseParams;
            }
        }

        /// <summary>
        ///     Had to override this as well since it would
        ///     fuck up the transparency
        /// </summary>
        /// <param name="pe">Argument passed when the event is triggered</param>
        protected override void OnPaintBackground(PaintEventArgs pe) { }

        #endregion
    }
}
