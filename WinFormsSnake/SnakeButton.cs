namespace WinFormsSnake
{
    public partial class SnakeButton : Button
    {
        public SnakeButton()
        {
            InitializeComponent();
            ApplyCustomSettings();
        }

        private void ApplyCustomSettings() 
        {
            FlatAppearance.BorderSize = 3;
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            FlatStyle = FlatStyle.Flat;
            Size = new Size(180, 60);
            Margin = new Padding(3, 3, 3, 30);
            
            BackColor = Color.FromName(Properties.Resources.mainBackColor);
            ForeColor = Color.FromName(Properties.Resources.mainForeColor);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
