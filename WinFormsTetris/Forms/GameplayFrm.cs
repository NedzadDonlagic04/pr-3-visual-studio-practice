using NAudio.Wave;
using TetrisGameLogic.Classes;

namespace WinFormsTetris
{
    public partial class GameplayFrm : Form
    {
        #region Fields and properties

        private bool _areShadowsEnabled = false;
        private const int DefaultColor = 0;
        private const int AnimationColor = 100;
        private const int ShadowColor = 101;
        private const int NextTetrominoBoxSize = 4;
        private readonly TetrisGame _tetrisGame = new();
        private readonly List<PictureBox> _boardTiles;
        private readonly List<PictureBox> _nextTetrominoTiles;
        private readonly WaveOutEvent _outputDevice;
        private readonly AudioFileReader _audioFile;

        #endregion

        #region Public methods

        public GameplayFrm()
        {
            InitializeComponent();

            string audioFilePath = Path.Combine(".", "Resources", "tetrominoDrop.mp3");
            _audioFile = new AudioFileReader(audioFilePath);
            _outputDevice = new WaveOutEvent();
            _outputDevice.Init(_audioFile);

            // Because opening the Designer with 150+ picture boxes is suicide for VS
            // and changing the interval is something I do often for testing I will 
            // leave it here
            gameTmr.Interval = 500;

            _boardTiles = gameTilesContainer.Controls.Cast<PictureBox>().ToList();
            _nextTetrominoTiles = nextTetrominoTilesContainer.Controls.Cast<PictureBox>().ToList();

            RestartGame();
        }

        #endregion

        #region Private methods

        private void RestartGame()
        {
            _tetrisGame.RestartGame();
            UpdatePlayerScore();
            ResetBoardTiles();
            ResetNextTetrominoTiles();

            if (!gameTmr.Enabled)
            {
                gameTmr.Tick += GameTimerTick;
                gameTmr.Enabled = true;
                gameOverLbl.Visible = false;
            }

            DrawGameBoard();
        }

        private void ToggleShadowsBtnClick(object? sender, EventArgs e)
            => _areShadowsEnabled = !_areShadowsEnabled;

        private void RestartGameBtnClick(object? sender, EventArgs e)
            => RestartGame();

