namespace WinFormsTicTacToe.CustomControls
{
    /// <summary>
    /// 
    /// </summary>
    internal partial class LineAnimationPanel : TransparentPanel
    {
        #region Fields, constants, properties

        private Point _from;
        private Point _to;
        private Point _increment;

        private const int Step = 2;
        
        public readonly int EllipseRadius = 16;

        private readonly System.Windows.Forms.Timer _animationTmr = new();
        public SolidBrush EllipseBrush { get; set; } = new(Color.Black);

        #endregion

        #region Internal methods

        /// <summary>
        ///     Constructs an instance of LineAnimationPanel
        /// </summary>
        internal LineAnimationPanel()
        {
            InitializeComponent();

            _animationTmr.Interval = 10;
            _animationTmr.Tick += AnimationTick;
        }

        internal void DrawLineFromTo(Point from, Point to)
        {
            _from = from;
            _to = to;

            _increment.X = (_from.X < _to.X) ? Step : -Step;
            _increment.Y = (_from.Y < _to.Y) ? Step : -Step;

            Show();
            _animationTmr.Start();
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Triggers on every tick of the timer and draws a part of the line
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void AnimationTick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            // Why is the 20 here?
            // I just put a random number off the top of my head
            // and the speed at which the line was drawn fit what I wanted
            // so I left it there
            for (int i = 0; i < 20; ++i)
            {
                // Here we are essentially drawing a bunch of ellipses very close to one
                // another which creates this nice animation of a line being drawn
                DrawPartOfLine();
            }
        }

        /// <summary>
        ///     Draws a single eclipse and moves the coordinates 
        /// </summary>
        private void DrawPartOfLine()
        {
            DrawFilledEllipse();

            _from.X += (_from.X != _to.X) ? _increment.X : 0;
            _from.Y += (_from.Y != _to.Y) ? _increment.Y : 0;

            if (IsLineDrawn())
            {
                _animationTmr.Stop();
                return;
            }
        }
     
        private bool IsLineDrawn() => _from.X >= _to.X && _from.Y >= _to.Y;

        private void DrawFilledEllipse()
        {
            using Graphics graphics = CreateGraphics();
            
            graphics.FillEllipse(EllipseBrush, new Rectangle(_from.X, _from.Y, EllipseRadius, EllipseRadius));
        }

        #endregion
    }
}
