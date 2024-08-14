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
            buttonsPanel = new Panel();
            cancelTodoButton = new Button();
            addTodoButton = new Button();
            textBoxWithLabel1 = new TextBoxWithLabel();
            buttonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // buttonsPanel
            // 
            buttonsPanel.Controls.Add(cancelTodoButton);
            buttonsPanel.Controls.Add(addTodoButton);
            buttonsPanel.Dock = DockStyle.Bottom;
            buttonsPanel.Location = new Point(0, 106);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(489, 89);
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
            // textBoxWithLabel1
            // 
            textBoxWithLabel1.Location = new Point(99, 12);
            textBoxWithLabel1.Name = "textBoxWithLabel1";
            textBoxWithLabel1.Size = new Size(291, 88);
            textBoxWithLabel1.TabIndex = 4;
            // 
            // AddTodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 195);
            Controls.Add(textBoxWithLabel1);
            Controls.Add(buttonsPanel);
            Name = "AddTodoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Todo";
            buttonsPanel.ResumeLayout(false);
            buttonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel buttonsPanel;
        private Button cancelTodoButton;
        private Button addTodoButton;
        private TextBoxWithLabel textBoxWithLabel1;
    }
}