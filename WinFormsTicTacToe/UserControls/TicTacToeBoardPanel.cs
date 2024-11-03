using System.ComponentModel;

namespace WinFormsTicTacToe.CustomControls
{
    [DefaultEvent(nameof(Click))]
    public partial class TicTacToeBoardPanel : UserControl
    {
        public new event EventHandler? Click;

        public TicTacToeBoardPanel()
        {
            InitializeComponent();

            symbolLbl.Click += SymbolLblClick;
        }

        [Browsable(true)]
        public override string Text
        {
            get => symbolLbl.Text;
            set => symbolLbl.Text = value;
        }

        private void SymbolLblClick(object? sender, EventArgs e) => Click?.Invoke(this, e);
    }
}
