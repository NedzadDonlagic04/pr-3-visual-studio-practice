namespace WinFormsTodoList
{
    partial class TodoList
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
            splitContainer = new SplitContainer();
            filterTodosButtonPanel = new Panel();
            filterTodosButton = new TodoListActionButton();
            removeTodosButtonPanel = new Panel();
            removeTodosButton = new TodoListActionButton();
            updateTodosButtonPanel = new Panel();
            updateTodosButton = new TodoListActionButton();
            addTodoButtonPanel = new Panel();
            addTodoButton = new TodoListActionButton();
            todoListLabelPanel = new Panel();
            todoListLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            filterTodosButtonPanel.SuspendLayout();
            removeTodosButtonPanel.SuspendLayout();
            updateTodosButtonPanel.SuspendLayout();
            addTodoButtonPanel.SuspendLayout();
            todoListLabelPanel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.BackColor = SystemColors.Control;
            splitContainer.Panel1.Controls.Add(filterTodosButtonPanel);
            splitContainer.Panel1.Controls.Add(removeTodosButtonPanel);
            splitContainer.Panel1.Controls.Add(updateTodosButtonPanel);
            splitContainer.Panel1.Controls.Add(addTodoButtonPanel);
            splitContainer.Panel1.Padding = new Padding(20, 15, 20, 15);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = SystemColors.Control;
            splitContainer.Panel2.Controls.Add(todoListLabelPanel);
            splitContainer.Size = new Size(784, 461);
            splitContainer.SplitterDistance = 261;
            splitContainer.TabIndex = 0;
            // 
            // filterTodosButtonPanel
            // 
            filterTodosButtonPanel.AutoSize = true;
            filterTodosButtonPanel.Controls.Add(filterTodosButton);
            filterTodosButtonPanel.Dock = DockStyle.Top;
            filterTodosButtonPanel.Location = new Point(20, 270);
            filterTodosButtonPanel.Name = "filterTodosButtonPanel";
            filterTodosButtonPanel.Padding = new Padding(10);
            filterTodosButtonPanel.Size = new Size(221, 85);
            filterTodosButtonPanel.TabIndex = 5;
            // 
            // filterTodosButton
            // 
            filterTodosButton.AutoSize = true;
            filterTodosButton.Dock = DockStyle.Top;
            filterTodosButton.Location = new Point(10, 10);
            filterTodosButton.Margin = new Padding(0);
            filterTodosButton.Name = "filterTodosButton";
            filterTodosButton.Padding = new Padding(20);
            filterTodosButton.Size = new Size(201, 65);
            filterTodosButton.TabIndex = 1;
            filterTodosButton.Text = "Filter Todos";
            filterTodosButton.UseVisualStyleBackColor = true;
            // 
            // removeTodosButtonPanel
            // 
            removeTodosButtonPanel.AutoSize = true;
            removeTodosButtonPanel.Controls.Add(removeTodosButton);
            removeTodosButtonPanel.Dock = DockStyle.Top;
            removeTodosButtonPanel.Location = new Point(20, 185);
            removeTodosButtonPanel.Name = "removeTodosButtonPanel";
            removeTodosButtonPanel.Padding = new Padding(10);
            removeTodosButtonPanel.Size = new Size(221, 85);
            removeTodosButtonPanel.TabIndex = 4;
            // 
            // removeTodosButton
            // 
            removeTodosButton.AutoSize = true;
            removeTodosButton.Dock = DockStyle.Top;
            removeTodosButton.Location = new Point(10, 10);
            removeTodosButton.Margin = new Padding(0);
            removeTodosButton.Name = "removeTodosButton";
            removeTodosButton.Padding = new Padding(20);
            removeTodosButton.Size = new Size(201, 65);
            removeTodosButton.TabIndex = 1;
            removeTodosButton.Text = "Remove Todos";
            removeTodosButton.UseVisualStyleBackColor = true;
            // 
            // updateTodosButtonPanel
            // 
            updateTodosButtonPanel.AutoSize = true;
            updateTodosButtonPanel.Controls.Add(updateTodosButton);
            updateTodosButtonPanel.Dock = DockStyle.Top;
            updateTodosButtonPanel.Location = new Point(20, 100);
            updateTodosButtonPanel.Name = "updateTodosButtonPanel";
            updateTodosButtonPanel.Padding = new Padding(10);
            updateTodosButtonPanel.Size = new Size(221, 85);
            updateTodosButtonPanel.TabIndex = 3;
            // 
            // updateTodosButton
            // 
            updateTodosButton.AutoSize = true;
            updateTodosButton.Dock = DockStyle.Top;
            updateTodosButton.Location = new Point(10, 10);
            updateTodosButton.Margin = new Padding(0);
            updateTodosButton.Name = "updateTodosButton";
            updateTodosButton.Padding = new Padding(20);
            updateTodosButton.Size = new Size(201, 65);
            updateTodosButton.TabIndex = 1;
            updateTodosButton.Text = "Update Todos";
            updateTodosButton.UseVisualStyleBackColor = true;
            // 
            // addTodoButtonPanel
            // 
            addTodoButtonPanel.AutoSize = true;
            addTodoButtonPanel.Controls.Add(addTodoButton);
            addTodoButtonPanel.Dock = DockStyle.Top;
            addTodoButtonPanel.Location = new Point(20, 15);
            addTodoButtonPanel.Name = "addTodoButtonPanel";
            addTodoButtonPanel.Padding = new Padding(10);
            addTodoButtonPanel.Size = new Size(221, 85);
            addTodoButtonPanel.TabIndex = 2;
            // 
            // addTodoButton
            // 
            addTodoButton.AutoSize = true;
            addTodoButton.Dock = DockStyle.Top;
            addTodoButton.Location = new Point(10, 10);
            addTodoButton.Margin = new Padding(0);
            addTodoButton.Name = "addTodoButton";
            addTodoButton.Padding = new Padding(20);
            addTodoButton.Size = new Size(201, 65);
            addTodoButton.TabIndex = 1;
            addTodoButton.Text = "Add Todo";
            addTodoButton.UseVisualStyleBackColor = true;
            // 
            // todoListLabelPanel
            // 
            todoListLabelPanel.Controls.Add(todoListLabel);
            todoListLabelPanel.Dock = DockStyle.Top;
            todoListLabelPanel.Location = new Point(0, 0);
            todoListLabelPanel.Name = "todoListLabelPanel";
            todoListLabelPanel.Padding = new Padding(30);
            todoListLabelPanel.Size = new Size(519, 68);
            todoListLabelPanel.TabIndex = 1;
            // 
            // todoListLabel
            // 
            todoListLabel.Anchor = AnchorStyles.None;
            todoListLabel.AutoSize = true;
            todoListLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            todoListLabel.Location = new Point(181, 12);
            todoListLabel.Name = "todoListLabel";
            todoListLabel.Size = new Size(156, 45);
            todoListLabel.TabIndex = 0;
            todoListLabel.Text = "Todo List";
            // 
            // TodoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer);
            MaximumSize = new Size(1200, 700);
            MinimumSize = new Size(800, 500);
            Name = "TodoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todo List Application";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            filterTodosButtonPanel.ResumeLayout(false);
            filterTodosButtonPanel.PerformLayout();
            removeTodosButtonPanel.ResumeLayout(false);
            removeTodosButtonPanel.PerformLayout();
            updateTodosButtonPanel.ResumeLayout(false);
            updateTodosButtonPanel.PerformLayout();
            addTodoButtonPanel.ResumeLayout(false);
            addTodoButtonPanel.PerformLayout();
            todoListLabelPanel.ResumeLayout(false);
            todoListLabelPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label todoListLabel;
        private Panel todoListLabelPanel;
        private Panel addTodoButtonPanel;
        private TodoListActionButton addTodoButton;
        private Panel filterTodosButtonPanel;
        private TodoListActionButton filterTodosButton;
        private Panel removeTodosButtonPanel;
        private TodoListActionButton removeTodosButton;
        private Panel updateTodosButtonPanel;
        private TodoListActionButton updateTodosButton;
    }
}