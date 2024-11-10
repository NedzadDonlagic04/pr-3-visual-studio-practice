namespace WinFormsTicTacToe.UserControls
{
    partial class TicTacToeScoreBoard
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
            playerScoresPnl = new Panel();
            bottomRightPnl = new Panel();
            bottomLeftPnl = new Panel();
            topPnl = new Panel();
            scoresLbl = new Label();
            oPnl = new Panel();
            oScorePnl = new Panel();
            xPnl = new Panel();
            xScorePnl = new Panel();
            xScoreLbl = new Label();
            oScoreLbl = new Label();
            oLbl = new Label();
            xLbl = new Label();
            playerScoresPnl.SuspendLayout();
            bottomRightPnl.SuspendLayout();
            bottomLeftPnl.SuspendLayout();
            topPnl.SuspendLayout();
            oPnl.SuspendLayout();
            oScorePnl.SuspendLayout();
            xPnl.SuspendLayout();
            xScorePnl.SuspendLayout();
            SuspendLayout();
            // 
            // playerScoresPnl
            // 
            playerScoresPnl.BackColor = Color.Black;
            playerScoresPnl.BackgroundImageLayout = ImageLayout.Zoom;
            playerScoresPnl.BorderStyle = BorderStyle.FixedSingle;
            playerScoresPnl.Controls.Add(bottomRightPnl);
            playerScoresPnl.Controls.Add(bottomLeftPnl);
            playerScoresPnl.Controls.Add(topPnl);
            playerScoresPnl.Location = new Point(0, 0);
            playerScoresPnl.Margin = new Padding(0);
            playerScoresPnl.Name = "playerScoresPnl";
            playerScoresPnl.Padding = new Padding(3);
            playerScoresPnl.Size = new Size(250, 200);
            playerScoresPnl.TabIndex = 3;
            // 
            // bottomRightPnl
            // 
            bottomRightPnl.BackColor = Color.Black;
            bottomRightPnl.Controls.Add(oScorePnl);
            bottomRightPnl.Controls.Add(oPnl);
            bottomRightPnl.Location = new Point(128, 82);
            bottomRightPnl.Name = "bottomRightPnl";
            bottomRightPnl.Size = new Size(115, 110);
            bottomRightPnl.TabIndex = 2;
            // 
            // bottomLeftPnl
            // 
            bottomLeftPnl.BackColor = Color.Black;
            bottomLeftPnl.Controls.Add(xScorePnl);
            bottomLeftPnl.Controls.Add(xPnl);
            bottomLeftPnl.Location = new Point(6, 82);
            bottomLeftPnl.Name = "bottomLeftPnl";
            bottomLeftPnl.Size = new Size(115, 110);
            bottomLeftPnl.TabIndex = 1;
            // 
            // topPnl
            // 
            topPnl.BackColor = SystemColors.Control;
            topPnl.Controls.Add(scoresLbl);
            topPnl.Location = new Point(6, 6);
            topPnl.Name = "topPnl";
            topPnl.Size = new Size(236, 70);
            topPnl.TabIndex = 0;
            // 
            // scoresLbl
            // 
            scoresLbl.AutoSize = true;
            scoresLbl.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoresLbl.Location = new Point(55, 12);
            scoresLbl.Name = "scoresLbl";
            scoresLbl.Size = new Size(126, 47);
            scoresLbl.TabIndex = 0;
            scoresLbl.Text = "Scores";
            scoresLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oPnl
            // 
            oPnl.BackColor = SystemColors.Control;
            oPnl.Controls.Add(oLbl);
            oPnl.Location = new Point(0, 0);
            oPnl.Margin = new Padding(0);
            oPnl.Name = "oPnl";
            oPnl.Size = new Size(115, 55);
            oPnl.TabIndex = 0;
            // 
            // oScorePnl
            // 
            oScorePnl.BackColor = Color.WhiteSmoke;
            oScorePnl.Controls.Add(oScoreLbl);
            oScorePnl.Location = new Point(0, 57);
            oScorePnl.Margin = new Padding(0);
            oScorePnl.Name = "oScorePnl";
            oScorePnl.Size = new Size(115, 53);
            oScorePnl.TabIndex = 1;
            // 
            // xPnl
            // 
            xPnl.BackColor = SystemColors.Control;
            xPnl.Controls.Add(xLbl);
            xPnl.Location = new Point(0, 0);
            xPnl.Margin = new Padding(0);
            xPnl.Name = "xPnl";
            xPnl.Size = new Size(115, 55);
            xPnl.TabIndex = 1;
            // 
            // xScorePnl
            // 
            xScorePnl.BackColor = Color.WhiteSmoke;
            xScorePnl.Controls.Add(xScoreLbl);
            xScorePnl.Location = new Point(0, 57);
            xScorePnl.Margin = new Padding(0);
            xScorePnl.Name = "xScorePnl";
            xScorePnl.Size = new Size(115, 53);
            xScorePnl.TabIndex = 2;
            // 
            // xScoreLbl
            // 
            xScoreLbl.Dock = DockStyle.Fill;
            xScoreLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            xScoreLbl.Location = new Point(0, 0);
            xScoreLbl.Name = "xScoreLbl";
            xScoreLbl.Size = new Size(115, 53);
            xScoreLbl.TabIndex = 0;
            xScoreLbl.Text = "0";
            xScoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oScoreLbl
            // 
            oScoreLbl.Dock = DockStyle.Fill;
            oScoreLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            oScoreLbl.Location = new Point(0, 0);
            oScoreLbl.Name = "oScoreLbl";
            oScoreLbl.Size = new Size(115, 53);
            oScoreLbl.TabIndex = 1;
            oScoreLbl.Text = "0";
            oScoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oLbl
            // 
            oLbl.Dock = DockStyle.Fill;
            oLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            oLbl.Location = new Point(0, 0);
            oLbl.Name = "oLbl";
            oLbl.Size = new Size(115, 55);
            oLbl.TabIndex = 2;
            oLbl.Text = "O";
            oLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // xLbl
            // 
            xLbl.Dock = DockStyle.Fill;
            xLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            xLbl.Location = new Point(0, 0);
            xLbl.Name = "xLbl";
            xLbl.Size = new Size(115, 55);
            xLbl.TabIndex = 3;
            xLbl.Text = "X";
            xLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TicTacToePlayerScoresTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(playerScoresPnl);
            Name = "TicTacToePlayerScoresTracker";
            Size = new Size(250, 200);
            playerScoresPnl.ResumeLayout(false);
            bottomRightPnl.ResumeLayout(false);
            bottomLeftPnl.ResumeLayout(false);
            topPnl.ResumeLayout(false);
            topPnl.PerformLayout();
            oPnl.ResumeLayout(false);
            oScorePnl.ResumeLayout(false);
            xPnl.ResumeLayout(false);
            xScorePnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel playerScoresPnl;
        private Panel bottomRightPnl;
        private Panel bottomLeftPnl;
        private Panel topPnl;
        private Label scoresLbl;
        private Panel oScorePnl;
        private Panel oPnl;
        private Panel xScorePnl;
        private Panel xPnl;
        private Label xScoreLbl;
        private Label oScoreLbl;
        private Label oLbl;
        private Label xLbl;
    }
}
