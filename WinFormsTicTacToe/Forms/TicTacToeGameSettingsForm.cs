using WinFormsTicTacToe.Classes;
using WinFormsTicTacToe.Enums;

namespace WinFormsTicTacToe.Forms
{
    /// <summary>
    ///     A form that allows to configure tic tac toe game
    ///     settings
    /// </summary>
    internal partial class TicTacToeGameSettingsForm : Form
    {
        #region Fields, constants, properties

        internal TicTacToeGameSettings? Settings { get; private set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams baseParams = base.CreateParams;
                baseParams.ClassStyle |= CP_NOCLOSE_BUTTON;
                return baseParams;
            }
        }

        private const int CP_NOCLOSE_BUTTON = 0x0000_0200;

        #endregion

        #region Internal methods

        /// <summary>
        ///     Constructs an instance of TicTacToeGameSettingsForm
        /// </summary>
        /// <param name="settings">Optional settings to initialize the form with</param>
        internal TicTacToeGameSettingsForm(TicTacToeGameSettings? settings = null)
        {
            InitializeComponent();

            Settings = settings;
            ApplySettings();
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Sets the given form controls to have the same values
        ///     as the Settings property
        /// </summary>
        private void ApplySettings()
        {
            if (Settings == null)
            {
                return;
            }

            xColorPnl.BackColor = Settings.XColor;
            oColorPnl.BackColor = Settings.OColor;

            bool isBotDifficultySet = Settings.BotDifficulty != null;

            playAgainstBotChkbx.Checked = isBotDifficultySet;
            additionalBotSettingsPnl.Visible = isBotDifficultySet;

            if (!isBotDifficultySet)
            {
                easyDifficultyRadioBtn.Checked = true;
                playXRadioBtn.Checked = true;
                return;
            }

            if (Settings.BotDifficulty == BotDifficulty.Easy)
            {
                easyDifficultyRadioBtn.Checked = true;
            }
            else
            {
                hardDifficultyRadioBtn.Checked = true;
            }
            
            if (Settings.IsBotPlayingFirst)
            {
                playXRadioBtn.Checked = true;
            }
            else
            {
                playORadioBtn.Checked = true;
            }
        }

        /// <summary>
        ///     Opens the color dialog and assigns the value
        ///     selected to the panel that was clicked
        ///     (if all goes well)
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void OpenColorDialog(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            Panel colorPnl = (Panel)sender;

            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                colorPnl.BackColor = colorDialog.Color;
            }
        }

        /// <summary>
        ///     Toggles the visibility of additional bot settings
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void TogglePlayWithBotSettings(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            CheckBox checkBox = (CheckBox)sender;

            additionalBotSettingsPnl.Visible = checkBox.Checked;
        }

        /// <summary>
        ///     Closes the form, sets DialogResult
        ///     and Settings property
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        /// <inheritdoc cref="CreateSettings"/>
        private void SaveBtnClick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            DialogResult = DialogResult.Yes;
            Settings = CreateSettings();
            Close();
        }

        /// <summary>
        ///     Closes the form and sets DialogResult
        /// </summary>
        /// <param name="sender">Object that triggered the event</param>
        /// <param name="e">Event arguments</param>
        private void CancelBtnClick(object? sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            DialogResult = DialogResult.No;
            Close();
        }

        /// <summary>
        ///     Creates and returns a settings object based on the form's
        ///     various inputs
        /// </summary>
        /// <returns>TicTacToeBoardSettings object</returns>
        /// <inheritdoc cref="GetBotDifficulty"/>
        private TicTacToeGameSettings CreateSettings()
        {
            TicTacToeGameSettings settings = new(
                xColorPnl.BackColor,
                oColorPnl.BackColor,
                additionalBotSettingsPnl.Visible ? GetBotDifficulty() : null,
                playXRadioBtn.Checked
            );

            return settings;
        }

        /// <summary>
        ///     Return the bot difficulty for the selected checkbox
        /// </summary>
        /// <returns>Difficulty of the bot through the enum BotDifficulty</returns>
        /// <exception cref="NotImplementedException">
        ///     Thrown if the selected checkbox doesn't have a specified
        ///     difficulty to return
        /// </exception>
        private BotDifficulty GetBotDifficulty()
        {
            if (easyDifficultyRadioBtn.Checked)
            {
                return BotDifficulty.Easy;
            }
            else if (hardDifficultyRadioBtn.Checked)
            {
                return BotDifficulty.Hard;
            }

            throw new NotImplementedException("Difficulty not implemented");
        }

        #endregion
    }
}
