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
            todoListActionButton4 = new TodoListActionButton();
            todoListActionButton3 = new TodoListActionButton();
            todoListActionButton2 = new TodoListActionButton();
            todoListActionButton1 = new TodoListActionButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
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
            splitContainer.Panel1.Controls.Add(todoListActionButton4);
            splitContainer.Panel1.Controls.Add(todoListActionButton3);
            splitContainer.Panel1.Controls.Add(todoListActionButton2);
            splitContainer.Panel1.Controls.Add(todoListActionButton1);
            splitContainer.Panel1.Padding = new Padding(20);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.BackColor = SystemColors.Control;
            splitContainer.Panel2.Controls.Add(label1);
            splitContainer.Size = new Size(784, 461);
            splitContainer.SplitterDistance = 261;
            splitContainer.TabIndex = 0;
            // 
            // todoListActionButton4
            // 
            todoListActionButton4.Anchor = AnchorStyles.Top;
            todoListActionButton4.AutoSize = true;
            todoListActionButton4.Location = new Point(20, 215);
            todoListActionButton4.Margin = new Padding(20);
            todoListActionButton4.Name = "todoListActionButton4";
            todoListActionButton4.Padding = new Padding(20);
            todoListActionButton4.Size = new Size(221, 65);
            todoListActionButton4.TabIndex = 3;
            todoListActionButton4.Text = "todoListActionButton4";
            todoListActionButton4.UseVisualStyleBackColor = true;
            // 
            // todoListActionButton3
            // 
            todoListActionButton3.Anchor = AnchorStyles.Top;
            todoListActionButton3.AutoSize = true;
            todoListActionButton3.Location = new Point(20, 150);
            todoListActionButton3.Margin = new Padding(20);
            todoListActionButton3.Name = "todoListActionButton3";
            todoListActionButton3.Padding = new Padding(20);
            todoListActionButton3.Size = new Size(221, 65);
            todoListActionButton3.TabIndex = 2;
            todoListActionButton3.Text = "todoListActionButton3";
            todoListActionButton3.UseVisualStyleBackColor = true;
            // 
            // todoListActionButton2
            // 
            todoListActionButton2.Anchor = AnchorStyles.Top;
            todoListActionButton2.AutoSize = true;
            todoListActionButton2.Location = new Point(20, 85);
            todoListActionButton2.Margin = new Padding(100);
            todoListActionButton2.Name = "todoListActionButton2";
            todoListActionButton2.Padding = new Padding(20);
            todoListActionButton2.Size = new Size(221, 65);
            todoListActionButton2.TabIndex = 1;
            todoListActionButton2.Text = "todoListActionButton2";
            todoListActionButton2.UseVisualStyleBackColor = true;
            // 
            // todoListActionButton1
            // 
            todoListActionButton1.Anchor = AnchorStyles.Top;
            todoListActionButton1.AutoSize = true;
            todoListActionButton1.Location = new Point(20, 20);
            todoListActionButton1.Margin = new Padding(20);
            todoListActionButton1.Name = "todoListActionButton1";
            todoListActionButton1.Padding = new Padding(20);
            todoListActionButton1.Size = new Size(221, 65);
            todoListActionButton1.TabIndex = 0;
            todoListActionButton1.Text = "todoListActionButton1";
            todoListActionButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 40);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 0;
            label1.Text = "Todo List";
            // 
            // TodoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer);
            MaximumSize = new Size(900, 500);
            MinimumSize = new Size(800, 500);
            Name = "TodoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todo List Application";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TodoListActionButton todoListActionButton1;
        private TodoListActionButton todoListActionButton4;
        private TodoListActionButton todoListActionButton3;
        private TodoListActionButton todoListActionButton2;
        private Label label1;
    }
}