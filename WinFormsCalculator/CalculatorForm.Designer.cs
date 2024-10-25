namespace WinFormsCalculator
{
    partial class CalculatorForm
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
            btnsFlowLayoutPanel = new FlowLayoutPanel();
            remainderBtn = new Button();
            clearEntryBtn = new Button();
            clearEverythingBtn = new Button();
            undoPreviousActionBtn = new Button();
            reciprocationBtn = new Button();
            squareBtn = new Button();
            rootBtn = new Button();
            divisionBtn = new Button();
            sevenBtn = new Button();
            eightBtn = new Button();
            nineBtn = new Button();
            multiplyBtn = new Button();
            fourBtn = new Button();
            fiveBtn = new Button();
            sixBtn = new Button();
            minusBtn = new Button();
            oneBtn = new Button();
            twoBtn = new Button();
            threeBtn = new Button();
            plusBtn = new Button();
            changeSignBtn = new Button();
            zeroBtn = new Button();
            floatingPointBtn = new Button();
            resultBtn = new Button();
            resultLabelsPanel = new Panel();
            lastOperationTxtBox = new TextBox();
            currentOperationTxtBox = new TextBox();
            viewHistoryBtn = new Button();
            btnsFlowLayoutPanel.SuspendLayout();
            resultLabelsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnsFlowLayoutPanel
            // 
            btnsFlowLayoutPanel.Controls.Add(remainderBtn);
            btnsFlowLayoutPanel.Controls.Add(clearEntryBtn);
            btnsFlowLayoutPanel.Controls.Add(clearEverythingBtn);
            btnsFlowLayoutPanel.Controls.Add(undoPreviousActionBtn);
            btnsFlowLayoutPanel.Controls.Add(reciprocationBtn);
            btnsFlowLayoutPanel.Controls.Add(squareBtn);
            btnsFlowLayoutPanel.Controls.Add(rootBtn);
            btnsFlowLayoutPanel.Controls.Add(divisionBtn);
            btnsFlowLayoutPanel.Controls.Add(sevenBtn);
            btnsFlowLayoutPanel.Controls.Add(eightBtn);
            btnsFlowLayoutPanel.Controls.Add(nineBtn);
            btnsFlowLayoutPanel.Controls.Add(multiplyBtn);
            btnsFlowLayoutPanel.Controls.Add(fourBtn);
            btnsFlowLayoutPanel.Controls.Add(fiveBtn);
            btnsFlowLayoutPanel.Controls.Add(sixBtn);
            btnsFlowLayoutPanel.Controls.Add(minusBtn);
            btnsFlowLayoutPanel.Controls.Add(oneBtn);
            btnsFlowLayoutPanel.Controls.Add(twoBtn);
            btnsFlowLayoutPanel.Controls.Add(threeBtn);
            btnsFlowLayoutPanel.Controls.Add(plusBtn);
            btnsFlowLayoutPanel.Controls.Add(changeSignBtn);
            btnsFlowLayoutPanel.Controls.Add(zeroBtn);
            btnsFlowLayoutPanel.Controls.Add(floatingPointBtn);
            btnsFlowLayoutPanel.Controls.Add(resultBtn);
            btnsFlowLayoutPanel.Location = new Point(11, 139);
            btnsFlowLayoutPanel.Margin = new Padding(1);
            btnsFlowLayoutPanel.Name = "btnsFlowLayoutPanel";
            btnsFlowLayoutPanel.Size = new Size(368, 312);
            btnsFlowLayoutPanel.TabIndex = 0;
            // 
            // remainderBtn
            // 
            remainderBtn.AutoSize = true;
            remainderBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            remainderBtn.Location = new Point(1, 1);
            remainderBtn.Margin = new Padding(1);
            remainderBtn.Name = "remainderBtn";
            remainderBtn.Size = new Size(90, 50);
            remainderBtn.TabIndex = 2;
            remainderBtn.Text = "%";
            remainderBtn.UseVisualStyleBackColor = true;
            remainderBtn.Click += CalculatorButtonClick;
            // 
            // clearEntryBtn
            // 
            clearEntryBtn.AutoSize = true;
            clearEntryBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            clearEntryBtn.Location = new Point(93, 1);
            clearEntryBtn.Margin = new Padding(1);
            clearEntryBtn.Name = "clearEntryBtn";
            clearEntryBtn.Size = new Size(90, 50);
            clearEntryBtn.TabIndex = 3;
            clearEntryBtn.Text = "CE";
            clearEntryBtn.UseVisualStyleBackColor = true;
            clearEntryBtn.Click += CalculatorButtonClick;
            // 
            // clearEverythingBtn
            // 
            clearEverythingBtn.AutoSize = true;
            clearEverythingBtn.BackColor = Color.FromArgb(59, 59, 59);
            clearEverythingBtn.FlatStyle = FlatStyle.Flat;
            clearEverythingBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            clearEverythingBtn.ForeColor = Color.FromArgb(226, 226, 226);
            clearEverythingBtn.Location = new Point(185, 1);
            clearEverythingBtn.Margin = new Padding(1);
            clearEverythingBtn.Name = "clearEverythingBtn";
            clearEverythingBtn.Size = new Size(90, 50);
            clearEverythingBtn.TabIndex = 4;
            clearEverythingBtn.Text = "C";
            clearEverythingBtn.UseVisualStyleBackColor = false;
            clearEverythingBtn.Click += CalculatorButtonClick;
            // 
            // undoPreviousActionBtn
            // 
            undoPreviousActionBtn.AutoSize = true;
            undoPreviousActionBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            undoPreviousActionBtn.Location = new Point(277, 1);
            undoPreviousActionBtn.Margin = new Padding(1);
            undoPreviousActionBtn.Name = "undoPreviousActionBtn";
            undoPreviousActionBtn.Size = new Size(90, 50);
            undoPreviousActionBtn.TabIndex = 5;
            undoPreviousActionBtn.Text = "⌫";
            undoPreviousActionBtn.UseVisualStyleBackColor = true;
            undoPreviousActionBtn.Click += CalculatorButtonClick;
            // 
            // reciprocationBtn
            // 
            reciprocationBtn.AutoSize = true;
            reciprocationBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            reciprocationBtn.Location = new Point(1, 53);
            reciprocationBtn.Margin = new Padding(1);
            reciprocationBtn.Name = "reciprocationBtn";
            reciprocationBtn.Size = new Size(90, 50);
            reciprocationBtn.TabIndex = 6;
            reciprocationBtn.Text = "x⁻¹";
            reciprocationBtn.UseVisualStyleBackColor = true;
            reciprocationBtn.Click += CalculatorButtonClick;
            // 
            // squareBtn
            // 
            squareBtn.AutoSize = true;
            squareBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            squareBtn.Location = new Point(93, 53);
            squareBtn.Margin = new Padding(1);
            squareBtn.Name = "squareBtn";
            squareBtn.Size = new Size(90, 50);
            squareBtn.TabIndex = 7;
            squareBtn.Text = "x²";
            squareBtn.UseVisualStyleBackColor = true;
            squareBtn.Click += CalculatorButtonClick;
            // 
            // rootBtn
            // 
            rootBtn.AutoSize = true;
            rootBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rootBtn.Location = new Point(185, 53);
            rootBtn.Margin = new Padding(1);
            rootBtn.Name = "rootBtn";
            rootBtn.Size = new Size(90, 50);
            rootBtn.TabIndex = 8;
            rootBtn.Text = "√";
            rootBtn.UseVisualStyleBackColor = true;
            rootBtn.Click += CalculatorButtonClick;
            // 
            // divisionBtn
            // 
            divisionBtn.AutoSize = true;
            divisionBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            divisionBtn.Location = new Point(277, 53);
            divisionBtn.Margin = new Padding(1);
            divisionBtn.Name = "divisionBtn";
            divisionBtn.Size = new Size(90, 50);
            divisionBtn.TabIndex = 9;
            divisionBtn.Text = "÷";
            divisionBtn.UseVisualStyleBackColor = true;
            divisionBtn.Click += CalculatorButtonClick;
            // 
            // sevenBtn
            // 
            sevenBtn.AutoSize = true;
            sevenBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sevenBtn.Location = new Point(1, 105);
            sevenBtn.Margin = new Padding(1);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(90, 50);
            sevenBtn.TabIndex = 10;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = true;
            sevenBtn.Click += CalculatorButtonClick;
            // 
            // eightBtn
            // 
            eightBtn.AutoSize = true;
            eightBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            eightBtn.Location = new Point(93, 105);
            eightBtn.Margin = new Padding(1);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(90, 50);
            eightBtn.TabIndex = 11;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = true;
            eightBtn.Click += CalculatorButtonClick;
            // 
            // nineBtn
            // 
            nineBtn.AutoSize = true;
            nineBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nineBtn.Location = new Point(185, 105);
            nineBtn.Margin = new Padding(1);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(90, 50);
            nineBtn.TabIndex = 12;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = true;
            nineBtn.Click += CalculatorButtonClick;
            // 
            // multiplyBtn
            // 
            multiplyBtn.AutoSize = true;
            multiplyBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            multiplyBtn.Location = new Point(277, 105);
            multiplyBtn.Margin = new Padding(1);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(90, 50);
            multiplyBtn.TabIndex = 13;
            multiplyBtn.Text = "×";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += CalculatorButtonClick;
            // 
            // fourBtn
            // 
            fourBtn.AutoSize = true;
            fourBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            fourBtn.Location = new Point(1, 157);
            fourBtn.Margin = new Padding(1);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(90, 50);
            fourBtn.TabIndex = 14;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = true;
            fourBtn.Click += CalculatorButtonClick;
            // 
            // fiveBtn
            // 
            fiveBtn.AutoSize = true;
            fiveBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            fiveBtn.Location = new Point(93, 157);
            fiveBtn.Margin = new Padding(1);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(90, 50);
            fiveBtn.TabIndex = 15;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = true;
            fiveBtn.Click += CalculatorButtonClick;
            // 
            // sixBtn
            // 
            sixBtn.AutoSize = true;
            sixBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sixBtn.Location = new Point(185, 157);
            sixBtn.Margin = new Padding(1);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(90, 50);
            sixBtn.TabIndex = 16;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = true;
            sixBtn.Click += CalculatorButtonClick;
            // 
            // minusBtn
            // 
            minusBtn.AutoSize = true;
            minusBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            minusBtn.Location = new Point(277, 157);
            minusBtn.Margin = new Padding(1);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(90, 50);
            minusBtn.TabIndex = 17;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = true;
            minusBtn.Click += CalculatorButtonClick;
            // 
            // oneBtn
            // 
            oneBtn.AutoSize = true;
            oneBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            oneBtn.Location = new Point(1, 209);
            oneBtn.Margin = new Padding(1);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(90, 50);
            oneBtn.TabIndex = 18;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = true;
            oneBtn.Click += CalculatorButtonClick;
            // 
            // twoBtn
            // 
            twoBtn.AutoSize = true;
            twoBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            twoBtn.Location = new Point(93, 209);
            twoBtn.Margin = new Padding(1);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(90, 50);
            twoBtn.TabIndex = 19;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = true;
            twoBtn.Click += CalculatorButtonClick;
            // 
            // threeBtn
            // 
            threeBtn.AutoSize = true;
            threeBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            threeBtn.Location = new Point(185, 209);
            threeBtn.Margin = new Padding(1);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(90, 50);
            threeBtn.TabIndex = 20;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = true;
            threeBtn.Click += CalculatorButtonClick;
            // 
            // plusBtn
            // 
            plusBtn.AutoSize = true;
            plusBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            plusBtn.Location = new Point(277, 209);
            plusBtn.Margin = new Padding(1);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(90, 50);
            plusBtn.TabIndex = 21;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = true;
            plusBtn.Click += CalculatorButtonClick;
            // 
            // changeSignBtn
            // 
            changeSignBtn.AutoSize = true;
            changeSignBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            changeSignBtn.Location = new Point(1, 261);
            changeSignBtn.Margin = new Padding(1);
            changeSignBtn.Name = "changeSignBtn";
            changeSignBtn.Size = new Size(90, 50);
            changeSignBtn.TabIndex = 22;
            changeSignBtn.Text = "±";
            changeSignBtn.UseVisualStyleBackColor = true;
            changeSignBtn.Click += CalculatorButtonClick;
            // 
            // zeroBtn
            // 
            zeroBtn.AutoSize = true;
            zeroBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            zeroBtn.Location = new Point(93, 261);
            zeroBtn.Margin = new Padding(1);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(90, 50);
            zeroBtn.TabIndex = 23;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = true;
            zeroBtn.Click += CalculatorButtonClick;
            // 
            // floatingPointBtn
            // 
            floatingPointBtn.AutoSize = true;
            floatingPointBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            floatingPointBtn.Location = new Point(185, 261);
            floatingPointBtn.Margin = new Padding(1);
            floatingPointBtn.Name = "floatingPointBtn";
            floatingPointBtn.Size = new Size(90, 50);
            floatingPointBtn.TabIndex = 24;
            floatingPointBtn.Text = ".";
            floatingPointBtn.UseVisualStyleBackColor = true;
            floatingPointBtn.Click += CalculatorButtonClick;
            // 
            // resultBtn
            // 
            resultBtn.AutoSize = true;
            resultBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            resultBtn.Location = new Point(277, 261);
            resultBtn.Margin = new Padding(1);
            resultBtn.Name = "resultBtn";
            resultBtn.Size = new Size(90, 50);
            resultBtn.TabIndex = 25;
            resultBtn.Text = "=";
            resultBtn.UseVisualStyleBackColor = true;
            resultBtn.Click += CalculatorButtonClick;
            // 
            // resultLabelsPanel
            // 
            resultLabelsPanel.Controls.Add(lastOperationTxtBox);
            resultLabelsPanel.Controls.Add(currentOperationTxtBox);
            resultLabelsPanel.Location = new Point(12, 36);
            resultLabelsPanel.Name = "resultLabelsPanel";
            resultLabelsPanel.Size = new Size(366, 100);
            resultLabelsPanel.TabIndex = 1;
            // 
            // lastOperationTxtBox
            // 
            lastOperationTxtBox.BackColor = SystemColors.Control;
            lastOperationTxtBox.Enabled = false;
            lastOperationTxtBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lastOperationTxtBox.Location = new Point(0, 1);
            lastOperationTxtBox.Name = "lastOperationTxtBox";
            lastOperationTxtBox.RightToLeft = RightToLeft.Yes;
            lastOperationTxtBox.Size = new Size(365, 43);
            lastOperationTxtBox.TabIndex = 2;
            // 
            // currentOperationTxtBox
            // 
            currentOperationTxtBox.BackColor = SystemColors.Control;
            currentOperationTxtBox.Enabled = false;
            currentOperationTxtBox.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            currentOperationTxtBox.Location = new Point(0, 49);
            currentOperationTxtBox.Name = "currentOperationTxtBox";
            currentOperationTxtBox.RightToLeft = RightToLeft.Yes;
            currentOperationTxtBox.Size = new Size(366, 50);
            currentOperationTxtBox.TabIndex = 1;
            // 
            // viewHistoryBtn
            // 
            viewHistoryBtn.Location = new Point(199, 5);
            viewHistoryBtn.Name = "viewHistoryBtn";
            viewHistoryBtn.Size = new Size(179, 26);
            viewHistoryBtn.TabIndex = 2;
            viewHistoryBtn.Text = "View History";
            viewHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(389, 454);
            Controls.Add(viewHistoryBtn);
            Controls.Add(resultLabelsPanel);
            Controls.Add(btnsFlowLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CalculatorForm";
            Padding = new Padding(2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            btnsFlowLayoutPanel.ResumeLayout(false);
            btnsFlowLayoutPanel.PerformLayout();
            resultLabelsPanel.ResumeLayout(false);
            resultLabelsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel btnsFlowLayoutPanel;
        private Button remainderBtn;
        private Button clearEntryBtn;
        private Button clearEverythingBtn;
        private Button undoPreviousActionBtn;
        private Button reciprocationBtn;
        private Button squareBtn;
        private Button rootBtn;
        private Button divisionBtn;
        private Button sevenBtn;
        private Button eightBtn;
        private Button nineBtn;
        private Button multiplyBtn;
        private Button fourBtn;
        private Button fiveBtn;
        private Button sixBtn;
        private Button minusBtn;
        private Button oneBtn;
        private Button twoBtn;
        private Button threeBtn;
        private Button plusBtn;
        private Button changeSignBtn;
        private Button zeroBtn;
        private Button floatingPointBtn;
        private Button resultBtn;
        private Panel resultLabelsPanel;
        private Button viewHistoryBtn;
        private TextBox currentOperationTxtBox;
        private TextBox lastOperationTxtBox;
    }
}