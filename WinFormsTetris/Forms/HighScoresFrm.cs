using TetrisGameLogic.Classes;

namespace WinFormsTetris.Forms
{
    public partial class HighScoresFrm : Form
    {
        #region Fields and properties

        private readonly HighScoreManager _highScoreManager = new();

        #endregion

        #region Public methods

        public HighScoresFrm()
        {
            InitializeComponent();
        }

        #endregion

        #region Private methods

        private void HighScoresFormLoad(object? sender, EventArgs e)
        {
            SetDgvProperties();
            LoadHighScoresIntoDgv();
        }

        private void HighScoresDgvSelectionChanged(object? sender, EventArgs e)
        {
            highScoresDgv.ClearSelection();
        }

        private void SetDgvProperties()
        {
            highScoresDgv.ReadOnly = true;
            highScoresDgv.MultiSelect = false;
            highScoresDgv.AutoGenerateColumns = false;
            highScoresDgv.AllowUserToResizeColumns = false;
            highScoresDgv.AllowUserToResizeRows = false;

            DateAndTime.DefaultCellStyle.Format = "HH:mm:ss dd.MM.yyyy";
        }

        private void LoadHighScoresIntoDgv()
        {
            var highScores = _highScoreManager.HighScores;

            highScoresDgv.DataSource = highScores;

            for (int i = 0; i < highScores.Count; ++i)
            {
                highScoresDgv.Rows[i].Cells["Pos"].Value = i + 1;
                if ((DateTime.Now - highScores[i].DateTime).Minutes <= 5)
                {
                    highScoresDgv.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        #endregion
    }
}
