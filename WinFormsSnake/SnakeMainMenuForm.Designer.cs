namespace WinFormsSnake
{
    partial class SnakeMainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            playSnakeButton = new SnakeButton();
            highScoresSnakeButton = new SnakeButton();
            quitSnakeButton = new SnakeButton();
            SuspendLayout();
            // 
            // playSnakeButton
            // 
            playSnakeButton.BackColor = Color.GreenYellow;
            playSnakeButton.FlatAppearance.BorderSize = 3;
            playSnakeButton.FlatStyle = FlatStyle.Flat;
            playSnakeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            playSnakeButton.ForeColor = Color.ForestGreen;
            playSnakeButton.Location = new Point(310, 172);
            playSnakeButton.Margin = new Padding(3, 3, 3, 30);
            playSnakeButton.Name = "playSnakeButton";
            playSnakeButton.Size = new Size(180, 60);
            playSnakeButton.TabIndex = 0;
            playSnakeButton.Text = "Play";
            playSnakeButton.UseVisualStyleBackColor = false;
            // 
            // highScoresSnakeButton
            // 
            highScoresSnakeButton.BackColor = Color.GreenYellow;
            highScoresSnakeButton.FlatAppearance.BorderSize = 3;
            highScoresSnakeButton.FlatStyle = FlatStyle.Flat;
            highScoresSnakeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            highScoresSnakeButton.ForeColor = Color.ForestGreen;
            highScoresSnakeButton.Location = new Point(310, 265);
            highScoresSnakeButton.Margin = new Padding(3, 3, 3, 30);
            highScoresSnakeButton.Name = "highScoresSnakeButton";
            highScoresSnakeButton.Size = new Size(180, 60);
            highScoresSnakeButton.TabIndex = 1;
            highScoresSnakeButton.Text = "High Scores";
            highScoresSnakeButton.UseVisualStyleBackColor = false;
            // 
            // quitSnakeButton
            // 
            quitSnakeButton.BackColor = Color.GreenYellow;
            quitSnakeButton.FlatAppearance.BorderSize = 3;
            quitSnakeButton.FlatStyle = FlatStyle.Flat;
            quitSnakeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            quitSnakeButton.ForeColor = Color.ForestGreen;
            quitSnakeButton.Location = new Point(310, 358);
            quitSnakeButton.Margin = new Padding(3, 3, 3, 30);
            quitSnakeButton.Name = "quitSnakeButton";
            quitSnakeButton.Size = new Size(180, 60);
            quitSnakeButton.TabIndex = 2;
            quitSnakeButton.Text = "Quit";
            quitSnakeButton.UseVisualStyleBackColor = false;
            // 
            // SnakeMainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.mainMenuBackgroundImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(quitSnakeButton);
            Controls.Add(highScoresSnakeButton);
            Controls.Add(playSnakeButton);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "SnakeMainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private SnakeButton playSnakeButton;
        private SnakeButton highScoresSnakeButton;
        private SnakeButton quitSnakeButton;
    }
}