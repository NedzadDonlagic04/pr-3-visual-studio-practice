using WinFormsTicTacToe.CustomControls;

namespace WinFormsTicTacToe
{
    partial class TicTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeForm));
            ticTacToeBoard = new UserControls.TicTacToeBoardDisplay();
            ticTacToeScoreBoard = new UserControls.TicTacToeScoreBoard();
            resetGameBtn = new Button();
            gameConfigPnl = new Panel();
            resultPnl = new Panel();
            resultLbl = new Label();
            settingsBtn = new Button();
            gameConfigPnl.SuspendLayout();
            resultPnl.SuspendLayout();
            SuspendLayout();
            // 
            // ticTacToeBoard
            // 
            ticTacToeBoard.BackColor = Color.Black;
            ticTacToeBoard.Location = new Point(12, 12);
            ticTacToeBoard.Name = "ticTacToeBoard";
            ticTacToeBoard.Size = new Size(390, 390);
            ticTacToeBoard.TabIndex = 0;
            ticTacToeBoard.OnGameOver += UpdatePlayerScore;
            // 
            // resetGameBtn
            // 
            resetGameBtn.AutoSize = true;
            resetGameBtn.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            resetGameBtn.Location = new Point(81, 3);
            resetGameBtn.Name = "resetGameBtn";
            resetGameBtn.Size = new Size(250, 50);
            resetGameBtn.TabIndex = 1;
            resetGameBtn.Text = "Reset Game";
            resetGameBtn.UseVisualStyleBackColor = true;
            resetGameBtn.Click += ResetGameClick;
            // 
            // gameConfigPnl
            // 
            gameConfigPnl.Controls.Add(ticTacToeScoreBoard);
            gameConfigPnl.Controls.Add(resultPnl);
            gameConfigPnl.Controls.Add(settingsBtn);
            gameConfigPnl.Controls.Add(resetGameBtn);
            gameConfigPnl.Location = new Point(408, 12);
            gameConfigPnl.Name = "gameConfigPnl";
            gameConfigPnl.Size = new Size(390, 390);
            gameConfigPnl.TabIndex = 2;
            // 
            // resultPnl
            // 
            resultPnl.Controls.Add(resultLbl);
            resultPnl.Location = new Point(81, 131);
            resultPnl.Name = "resultPnl";
            resultPnl.Size = new Size(252, 50);
            resultPnl.TabIndex = 5;
            // 
            // resultLbl
            // 
            resultLbl.Dock = DockStyle.Fill;
            resultLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            resultLbl.Location = new Point(0, 0);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(252, 50);
            resultLbl.TabIndex = 4;
            resultLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // settingsBtn
            // 
            settingsBtn.AutoSize = true;
            settingsBtn.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            settingsBtn.Location = new Point(81, 69);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(252, 50);
            settingsBtn.TabIndex = 3;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += OpenSettingsForm;
            // 
            // ticTacToeScoreBoard
            // 
            ticTacToeScoreBoard.Location = new Point(83, 184);
            ticTacToeScoreBoard.Name = "ticTacToeScoreBoard";
            ticTacToeScoreBoard.Size = new Size(250, 200);
            ticTacToeScoreBoard.TabIndex = 6;
            // 
            // TicTacToeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(810, 414);
            Controls.Add(gameConfigPnl);
            Controls.Add(ticTacToeBoard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicTacToeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            gameConfigPnl.ResumeLayout(false);
            gameConfigPnl.PerformLayout();
            resultPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UserControls.TicTacToeBoardDisplay ticTacToeBoard;
        private Button resetGameBtn;
        private Panel gameConfigPnl;
        private Panel resultPnl;
        private Label resultLbl;
        private Button settingsBtn;
        private UserControls.TicTacToeScoreBoard ticTacToeScoreBoard;
    }
}