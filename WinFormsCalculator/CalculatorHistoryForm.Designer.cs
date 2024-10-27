namespace WinFormsCalculator
{
    partial class CalculatorHistoryForm
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
            calculatorHistoryPnl = new Panel();
            calculatorHistoryLbl = new Label();
            SuspendLayout();
            // 
            // calculatorHistoryPnl
            // 
            calculatorHistoryPnl.AutoScroll = true;
            calculatorHistoryPnl.Dock = DockStyle.Bottom;
            calculatorHistoryPnl.Location = new Point(0, 57);
            calculatorHistoryPnl.Name = "calculatorHistoryPnl";
            calculatorHistoryPnl.Size = new Size(390, 414);
            calculatorHistoryPnl.TabIndex = 0;
            // 
            // calculatorHistoryLbl
            // 
            calculatorHistoryLbl.AutoSize = true;
            calculatorHistoryLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            calculatorHistoryLbl.ForeColor = Color.FromArgb(226, 226, 226);
            calculatorHistoryLbl.Location = new Point(63, 9);
            calculatorHistoryLbl.Name = "calculatorHistoryLbl";
            calculatorHistoryLbl.Size = new Size(265, 40);
            calculatorHistoryLbl.TabIndex = 1;
            calculatorHistoryLbl.Text = "Calculator History";
            // 
            // CalculatorHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(390, 471);
            Controls.Add(calculatorHistoryLbl);
            Controls.Add(calculatorHistoryPnl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalculatorHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator History";
            Shown += CalculatorHistoryFormShown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel calculatorHistoryPnl;
        private Label calculatorHistoryLbl;
    }
}