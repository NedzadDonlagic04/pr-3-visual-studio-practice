namespace WinFormsTicTacToe.CustomControls
{
    partial class TicTacToeBoardPanel
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
            symbolLbl = new Label();
            SuspendLayout();
            // 
            // symbolLbl
            // 
            symbolLbl.BackColor = SystemColors.Control;
            symbolLbl.Dock = DockStyle.Fill;
            symbolLbl.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            symbolLbl.Location = new Point(0, 0);
            symbolLbl.Margin = new Padding(0);
            symbolLbl.Name = "symbolLbl";
            symbolLbl.Size = new Size(128, 128);
            symbolLbl.TabIndex = 2;
            symbolLbl.Text = "X";
            symbolLbl.TextAlign = ContentAlignment.MiddleCenter;
            symbolLbl.UseCompatibleTextRendering = true;
            // 
            // TicTacToeBoardPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(symbolLbl);
            Margin = new Padding(0);
            Name = "TicTacToeBoardPanel";
            Size = new Size(128, 128);
            ResumeLayout(false);
        }

        #endregion

        private Label symbolLbl;
    }
}
