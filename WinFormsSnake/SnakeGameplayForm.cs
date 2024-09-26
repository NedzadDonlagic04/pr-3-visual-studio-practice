using Extensions;
using WinFormsSnake.SnakeExceptions;

namespace WinFormsSnake
{
    /*
     * Due to the nature of how I want the snake to accept movements
     * given by the player (ie. if the snake is going RIGHT the only
     * valid directions to go in next are either UP, DOWN or continue
     * going RIGHT) I decided to make the values for each enum element
     * follow the rule that opposites directions when summed would give
     * a value 0, to make my life easier with checking
     * 
     * This could be switched for any operation and any value as long
     * as this idea is true
     * 
     * Choosing sbyte as the type felt right because I won't be needing
     * more than 1 single bite for this
     */
    public enum Direction : sbyte
    {
        Up = 2,
        Down = -2,
        Left = -1,
        Right = 1
    }

    public partial class SnakeGameplayForm : Form
    {
        private const int GameFieldRows = 9;
        private const int GameFieldCols = 19;
        private readonly PictureBox[,] _grassTiles = new PictureBox[GameFieldRows, GameFieldCols];

        private readonly Point InitialApplePos = new(5, 4);
        private PictureBox _appleTile;
        private readonly LinkedList<PictureBox> _availableAppleTiles = new();
        
        private const int InitialSnakeSize = 3;
        private readonly Point InitialSnakeHeadPos = new(11, 4);
        private Point _snakeHeadPos;
        private readonly LinkedList<PictureBox> _snakeTiles = new();

        private Direction _currentDirection = Direction.Left;
        private Direction _nextDirection = Direction.Left;
        
        public SnakeGameAction NextAction { get; private set; }

        public SnakeGameplayForm()
        {
            InitializeComponent();
            ApplySharedTheme();
            InitializeGrassTilesAndSetThemToMainBGColor();

            // Lines below are added to shush the warnings about
            // existing constructor as null up
            _appleTile = _grassTiles[InitialApplePos.Y, InitialApplePos.X];
        }

        private void ApplySharedTheme()
        {
            BackColor = Color.FromName(Properties.Resources.mainBackColor);
            ForeColor = Color.FromName(Properties.Resources.mainForeColor);
        }

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

        private void InitializeGrassTilesAndSetThemToMainBGColor()
        {
            int rows = _grassTiles.GetLength(0);
            int cols = _grassTiles.GetLength(1);
            PictureBox? grassTile;

            for (int i = 0; i < rows; ++i)
            {
                for (int ii = 0; ii < cols; ++ii)
                {
                    grassTile = snakeTilesFlowLayoutPanel.Controls[i * cols + ii] as PictureBox;

                    if (grassTile == null)
                    {
                        continue;
                    }

                    _grassTiles[i, ii] = grassTile;
                    _grassTiles[i, ii].BackColor = GetGrassTileColor();

                    _availableAppleTiles.AddLast(grassTile);
                }
            }
        }

        private Image GetSnakeHeadImageForCurrentDirection() => _currentDirection switch
        {
            Direction.Up => Properties.Resources.snakeHeadTurnedUp,
            Direction.Down => Properties.Resources.snakeHeadTurnedDown,
            Direction.Left => Properties.Resources.snakeHeadTurnedLeft,
            Direction.Right => Properties.Resources.snakeHeadTurnedRight,
            _ => throw new NotImplementedException()
        };

        private Image GetAppleImage() => Properties.Resources.appleBackgroundImage;

        private Direction GetDirectionForKeyChar(char keyChar) => keyChar switch
        {
            'w' => Direction.Up,
            's' => Direction.Down,
            'a' => Direction.Left,
            'd' => Direction.Right,
            _ => throw new NotImplementedException()
        };

        private Point GetPointOffsetForDirection(Direction direction) => direction switch
        {
            Direction.Up => new() { X = 0, Y = -1 },
            Direction.Down => new() { X = 0, Y = 1 },
            Direction.Left => new() { X = -1, Y = 0 },
            Direction.Right => new() { X = 1, Y = 0 },
            _ => throw new NotImplementedException()
        };

        private Color GetSnakeBodyColor() => Color.FromName(Properties.Resources.mainForeColor);

        private Color GetGrassTileColor() => Color.FromName(Properties.Resources.mainBackColor);

        private void ClearGrassTiles()
        {
            _appleTile.BackColor = GetGrassTileColor();

            for (int i = 1; i < _snakeTiles.Count; ++i)
            {
                _snakeTiles.ElementAt(i).BackColor = GetGrassTileColor();
            }

            if (_snakeTiles.Count != 0 && !IsSnakeHeadOutOfBounds())
            {
                _snakeTiles.First().BackgroundImage = null;
            }
        }

