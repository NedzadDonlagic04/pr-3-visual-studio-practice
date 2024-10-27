namespace WinFormsCalculator
{
    public partial class CalculatorButton : Button
    {
        public CalculatorButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe) => base.OnPaint(pe);

        protected override void OnEnter(EventArgs e) => FlatAppearance.BorderSize = 3;

        protected override void OnLeave(EventArgs e) => FlatAppearance.BorderSize = 1;
    }
}
