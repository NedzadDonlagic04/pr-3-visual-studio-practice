namespace WinFormsTicTacToe.CustomControls
{
    public partial class TicTacToeBoardButton : Button
    {
        public TicTacToeBoardButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e) => base.OnPaint(e);

        protected override void OnEnter(EventArgs e) => FlatAppearance.BorderSize = 0;

        protected override void OnLeave(EventArgs e) => FlatAppearance.BorderSize = 0;
    }
}
