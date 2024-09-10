namespace WinFormsSnake
{
    partial class SnakeGameplayForm
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
            gameOverSnakeButton = new SnakeButton();
            SuspendLayout();
            // 
            // gameOverSnakeButton
            // 
            gameOverSnakeButton.BackColor = Color.GreenYellow;
            gameOverSnakeButton.FlatAppearance.BorderSize = 3;
            gameOverSnakeButton.FlatStyle = FlatStyle.Flat;
            gameOverSnakeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverSnakeButton.ForeColor = Color.ForestGreen;
            gameOverSnakeButton.Location = new Point(310, 195);
            gameOverSnakeButton.Margin = new Padding(3, 3, 3, 30);
            gameOverSnakeButton.Name = "gameOverSnakeButton";
            gameOverSnakeButton.Size = new Size(180, 60);
            gameOverSnakeButton.TabIndex = 0;
            gameOverSnakeButton.Text = "Game Over";
            gameOverSnakeButton.UseVisualStyleBackColor = false;
            gameOverSnakeButton.Click += QuitGame;
            // 
            // SnakeGameplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gameOverSnakeButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SnakeGameplayForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake Gameplay";
            Shown += FormShownEvent;
            ResumeLayout(false);
        }

        #endregion

        private SnakeButton gameOverSnakeButton;
    }
}