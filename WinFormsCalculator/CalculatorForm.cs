using System.Text;

using WinFormsCalculator.Classes;

namespace WinFormsCalculator
{
    internal partial class CalculatorForm : Form
    {
        private double _result;

        private readonly StringBuilder _currentOperand = new("0");

        private double CurrentOperand { get => double.Parse(_currentOperand.ToString()); }

        private string _operation = "";

        private readonly CalculatorHistory _calculatorHistory = new();

        internal CalculatorForm()
        {
            InitializeComponent();
        }

        private void SetEnableForSpecialButtons(bool state)
        {
            floatingPointBtn.Enabled = state;
            changeSignBtn.Enabled = state;
            undoPreviousActionBtn.Enabled = state;
            equalsBtn.Enabled = state;
        }

        private void ResetResultUpperLbl()
        {
            resultUpperLbl.Text = "";
            _operation = "";
        }

        private void ResetResultLowerLbl()
        {
            _currentOperand.Clear();
            _currentOperand.Append(0);
            resultLowerLbl.Text = _currentOperand.ToString();
            SetEnableForSpecialButtons(true);
        }

        private void ResetResultLbls()
        {
            ResetResultUpperLbl();
            ResetResultLowerLbl();
        }

        private void NumberBtnClick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            else if (_operation == "=")
            {
                ResetResultLbls();
            }

            Button btn = (Button)sender;

            if (_currentOperand.ToString() == "0")
            {
                _currentOperand.Remove(0, 1);
            }
            _currentOperand.Append(btn.Text);

            resultLowerLbl.Text = _currentOperand.ToString();
        }

        private void FloatingPointBtnClick(object? sender, EventArgs e)
        {
            _currentOperand.Append('.');
            floatingPointBtn.Enabled = false;
        }

        private double GetResultOfOperation(string operation) => operation switch
        {
            "+" => _result + CurrentOperand,
            "-" => _result - CurrentOperand,
            "×" => _result * CurrentOperand,
            "÷" => _result / CurrentOperand,
            "%" => _result % CurrentOperand,
            "√" => Math.Sqrt(CurrentOperand),
            "x²" => CurrentOperand * CurrentOperand,
            "x⁻¹" => 1 / CurrentOperand,
            _ => throw new NotImplementedException($"Operation \"{_operation}\" is not a supported operation")
        };

        private string GetEndOfExpressionFormat(string operation) => operation switch
        {
            "√" => $"√{_currentOperand}",
            "x²" => $"{_currentOperand}²",
            "x⁻¹" => $"{_currentOperand}⁻¹",
            "+" or "-" or "×" or "÷" or "%" => $"{_currentOperand}",
            _ => throw new NotImplementedException($"Operation \"{_operation}\" is not a supported operation")
        };

        private void EqualsBtnClick(object? sender, EventArgs e)
        {
            _result = GetResultOfOperation(_operation);
            string endOfExpressionFormat = GetEndOfExpressionFormat(_operation);

            resultUpperLbl.Text += (CurrentOperand < 0) ? $"({endOfExpressionFormat})" : $"{endOfExpressionFormat}";
            resultUpperLbl.Text += " =";

            _calculatorHistory.Add(resultUpperLbl.Text, _result);

            _currentOperand.Clear();
            _currentOperand.Append(_result);
            resultLowerLbl.Text = _currentOperand.ToString();

            _operation = "=";

            SetEnableForSpecialButtons(false);
        }

        private bool IsOperationForSingleOperand(string operation) => operation switch
        {
            "√" or "x²" or "x⁻¹" => true,
            "+" or "-" or "×" or "÷" or "%" or "" => false,
            _ => throw new NotImplementedException($"Operation \"{_operation}\" is not a supported operation")
        };

        private void OperationBtnClick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            Button btn = (Button)sender;

            if (_operation != "" && _operation != "=")
            {
                equalsBtn.PerformClick();
            }

            _result = CurrentOperand;
            _operation = btn.Text;

            if (IsOperationForSingleOperand(_operation))
            {
                resultUpperLbl.Text = "";
                equalsBtn.Enabled = true;
                equalsBtn.PerformClick();
                return;
            }

            resultUpperLbl.Text = $"{_result} {_operation} ";
            ResetResultLowerLbl();
        }

        private void SwitchSignBtnClick(object? sender, EventArgs e)
        {
            if (_currentOperand.ToString() == "0")
            {
                return;
            }
            else if (_currentOperand[0] == '-')
            {
                _currentOperand.Remove(0, 1);
            }
            else
            {
                _currentOperand.Insert(0, '-');
            }

            resultLowerLbl.Text = _currentOperand.ToString();
        }

        private void ClearBtnClick(object? sender, EventArgs e) => ResetResultLbls();

        private void ClearEntryBtnClick(object? sender, EventArgs e)
        {
            if (resultUpperLbl.Text.EndsWith('='))
            {
                ResetResultUpperLbl();
            }
            ResetResultLowerLbl();
        }

        private void UndoPreviousActionBtnClick(object? sender, EventArgs e)
        {
            if (_currentOperand.ToString() == "0")
            {
                return;
            }
            else if (_currentOperand[^1] == '.')
            {
                floatingPointBtn.Enabled = true;
            }

            _currentOperand.Remove(_currentOperand.Length - 1, 1);

            if (_currentOperand.Length == 1 && _currentOperand[0] == '-')
            {
                _currentOperand.Clear();
                _currentOperand.Append(0);
            }

            resultLowerLbl.Text = _currentOperand.ToString();
        }

        private void ViewHistoryBtn(object sender, EventArgs e)
        {
            using CalculatorHistoryForm calculatorHistoryForm = new(_calculatorHistory);

            var dialogResult = calculatorHistoryForm.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                Expression selectedExpression = calculatorHistoryForm.SelectedExpression;

                _result = selectedExpression.Result;
                resultUpperLbl.Text = selectedExpression.ToString();

                _currentOperand.Clear();
                _currentOperand.Append(_result);

                resultLowerLbl.Text = _currentOperand.ToString();
                _operation = "=";

                SetEnableForSpecialButtons(false);
            }
        }
    }
}