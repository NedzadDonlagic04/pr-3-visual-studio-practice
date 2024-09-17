using Extensions;

namespace WinFormsSnake
{
    public partial class SnakeGameplayForm : Form
    {
        public enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        private const int GameFieldRows = 9;
        private const int GameFieldCols = 19;
        private readonly PictureBox[,] _grassTiles = new PictureBox[GameFieldRows, GameFieldCols];
        private Point _applePoint;
        private readonly LinkedList<Point> _snakePoints = new();
        private readonly Point InitialApplePoint = new(5, 4);
        private readonly Random random = new();
        private Direction _currentDirection = Direction.LEFT;

        public SnakeGameplayForm()
        {
            InitializeComponent();
            ApplySharedTheme();
            InitializeGrassTilesAndSetThemToMainBGColor();
        }

        private void ApplySharedTheme()
        {
            BackColor = Color.FromName(Properties.Resources.mainBackColor);
            ForeColor = Color.FromName(Properties.Resources.mainForeColor);
        }
        private void InitializeGrassTilesAndSetThemToMainBGColor()
        {
            int rows = _grassTiles.GetLength(0);
            int cols = _grassTiles.GetLength(1);
            PictureBox? currentPictureBox;

            for (int i = 0; i < rows; ++i)
            {
                for (int ii = 0; ii < cols; ++ii)
                {
                    currentPictureBox = snakeTilesFlowLayoutPanel.Controls[i * cols + ii] as PictureBox;

                    if (currentPictureBox == null)
                    {
                        continue;
                    }

                    _grassTiles[i, ii] = currentPictureBox;
                    _grassTiles[i, ii].BackColor = Color.FromName(Properties.Resources.mainBackColor);
                }
            }
        }

        private Point GetRandomPointOnField()
        {
            return new()
            {
                X = random.Next(0, GameFieldCols),
                Y = random.Next(0, GameFieldRows) 
            };
        }

        private static Image GetSnakeHeadImageForDirection(Direction direction)
        {
            return direction switch
            {
                Direction.UP => Properties.Resources.snakeHeadTurnedUp,
                Direction.DOWN => Properties.Resources.snakeHeadTurnedDown,
                Direction.LEFT => Properties.Resources.snakeHeadTurnedLeft,
                _ => Properties.Resources.snakeHeadTurnedRight,
            };
        }

        private static Point GetPointOffsetForDirection(Direction direction)
        {
            return direction switch
            {
                Direction.UP => new() { X = 0, Y = -1 },
                Direction.DOWN => new() { X = 0, Y = 1 },
                Direction.LEFT => new() { X = -1, Y = 0 },
                _ => new() { X = 1, Y = 0 },
            };
        }

        private Point GetNextHeadPoint() 
        {
            Point headPoint = _snakePoints.First();

            return headPoint.Sum(GetPointOffsetForDirection(_currentDirection));
        }

        private void ClearPreviouslyDrawnOnPoints() 
        {
            _grassTiles[_applePoint.Y, _applePoint.X].BackColor = Color.FromName(Properties.Resources.mainBackColor);
            _applePoint = InitialApplePoint;

            foreach (Point snakePoint in _snakePoints) {
                _grassTiles[snakePoint.Y, snakePoint.X].BackColor = Color.FromName(Properties.Resources.mainBackColor);
            }

            Point headPoint = _snakePoints.FirstOrDefault();
            _grassTiles[headPoint.Y, headPoint.X].BackgroundImage = null;

            _snakePoints.Clear();
        }

        private void SetInitialSnakePosAndDraw()
        {
            for (int appleOffset = 6; appleOffset < 9; ++appleOffset)
            {
                Point snakePoint = new() { X = _applePoint.X + appleOffset, Y = _applePoint.Y };
                _snakePoints.AddLast(snakePoint);
                _grassTiles[snakePoint.Y, snakePoint.X].BackColor = Color.FromName(Properties.Resources.mainForeColor);
            }

            Point headPoint = _snakePoints.First();
            _grassTiles[headPoint.Y, headPoint.X].BackgroundImage = GetSnakeHeadImageForDirection(_currentDirection);
        }

        private void DrawSnake()
        {
            Point headPoint = _snakePoints.First();
            _grassTiles[headPoint.Y, headPoint.X].BackgroundImage = GetSnakeHeadImageForDirection(_currentDirection);

            Point previousHeadPoint = _snakePoints.ElementAt(1);
            _grassTiles[previousHeadPoint.Y, previousHeadPoint.X].BackgroundImage = null;
            _grassTiles[previousHeadPoint.Y, previousHeadPoint.X].BackColor = Color.FromName(Properties.Resources.mainForeColor);

            Point tailPoint = _snakePoints.Last();
            _grassTiles[tailPoint.Y, tailPoint.X].BackColor = Color.FromName(Properties.Resources.mainBackColor);
            _snakePoints.RemoveLast();
        }

        private void MoveSnake() 
        {
            _snakePoints.AddFirst(GetNextHeadPoint());
        }

        private bool IsSnakeHeadOutOfBounds()
        {
            Point headPoint = GetNextHeadPoint();
            return headPoint.X < 0 || headPoint.X >= GameFieldCols
                || headPoint.Y < 0 || headPoint.Y >= GameFieldRows;
        }

        private bool DidSnakeBiteItself()
        {
            return _snakePoints.Find(GetNextHeadPoint()) != null;
        }

        private bool IsGameOver() 
        {
            return IsSnakeHeadOutOfBounds() || DidSnakeBiteItself();
        }

        public void RestartGame()
        {
            _currentDirection = Direction.LEFT;

            ClearPreviouslyDrawnOnPoints();
            SetInitialSnakePosAndDraw();

            updateSnakePosTimer.Start();
        }

        public SnakeGameAction NextAction { get; private set; }

        private void StartPlayerDiedEvent()
        {
            Hide();

            using (SnakeGameOverForm snakeGameOverForm = new())
            {
                snakeGameOverForm.ShowDialog();
                NextAction = snakeGameOverForm.NextAction;

                if (NextAction == SnakeGameAction.QuitGame || NextAction == SnakeGameAction.GoToMainMenu)
                {
                    Close();
                    return;
                }
            }

            NextAction = SnakeGameAction.QuitGame;
            RestartGame();
            Show();
        }

        private void FormShownEvent(object sender, EventArgs e)
        {
            NextAction = SnakeGameAction.QuitGame;
        }

        private void UpdateGameField(object sender, EventArgs e)
        {
            updateSnakePosTimer.Stop();

            if (IsGameOver()) 
            {
                StartPlayerDiedEvent();
            } 
            else 
            {
                MoveSnake();
                DrawSnake();
            }

            updateSnakePosTimer.Start();
        }
    }
}
