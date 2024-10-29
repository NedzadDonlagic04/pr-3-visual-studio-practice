namespace WinFormsTicTacToe.CustomControls
{
    public partial class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            InitializeComponent();
        }

        private const int WS_EX_TRANSPARENT = 0x00000020;

        protected override CreateParams CreateParams 
        {
            get 
            {
                CreateParams baseParams = base.CreateParams;
                baseParams.ExStyle |= WS_EX_TRANSPARENT;
                return baseParams;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pe) { }
    }
}
