using System.ComponentModel;

namespace WinFormsTodoList
{
    public partial class PanelWithButtonInside : UserControl
    {
        public PanelWithButtonInside()
        {
            InitializeComponent();
            ResizeAndRelocatedButton();
        }

        private void ResizeAndRelocatedButton()
        {
            button.Width = panel.Width - panel.Padding.Left - panel.Padding.Right;
            button.Left = (panel.Width - button.Width) / 2;
        }

        [DefaultValue("")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => button.Text;
            set => button.Text = value;
        }

        [DefaultValue(typeof(Padding))]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Padding PanelPadding
        {
            get => panel.Padding;
            set => panel.Padding = value;
        }

        [DefaultValue(typeof(Padding))]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Padding ButtonPadding
        {
            get => button.Padding;
            set => button.Padding = value;
        }

        private void Panel_Resize(object sender, EventArgs e)
        {
            ResizeAndRelocatedButton();
        }

        private void PanelWithButtonInside_Load(object sender, EventArgs e)
        {
            ResizeAndRelocatedButton();
        }

        public new event EventHandler Click {
            add {
                button.Click += value;
            }
            remove {
                button.Click -= value;
            }
        }
    }
}
