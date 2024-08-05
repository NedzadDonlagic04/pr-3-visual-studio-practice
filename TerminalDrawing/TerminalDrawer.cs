using System.Drawing;

namespace TerminalDrawing
{   
    internal class TerminalDrawer
    {
        private const int CanvasHeight = 15;
        private const int CanvasWidth = CanvasHeight * 2;

        private const string DrawingDirectoryPath = "./terminalDrawingOutput";
        private const string DefaultFileName = "defaultFileName";
        private string _fileName;
        private string FilePath => $"{DrawingDirectoryPath}/{_fileName}.txt";

        private readonly TerminalCanvas _terminalCanvas;

        public TerminalDrawer() 
        {
            _fileName = DefaultFileName;
            _terminalCanvas = new(CanvasWidth, CanvasHeight);
        }

        public void Start() {
            PrintWelcomeMessage();
            EnterDrawingFileName();
            StartDrawingProcess();
        }   

        private static void PrintWelcomeMessage() {
            // Possibly expand welcome message as I have no idea
            // what more I could say to my imaginary friend testing this
            Console.WriteLine("Welcome to \"Termina Drawer\" an excersize to help me better understand C#");
        }

        private void EnterDrawingFileName()
        {
            Console.Write("Enter the name of file where the drawing will be saved: ");
            _fileName = Console.ReadLine() ?? DefaultFileName;

            if (!File.Exists(FilePath)) 
            {
                return;
            }

            char option;

            Console.WriteLine("The entered file already exists");
            Console.Write("Do you wish to load it's content, keep in mind not loading it will override the current content?(y\\n): ");
            option = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (option == 'y') 
            {
                _terminalCanvas.LoadFromFile(FilePath);
            }
        }

        private void StartDrawingProcess() {
            Console.Clear();

            RunCanvasDrawingLoop();
            
            Console.Clear();

            char option;

            Console.Write("Do you wish to save the changes made?(y\\n): ");
            option = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (option == 'y')
            {
                _terminalCanvas.SaveToFile(FilePath);
            }
        }

        private void RunCanvasDrawingLoop() {
            ConsoleKeyInfo enteredKeyInfo;

            var cursorPosition = new Point(0, 0);
            char keyChar = 'A';

            do
            {
                Console.CursorVisible = false;
                Console.SetCursorPosition(0, 0);

                _terminalCanvas.PrintCanvas();

                Console.SetCursorPosition(cursorPosition.X + 1, cursorPosition.Y + 1);
                Console.Write(keyChar);
                Console.SetCursorPosition(cursorPosition.X + 1, cursorPosition.Y + 1);
                Console.CursorVisible = true;

                enteredKeyInfo = Console.ReadKey(true);
                HandleKeyInput(enteredKeyInfo, ref cursorPosition, ref keyChar);
            } while (enteredKeyInfo.Key != ConsoleKey.Escape);
        }

        private void HandleKeyInput(ConsoleKeyInfo consoleKeyInfo, ref Point cursorPosition, ref char keyChar) {
            switch(consoleKeyInfo.Key) {
                case ConsoleKey.UpArrow:
                    cursorPosition.Y = Math.Max(cursorPosition.Y - 1, 0);
                    break;
                case ConsoleKey.DownArrow: 
                    cursorPosition.Y = Math.Min(cursorPosition.Y + 1, CanvasHeight - 1);
                    break;
                case ConsoleKey.LeftArrow: 
                    cursorPosition.X = Math.Max(cursorPosition.X - 1, 0);
                    break;
                case ConsoleKey.RightArrow: 
                    cursorPosition.X = Math.Min(cursorPosition.X + 1, CanvasWidth - 1);
                    break;
                case ConsoleKey.Enter:
                    _terminalCanvas.SetPixel(cursorPosition, keyChar);
                    break;
                default:
                    keyChar = consoleKeyInfo.KeyChar;
                    break;
            }
        }
    }
}
