namespace WinFormsTodoList
{
    public partial class PromptInputForm : Form
    {
        public PromptInputForm()
        {
            InitializeComponent();
        }

        public string EnteredText {
            get => TextBoxWithLabel.TextBoxText;
            set => TextBoxWithLabel.TextBoxText = value;
        }

        public TextBoxWithLabel TextBoxWithLabel
        {
            get => enterTodoTextBoxWithLabel;
            set => enterTodoTextBoxWithLabel = value;
        }

        public string OkTodoButtonText
        {
            get => okTodoButton.Text;
            set => okTodoButton.Text = value;
        }

        public string CancelTodoButtonText
        {
            get => cancelTodoButton.Text;
            set => cancelTodoButton.Text = value;
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
