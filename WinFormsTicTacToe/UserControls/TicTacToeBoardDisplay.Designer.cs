using WinFormsTicTacToe.CustomControls;

namespace WinFormsTicTacToe.UserControls
{
    partial class TicTacToeBoardDisplay
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
            ticTacToeBoardTilesFlwLytPnl = new FlowLayoutPanel();
            lineAnimationPnl = new CustomControls.LineAnimationPanel();
            ticTacToeBoardTile0 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTile1 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTile2 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTile3 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTile4 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTile5 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTile6 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTile7 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTile8 = new CustomControls.TicTacToeBoardTile();
            ticTacToeBoardTilesFlwLytPnl.SuspendLayout();
            SuspendLayout();
            // 
            // ticTacToeBoardTilesFlwLytPnl
            // 
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile0);
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile1);
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile2);
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile3);
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile4);
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile5);
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile6);
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile7);
            ticTacToeBoardTilesFlwLytPnl.Controls.Add(ticTacToeBoardTile8);
            ticTacToeBoardTilesFlwLytPnl.Location = new Point(0, 0);
            ticTacToeBoardTilesFlwLytPnl.Margin = new Padding(0);
            ticTacToeBoardTilesFlwLytPnl.Name = "ticTacToeBoardTilesFlwLytPnl";
            ticTacToeBoardTilesFlwLytPnl.Size = new Size(390, 390);
            ticTacToeBoardTilesFlwLytPnl.TabIndex = 0;
            // 
            // ticTacToeBoardTile0
            // 
            ticTacToeBoardTile0.BackColor = Color.White;
            ticTacToeBoardTile0.Location = new Point(0, 0);
            ticTacToeBoardTile0.Margin = new Padding(0, 0, 3, 0);
            ticTacToeBoardTile0.Name = "ticTacToeBoardTile0";
            ticTacToeBoardTile0.Size = new Size(128, 128);
            ticTacToeBoardTile0.Symbol = 'X';
            ticTacToeBoardTile0.TabIndex = 9;
            ticTacToeBoardTile0.Click += PlayerMove;
            // 
            // ticTacToeBoardTile1
            // 
            ticTacToeBoardTile1.BackColor = Color.White;
            ticTacToeBoardTile1.Location = new Point(131, 0);
            ticTacToeBoardTile1.Margin = new Padding(0, 0, 3, 0);
            ticTacToeBoardTile1.Name = "ticTacToeBoardTile1";
            ticTacToeBoardTile1.Size = new Size(128, 128);
            ticTacToeBoardTile1.Symbol = 'X';
            ticTacToeBoardTile1.TabIndex = 10;
            ticTacToeBoardTile1.Click += PlayerMove;
            // 
            // ticTacToeBoardTile2
            // 
            ticTacToeBoardTile2.BackColor = Color.White;
            ticTacToeBoardTile2.Location = new Point(262, 0);
            ticTacToeBoardTile2.Margin = new Padding(0);
            ticTacToeBoardTile2.Name = "ticTacToeBoardTile2";
            ticTacToeBoardTile2.Size = new Size(128, 128);
            ticTacToeBoardTile2.Symbol = 'X';
            ticTacToeBoardTile2.TabIndex = 11;
            ticTacToeBoardTile2.Click += PlayerMove;
            // 
            // ticTacToeBoardTile3
            // 
            ticTacToeBoardTile3.BackColor = Color.White;
            ticTacToeBoardTile3.Location = new Point(0, 131);
            ticTacToeBoardTile3.Margin = new Padding(0, 3, 3, 3);
            ticTacToeBoardTile3.Name = "ticTacToeBoardTile3";
            ticTacToeBoardTile3.Size = new Size(128, 128);
            ticTacToeBoardTile3.Symbol = 'X';
            ticTacToeBoardTile3.TabIndex = 12;
            ticTacToeBoardTile3.Click += PlayerMove;
            // 
            // ticTacToeBoardTile4
            // 
            ticTacToeBoardTile4.BackColor = Color.White;
            ticTacToeBoardTile4.Location = new Point(131, 131);
            ticTacToeBoardTile4.Margin = new Padding(0, 3, 3, 3);
            ticTacToeBoardTile4.Name = "ticTacToeBoardTile4";
            ticTacToeBoardTile4.Size = new Size(128, 128);
            ticTacToeBoardTile4.Symbol = 'X';
            ticTacToeBoardTile4.TabIndex = 13;
            ticTacToeBoardTile4.Click += PlayerMove;
            // 
            // ticTacToeBoardTile5
            // 
            ticTacToeBoardTile5.BackColor = Color.White;
            ticTacToeBoardTile5.Location = new Point(262, 131);
            ticTacToeBoardTile5.Margin = new Padding(0, 3, 0, 3);
            ticTacToeBoardTile5.Name = "ticTacToeBoardTile5";
            ticTacToeBoardTile5.Size = new Size(128, 128);
            ticTacToeBoardTile5.Symbol = 'X';
            ticTacToeBoardTile5.TabIndex = 14;
            ticTacToeBoardTile5.Click += PlayerMove;
            // 
            // ticTacToeBoardTile6
            // 
            ticTacToeBoardTile6.BackColor = Color.White;
            ticTacToeBoardTile6.Location = new Point(0, 262);
            ticTacToeBoardTile6.Margin = new Padding(0, 0, 3, 0);
            ticTacToeBoardTile6.Name = "ticTacToeBoardTile6";
            ticTacToeBoardTile6.Size = new Size(128, 128);
            ticTacToeBoardTile6.Symbol = 'X';
            ticTacToeBoardTile6.TabIndex = 15;
            ticTacToeBoardTile6.Click += PlayerMove;
            // 
            // ticTacToeBoardTile7
            // 
            ticTacToeBoardTile7.BackColor = Color.White;
            ticTacToeBoardTile7.Location = new Point(131, 262);
            ticTacToeBoardTile7.Margin = new Padding(0, 0, 3, 0);
            ticTacToeBoardTile7.Name = "ticTacToeBoardTile7";
            ticTacToeBoardTile7.Size = new Size(128, 128);
            ticTacToeBoardTile7.Symbol = 'X';
            ticTacToeBoardTile7.TabIndex = 16;
            ticTacToeBoardTile7.Click += PlayerMove;
            // 
            // ticTacToeBoardTile8
            // 
            ticTacToeBoardTile8.BackColor = Color.White;
            ticTacToeBoardTile8.Location = new Point(262, 262);
            ticTacToeBoardTile8.Margin = new Padding(0);
            ticTacToeBoardTile8.Name = "ticTacToeBoardTile8";
            ticTacToeBoardTile8.Size = new Size(128, 128);
            ticTacToeBoardTile8.Symbol = 'X';
            ticTacToeBoardTile8.TabIndex = 17;
            ticTacToeBoardTile8.Click += PlayerMove;
            // 
            // lineAnimationPnl
            // 
            lineAnimationPnl.Location = new Point(0, 0);
            lineAnimationPnl.Name = "lineAnimationPnl";
            lineAnimationPnl.Size = new Size(390, 390);
            lineAnimationPnl.TabIndex = 1;
            // 
            // TicTacToeBoardControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(ticTacToeBoardTilesFlwLytPnl);
            Controls.Add(lineAnimationPnl);
            Name = "TicTacToeBoardControl";
            Size = new Size(390, 390);
            ticTacToeBoardTilesFlwLytPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ticTacToeBoardTilesFlwLytPnl;
        private CustomControls.LineAnimationPanel lineAnimationPnl;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile8;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile7;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile6;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile5;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile4;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile3;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile2;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile1;
        private CustomControls.TicTacToeBoardTile ticTacToeBoardTile0;
    }
}
