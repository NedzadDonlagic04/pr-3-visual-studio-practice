﻿namespace WinFormsTetris.Forms
{
    public partial class MainMenuFrm : Form
    {
        #region Public methods

        public MainMenuFrm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        private void PlayBtnClick(object? sender, EventArgs e)
        {
            using GameplayFrm gameplayFrm = new();
            Hide();
            gameplayFrm.ShowDialog();
            Show();
        }

        private void HighScoresBtnClick(object? sender, EventArgs e)
        {
            using HighScoresFrm highScoresFrm = new();
            Hide();
            highScoresFrm.ShowDialog();
            Show();
        }

        private void QuitBtnClick(object? sender, EventArgs e)
            => Close();

        #endregion
    }
}
