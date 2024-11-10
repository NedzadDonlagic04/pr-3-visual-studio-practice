namespace WinFormsTicTacToe.Forms
{
    partial class TicTacToeGameSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeGameSettingsForm));
            colorDialog = new ColorDialog();
            cancelBtn = new Button();
            saveBtn = new Button();
            warningMsgLbl = new Label();
            botSettingsGrpBox = new GroupBox();
            additionalBotSettingsPnl = new Panel();
            botWillPlayPnl = new Panel();
            playORadioBtn = new RadioButton();
            playXRadioBtn = new RadioButton();
            label2 = new Label();
            botSettingsPnl = new Panel();
            hardDifficultyRadioBtn = new RadioButton();
            easyDifficultyRadioBtn = new RadioButton();
            selectDifficultyLbl = new Label();
            playAgainstBotChkbx = new CheckBox();
            colorSettingsGrpBox = new GroupBox();
            oColorPnl = new Panel();
            oColorLbl = new Label();
            xColorPnl = new Panel();
            xColorLbl = new Label();
            botSettingsGrpBox.SuspendLayout();
            additionalBotSettingsPnl.SuspendLayout();
            botWillPlayPnl.SuspendLayout();
            botSettingsPnl.SuspendLayout();
            colorSettingsGrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.AutoSize = true;
            cancelBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.Location = new Point(216, 467);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(111, 50);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += CancelBtnClick;
            // 
            // saveBtn
            // 
            saveBtn.AutoSize = true;
            saveBtn.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(73, 467);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(111, 50);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += SaveBtnClick;
            // 
            // warningMsgLbl
            // 
            warningMsgLbl.AutoSize = true;
            warningMsgLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            warningMsgLbl.ForeColor = Color.FromArgb(192, 0, 0);
            warningMsgLbl.Location = new Point(72, 9);
            warningMsgLbl.Name = "warningMsgLbl";
            warningMsgLbl.Size = new Size(255, 40);
            warningMsgLbl.TabIndex = 11;
            warningMsgLbl.Text = "Clicking save will apply the settings\r\nand reset the board";
            warningMsgLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // botSettingsGrpBox
            // 
            botSettingsGrpBox.Controls.Add(additionalBotSettingsPnl);
            botSettingsGrpBox.Controls.Add(playAgainstBotChkbx);
            botSettingsGrpBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            botSettingsGrpBox.Location = new Point(73, 168);
            botSettingsGrpBox.Name = "botSettingsGrpBox";
            botSettingsGrpBox.Size = new Size(254, 293);
            botSettingsGrpBox.TabIndex = 10;
            botSettingsGrpBox.TabStop = false;
            botSettingsGrpBox.Text = "Bot settings:";
            // 
            // additionalBotSettingsPnl
            // 
            additionalBotSettingsPnl.Controls.Add(botWillPlayPnl);
            additionalBotSettingsPnl.Controls.Add(botSettingsPnl);
            additionalBotSettingsPnl.Location = new Point(6, 80);
            additionalBotSettingsPnl.Name = "additionalBotSettingsPnl";
            additionalBotSettingsPnl.Size = new Size(242, 202);
            additionalBotSettingsPnl.TabIndex = 2;
            additionalBotSettingsPnl.Visible = false;
            // 
            // botWillPlayPnl
            // 
            botWillPlayPnl.Controls.Add(playORadioBtn);
            botWillPlayPnl.Controls.Add(playXRadioBtn);
            botWillPlayPnl.Controls.Add(label2);
            botWillPlayPnl.Location = new Point(3, 110);
            botWillPlayPnl.Name = "botWillPlayPnl";
            botWillPlayPnl.Size = new Size(236, 74);
            botWillPlayPnl.TabIndex = 5;
            // 
            // playORadioBtn
            // 
            playORadioBtn.AutoSize = true;
            playORadioBtn.Location = new Point(103, 35);
            playORadioBtn.Name = "playORadioBtn";
            playORadioBtn.Size = new Size(50, 36);
            playORadioBtn.TabIndex = 2;
            playORadioBtn.Text = "O";
            playORadioBtn.UseVisualStyleBackColor = true;
            // 
            // playXRadioBtn
            // 
            playXRadioBtn.AutoSize = true;
            playXRadioBtn.Checked = true;
            playXRadioBtn.Location = new Point(15, 35);
            playXRadioBtn.Name = "playXRadioBtn";
            playXRadioBtn.Size = new Size(48, 36);
            playXRadioBtn.TabIndex = 1;
            playXRadioBtn.TabStop = true;
            playXRadioBtn.Text = "X";
            playXRadioBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 0;
            label2.Text = "Bot will play:";
            // 
            // botSettingsPnl
            // 
            botSettingsPnl.Controls.Add(hardDifficultyRadioBtn);
            botSettingsPnl.Controls.Add(easyDifficultyRadioBtn);
            botSettingsPnl.Controls.Add(selectDifficultyLbl);
            botSettingsPnl.Location = new Point(5, 3);
            botSettingsPnl.Name = "botSettingsPnl";
            botSettingsPnl.Size = new Size(234, 83);
            botSettingsPnl.TabIndex = 4;
            // 
            // hardDifficultyRadioBtn
            // 
            hardDifficultyRadioBtn.AutoSize = true;
            hardDifficultyRadioBtn.Location = new Point(101, 35);
            hardDifficultyRadioBtn.Name = "hardDifficultyRadioBtn";
            hardDifficultyRadioBtn.Size = new Size(88, 36);
            hardDifficultyRadioBtn.TabIndex = 2;
            hardDifficultyRadioBtn.Text = "Hard";
            hardDifficultyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // easyDifficultyRadioBtn
            // 
            easyDifficultyRadioBtn.AutoSize = true;
            easyDifficultyRadioBtn.Checked = true;
            easyDifficultyRadioBtn.Location = new Point(13, 35);
            easyDifficultyRadioBtn.Name = "easyDifficultyRadioBtn";
            easyDifficultyRadioBtn.Size = new Size(82, 36);
            easyDifficultyRadioBtn.TabIndex = 1;
            easyDifficultyRadioBtn.TabStop = true;
            easyDifficultyRadioBtn.Text = "Easy";
            easyDifficultyRadioBtn.UseVisualStyleBackColor = true;
            // 
            // selectDifficultyLbl
            // 
            selectDifficultyLbl.AutoSize = true;
            selectDifficultyLbl.Location = new Point(3, 0);
            selectDifficultyLbl.Name = "selectDifficultyLbl";
            selectDifficultyLbl.Size = new Size(198, 32);
            selectDifficultyLbl.TabIndex = 0;
            selectDifficultyLbl.Text = "Select difficulty:";
            // 
            // playAgainstBotChkbx
            // 
            playAgainstBotChkbx.AutoSize = true;
            playAgainstBotChkbx.CheckAlign = ContentAlignment.MiddleRight;
            playAgainstBotChkbx.Location = new Point(6, 38);
            playAgainstBotChkbx.Name = "playAgainstBotChkbx";
            playAgainstBotChkbx.RightToLeft = RightToLeft.No;
            playAgainstBotChkbx.Size = new Size(227, 36);
            playAgainstBotChkbx.TabIndex = 1;
            playAgainstBotChkbx.Text = "Play against bot?";
            playAgainstBotChkbx.UseVisualStyleBackColor = true;
            playAgainstBotChkbx.Click += TogglePlayWithBotSettings;
            // 
            // colorSettingsGrpBox
            // 
            colorSettingsGrpBox.Controls.Add(oColorPnl);
            colorSettingsGrpBox.Controls.Add(oColorLbl);
            colorSettingsGrpBox.Controls.Add(xColorPnl);
            colorSettingsGrpBox.Controls.Add(xColorLbl);
            colorSettingsGrpBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            colorSettingsGrpBox.Location = new Point(73, 54);
            colorSettingsGrpBox.Name = "colorSettingsGrpBox";
            colorSettingsGrpBox.Size = new Size(249, 108);
            colorSettingsGrpBox.TabIndex = 9;
            colorSettingsGrpBox.TabStop = false;
            colorSettingsGrpBox.Text = "Color settings:";
            // 
            // oColorPnl
            // 
            oColorPnl.BorderStyle = BorderStyle.FixedSingle;
            oColorPnl.Location = new Point(139, 71);
            oColorPnl.Name = "oColorPnl";
            oColorPnl.Size = new Size(30, 30);
            oColorPnl.TabIndex = 4;
            oColorPnl.Click += OpenColorDialog;
            // 
            // oColorLbl
            // 
            oColorLbl.AutoSize = true;
            oColorLbl.Location = new Point(24, 67);
            oColorLbl.Name = "oColorLbl";
            oColorLbl.Size = new Size(109, 32);
            oColorLbl.TabIndex = 1;
            oColorLbl.Text = "O Color:";
            // 
            // xColorPnl
            // 
            xColorPnl.BorderStyle = BorderStyle.FixedSingle;
            xColorPnl.Location = new Point(139, 35);
            xColorPnl.Name = "xColorPnl";
            xColorPnl.Size = new Size(30, 30);
            xColorPnl.TabIndex = 3;
            xColorPnl.Click += OpenColorDialog;
            // 
            // xColorLbl
            // 
            xColorLbl.AutoSize = true;
            xColorLbl.Location = new Point(26, 35);
            xColorLbl.Name = "xColorLbl";
            xColorLbl.Size = new Size(107, 32);
            xColorLbl.TabIndex = 0;
            xColorLbl.Text = "X Color:";
            // 
            // TicTacToeGameSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 539);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(warningMsgLbl);
            Controls.Add(botSettingsGrpBox);
            Controls.Add(colorSettingsGrpBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TicTacToeGameSettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            botSettingsGrpBox.ResumeLayout(false);
            botSettingsGrpBox.PerformLayout();
            additionalBotSettingsPnl.ResumeLayout(false);
            botWillPlayPnl.ResumeLayout(false);
            botWillPlayPnl.PerformLayout();
            botSettingsPnl.ResumeLayout(false);
            botSettingsPnl.PerformLayout();
            colorSettingsGrpBox.ResumeLayout(false);
            colorSettingsGrpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog;
        private Button cancelBtn;
        private Button saveBtn;
        private Label warningMsgLbl;
        private GroupBox botSettingsGrpBox;
        private CheckBox playAgainstBotChkbx;
        private GroupBox colorSettingsGrpBox;
        private Panel oColorPnl;
        private Label oColorLbl;
        private Panel xColorPnl;
        private Label xColorLbl;
        private Panel additionalBotSettingsPnl;
        private Panel botWillPlayPnl;
        private RadioButton playORadioBtn;
        private RadioButton playXRadioBtn;
        private Label label2;
        private Panel botSettingsPnl;
        private RadioButton hardDifficultyRadioBtn;
        private RadioButton easyDifficultyRadioBtn;
        private Label selectDifficultyLbl;
    }
}