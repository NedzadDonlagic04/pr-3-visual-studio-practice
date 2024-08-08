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
            todoActionsFlowLayoutPanel = new FlowLayoutPanel();
            todoListActionButton1 = new TodoListActionButton();
            todoListActionButton3 = new TodoListActionButton();
            todoListActionButton4 = new TodoListActionButton();
            todoListActionButton2 = new TodoListActionButton();
            panel1 = new Panel();
            todoListLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            todoActionsFlowLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            splitContainer.Panel1.Controls.Add(todoActionsFlowLayoutPanel);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = SystemColors.Control;
            splitContainer.Panel2.Controls.Add(panel1);
            splitContainer.Size = new Size(784, 461);
            splitContainer.SplitterDistance = 261;
            splitContainer.TabIndex = 0;
            // 
            // todoActionsFlowLayoutPanel
            // 
            todoActionsFlowLayoutPanel.Controls.Add(todoListActionButton1);
            todoActionsFlowLayoutPanel.Controls.Add(todoListActionButton3);
            todoActionsFlowLayoutPanel.Controls.Add(todoListActionButton4);
            todoActionsFlowLayoutPanel.Controls.Add(todoListActionButton2);
            todoActionsFlowLayoutPanel.Dock = DockStyle.Fill;
            todoActionsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            todoActionsFlowLayoutPanel.Location = new Point(0, 0);
            todoActionsFlowLayoutPanel.Margin = new Padding(0);
            todoActionsFlowLayoutPanel.Name = "todoActionsFlowLayoutPanel";
            todoActionsFlowLayoutPanel.Size = new Size(261, 461);
            todoActionsFlowLayoutPanel.TabIndex = 0;
            todoActionsFlowLayoutPanel.WrapContents = false;
            // 
            // todoListActionButton1
            // 
            todoListActionButton1.AutoSize = true;
            todoListActionButton1.Location = new Point(3, 3);
            todoListActionButton1.Name = "todoListActionButton1";
            todoListActionButton1.Padding = new Padding(20);
            todoListActionButton1.Size = new Size(221, 65);
            todoListActionButton1.TabIndex = 0;
            todoListActionButton1.Text = "Add Todo";
            todoListActionButton1.UseVisualStyleBackColor = true;
            // 
            // todoListActionButton3
            // 
            todoListActionButton3.Anchor = AnchorStyles.Top;
            todoListActionButton3.AutoSize = true;
            todoListActionButton3.Location = new Point(3, 74);
            todoListActionButton3.Name = "todoListActionButton3";
            todoListActionButton3.Padding = new Padding(20);
            todoListActionButton3.Size = new Size(221, 65);
            todoListActionButton3.TabIndex = 2;
            todoListActionButton3.Text = "Update Todos";
            todoListActionButton3.UseVisualStyleBackColor = true;
            // 
            // todoListActionButton4
            // 
            todoListActionButton4.Anchor = AnchorStyles.Top;
            todoListActionButton4.AutoSize = true;
            todoListActionButton4.Location = new Point(3, 145);
            todoListActionButton4.Name = "todoListActionButton4";
            todoListActionButton4.Padding = new Padding(20);
            todoListActionButton4.Size = new Size(221, 65);
            todoListActionButton4.TabIndex = 3;
            todoListActionButton4.Text = "Filter Todos";
            todoListActionButton4.UseVisualStyleBackColor = true;
            // 
            // todoListActionButton2
            // 
            todoListActionButton2.Anchor = AnchorStyles.Top;
            todoListActionButton2.AutoSize = true;
            todoListActionButton2.Location = new Point(3, 216);
            todoListActionButton2.Name = "todoListActionButton2";
            todoListActionButton2.Padding = new Padding(20);
            todoListActionButton2.Size = new Size(221, 65);
            todoListActionButton2.TabIndex = 1;
            todoListActionButton2.Text = "Remove Todos";
            todoListActionButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(todoListLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 92);
            panel1.TabIndex = 1;
            // 
            // todoListLabel
            // 
            todoListLabel.Anchor = AnchorStyles.None;
            todoListLabel.AutoSize = true;
            todoListLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            todoListLabel.Location = new Point(181, 24);
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
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            todoActionsFlowLayoutPanel.ResumeLayout(false);
            todoActionsFlowLayoutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TodoListActionButton todoListActionButton1;
        private TodoListActionButton todoListActionButton4;
        private TodoListActionButton todoListActionButton3;
        private TodoListActionButton todoListActionButton2;
        private Label todoListLabel;
        private FlowLayoutPanel todoActionsFlowLayoutPanel;
        private Panel panel1;
    }
}