namespace WinFormsTetris.Forms
{
    partial class HighScoresFrm
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
            highScoresLbl = new Label();
            highScoresDgv = new DataGridView();
            Pos = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            LinesCleared = new DataGridViewTextBoxColumn();
            DateAndTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)highScoresDgv).BeginInit();
            SuspendLayout();
            // 
            // highScoresLbl
            // 
            highScoresLbl.AutoSize = true;
            highScoresLbl.BackColor = Color.Transparent;
            highScoresLbl.Font = new Font("Segoe UI", 48F, FontStyle.Bold);
            highScoresLbl.ForeColor = Color.WhiteSmoke;
            highScoresLbl.Location = new Point(155, 28);
            highScoresLbl.Name = "highScoresLbl";
            highScoresLbl.Size = new Size(491, 106);
            highScoresLbl.TabIndex = 4;
            highScoresLbl.Text = "High Scores";
            highScoresLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // highScoresDgv
            // 
            highScoresDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            highScoresDgv.Columns.AddRange(new DataGridViewColumn[] { Pos, Score, LinesCleared, DateAndTime });
            highScoresDgv.Location = new Point(12, 148);
            highScoresDgv.Name = "highScoresDgv";
            highScoresDgv.RowHeadersWidth = 51;
            highScoresDgv.ScrollBars = ScrollBars.Horizontal;
            highScoresDgv.Size = new Size(776, 316);
            highScoresDgv.TabIndex = 5;
            highScoresDgv.SelectionChanged += HighScoresDgvSelectionChanged;
            // 
            // Pos
            // 
            Pos.DataPropertyName = "Pos";
            Pos.HeaderText = "";
            Pos.MinimumWidth = 6;
            Pos.Name = "Pos";
            Pos.Width = 125;
            // 
            // Score
            // 
            Score.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Score.DataPropertyName = "Score";
            Score.HeaderText = "Score";
            Score.MinimumWidth = 6;
            Score.Name = "Score";
            // 
            // LinesCleared
            // 
            LinesCleared.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LinesCleared.DataPropertyName = "LinesCleared";
            LinesCleared.HeaderText = "Lines cleared";
            LinesCleared.MinimumWidth = 6;
            LinesCleared.Name = "LinesCleared";
            // 
            // DateAndTime
            // 
            DateAndTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateAndTime.DataPropertyName = "DateTime";
            DateAndTime.HeaderText = "Date and time";
            DateAndTime.MinimumWidth = 6;
            DateAndTime.Name = "DateAndTime";
            // 
            // HighScoresFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource.tetris_bg_purple;
            ClientSize = new Size(800, 476);
            Controls.Add(highScoresDgv);
            Controls.Add(highScoresLbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HighScoresFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "High Scores";
            Load += HighScoresFormLoad;
            ((System.ComponentModel.ISupportInitialize)highScoresDgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label highScoresLbl;
        private DataGridView highScoresDgv;
        private DataGridViewTextBoxColumn Pos;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn LinesCleared;
        private DataGridViewTextBoxColumn DateAndTime;
    }
}