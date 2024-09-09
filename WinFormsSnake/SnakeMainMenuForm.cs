namespace WinFormsSnake
{
    public partial class SnakeMainMenuForm : Form
    {
        public SnakeMainMenuForm()
        {
            InitializeComponent();
            ApplyCustomSettings();
        }

        private void ApplyCustomSettings()
        {
            BackColor = Color.FromName(Properties.Resources.mainBackColor);
            ForeColor = Color.FromName(Properties.Resources.mainForeColor);
        }

        private void QuitGame(object sender, EventArgs e)
        {
            Close();
        }
    }
}