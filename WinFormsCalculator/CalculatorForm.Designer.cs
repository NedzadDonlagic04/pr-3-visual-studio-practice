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
            lastOperationLbl = new Label();
            resultLbl = new Label();
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
            btnsFlowLayoutPanel.Location = new Point(12, 156);
            btnsFlowLayoutPanel.Margin = new Padding(1);
            btnsFlowLayoutPanel.Name = "btnsFlowLayoutPanel";
            btnsFlowLayoutPanel.Size = new Size(368, 312);
            btnsFlowLayoutPanel.TabIndex = 0;
            // 
            // remainderBtn
            // 
            remainderBtn.AutoSize = true;
            remainderBtn.BackColor = Color.FromArgb(59, 59, 59);
            remainderBtn.FlatStyle = FlatStyle.Flat;
            remainderBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            remainderBtn.ForeColor = Color.FromArgb(226, 226, 226);
            remainderBtn.Location = new Point(1, 1);
            remainderBtn.Margin = new Padding(1);
            remainderBtn.Name = "remainderBtn";
            remainderBtn.Size = new Size(90, 50);
            remainderBtn.TabIndex = 2;
            remainderBtn.Text = "%";
            remainderBtn.UseVisualStyleBackColor = false;
            remainderBtn.Enter += CalcBtnsEnterFocus;
            remainderBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // clearEntryBtn
            // 
            clearEntryBtn.AutoSize = true;
            clearEntryBtn.BackColor = Color.FromArgb(59, 59, 59);
            clearEntryBtn.FlatStyle = FlatStyle.Flat;
            clearEntryBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            clearEntryBtn.ForeColor = Color.FromArgb(226, 226, 226);
            clearEntryBtn.Location = new Point(93, 1);
            clearEntryBtn.Margin = new Padding(1);
            clearEntryBtn.Name = "clearEntryBtn";
            clearEntryBtn.Size = new Size(90, 50);
            clearEntryBtn.TabIndex = 3;
            clearEntryBtn.Text = "CE";
            clearEntryBtn.UseVisualStyleBackColor = false;
            clearEntryBtn.Click += ClearEntryBtnClick;
            clearEntryBtn.Enter += CalcBtnsEnterFocus;
            clearEntryBtn.Leave += CalcBtnsLeaveFocus;
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
            clearEverythingBtn.Click += ClearBtnClick;
            clearEverythingBtn.Enter += CalcBtnsEnterFocus;
            clearEverythingBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // undoPreviousActionBtn
            // 
            undoPreviousActionBtn.AutoSize = true;
            undoPreviousActionBtn.BackColor = Color.FromArgb(59, 59, 59);
            undoPreviousActionBtn.FlatStyle = FlatStyle.Flat;
            undoPreviousActionBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            undoPreviousActionBtn.ForeColor = Color.FromArgb(226, 226, 226);
            undoPreviousActionBtn.Location = new Point(277, 1);
            undoPreviousActionBtn.Margin = new Padding(1);
            undoPreviousActionBtn.Name = "undoPreviousActionBtn";
            undoPreviousActionBtn.Size = new Size(90, 50);
            undoPreviousActionBtn.TabIndex = 5;
            undoPreviousActionBtn.Text = "⌫";
            undoPreviousActionBtn.UseVisualStyleBackColor = false;
            undoPreviousActionBtn.Click += UndoPreviousActionBtnClick;
            undoPreviousActionBtn.Enter += CalcBtnsEnterFocus;
            undoPreviousActionBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // reciprocationBtn
            // 
            reciprocationBtn.AutoSize = true;
            reciprocationBtn.BackColor = Color.FromArgb(59, 59, 59);
            reciprocationBtn.FlatStyle = FlatStyle.Flat;
            reciprocationBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            reciprocationBtn.ForeColor = Color.FromArgb(226, 226, 226);
            reciprocationBtn.Location = new Point(1, 53);
            reciprocationBtn.Margin = new Padding(1);
            reciprocationBtn.Name = "reciprocationBtn";
            reciprocationBtn.Size = new Size(90, 50);
            reciprocationBtn.TabIndex = 6;
            reciprocationBtn.Text = "x⁻¹";
            reciprocationBtn.UseVisualStyleBackColor = false;
            reciprocationBtn.Click += SpecialOperationBtnClick;
            reciprocationBtn.Enter += CalcBtnsEnterFocus;
            reciprocationBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // squareBtn
            // 
            squareBtn.AutoSize = true;
            squareBtn.BackColor = Color.FromArgb(59, 59, 59);
            squareBtn.FlatStyle = FlatStyle.Flat;
            squareBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            squareBtn.ForeColor = Color.FromArgb(226, 226, 226);
            squareBtn.Location = new Point(93, 53);
            squareBtn.Margin = new Padding(1);
            squareBtn.Name = "squareBtn";
            squareBtn.Size = new Size(90, 50);
            squareBtn.TabIndex = 7;
            squareBtn.Tag = "";
            squareBtn.Text = "x²";
            squareBtn.UseVisualStyleBackColor = false;
            squareBtn.Click += SpecialOperationBtnClick;
            squareBtn.Enter += CalcBtnsEnterFocus;
            squareBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // rootBtn
            // 
            rootBtn.AutoSize = true;
            rootBtn.BackColor = Color.FromArgb(59, 59, 59);
            rootBtn.FlatStyle = FlatStyle.Flat;
            rootBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rootBtn.ForeColor = Color.FromArgb(226, 226, 226);
            rootBtn.Location = new Point(185, 53);
            rootBtn.Margin = new Padding(1);
            rootBtn.Name = "rootBtn";
            rootBtn.Size = new Size(90, 50);
            rootBtn.TabIndex = 8;
            rootBtn.Text = "√";
            rootBtn.UseVisualStyleBackColor = false;
            rootBtn.Click += SpecialOperationBtnClick;
            rootBtn.Enter += CalcBtnsEnterFocus;
            rootBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // divisionBtn
            // 
            divisionBtn.AutoSize = true;
            divisionBtn.BackColor = Color.FromArgb(59, 59, 59);
            divisionBtn.FlatStyle = FlatStyle.Flat;
            divisionBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            divisionBtn.ForeColor = Color.FromArgb(226, 226, 226);
            divisionBtn.Location = new Point(277, 53);
            divisionBtn.Margin = new Padding(1);
            divisionBtn.Name = "divisionBtn";
            divisionBtn.Size = new Size(90, 50);
            divisionBtn.TabIndex = 9;
            divisionBtn.Text = "÷";
            divisionBtn.UseVisualStyleBackColor = false;
            divisionBtn.Click += OperationBtnClick;
            divisionBtn.Enter += CalcBtnsEnterFocus;
            divisionBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // sevenBtn
            // 
            sevenBtn.AutoSize = true;
            sevenBtn.BackColor = Color.FromArgb(59, 59, 59);
            sevenBtn.FlatStyle = FlatStyle.Flat;
            sevenBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sevenBtn.ForeColor = Color.FromArgb(226, 226, 226);
            sevenBtn.Location = new Point(1, 105);
            sevenBtn.Margin = new Padding(1);
            sevenBtn.Name = "sevenBtn";
            sevenBtn.Size = new Size(90, 50);
            sevenBtn.TabIndex = 10;
            sevenBtn.Text = "7";
            sevenBtn.UseVisualStyleBackColor = false;
            sevenBtn.Click += NumberBtnClick;
            sevenBtn.Enter += CalcBtnsEnterFocus;
            sevenBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // eightBtn
            // 
            eightBtn.AutoSize = true;
            eightBtn.BackColor = Color.FromArgb(59, 59, 59);
            eightBtn.FlatStyle = FlatStyle.Flat;
            eightBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            eightBtn.ForeColor = Color.FromArgb(226, 226, 226);
            eightBtn.Location = new Point(93, 105);
            eightBtn.Margin = new Padding(1);
            eightBtn.Name = "eightBtn";
            eightBtn.Size = new Size(90, 50);
            eightBtn.TabIndex = 11;
            eightBtn.Text = "8";
            eightBtn.UseVisualStyleBackColor = false;
            eightBtn.Click += NumberBtnClick;
            eightBtn.Enter += CalcBtnsEnterFocus;
            eightBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // nineBtn
            // 
            nineBtn.AutoSize = true;
            nineBtn.BackColor = Color.FromArgb(59, 59, 59);
            nineBtn.FlatStyle = FlatStyle.Flat;
            nineBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nineBtn.ForeColor = Color.FromArgb(226, 226, 226);
            nineBtn.Location = new Point(185, 105);
            nineBtn.Margin = new Padding(1);
            nineBtn.Name = "nineBtn";
            nineBtn.Size = new Size(90, 50);
            nineBtn.TabIndex = 12;
            nineBtn.Text = "9";
            nineBtn.UseVisualStyleBackColor = false;
            nineBtn.Click += NumberBtnClick;
            nineBtn.Enter += CalcBtnsEnterFocus;
            nineBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // multiplyBtn
            // 
            multiplyBtn.AutoSize = true;
            multiplyBtn.BackColor = Color.FromArgb(59, 59, 59);
            multiplyBtn.FlatStyle = FlatStyle.Flat;
            multiplyBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            multiplyBtn.ForeColor = Color.FromArgb(226, 226, 226);
            multiplyBtn.Location = new Point(277, 105);
            multiplyBtn.Margin = new Padding(1);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(90, 50);
            multiplyBtn.TabIndex = 13;
            multiplyBtn.Text = "×";
            multiplyBtn.UseVisualStyleBackColor = false;
            multiplyBtn.Click += OperationBtnClick;
            multiplyBtn.Enter += CalcBtnsEnterFocus;
            multiplyBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // fourBtn
            // 
            fourBtn.AutoSize = true;
            fourBtn.BackColor = Color.FromArgb(59, 59, 59);
            fourBtn.FlatStyle = FlatStyle.Flat;
            fourBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            fourBtn.ForeColor = Color.FromArgb(226, 226, 226);
            fourBtn.Location = new Point(1, 157);
            fourBtn.Margin = new Padding(1);
            fourBtn.Name = "fourBtn";
            fourBtn.Size = new Size(90, 50);
            fourBtn.TabIndex = 14;
            fourBtn.Text = "4";
            fourBtn.UseVisualStyleBackColor = false;
            fourBtn.Click += NumberBtnClick;
            fourBtn.Enter += CalcBtnsEnterFocus;
            fourBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // fiveBtn
            // 
            fiveBtn.AutoSize = true;
            fiveBtn.BackColor = Color.FromArgb(59, 59, 59);
            fiveBtn.FlatStyle = FlatStyle.Flat;
            fiveBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            fiveBtn.ForeColor = Color.FromArgb(226, 226, 226);
            fiveBtn.Location = new Point(93, 157);
            fiveBtn.Margin = new Padding(1);
            fiveBtn.Name = "fiveBtn";
            fiveBtn.Size = new Size(90, 50);
            fiveBtn.TabIndex = 15;
            fiveBtn.Text = "5";
            fiveBtn.UseVisualStyleBackColor = false;
            fiveBtn.Click += NumberBtnClick;
            fiveBtn.Enter += CalcBtnsEnterFocus;
            fiveBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // sixBtn
            // 
            sixBtn.AutoSize = true;
            sixBtn.BackColor = Color.FromArgb(59, 59, 59);
            sixBtn.FlatStyle = FlatStyle.Flat;
            sixBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            sixBtn.ForeColor = Color.FromArgb(226, 226, 226);
            sixBtn.Location = new Point(185, 157);
            sixBtn.Margin = new Padding(1);
            sixBtn.Name = "sixBtn";
            sixBtn.Size = new Size(90, 50);
            sixBtn.TabIndex = 16;
            sixBtn.Text = "6";
            sixBtn.UseVisualStyleBackColor = false;
            sixBtn.Click += NumberBtnClick;
            sixBtn.Enter += CalcBtnsEnterFocus;
            sixBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // minusBtn
            // 
            minusBtn.AutoSize = true;
            minusBtn.BackColor = Color.FromArgb(59, 59, 59);
            minusBtn.FlatStyle = FlatStyle.Flat;
            minusBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            minusBtn.ForeColor = Color.FromArgb(226, 226, 226);
            minusBtn.Location = new Point(277, 157);
            minusBtn.Margin = new Padding(1);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(90, 50);
            minusBtn.TabIndex = 17;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = false;
            minusBtn.Click += OperationBtnClick;
            minusBtn.Enter += CalcBtnsEnterFocus;
            minusBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // oneBtn
            // 
            oneBtn.AutoSize = true;
            oneBtn.BackColor = Color.FromArgb(59, 59, 59);
            oneBtn.FlatStyle = FlatStyle.Flat;
            oneBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            oneBtn.ForeColor = Color.FromArgb(226, 226, 226);
            oneBtn.Location = new Point(1, 209);
            oneBtn.Margin = new Padding(1);
            oneBtn.Name = "oneBtn";
            oneBtn.Size = new Size(90, 50);
            oneBtn.TabIndex = 18;
            oneBtn.Text = "1";
            oneBtn.UseVisualStyleBackColor = false;
            oneBtn.Click += NumberBtnClick;
            oneBtn.Enter += CalcBtnsEnterFocus;
            oneBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // twoBtn
            // 
            twoBtn.AutoSize = true;
            twoBtn.BackColor = Color.FromArgb(59, 59, 59);
            twoBtn.FlatStyle = FlatStyle.Flat;
            twoBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            twoBtn.ForeColor = Color.FromArgb(226, 226, 226);
            twoBtn.Location = new Point(93, 209);
            twoBtn.Margin = new Padding(1);
            twoBtn.Name = "twoBtn";
            twoBtn.Size = new Size(90, 50);
            twoBtn.TabIndex = 19;
            twoBtn.Text = "2";
            twoBtn.UseVisualStyleBackColor = false;
            twoBtn.Click += NumberBtnClick;
            twoBtn.Enter += CalcBtnsEnterFocus;
            twoBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // threeBtn
            // 
            threeBtn.AutoSize = true;
            threeBtn.BackColor = Color.FromArgb(59, 59, 59);
            threeBtn.FlatStyle = FlatStyle.Flat;
            threeBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            threeBtn.ForeColor = Color.FromArgb(226, 226, 226);
            threeBtn.Location = new Point(185, 209);
            threeBtn.Margin = new Padding(1);
            threeBtn.Name = "threeBtn";
            threeBtn.Size = new Size(90, 50);
            threeBtn.TabIndex = 20;
            threeBtn.Text = "3";
            threeBtn.UseVisualStyleBackColor = false;
            threeBtn.Click += NumberBtnClick;
            threeBtn.Enter += CalcBtnsEnterFocus;
            threeBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // plusBtn
            // 
            plusBtn.AutoSize = true;
            plusBtn.BackColor = Color.FromArgb(59, 59, 59);
            plusBtn.FlatStyle = FlatStyle.Flat;
            plusBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            plusBtn.ForeColor = Color.FromArgb(226, 226, 226);
            plusBtn.Location = new Point(277, 209);
            plusBtn.Margin = new Padding(1);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(90, 50);
            plusBtn.TabIndex = 21;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = false;
            plusBtn.Click += OperationBtnClick;
            plusBtn.Enter += CalcBtnsEnterFocus;
            plusBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // changeSignBtn
            // 
            changeSignBtn.AutoSize = true;
            changeSignBtn.BackColor = Color.FromArgb(59, 59, 59);
            changeSignBtn.FlatStyle = FlatStyle.Flat;
            changeSignBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            changeSignBtn.ForeColor = Color.FromArgb(226, 226, 226);
            changeSignBtn.Location = new Point(1, 261);
            changeSignBtn.Margin = new Padding(1);
            changeSignBtn.Name = "changeSignBtn";
            changeSignBtn.Size = new Size(90, 50);
            changeSignBtn.TabIndex = 22;
            changeSignBtn.Text = "±";
            changeSignBtn.UseVisualStyleBackColor = false;
            changeSignBtn.Click += SwitchSignBtnClick;
            changeSignBtn.Enter += CalcBtnsEnterFocus;
            changeSignBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // zeroBtn
            // 
            zeroBtn.AutoSize = true;
            zeroBtn.BackColor = Color.FromArgb(59, 59, 59);
            zeroBtn.FlatStyle = FlatStyle.Flat;
            zeroBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            zeroBtn.ForeColor = Color.FromArgb(226, 226, 226);
            zeroBtn.Location = new Point(93, 261);
            zeroBtn.Margin = new Padding(1);
            zeroBtn.Name = "zeroBtn";
            zeroBtn.Size = new Size(90, 50);
            zeroBtn.TabIndex = 23;
            zeroBtn.Text = "0";
            zeroBtn.UseVisualStyleBackColor = false;
            zeroBtn.Click += NumberBtnClick;
            zeroBtn.Enter += CalcBtnsEnterFocus;
            zeroBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // floatingPointBtn
            // 
            floatingPointBtn.AutoSize = true;
            floatingPointBtn.BackColor = Color.FromArgb(59, 59, 59);
            floatingPointBtn.FlatStyle = FlatStyle.Flat;
            floatingPointBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            floatingPointBtn.ForeColor = Color.FromArgb(226, 226, 226);
            floatingPointBtn.Location = new Point(185, 261);
            floatingPointBtn.Margin = new Padding(1);
            floatingPointBtn.Name = "floatingPointBtn";
            floatingPointBtn.Size = new Size(90, 50);
            floatingPointBtn.TabIndex = 24;
            floatingPointBtn.Text = ".";
            floatingPointBtn.UseVisualStyleBackColor = false;
            floatingPointBtn.Click += FloatingPointBtnClick;
            floatingPointBtn.Enter += CalcBtnsEnterFocus;
            floatingPointBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // resultBtn
            // 
            resultBtn.AutoSize = true;
            resultBtn.BackColor = Color.FromArgb(59, 59, 59);
            resultBtn.FlatStyle = FlatStyle.Flat;
            resultBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            resultBtn.ForeColor = Color.FromArgb(226, 226, 226);
            resultBtn.Location = new Point(277, 261);
            resultBtn.Margin = new Padding(1);
            resultBtn.Name = "resultBtn";
            resultBtn.Size = new Size(90, 50);
            resultBtn.TabIndex = 25;
            resultBtn.Text = "=";
            resultBtn.UseVisualStyleBackColor = false;
            resultBtn.Click += EqualsBtnClick;
            resultBtn.Enter += CalcBtnsEnterFocus;
            resultBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // resultLabelsPanel
            // 
            resultLabelsPanel.Controls.Add(lastOperationLbl);
            resultLabelsPanel.Controls.Add(resultLbl);
            resultLabelsPanel.Location = new Point(12, 53);
            resultLabelsPanel.Name = "resultLabelsPanel";
            resultLabelsPanel.Size = new Size(366, 100);
            resultLabelsPanel.TabIndex = 1;
            // 
            // lastOperationLbl
            // 
            lastOperationLbl.BackColor = Color.FromArgb(226, 226, 226);
            lastOperationLbl.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lastOperationLbl.ForeColor = Color.FromArgb(59, 59, 59);
            lastOperationLbl.Location = new Point(0, 0);
            lastOperationLbl.Name = "lastOperationLbl";
            lastOperationLbl.RightToLeft = RightToLeft.No;
            lastOperationLbl.Size = new Size(365, 43);
            lastOperationLbl.TabIndex = 4;
            lastOperationLbl.TextAlign = ContentAlignment.BottomRight;
            lastOperationLbl.Click += OperationBtnClick;
            // 
            // resultLbl
            // 
            resultLbl.BackColor = Color.FromArgb(226, 226, 226);
            resultLbl.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            resultLbl.ForeColor = Color.FromArgb(59, 59, 59);
            resultLbl.Location = new Point(0, 50);
            resultLbl.Name = "resultLbl";
            resultLbl.RightToLeft = RightToLeft.No;
            resultLbl.Size = new Size(365, 50);
            resultLbl.TabIndex = 3;
            resultLbl.Text = "0";
            resultLbl.TextAlign = ContentAlignment.BottomRight;
            // 
            // viewHistoryBtn
            // 
            viewHistoryBtn.AutoSize = true;
            viewHistoryBtn.BackColor = Color.FromArgb(59, 59, 59);
            viewHistoryBtn.FlatStyle = FlatStyle.Flat;
            viewHistoryBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            viewHistoryBtn.ForeColor = Color.FromArgb(226, 226, 226);
            viewHistoryBtn.Location = new Point(199, 5);
            viewHistoryBtn.Name = "viewHistoryBtn";
            viewHistoryBtn.Size = new Size(179, 42);
            viewHistoryBtn.TabIndex = 2;
            viewHistoryBtn.Text = "View History";
            viewHistoryBtn.UseVisualStyleBackColor = false;
            viewHistoryBtn.Enter += CalcBtnsEnterFocus;
            viewHistoryBtn.Leave += CalcBtnsLeaveFocus;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(390, 471);
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
            ResumeLayout(false);
            PerformLayout();
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
        private Label resultLbl;
        private Label lastOperationLbl;
    }
}