namespace WinFormsTodoList
{
    partial class AddTodoForm
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
            enterTodoTextBox = new TextBox();
            enterTodoLabel = new Label();
            enterTodoPanel = new Panel();
            buttonsPanel = new Panel();
            cancelTodoButton = new Button();
            addTodoButton = new Button();
            enterTodoPanel.SuspendLayout();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // enterTodoTextBox
            // 
            enterTodoTextBox.Dock = DockStyle.Fill;
            enterTodoTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            enterTodoTextBox.Location = new Point(0, 30);
            enterTodoTextBox.Name = "enterTodoTextBox";
            enterTodoTextBox.Size = new Size(319, 35);
            enterTodoTextBox.TabIndex = 0;
            enterTodoTextBox.TextChanged += EnteredTodoChange;
            // 
            // enterTodoLabel
            // 
            enterTodoLabel.AutoSize = true;
            enterTodoLabel.Dock = DockStyle.Top;
            enterTodoLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            enterTodoLabel.Location = new Point(0, 0);
            enterTodoLabel.Name = "enterTodoLabel";
            enterTodoLabel.Size = new Size(125, 30);
            enterTodoLabel.TabIndex = 1;
            enterTodoLabel.Text = "Enter Todo:";
            // 
            // enterTodoPanel
            // 
            enterTodoPanel.Controls.Add(enterTodoTextBox);
            enterTodoPanel.Controls.Add(enterTodoLabel);
            enterTodoPanel.Location = new Point(85, 29);
            enterTodoPanel.Name = "enterTodoPanel";
            enterTodoPanel.Size = new Size(319, 100);
            enterTodoPanel.TabIndex = 2;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(cancelTodoButton);
            buttonsPanel.Controls.Add(addTodoButton);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.Location = new Point(0, 150);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(489, 77);
            buttonsPanel.TabIndex = 3;
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
            cancelTodoButton.Click += CancelAddingTodo;
            // 
            // addTodoButton
            // 
            addTodoButton.AutoSize = true;
            addTodoButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTodoButton.Location = new Point(85, 13);
            addTodoButton.Name = "addTodoButton";
            addTodoButton.Padding = new Padding(5);
            addTodoButton.Size = new Size(113, 50);
            addTodoButton.TabIndex = 0;
            addTodoButton.Text = "Add";
            addTodoButton.UseVisualStyleBackColor = true;
            addTodoButton.Click += AddTodo;
            // 
            // AddTodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 227);
            Controls.Add(buttonsPanel);
            Controls.Add(enterTodoPanel);
            Name = "AddTodoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Todo";
            enterTodoPanel.ResumeLayout(false);
            enterTodoPanel.PerformLayout();
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox enterTodoTextBox;
        private Label enterTodoLabel;
        private Panel enterTodoPanel;
        private Panel buttonsPanel;
        private Button cancelTodoButton;
        private Button addTodoButton;
    }
}