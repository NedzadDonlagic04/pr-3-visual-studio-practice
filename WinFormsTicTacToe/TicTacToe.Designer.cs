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
            ticTacToeBoard = new UserControls.TicTacToeBoard();
            resetGameBtn = new Button();
            gameConfigPnl = new Panel();
            ticTacToePlayerScoresTracker = new UserControls.TicTacToePlayerScoresTracker();
            optionsBtn = new Button();
            resultLbl = new Label();
            resultPnl = new Panel();
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
            gameConfigPnl.Controls.Add(resultPnl);
            gameConfigPnl.Controls.Add(optionsBtn);
            gameConfigPnl.Controls.Add(ticTacToePlayerScoresTracker);
            gameConfigPnl.Controls.Add(resetGameBtn);
            gameConfigPnl.Location = new Point(408, 12);
            gameConfigPnl.Name = "gameConfigPnl";
            gameConfigPnl.Size = new Size(390, 390);
            gameConfigPnl.TabIndex = 2;
            // 
            // ticTacToePlayerScoresTracker
            // 
            ticTacToePlayerScoresTracker.Location = new Point(81, 187);
            ticTacToePlayerScoresTracker.Name = "ticTacToePlayerScoresTracker";
            ticTacToePlayerScoresTracker.Size = new Size(250, 200);
            ticTacToePlayerScoresTracker.TabIndex = 2;
            // 
            // optionsBtn
            // 
            optionsBtn.AutoSize = true;
            optionsBtn.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            optionsBtn.Location = new Point(81, 69);
            optionsBtn.Name = "optionsBtn";
            optionsBtn.Size = new Size(252, 50);
            optionsBtn.TabIndex = 3;
            optionsBtn.Text = "Options";
            optionsBtn.UseVisualStyleBackColor = true;
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
            // resultPnl
            // 
            resultPnl.Controls.Add(resultLbl);
            resultPnl.Location = new Point(81, 131);
            resultPnl.Name = "resultPnl";
            resultPnl.Size = new Size(252, 50);
            resultPnl.TabIndex = 5;
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

        private UserControls.TicTacToeBoard ticTacToeBoard;
        private Button resetGameBtn;
        private Panel gameConfigPnl;
        private UserControls.TicTacToePlayerScoresTracker ticTacToePlayerScoresTracker;
        private Panel resultPnl;
        private Label resultLbl;
        private Button optionsBtn;
    }
}