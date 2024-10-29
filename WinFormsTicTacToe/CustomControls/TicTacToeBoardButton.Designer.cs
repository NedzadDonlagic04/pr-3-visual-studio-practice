namespace WinFormsTicTacToe.CustomControls
{
    partial class TicTacToeBoardButton
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
            components = new System.ComponentModel.Container();

            Font = new Font("Segoe UI", 36, FontStyle.Bold);
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.Black;
            TabStop = false;
            // Might be useful for the line below
            // https://stackoverflow.com/questions/8283631/graphics-drawstring-vs-textrenderer-drawtextwhich-can-deliver-better-quality#23230570
            // TL;DR I had to make this true so that when a vertical victory was achieved in the game
            // the line drawn would go through the middle of the characters, leaving this as false
            // would make it so they're a bit more to the left than they should be
            UseCompatibleTextRendering = true;
        }

        #endregion
    }
}
