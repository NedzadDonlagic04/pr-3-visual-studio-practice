namespace WinFormsTodoList
{
    public partial class PromptInputForm : Form
    {
        public string EnteredText { get; set; } = "";

        public PromptInputForm()
        {
            InitializeComponent();
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
            EnteredText = enterTodoTextBoxWithLabel.TextBoxText;
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
