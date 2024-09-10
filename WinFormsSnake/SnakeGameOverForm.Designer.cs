namespace WinFormsSnake
{
    partial class SnakeGameOverForm
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
            playAgainSnakeButton = new SnakeButton();
            quitSnakeButton = new SnakeButton();
            mainMenuSnakeButton = new SnakeButton();
            SuspendLayout();
            // 
            // playAgainSnakeButton
            // 
            playAgainSnakeButton.BackColor = Color.GreenYellow;
            playAgainSnakeButton.FlatAppearance.BorderSize = 3;
            playAgainSnakeButton.FlatStyle = FlatStyle.Flat;
            playAgainSnakeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            playAgainSnakeButton.ForeColor = Color.ForestGreen;
            playAgainSnakeButton.Location = new Point(262, 193);
            playAgainSnakeButton.Margin = new Padding(3, 3, 3, 30);
            playAgainSnakeButton.Name = "playAgainSnakeButton";
            playAgainSnakeButton.Size = new Size(180, 60);
            playAgainSnakeButton.TabIndex = 0;
            playAgainSnakeButton.Text = "Play Again";
            playAgainSnakeButton.UseVisualStyleBackColor = false;
            // 
            // quitSnakeButton
            // 
            quitSnakeButton.BackColor = Color.GreenYellow;
            quitSnakeButton.FlatAppearance.BorderSize = 3;
            quitSnakeButton.FlatStyle = FlatStyle.Flat;
            quitSnakeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            quitSnakeButton.ForeColor = Color.ForestGreen;
            quitSnakeButton.Location = new Point(262, 379);
            quitSnakeButton.Margin = new Padding(3, 3, 3, 30);
            quitSnakeButton.Name = "quitSnakeButton";
            quitSnakeButton.Size = new Size(180, 60);
            quitSnakeButton.TabIndex = 1;
            quitSnakeButton.Text = "Quit";
            quitSnakeButton.UseVisualStyleBackColor = false;
            quitSnakeButton.Click += QuitGame;
            // 
            // mainMenuSnakeButton
            // 
            mainMenuSnakeButton.BackColor = Color.GreenYellow;
            mainMenuSnakeButton.FlatAppearance.BorderSize = 3;
            mainMenuSnakeButton.FlatStyle = FlatStyle.Flat;
            mainMenuSnakeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            mainMenuSnakeButton.ForeColor = Color.ForestGreen;
            mainMenuSnakeButton.Location = new Point(262, 286);
            mainMenuSnakeButton.Margin = new Padding(3, 3, 3, 30);
            mainMenuSnakeButton.Name = "mainMenuSnakeButton";
            mainMenuSnakeButton.Size = new Size(180, 60);
            mainMenuSnakeButton.TabIndex = 2;
            mainMenuSnakeButton.Text = "Main Menu";
            mainMenuSnakeButton.UseVisualStyleBackColor = false;
            // 
            // SnakeGameOverForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gameOverBackgroundImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 461);
            Controls.Add(mainMenuSnakeButton);
            Controls.Add(quitSnakeButton);
            Controls.Add(playAgainSnakeButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SnakeGameOverForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake Game Over";
            ResumeLayout(false);
        }

        #endregion

        private SnakeButton playAgainSnakeButton;
        private SnakeButton quitSnakeButton;
        private SnakeButton mainMenuSnakeButton;
    }
}