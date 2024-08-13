using System.Reflection.Metadata;

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
            filterTodosPanelWithButtonInside = new PanelWithButtonInside();
            removeTodosPanelWithButtonInside = new PanelWithButtonInside();
            updateTodosPanelWithButtonInside = new PanelWithButtonInside();
            addTodoPanelWithButtonInside = new PanelWithButtonInside();
            todosListBox = new ListBox();
            todoListLabelPanel = new Panel();
            todoListLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
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
            splitContainer.Panel1.Controls.Add(filterTodosPanelWithButtonInside);
            splitContainer.Panel1.Controls.Add(removeTodosPanelWithButtonInside);
            splitContainer.Panel1.Controls.Add(updateTodosPanelWithButtonInside);
            splitContainer.Panel1.Controls.Add(addTodoPanelWithButtonInside);
            splitContainer.Panel1.Padding = new Padding(20, 15, 20, 15);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = SystemColors.Control;
            splitContainer.Panel2.Controls.Add(todosListBox);
            splitContainer.Panel2.Controls.Add(todoListLabelPanel);
            splitContainer.Size = new Size(784, 461);
            splitContainer.SplitterDistance = 261;
            splitContainer.TabIndex = 0;
            // 
            // filterTodosPanelWithButtonInside
            // 
            filterTodosPanelWithButtonInside.ButtonPadding = new Padding(20);
            filterTodosPanelWithButtonInside.Dock = DockStyle.Top;
            filterTodosPanelWithButtonInside.Location = new Point(20, 324);
            filterTodosPanelWithButtonInside.Margin = new Padding(0);
            filterTodosPanelWithButtonInside.Name = "filterTodosPanelWithButtonInside";
            filterTodosPanelWithButtonInside.PanelPadding = new Padding(20);
            filterTodosPanelWithButtonInside.Size = new Size(221, 103);
            filterTodosPanelWithButtonInside.TabIndex = 3;
            filterTodosPanelWithButtonInside.Text = "Filter Todos";
            filterTodosPanelWithButtonInside.Click += FilterTodosWindow;
            // 
            // removeTodosPanelWithButtonInside
            // 
            removeTodosPanelWithButtonInside.ButtonPadding = new Padding(20);
            removeTodosPanelWithButtonInside.Dock = DockStyle.Top;
            removeTodosPanelWithButtonInside.Location = new Point(20, 221);
            removeTodosPanelWithButtonInside.Margin = new Padding(0);
            removeTodosPanelWithButtonInside.Name = "removeTodosPanelWithButtonInside";
            removeTodosPanelWithButtonInside.PanelPadding = new Padding(20);
            removeTodosPanelWithButtonInside.Size = new Size(221, 103);
            removeTodosPanelWithButtonInside.TabIndex = 2;
            removeTodosPanelWithButtonInside.Text = "Remove Todos";
            removeTodosPanelWithButtonInside.Click += RemoveTodosWindow;
            // 
            // updateTodosPanelWithButtonInside
            // 
            updateTodosPanelWithButtonInside.ButtonPadding = new Padding(20);
            updateTodosPanelWithButtonInside.Dock = DockStyle.Top;
            updateTodosPanelWithButtonInside.Location = new Point(20, 118);
            updateTodosPanelWithButtonInside.Margin = new Padding(0);
            updateTodosPanelWithButtonInside.Name = "updateTodosPanelWithButtonInside";
            updateTodosPanelWithButtonInside.PanelPadding = new Padding(20);
            updateTodosPanelWithButtonInside.Size = new Size(221, 103);
            updateTodosPanelWithButtonInside.TabIndex = 1;
            updateTodosPanelWithButtonInside.Text = "Update Todos";
            updateTodosPanelWithButtonInside.Click += UpdateTodosWindow;
            // 
            // addTodoPanelWithButtonInside
            // 
            addTodoPanelWithButtonInside.ButtonPadding = new Padding(20);
            addTodoPanelWithButtonInside.Dock = DockStyle.Top;
            addTodoPanelWithButtonInside.ForeColor = SystemColors.ControlText;
            addTodoPanelWithButtonInside.Location = new Point(20, 15);
            addTodoPanelWithButtonInside.Margin = new Padding(0);
            addTodoPanelWithButtonInside.Name = "addTodoPanelWithButtonInside";
            addTodoPanelWithButtonInside.PanelPadding = new Padding(20);
            addTodoPanelWithButtonInside.Size = new Size(221, 103);
            addTodoPanelWithButtonInside.TabIndex = 0;
            addTodoPanelWithButtonInside.Text = "Add Todo";
            addTodoPanelWithButtonInside.Click += AddTodoWindow;
            // 
            // todosListBox
            // 
            todosListBox.Anchor = AnchorStyles.None;
            todosListBox.FormattingEnabled = true;
            todosListBox.ItemHeight = 15;
            todosListBox.Location = new Point(49, 101);
            todosListBox.Name = "todosListBox";
            todosListBox.Size = new Size(420, 259);
            todosListBox.TabIndex = 2;
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
            MaximumSize = new Size(1500, 700);
            MinimumSize = new Size(800, 500);
            Name = "TodoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todo List Application";
            Load += LoadForm;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            todoListLabelPanel.ResumeLayout(false);
            todoListLabelPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private Label todoListLabel;
        private Panel todoListLabelPanel;
        private PanelWithButtonInside addTodoPanelWithButtonInside;
        private PanelWithButtonInside filterTodosPanelWithButtonInside;
        private PanelWithButtonInside removeTodosPanelWithButtonInside;
        private PanelWithButtonInside updateTodosPanelWithButtonInside;
        private ListBox todosListBox;
    }
}