using System.Drawing;
using System.Security.Cryptography;

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
            char option = 'n';

            do {
                Console.Write("Enter the name of file where the drawing will be saved: ");
                _fileName = Console.ReadLine() ?? DefaultFileName;

                if (File.Exists(FilePath)) {
                    Console.WriteLine("The entered name already exists, which means saving will override what is currently inside the file");
                    Console.Write("Do you wish to change the file name(y\\n): ");
                    option = char.Parse(Console.ReadLine() ?? "n");
                    Console.WriteLine();
                }
            } while (option != 'n');
        }

        private void StartDrawingProcess() {
            ConsoleKeyInfo enteredKeyInfo;

            var cursorPosition = new Point(0, 0);
            char keyChar = 'A';

            Console.Clear();
            
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
            
            Console.Clear();
            
            _terminalCanvas.SaveToFile(FilePath);
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
