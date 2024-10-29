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
            components = new System.ComponentModel.Container();
            ticTacToeBoardFlowLayoutPnl = new FlowLayoutPanel();
            button1 = new TicTacToeBoardButton();
            button2 = new TicTacToeBoardButton();
            button3 = new TicTacToeBoardButton();
            button4 = new TicTacToeBoardButton();
            button5 = new TicTacToeBoardButton();
            button6 = new TicTacToeBoardButton();
            button7 = new TicTacToeBoardButton();
            button8 = new TicTacToeBoardButton();
            button9 = new TicTacToeBoardButton();
            playAgainBtn = new Button();
            lineAnimationTimer = new System.Windows.Forms.Timer(components);
            ticTacToeBoardAnimationPanel = new TransparentPanel();
            playerXScorePnl = new Panel();
            playerXLbl = new Label();
            playerXScoreLbl = new Label();
            playerYScorePnl = new Panel();
            playerYScoreLbl = new Label();
            playerYLbl = new Label();
            ticTacToeBoardFlowLayoutPnl.SuspendLayout();
            playerXScorePnl.SuspendLayout();
            playerYScorePnl.SuspendLayout();
            SuspendLayout();
            // 
            // ticTacToeBoardFlowLayoutPnl
            // 
            ticTacToeBoardFlowLayoutPnl.BackColor = Color.FromArgb(64, 64, 64);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button1);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button2);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button3);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button4);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button5);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button6);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button7);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button8);
            ticTacToeBoardFlowLayoutPnl.Controls.Add(button9);
            ticTacToeBoardFlowLayoutPnl.Location = new Point(115, 211);
            ticTacToeBoardFlowLayoutPnl.Name = "ticTacToeBoardFlowLayoutPnl";
            ticTacToeBoardFlowLayoutPnl.Size = new Size(390, 390);
            ticTacToeBoardFlowLayoutPnl.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0, 0, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(128, 128);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlaceSymbol;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(131, 0);
            button2.Margin = new Padding(0, 0, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(128, 128);
            button2.TabIndex = 1;
            button2.TabStop = false;
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlaceSymbol;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(262, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(128, 128);
            button3.TabIndex = 2;
            button3.TabStop = false;
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlaceSymbol;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(0, 131);
            button4.Margin = new Padding(0, 0, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(128, 128);
            button4.TabIndex = 3;
            button4.TabStop = false;
            button4.UseCompatibleTextRendering = true;
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlaceSymbol;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(131, 131);
            button5.Margin = new Padding(0, 0, 3, 3);
            button5.Name = "button5";
            button5.Size = new Size(128, 128);
            button5.TabIndex = 4;
            button5.TabStop = false;
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlaceSymbol;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(262, 131);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(128, 128);
            button6.TabIndex = 5;
            button6.TabStop = false;
            button6.UseCompatibleTextRendering = true;
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlaceSymbol;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(0, 262);
            button7.Margin = new Padding(0, 0, 3, 0);
            button7.Name = "button7";
            button7.Size = new Size(128, 128);
            button7.TabIndex = 6;
            button7.TabStop = false;
            button7.UseCompatibleTextRendering = true;
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlaceSymbol;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Control;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Black;
            button8.Location = new Point(131, 262);
            button8.Margin = new Padding(0, 0, 3, 0);
            button8.Name = "button8";
            button8.Size = new Size(128, 128);
            button8.TabIndex = 7;
            button8.TabStop = false;
            button8.UseCompatibleTextRendering = true;
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlaceSymbol;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Control;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.Black;
            button9.Location = new Point(262, 262);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(128, 128);
            button9.TabIndex = 8;
            button9.TabStop = false;
            button9.UseCompatibleTextRendering = true;
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlaceSymbol;
            // 
            // playAgainBtn
            // 
            playAgainBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playAgainBtn.Location = new Point(213, 134);
            playAgainBtn.Name = "playAgainBtn";
            playAgainBtn.Size = new Size(195, 50);
            playAgainBtn.TabIndex = 1;
            playAgainBtn.Text = "Play Again";
            playAgainBtn.UseVisualStyleBackColor = true;
            playAgainBtn.Click += ResetGameClick;
            // 
            // lineAnimationTimer
            // 
            lineAnimationTimer.Interval = 10;
            lineAnimationTimer.Tick += AnimationFrame;
            // 
            // ticTacToeBoardAnimationPanel
            // 
            ticTacToeBoardAnimationPanel.Location = new Point(115, 211);
            ticTacToeBoardAnimationPanel.Name = "ticTacToeBoardAnimationPanel";
            ticTacToeBoardAnimationPanel.Size = new Size(390, 390);
            ticTacToeBoardAnimationPanel.TabIndex = 3;
            // 
            // playerXScorePnl
            // 
            playerXScorePnl.Controls.Add(playerXScoreLbl);
            playerXScorePnl.Controls.Add(playerXLbl);
            playerXScorePnl.Location = new Point(43, 12);
            playerXScorePnl.Name = "playerXScorePnl";
            playerXScorePnl.Size = new Size(200, 100);
            playerXScorePnl.TabIndex = 4;
            // 
            // playerXLbl
            // 
            playerXLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            playerXLbl.Location = new Point(8, 0);
            playerXLbl.Name = "playerXLbl";
            playerXLbl.Size = new Size(185, 32);
            playerXLbl.TabIndex = 5;
            playerXLbl.Text = "Player X Score:";
            // 
            // playerXScoreLbl
            // 
            playerXScoreLbl.AutoSize = true;
            playerXScoreLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            playerXScoreLbl.Location = new Point(86, 49);
            playerXScoreLbl.Name = "playerXScoreLbl";
            playerXScoreLbl.Size = new Size(28, 32);
            playerXScoreLbl.TabIndex = 6;
            playerXScoreLbl.Text = "0";
            // 
            // playerYScorePnl
            // 
            playerYScorePnl.Controls.Add(playerYScoreLbl);
            playerYScorePnl.Controls.Add(playerYLbl);
            playerYScorePnl.Location = new Point(377, 12);
            playerYScorePnl.Name = "playerYScorePnl";
            playerYScorePnl.Size = new Size(200, 100);
            playerYScorePnl.TabIndex = 7;
            // 
            // playerYScoreLbl
            // 
            playerYScoreLbl.AutoSize = true;
            playerYScoreLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            playerYScoreLbl.Location = new Point(86, 49);
            playerYScoreLbl.Name = "playerYScoreLbl";
            playerYScoreLbl.Size = new Size(28, 32);
            playerYScoreLbl.TabIndex = 6;
            playerYScoreLbl.Text = "0";
            // 
            // playerYLbl
            // 
            playerYLbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            playerYLbl.Location = new Point(8, 0);
            playerYLbl.Name = "playerYLbl";
            playerYLbl.Size = new Size(185, 32);
            playerYLbl.TabIndex = 5;
            playerYLbl.Text = "Player Y Score:";
            // 
            // TicTacToeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(620, 642);
            Controls.Add(playerYScorePnl);
            Controls.Add(playerXScorePnl);
            Controls.Add(ticTacToeBoardAnimationPanel);
            Controls.Add(playAgainBtn);
            Controls.Add(ticTacToeBoardFlowLayoutPnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicTacToeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            ticTacToeBoardFlowLayoutPnl.ResumeLayout(false);
            playerXScorePnl.ResumeLayout(false);
            playerXScorePnl.PerformLayout();
            playerYScorePnl.ResumeLayout(false);
            playerYScorePnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label testAnimationLbl;
        private FlowLayoutPanel ticTacToeBoardFlowLayoutPnl;
        private TicTacToeBoardButton button1;
        private TicTacToeBoardButton button2;
        private TicTacToeBoardButton button3;
        private TicTacToeBoardButton button4;
        private TicTacToeBoardButton button5;
        private TicTacToeBoardButton button6;
        private TicTacToeBoardButton button7;
        private TicTacToeBoardButton button8;
        private TicTacToeBoardButton button9;
        private Button playAgainBtn;
        private System.Windows.Forms.Timer lineAnimationTimer;
        private TransparentPanel ticTacToeBoardAnimationPanel;
        private Panel playerXScorePnl;
        private Label playerXLbl;
        private Label playerXScoreLbl;
        private Panel playerYScorePnl;
        private Label playerYScoreLbl;
        private Label playerYLbl;
    }
}