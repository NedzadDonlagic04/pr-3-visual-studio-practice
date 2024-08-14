namespace WinFormsTodoList
{
    public partial class TextBoxWithLabel
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
            textBoxLabel = new Label();
            textBox = new TextBox();
            characterCountLabel = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxLabel
            // 
            textBoxLabel.AutoSize = true;
            textBoxLabel.Dock = DockStyle.Top;
            textBoxLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxLabel.Location = new Point(0, 0);
            textBoxLabel.Name = "textBoxLabel";
            textBoxLabel.Size = new Size(72, 30);
            textBoxLabel.TabIndex = 0;
            textBoxLabel.Text = "label1";
            // 
            // textBox
            // 
            textBox.Dock = DockStyle.Top;
            textBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox.Location = new Point(0, 30);
            textBox.Name = "textBox";
            textBox.Size = new Size(291, 35);
            textBox.TabIndex = 1;
            // 
            // characterCountLabel
            // 
            characterCountLabel.AutoSize = true;
            characterCountLabel.Dock = DockStyle.Top;
            characterCountLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            characterCountLabel.Location = new Point(0, 65);
            characterCountLabel.Name = "characterCountLabel";
            characterCountLabel.Size = new Size(51, 20);
            characterCountLabel.TabIndex = 2;
            characterCountLabel.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(characterCountLabel);
            panel1.Controls.Add(textBox);
            panel1.Controls.Add(textBoxLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 88);
            panel1.TabIndex = 3;
            // 
            // TextBoxWithLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TextBoxWithLabel";
            Size = new Size(291, 88);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label textBoxLabel;
        private TextBox textBox;
        private Label characterCountLabel;
        private Panel panel1;
    }
}
