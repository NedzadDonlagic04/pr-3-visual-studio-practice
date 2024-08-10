namespace WinFormsTodoList
{
    partial class PanelWithButtonInside
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            button = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.AutoSize = true;
            panel.BackColor = SystemColors.Control;
            panel.Controls.Add(button);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Padding = new Padding(20);
            panel.Size = new Size(192, 103);
            panel.TabIndex = 0;
            panel.Resize += Panel_Resize;
            // 
            // button
            // 
            button.Anchor = AnchorStyles.None;
            button.AutoSize = true;
            button.Location = new Point(46, 19);
            button.MaximumSize = new Size(300, 0);
            button.MinimumSize = new Size(100, 0);
            button.Name = "button";
            button.Padding = new Padding(20);
            button.Size = new Size(100, 65);
            button.TabIndex = 0;
            button.UseVisualStyleBackColor = true;
            // 
            // PanelWithButtonInside
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Margin = new Padding(0);
            Name = "PanelWithButtonInside";
            Size = new Size(192, 103);
            Load += PanelWithButtonInside_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button button;
    }
}
