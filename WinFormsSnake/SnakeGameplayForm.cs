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

        private Point _applePos;
        private int _applesEaten = 0;
        private readonly Point InitialApplePos = new(5, 4);
        
        private readonly LinkedList<Point> _snakeParts = new();
        private readonly Point InitialSnakeHeadPos = new(11, 4);
        private const int InitialSnakeSize = 4;

        private Direction _currentDirection = Direction.Left;
        private Direction _nextDirection = Direction.Left;
        
        public SnakeGameAction NextAction { get; private set; }

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
                    _grassTiles[i, ii].BackColor = GetGrassTileColor();
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
            _grassTiles[_applePos.Y, _applePos.X].BackColor = GetGrassTileColor();

            for (int i = 1; i < _snakeParts.Count; ++i)
            {
                Point snakePos = _snakeParts.ElementAt(i);
                _grassTiles[snakePos.Y, snakePos.X].BackColor = GetGrassTileColor();
            }

            if (_snakeParts.Count != 0 && !IsSnakeHeadOutOfBounds())
            {
                Point headPos = _snakeParts.First();
                _grassTiles[headPos.Y, headPos.X].BackgroundImage = null;
            }
        }

        private Point GetNextHeadPos()
        {
            Point headPos = _snakeParts.First();
            Point offset = GetPointOffsetForDirection(_currentDirection);

            return headPos.Sum(offset);
        }

        private void ResetSnakeParts()
        {
            _snakeParts.Clear();
            _applesEaten = 0;

            for (int i = 0; i < InitialSnakeSize; ++i)
            {
                Point snakePos = new() { X = InitialSnakeHeadPos.X + i, Y = InitialSnakeHeadPos.Y };
                _snakeParts.AddLast(snakePos);
                _grassTiles[snakePos.Y, snakePos.X].BackColor = GetSnakeBodyColor();
            }

            Point headPos = _snakeParts.First();
            _grassTiles[headPos.Y, headPos.X].BackgroundImage = GetSnakeHeadImageForCurrentDirection();
        }

        private void ResetApple()
        {
            _applePos = InitialApplePos;
            _grassTiles[_applePos.Y, _applePos.X].BackgroundImage = GetAppleImage();
        }

        public void RestartGame()
        {
            ClearGrassTiles();

            _nextDirection = Direction.Left;
            _currentDirection = _nextDirection;

            ResetSnakeParts();
            ResetApple();

            updateSnakePosTimer.Start();
        }

        private bool HasAppleBeenEaten() => _snakeParts.First() == _applePos;

        private void RespawnApple()
        {
            _applePos.X = -10;
            _applePos.Y = -10;
        }

        private void IncrementApplesEatenCounter()
        {
            ++_applesEaten;
            scoreLabel.Text = _applesEaten.ToString();
        }

        private bool IsSnakeHeadOutOfBounds()
        {
            Point headPoint = _snakeParts.First();
            return headPoint.X < 0 || headPoint.X >= GameFieldCols
                || headPoint.Y < 0 || headPoint.Y >= GameFieldRows;
        }

        private bool DidSnakeBiteItself() 
        {
            Point headPoint = _snakeParts.First();

            return _snakeParts.Where(snakePoint => snakePoint == headPoint).Count() == 2;
        }
            
        private void FormShownEvent(object sender, EventArgs e) => NextAction = SnakeGameAction.QuitGame;

        private void UpdateSnakeHead()
        {
            Point headPos = GetNextHeadPos();
            Point previousHeadPos = _snakeParts.First();

            _snakeParts.AddFirst(headPos);

            _grassTiles[previousHeadPos.Y, previousHeadPos.X].BackgroundImage = null;
            _grassTiles[previousHeadPos.Y, previousHeadPos.X].BackColor = GetSnakeBodyColor();

            if (IsSnakeHeadOutOfBounds())
            {
                throw new SnakeOutOfBoundsException();
            }

            _grassTiles[headPos.Y, headPos.X].BackgroundImage = GetSnakeHeadImageForCurrentDirection();
        }

        public void UpdateSnakeTail()
        {
            Point tailPos = _snakeParts.Last();

            _snakeParts.RemoveLast();
            _grassTiles[tailPos.Y, tailPos.X].BackColor = GetGrassTileColor();

            if (DidSnakeBiteItself())
            {
                throw new SnakeBitItselfException();
            }

            _grassTiles[tailPos.Y, tailPos.X].BackColor = GetGrassTileColor();
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
            catch(SnakeOutOfBoundsException) 
            {
                StartPlayerDiedEvent();
            } 
            catch(SnakeBitItselfException) 
            {
                StartPlayerDiedEvent();
            } 
            catch(Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine($"Unexpected error: {ex}");
            }

            updateSnakePosTimer.Start();
        }

        private bool AreOppositeDirections(Direction lhs, Direction rhs) 
            => (sbyte)lhs + rhs == 0;

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            var direction = GetDirectionForKeyChar(char.ToLower(e.KeyChar));

            if (!AreOppositeDirections(_currentDirection, direction)) 
            {
                _nextDirection = direction;
            }
        }
    }
}
