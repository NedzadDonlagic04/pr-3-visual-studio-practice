namespace WinFormsCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private double _resultLblNum = 0;

        private double _decimalsAfterResult = 0;

        private double ResultLblNum { get => _resultLblNum / Math.Pow(10, _decimalsAfterResult); }

        private double _lastResultLblNum = 0;

        private string _operation = "";

        private void UpdateDisplay()
        {
            if (_operation != "")
            {
                lastOperationLbl.Text = $"{_lastResultLblNum} {_operation}";
            }

            resultLbl.Text = ResultLblNum.ToString();
        }

        private void ResetLastOperationLbl()
        {
            _operation = "";
            _lastResultLblNum = 0;
            lastOperationLbl.Text = "";
        }

        private void ResetResultLbl()
        {
            _resultLblNum = 0;
            _decimalsAfterResult = 0;
            floatingPointBtn.Enabled = true;
            resultLbl.Text = "";
        }

        private void ResetResultLabelsPanel()
        {
            ResetLastOperationLbl();
            ResetResultLbl();
        }

        private void NumberBtnClick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            Button btn = (Button)sender;

            _resultLblNum = _resultLblNum * 10 + double.Parse(btn.Text);

            if (floatingPointBtn.Enabled == false)
            {
                ++_decimalsAfterResult;
            }

            UpdateDisplay();
        }

        private double GetResultOfOperation(string operation) => operation switch
        {
            "+" => _lastResultLblNum + ResultLblNum,
            "-" => _lastResultLblNum - ResultLblNum,
            "×" => _lastResultLblNum * ResultLblNum,
            "÷" => _lastResultLblNum / ResultLblNum,
            "%" => _lastResultLblNum % ResultLblNum,
            "" => ResultLblNum,
            _ => throw new NotImplementedException($"Operation \"{_operation}\" is not a supported operation")
        };

        private void OperationBtnClick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            Button btn = (Button)sender;

            _lastResultLblNum = GetResultOfOperation(_operation);
            _operation = btn.Text;

            ResetResultLbl();
            UpdateDisplay();
        }

        private double GetResultOfSpecialOperation(string operation) => operation switch
        {
            "√" => Math.Sqrt(ResultLblNum),
            "x²" => ResultLblNum * ResultLblNum,
            "x⁻¹" => 1 / ResultLblNum,
            _ => throw new NotImplementedException($"Operation \"{_operation}\" is not a supported special operation")
        };

        private void SpecialOperationBtnClick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            Button btn = (Button)sender;

            _resultLblNum = GetResultOfSpecialOperation(btn.Text);

            floatingPointBtn.Enabled = double.IsInteger(_resultLblNum);
            _decimalsAfterResult = 0;

            UpdateDisplay();
        }

        private void SwitchSignBtnClick(object? sender, EventArgs e)
        {
            if (_resultLblNum != 0)
            {
                _resultLblNum *= -1;
            }
            UpdateDisplay();
        }

        private void EqualsBtnClick(object? sender, EventArgs e)
        {
            if (_operation != "")
            {
                _resultLblNum = GetResultOfOperation(_operation);
                ResetLastOperationLbl();
            }

            UpdateDisplay();
        }

        private void ClearBtnClick(object? sender, EventArgs e) => ResetResultLabelsPanel();

        private void ClearEntryBtnClick(object? sender, EventArgs e) => ResetResultLbl();

        private void UndoPreviousActionBtnClick(object? sender, EventArgs e)
        {
            if (_decimalsAfterResult != 0)
            {
                --_decimalsAfterResult;
            }
            else
            {
                floatingPointBtn.Enabled = true;
                _resultLblNum = (int)(_resultLblNum / 10);
            }

            UpdateDisplay();
        }

        private void FloatingPointBtnClick(object? sender, EventArgs e)
        {
            floatingPointBtn.Enabled = false;
            _decimalsAfterResult = 0;
        }

        private void CalcBtnsEnterFocus(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            Button btn = (Button)sender;

            btn.FlatAppearance.BorderSize = 4;
        }

        private void CalcBtnsLeaveFocus(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            Button btn = (Button)sender;

            btn.FlatAppearance.BorderSize = 1;
        }
    }
}