        private void GameplayFrm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    _tetrisGame.MoveTetrominoLeft();
                    break;
                case Keys.S:
                    _tetrisGame.HardDropTetromino();
                    PlayHardDropSfx();
                    break;
                case Keys.D:
                    _tetrisGame.MoveTetrominoRight();
                    break;
                case Keys.T:
                    toggleShadowsBtn.PerformClick();
                    break;
                case Keys.K:
                    _tetrisGame.RotateTetrominoLeft();
                    break;
                case Keys.L:
                    _tetrisGame.RotateTetrominoRight();
                    break;
            }
        }

        private void PlayHardDropSfx()
        {
            _audioFile.Seek(0, SeekOrigin.Begin);
            _outputDevice.Play();
        }

        private void GameTimerTick(object? sender, EventArgs e)
        {
            _tetrisGame.MoveTetrominoDown();
            DrawGameBoard();
            DrawNextTetromino();
            UpdatePlayerScore();

            if (_tetrisGame.IsGameOver)
            {
                gameTmr.Tick -= GameTimerTick;
                gameTmr.Enabled = false;
                gameOverLbl.Visible = true;
            }
        }

        private void ResetBoardTiles()
        {
            foreach (var pb in _boardTiles)
            {
                pb.BackColor = Color.White;
            }
        }

        private void ResetNextTetrominoTiles()
        {
            foreach (var pb in _nextTetrominoTiles)
            {
                pb.BackColor = Color.White;
            }
        }

        private void UpdatePlayerScore()
        {
            scoreLbl.Text = _tetrisGame.Score.ToString();
            clearedLinesLbl.Text = _tetrisGame.TotalClearedLines.ToString();
        }

        private Color GetColorForId(int colorId)
        {
            return colorId switch
            {
                DefaultColor => Color.White,
                1 => Color.Red,
                2 => Color.DarkOrange,
                3 => Color.Green,
                4 => Color.Blue,
                5 => Color.Cyan,
                6 => Color.DarkMagenta,
                7 => Color.DarkBlue,
                8 => Color.Gray,
                AnimationColor => Color.Yellow,
                ShadowColor => Color.Black,
                _ => throw new NotImplementedException()
            };
        }
        private void DrawGameBoard()
        {
            AnimateClearedLines(_tetrisGame.ClearedLines);

            DrawBoard();
            DrawTetrominoShadow();
            DrawTetromino();
        }

        private void AnimateClearedLines(List<int> clearedLines)
        {
            if (clearedLines.Count == 0)
            {
                return;
            }

            int cols = TetrisGame.Cols;

            foreach (int row in clearedLines)
            {
                for (int i = 0; i < cols; ++i)
                {
                    _boardTiles[row * cols + i].BackColor = GetColorForId(AnimationColor);
                    _boardTiles[row * cols + i].Update();
                }
            }

            Thread.Sleep(100);
        }

        private void DrawBoard()
        {
            int rows = TetrisGame.Rows;
            int cols = TetrisGame.Cols;
            var board = _tetrisGame.Board;

            for (int i = 0; i < rows; ++i)
            {
                for (int ii = 0; ii < cols; ++ii)
                {
                    _boardTiles[i * cols + ii].BackColor = GetColorForId(board[i, ii]);
                }
            }
        }

        private bool AreIndexesInRange(int row, int col, Tetromino tetromino)
        {
            bool isRowValid = row >= 0 && row < TetrisGame.Rows;
            bool isColValid = col >= 0 && col < TetrisGame.Cols;

            return isRowValid && isColValid;
        }

        private void DrawTetrominoShadow()
        {
            if (!_areShadowsEnabled)
            {
                return;
            }

            int x = _tetrisGame.ShadowPos.X;
            int y = _tetrisGame.ShadowPos.Y;
            Tetromino tetromino = _tetrisGame.CurrentTetromino;
            int size = tetromino.Size;
            int cols = TetrisGame.Cols;

            for (int i = y; i < y + size; ++i)
            {
                for (int ii = x; ii < x + size; ++ii)
                {
                    if (AreIndexesInRange(i, ii, tetromino) && tetromino[i - y, ii - x] != 0)
                    {
                        _boardTiles[i * cols + ii].BackColor = GetColorForId(ShadowColor);
                    }
                }
            }
        }

        private void DrawTetromino()
        {
            int x = _tetrisGame.PlayerPos.X;
            int y = _tetrisGame.PlayerPos.Y;
            Tetromino tetromino = _tetrisGame.CurrentTetromino;
            int size = tetromino.Size;
            int cols = TetrisGame.Cols;

            for (int i = y; i < y + size; ++i)
            {
                for (int ii = x; ii < x + size; ++ii)
                {
                    if (AreIndexesInRange(i, ii, tetromino) && tetromino[i - y, ii - x] != 0)
                    {
                        _boardTiles[i * cols + ii].BackColor = GetColorForId(tetromino[i - y, ii - x]);
                        System.Diagnostics.Debug.WriteLine($"[{i} * {cols} + {ii}] = [{i * cols + ii}]");
                    }
                }
            }
        }

        private void DrawNextTetromino()
        {
            Tetromino tetromino = _tetrisGame.NextTetromino;
            int size = tetromino.Size;

            for (int i = 0; i < NextTetrominoBoxSize; ++i)
            {
                for (int ii = 0; ii < NextTetrominoBoxSize; ++ii)
                {
                    if (i < size && ii < size)
                    {
                        _nextTetrominoTiles[i * NextTetrominoBoxSize + ii].BackColor = GetColorForId(tetromino[i, ii]);
                    }
                    else
                    {
                        _nextTetrominoTiles[i * NextTetrominoBoxSize + ii].BackColor = GetColorForId(DefaultColor);
                    }
                }
            }

            for (int i = 0; i < size; ++i)
            {
                for (int ii = 0; ii < size; ++ii)
                {
                    _nextTetrominoTiles[i * NextTetrominoBoxSize + ii].BackColor = GetColorForId(tetromino[i, ii]);
                }
            }
        }

        #endregion
    }
}