        private void ResetSnakeTiles()
        {
            _snakeTiles.Clear();

            _snakeHeadPos = InitialSnakeHeadPos;

            for (int i = 0; i < InitialSnakeSize; ++i)
            {
                PictureBox snakeTile = _grassTiles[InitialSnakeHeadPos.Y, InitialSnakeHeadPos.X + i];
                snakeTile.BackColor = GetSnakeBodyColor();
                _snakeTiles.AddLast(snakeTile);

                _availableAppleTiles.Remove(snakeTile);
            }

            _snakeTiles.First().BackgroundImage = GetSnakeHeadImageForCurrentDirection();
        }

        private void ResetApple()
        {
            _appleTile.BackgroundImage = null;
            _appleTile = _grassTiles[InitialApplePos.Y, InitialApplePos.X];
            _appleTile.BackgroundImage = GetAppleImage();
        }

        private void ResetAvailableApplePoints()
        {
            foreach (PictureBox snakeTile in _snakeTiles)
            {
                _availableAppleTiles.AddLast(snakeTile);
            }
        }

        public void RestartGame()
        {
            ClearGrassTiles();

            _nextDirection = Direction.Left;
            _currentDirection = _nextDirection;

            ResetAvailableApplePoints();
            ResetSnakeTiles();
            ResetApple();

            updateSnakePosTimer.Start();
        }

        private bool HasAppleBeenEaten() => _snakeTiles.First() == _appleTile;

        private void RespawnApple()
        {
            Random random = new();
            int index = random.Next(0, _availableAppleTiles.Count);

            _appleTile = _availableAppleTiles.ElementAt(index);
            _appleTile.BackgroundImage = GetAppleImage();
        }

        private void IncrementApplesEatenCounter()
        {
            scoreLabel.Text = (_snakeTiles.Count - InitialSnakeSize).ToString();
        }

        private bool IsSnakeHeadOutOfBounds()
            =>  _snakeHeadPos.X < 0 || _snakeHeadPos.X >= GameFieldCols
             || _snakeHeadPos.Y < 0 || _snakeHeadPos.Y >= GameFieldRows;

        private bool DidSnakeBiteItself() 
        {
            PictureBox headTile = _snakeTiles.First();

            return _snakeTiles.Where(snakeTile => snakeTile == headTile).Count() == 2;
        }
            
        private void FormShownEvent(object sender, EventArgs e) => NextAction = SnakeGameAction.QuitGame;

        private void UpdateSnakeHead()
        {
            _snakeHeadPos.Sum(GetPointOffsetForDirection(_currentDirection));

            PictureBox previousSnakeHeadTile = _snakeTiles.First();
            previousSnakeHeadTile.BackgroundImage = null;
            previousSnakeHeadTile.BackColor = GetSnakeBodyColor();

            if (IsSnakeHeadOutOfBounds())
            {
                throw new SnakeOutOfBoundsException();
            }

            PictureBox newSnakeHeadTile = _grassTiles[_snakeHeadPos.Y, _snakeHeadPos.X];
            newSnakeHeadTile.BackgroundImage = GetSnakeHeadImageForCurrentDirection();

            _snakeTiles.AddFirst(newSnakeHeadTile);
            _availableAppleTiles.Remove(newSnakeHeadTile);
        }

        public void UpdateSnakeTail()
        {
            PictureBox snakeTailTile = _snakeTiles.Last();

            _snakeTiles.RemoveLast();
            snakeTailTile.BackColor = GetGrassTileColor();

            if (DidSnakeBiteItself())
            {
                throw new SnakeBitItselfException();
            }

            _availableAppleTiles.AddLast(snakeTailTile);
        }

        private void UpdateSnake()
        {
            UpdateSnakeHead();
            if (HasAppleBeenEaten())
            {
                IncrementApplesEatenCounter();
                RespawnApple();
                return;
            }
            UpdateSnakeTail();
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            updateSnakePosTimer.Stop();

            _currentDirection = _nextDirection;

            try 
            {
                UpdateSnake();
            } 
            catch(SnakeException) 
            {
                StartPlayerDiedEvent();
            }
            catch(Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine($"Unexpected exception: {ex}");
            }

            updateSnakePosTimer.Start();
        }

        private bool AreOppositeDirections(Direction lhs, Direction rhs) 
            => (sbyte)lhs + rhs == 0;

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            try
            {
                var direction = GetDirectionForKeyChar(char.ToLower(e.KeyChar));

                if (!AreOppositeDirections(_currentDirection, direction))
                {
                    _nextDirection = direction;
                }
            }
            catch(NotImplementedException ex) 
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}
