using WinFormsTicTacToe.Enums;
using WinFormsTicTacToe.Exceptions;

namespace WinFormsTicTacToe.Classes
{
    /// <summary>
    ///     Class that represents a tic tac toe board
    /// </summary>
    internal class TicTacToeBoard
    {
        #region Fields and properties    

        private const int MinBoardSize = 3;
        /// <summary>
        ///     Represents a single dimension
        /// </summary>
        internal readonly int Size;
        /// <summary>
        ///     Represents total number of tiles,
        ///     basically BoardSize * BoardSize
        /// </summary>
        internal readonly int TotalSize;

        private char[] _board = null!;

        internal const char EmptyBoardValue = '\0';
        private const char StartingSymbol = 'X';

        internal char Symbol { get; private set; }

        private readonly Stack<int> _actionHistory = new();

        private List<List<int>> _winningPositions = null!;

        internal List<int>? WinningPosition { get; private set; }

        internal TicTacToeGameState GameState { get; private set; }

        #endregion

        #region Internal methods

        /// <summary>
        ///     Constructs an instance of TicTacToeBoard
        /// </summary>
        /// <param name="boardSize">
        ///     Represents the widht and height of the board
        /// </param>
        /// <exception cref="FormatException">
        ///     Will be thrown when the size does not reach
        ///     the minimum required size
        /// </exception>
        internal TicTacToeBoard(int boardSize = 3)
        {
            if (boardSize < MinBoardSize)
            {
                throw new FormatException($"Board size has to be a positive integer equal or greater than {MinBoardSize}");
            }

            Size = boardSize;
            TotalSize = boardSize * boardSize;

            InitializeBoard();
            InitializeWinningPositions();
        }

        /// <summary>
        ///     Resets the board
        /// </summary>
        internal void ResetBoard()
        {
            for (int i = 0; i < TotalSize; ++i)
            {
                _board[i] = EmptyBoardValue;
            }

            _actionHistory.Clear();

            GameState = TicTacToeGameState.GameOngoing;
            WinningPosition = null;

            Symbol = StartingSymbol;
        }

        /// <summary>
        ///     Allows the board to be accessed as if it were a matrix
        /// </summary>
        /// <param name="i">The row index</param>
        /// <param name="j">The column index</param>
        /// <returns>The character on the given index</returns>  
        internal char this[int i, int j]
        {
            get => _board[Get1DimensionalIndex(i, j)];
        }

        /// <summary>
        ///     Accesses the internal array that represents the board
        /// </summary>
        /// <param name="i">The index for the board array</param>
        /// <returns>The character on the given index</returns>
        internal char this[int i]
        {
            get => _board[i];
        }

        /// <summary>
        ///     Checks if the given index has an X or O
        ///     placed on it
        /// </summary>
        /// <param name="i">Index for board</param>
        /// <returns>True or false depending on the spot being taken</returns>
        internal bool IsSpotTaken(int i) => _board[i] != EmptyBoardValue;

        /// <summary>
        ///     Checks if the given index has an X or O
        ///     placed on it
        /// </summary>
        /// <param name="i">Index for board</param>
        /// <param name="j">Index for board</param>
        /// <returns>True or false depending on the spot being taken</returns>
        internal bool IsSpotTaken(int i, int j) => IsSpotTaken(Get1DimensionalIndex(i, j));

        /// <summary>
        ///     Places the current symbol on the following index and switches
        ///     to the next
        /// </summary>
        /// <param name="i">Board index</param>
        /// <returns>The placed symbol</returns>
        /// <exception cref="TicTacToeBoardException">
        ///     Thrown if the index already has a symbol placed on it
        ///     or if there was an attempt to place a symbol when the game
        ///     was not ongoing
        /// </exception>
        internal char PlaceSymbol(int i)
        {
            if (IsSpotTaken(i))
            {
                throw new TicTacToeBoardException($"Spot {i} is already taken by {_board[i]}");
            }
            else if (GameState != TicTacToeGameState.GameOngoing)
            {
                throw new TicTacToeBoardException("Can't place symbol when the game is not ongoing");
            }

            _board[i] = Symbol;
            UpdateGameStatus();

            char temp = Symbol;
            Symbol = InvertSymbol(Symbol);

            _actionHistory.Push(i);

            return temp;
        }

        /// <summary>
        ///     Places the current symbol on the following index and switches
        ///     to the next
        /// </summary>
        /// <param name="i">Board row index</param>
        /// <param name="j">Board column index</param>
        /// <returns>The placed symbol</returns>
        /// <exception cref="TicTacToeBoardException">
        ///     Thrown if the index already has a symbol placed on it
        ///     or if there was an attempt to place a symbol when the game
        ///     was not ongoing
        /// </exception>
        internal char PlaceSymbol(int i, int j)
        {
            if (IsSpotTaken(i, j))
            {
                throw new TicTacToeBoardException($"Spot [{i}, {j}] is already taken by {this[i, j]}");
            }

            return PlaceSymbol(Get1DimensionalIndex(i, j));
        }

