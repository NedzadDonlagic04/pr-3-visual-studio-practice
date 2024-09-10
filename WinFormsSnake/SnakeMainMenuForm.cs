namespace WinFormsSnake
{
    public partial class SnakeMainMenuForm : Form
    {
        public SnakeMainMenuForm()
        {
            InitializeComponent();
        }
        private void QuitGame(object sender, EventArgs e)
        {
            Close();
        }
    }
}