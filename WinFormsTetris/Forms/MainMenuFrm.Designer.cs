namespace WinFormsTetris.Forms
{
    partial class MainMenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuFrm));
            playBtn = new Button();
            highScoresBtn = new Button();
            quitBtn = new Button();
            tetrisLbl = new Label();
            SuspendLayout();
            // 
            // playBtn
            // 
            playBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            playBtn.Location = new Point(227, 164);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(178, 49);
            playBtn.TabIndex = 0;
            playBtn.Text = "Play";
            playBtn.UseVisualStyleBackColor = true;
            playBtn.Click += PlayBtnClick;
            // 
            // highScoresBtn
            // 
            highScoresBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            highScoresBtn.Location = new Point(227, 241);
            highScoresBtn.Name = "highScoresBtn";
            highScoresBtn.Size = new Size(178, 49);
            highScoresBtn.TabIndex = 1;
            highScoresBtn.Text = "High scores";
            highScoresBtn.UseVisualStyleBackColor = true;
            highScoresBtn.Click += HighScoresBtnClick;
            // 
            // quitBtn
            // 
            quitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            quitBtn.Location = new Point(227, 316);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(178, 49);
            quitBtn.TabIndex = 2;
            quitBtn.Text = "Quit";
            quitBtn.UseVisualStyleBackColor = true;
            quitBtn.Click += QuitBtnClick;
            // 
            // tetrisLbl
            // 
            tetrisLbl.AutoSize = true;
            tetrisLbl.BackColor = Color.Transparent;
            tetrisLbl.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            tetrisLbl.ForeColor = Color.WhiteSmoke;
            tetrisLbl.Location = new Point(192, 18);
            tetrisLbl.Name = "tetrisLbl";
            tetrisLbl.Size = new Size(249, 106);
            tetrisLbl.TabIndex = 3;
            tetrisLbl.Text = "Tetris";
            // 
            // MainMenuFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource.tetris_bg_purple;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(632, 413);
            Controls.Add(tetrisLbl);
            Controls.Add(quitBtn);
            Controls.Add(highScoresBtn);
            Controls.Add(playBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenuFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playBtn;
        private Button highScoresBtn;
        private Button quitBtn;
        private Label tetrisLbl;
    }
}