        /// <summary>
        ///     Returns the last placed symbol on the board
        /// </summary>
        /// <returns>Last placed symbol on the board</returns>
        /// <exception cref="TicTacToeBoardException">
        ///     If a symbol has not been placed and this method is called
        ///     the exception is thrown
        /// </exception>
        internal char LastPlacedSymbol()
        {
            if (_actionHistory.Count == 0)
            {
                throw new TicTacToeBoardException("No symbol has been placed yet");
            }

            int index = _actionHistory.Peek();

            return _board[index];
        }

        /// <summary>
        ///     Removes the last placed symbol from the board
        ///     and updates the current symbol to reflect that undo
        /// </summary>
        /// <exception cref="TicTacToeBoardException">
        ///     If a symbol has not been placed and this method is called
        ///     the exception is thrown
        /// </exception>
        internal void UndoLastSymbolPlace()
        {
            if (_actionHistory.Count == 0)
            {
                throw new TicTacToeBoardException("There's no last symbol to undo");
            }

            int index = _actionHistory.Pop();
            Symbol = _board[index];
            _board[index] = EmptyBoardValue;
            
            WinningPosition = null;
            GameState = TicTacToeGameState.GameOngoing;
        }

        /// <summary>
        ///     Checks if the game board is full
        /// </summary>
        /// <returns>True or false depending on if the board is full</returns>
        internal bool IsGameBoardFull()
        {
            foreach (var boardPiece in _board)
            {
                if (boardPiece == EmptyBoardValue)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        ///     Checks if the board is empty
        /// </summary>
        /// <returns>True or false depending on if the board is empty</returns>
        internal bool IsGameBoardEmpty()
        {
            foreach (var boardPiece in _board)
            {
                if (boardPiece != EmptyBoardValue)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region Private methods

        /// <summary>
        ///     Converts indexes for a 2D array to a 1D array index
        /// </summary>
        /// <param name="i">Board row index</param>
        /// <param name="j">Board column index</param>
        /// <returns>Converted index</returns>
        private int Get1DimensionalIndex(int i, int j) => i * Size + j;

        /// <summary>
        ///     Sets the board's size and after which 
        ///     ResetBoard is called
        /// </summary>
        private void InitializeBoard()
        {
            _board = new char[TotalSize];

            ResetBoard();
        }

        /// <summary>
        ///     Initializes the winning positions for rows and columns
        ///     (so vertical and horizontal victories)
        /// </summary>
        private void InitializeRowsAndColsWinningPositions()
        {
            for (int i = 0; i < Size; ++i)
            {
                // Row winning position
                _winningPositions.Add(Utils.Range(i * Size, Size, 1));

                // Col winning position
                _winningPositions.Add(Utils.Range(i, Size, Size));
            }
        }

        /// <summary>
        ///     Initializes the winning position for 
        ///     the main diagonal
        /// </summary>
        private void InitializeDiagonalWinningPosition()
        {
            List<int> winningPosition = new(Size);

            for (int i = 0; i < Size; ++i)
            {
                winningPosition.Add(i * Size + i); // [i][i]
            }

            _winningPositions.Add(winningPosition);
        }

        /// <summary>
        ///     Initializes the winning position for 
        ///     the side diagonal
        /// </summary>
        private void InitializeSideDiagonalWinningPosition()
        {
            List<int> winningPosition = new(Size);

            for (int i = 0; i < Size; ++i)
            {
                winningPosition.Add(i * Size + Size - 1 - i); // [i][BoardSize - 1 - i]
            }

            _winningPositions.Add(winningPosition);
        }

        /// <summary>
        ///     Initializes the field representing the indexes that represent
        ///     winning combinations
        /// </summary>
        private void InitializeWinningPositions()
        {
            // 2 * BoardSize because we have a position for each row and column
            // and the + 2 for the 2 diagonals
            int winningPositionCount = 2 * Size + 2;
            _winningPositions = new List<List<int>>(winningPositionCount);

            InitializeRowsAndColsWinningPositions();
            InitializeDiagonalWinningPosition();
            InitializeSideDiagonalWinningPosition();
        }

        /// <summary>
        ///     Inverts the given symbol
        /// </summary>
        /// <param name="symbol">Symbol to invert</param>
        /// <returns>Returns inverted symbol</returns>
        private static char InvertSymbol(char symbol) => symbol == 'X' ? 'O' : 'X';

        /// <summary>
        ///     Checks if X or O won the game and updates the GameState property
        /// </summary>
        private void UpdateGameStatus()
        {
            // Checks if either X or O won
            foreach (var winningPosition in _winningPositions)
            {
                int start = winningPosition[0];
                bool winnerFound = true;

                if (_board[start] == EmptyBoardValue)
                {
                    continue;
                }

                foreach (var index in winningPosition)
                {
                    if (_board[start] != _board[index])
                    {
                        winnerFound = false;
                        break;
                    }
                }

                if (winnerFound)
                {
                    WinningPosition = winningPosition;
                    GameState = (_board[start] == 'X') ? TicTacToeGameState.PlayerXWon : TicTacToeGameState.PlayerOWon;
                    return;
                }
            }

            // If no one won and the game board if full
            // then the game is a tie
            if (IsGameBoardFull())
            {
                GameState = TicTacToeGameState.Tie;
            }
        }

        #endregion
    }
}
