using System.ComponentModel;

namespace WinFormsTodoList
{
    public partial class TextBoxWithLabel : UserControl
    {
        public TextBoxWithLabel()
        {
            InitializeComponent();
        }

        [DefaultValue("")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TextBoxText
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        [DefaultValue("Label text: ")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string LabelText
        {
            get => textBoxLabel.Text;
            set => textBoxLabel.Text = value;
        }

        private int _maxTextBoxInputLength;
        [DefaultValue(0)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int MaxTextBoxInputLength
        {
            get => _maxTextBoxInputLength;
            set
            {
                _maxTextBoxInputLength = value;
                UpdateCharacterCountLabel();
            }
        }

        private void UpdateCharacterCountLabel()
        {
            int enteredCharacters = textBox.Text.Length;

            if (MaxTextBoxInputLength == 0)
            {
                characterCountLabel.Text = "";
                return;
            }

            characterCountLabel.Text = $"{enteredCharacters} / {MaxTextBoxInputLength}";
            characterCountLabel.ForeColor = Color.Black;

            if (MaxTextBoxInputLength - enteredCharacters <= 5)
            {
                characterCountLabel.ForeColor = Color.Red;
            }
        }

        private void RestrictTextBoxInput(object? sender, EventArgs e)
        {
            if (MaxTextBoxInputLength == 0)
            {
                return;
            }

            textBox.TextChanged -= RestrictTextBoxInput;

            if (textBox.Text.Length > MaxTextBoxInputLength)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);

                // These 2 lines below are some of the goofiest fixes to a problem
                // I've seen
                textBox.Enabled = false;
                textBox.Enabled = true;
            }
            UpdateCharacterCountLabel();

            textBox.TextChanged += RestrictTextBoxInput;
        }
    }
}
