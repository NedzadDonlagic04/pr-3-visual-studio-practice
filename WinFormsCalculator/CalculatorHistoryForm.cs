using WinFormsCalculator.Classes;

namespace WinFormsCalculator
{
    internal partial class CalculatorHistoryForm : Form
    {
        private readonly CalculatorHistory _calculatorHistory;

        internal Expression SelectedExpression = null!;

        internal CalculatorHistoryForm(CalculatorHistory calculatorHistory)
        {
            InitializeComponent();

            _calculatorHistory = calculatorHistory;

            foreach (var expression in _calculatorHistory.GetHistory())
            {
                CalculatorButton btn = new()
                {
                    Text = $"{expression}\n{expression.Result}",
                    Tag = expression,
                    Dock = DockStyle.Top,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleRight,
                };

                btn.Click += SelectCalculatorHistoryEntry;

                calculatorHistoryPnl.Controls.Add(btn);
            }
        }

        private void SelectCalculatorHistoryEntry(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            DialogResult = DialogResult.Yes;
            var calculatorBtn = (CalculatorButton)sender;
            var expression = (Expression?)calculatorBtn.Tag;

            if (expression == null)
            {
                DialogResult = DialogResult.Abort;
            }
            else
            {
                SelectedExpression = expression;
            }

            Close();
        }

        private void CalculatorHistoryFormShown(object sender, EventArgs e)
        {
            calculatorHistoryPnl.VerticalScroll.Value = 0;

            if (calculatorHistoryPnl.Controls.Count != 0)
            {
                ActiveControl = calculatorHistoryPnl.Controls[^1];
            }
        }
    }
}
