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
            playBtn = new Button();
            checkGameHistoryBtn = new Button();
            quitBtn = new Button();
            SuspendLayout();
            // 
            // playBtn
            // 
            playBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            playBtn.Location = new Point(310, 131);
            playBtn.Margin = new Padding(3, 3, 3, 30);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(180, 60);
            playBtn.TabIndex = 0;
            playBtn.Text = "Play";
            playBtn.UseVisualStyleBackColor = true;
            // 
            // checkGameHistoryBtn
            // 
            checkGameHistoryBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            checkGameHistoryBtn.Location = new Point(310, 224);
            checkGameHistoryBtn.Margin = new Padding(3, 3, 3, 30);
            checkGameHistoryBtn.Name = "checkGameHistoryBtn";
            checkGameHistoryBtn.Size = new Size(180, 60);
            checkGameHistoryBtn.TabIndex = 1;
            checkGameHistoryBtn.Text = "Games History";
            checkGameHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // quitBtn
            // 
            quitBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.Location = new Point(310, 317);
            quitBtn.Margin = new Padding(3, 3, 3, 30);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(180, 60);
            quitBtn.TabIndex = 2;
            quitBtn.Text = "Quit";
            quitBtn.UseVisualStyleBackColor = true;
            // 
            // SnakeMainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(quitBtn);
            Controls.Add(checkGameHistoryBtn);
            Controls.Add(playBtn);
            MaximizeBox = false;
            Name = "SnakeMainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake Main Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button playBtn;
        private Button checkGameHistoryBtn;
        private Button quitBtn;
    }
}