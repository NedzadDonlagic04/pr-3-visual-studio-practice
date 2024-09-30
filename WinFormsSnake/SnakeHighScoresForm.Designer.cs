namespace WinFormsSnake
{
    partial class SnakeHighScoresForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            goToMainMenuSnakeButton = new SnakeButton();
            highScoresListBox = new ListBox();
            SuspendLayout();
            // 
            // goToMainMenuSnakeButton
            // 
            goToMainMenuSnakeButton.BackColor = Color.GreenYellow;
            goToMainMenuSnakeButton.FlatAppearance.BorderSize = 3;
            goToMainMenuSnakeButton.FlatStyle = FlatStyle.Flat;
            goToMainMenuSnakeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            goToMainMenuSnakeButton.ForeColor = Color.ForestGreen;
            goToMainMenuSnakeButton.Location = new Point(312, 389);
            goToMainMenuSnakeButton.Margin = new Padding(3, 3, 3, 30);
            goToMainMenuSnakeButton.Name = "goToMainMenuSnakeButton";
            goToMainMenuSnakeButton.Size = new Size(180, 60);
            goToMainMenuSnakeButton.TabIndex = 0;
            goToMainMenuSnakeButton.Text = "Main Menu";
            goToMainMenuSnakeButton.UseVisualStyleBackColor = false;
            goToMainMenuSnakeButton.Click += GoToMainMenu;
            // 
            // highScoresListBox
            // 
            highScoresListBox.BackColor = Color.GreenYellow;
            highScoresListBox.BorderStyle = BorderStyle.FixedSingle;
            highScoresListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            highScoresListBox.ForeColor = Color.ForestGreen;
            highScoresListBox.FormattingEnabled = true;
            highScoresListBox.ItemHeight = 30;
            highScoresListBox.Location = new Point(90, 157);
            highScoresListBox.Name = "highScoresListBox";
            highScoresListBox.Size = new Size(624, 212);
            highScoresListBox.TabIndex = 1;
            // 
            // SnakeHighScoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.highScoresBackgroundImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(804, 461);
            Controls.Add(highScoresListBox);
            Controls.Add(goToMainMenuSnakeButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SnakeHighScoresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake High Scores";
            ResumeLayout(false);
        }

        #endregion

        private SnakeButton goToMainMenuSnakeButton;
        private ListBox highScoresListBox;
    }
}