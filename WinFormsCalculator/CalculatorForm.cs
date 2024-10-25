namespace WinFormsCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorButtonClick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            Button btn = (Button)sender;

            MessageBox.Show($"Button Clicked -> {btn.Text}");
        }
    }
}