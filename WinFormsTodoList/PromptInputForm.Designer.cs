namespace WinFormsTodoList
{
    partial class PromptInputForm
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
            enterTodoTextBoxWithLabel = new TextBoxWithLabel();
            buttonsPanel = new Panel();
            cancelTodoButton = new Button();
            okTodoButton = new Button();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // enterTodoTextBoxWithLabel
            // 
            enterTodoTextBoxWithLabel.LabelText = "Enter input:";
            enterTodoTextBoxWithLabel.Location = new Point(85, 12);
            enterTodoTextBoxWithLabel.MaxTextBoxInputLength = 6;
            enterTodoTextBoxWithLabel.Name = "enterTodoTextBoxWithLabel";
            enterTodoTextBoxWithLabel.Size = new Size(319, 88);
            enterTodoTextBoxWithLabel.TabIndex = 5;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(cancelTodoButton);
            buttonsPanel.Controls.Add(okTodoButton);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.Location = new Point(0, 106);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(489, 89);
            buttonsPanel.TabIndex = 6;
            // 
            // cancelTodoButton
            // 
            cancelTodoButton.AutoSize = true;
            cancelTodoButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelTodoButton.Location = new Point(291, 13);
            cancelTodoButton.Name = "cancelTodoButton";
            cancelTodoButton.Padding = new Padding(5);
            cancelTodoButton.Size = new Size(113, 50);
            cancelTodoButton.TabIndex = 1;
            cancelTodoButton.Text = "Cancel";
            cancelTodoButton.UseVisualStyleBackColor = true;
            cancelTodoButton.Click += CancelButtonClick;
            // 
            // okTodoButton
            // 
            okTodoButton.AutoSize = true;
            okTodoButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            okTodoButton.Location = new Point(85, 13);
            okTodoButton.Name = "okTodoButton";
            okTodoButton.Padding = new Padding(5);
            okTodoButton.Size = new Size(113, 50);
            okTodoButton.TabIndex = 0;
            okTodoButton.Text = "Ok";
            okTodoButton.UseVisualStyleBackColor = true;
            okTodoButton.Click += OkButtonClick;
            // 
            // PromptInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 195);
            Controls.Add(buttonsPanel);
            Controls.Add(enterTodoTextBoxWithLabel);
            MaximumSize = new Size(505, 234);
            MinimumSize = new Size(505, 234);
            Name = "PromptInputForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Prompt Input Form";
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBoxWithLabel enterTodoTextBoxWithLabel;
        private Panel buttonsPanel;
        private Button cancelTodoButton;
        private Button okTodoButton;
    }
}