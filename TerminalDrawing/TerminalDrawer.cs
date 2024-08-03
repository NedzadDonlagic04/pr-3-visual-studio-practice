namespace TerminalDrawing
{   
    internal class TerminalDrawer
    {
        private const string DrawingDirectoryPath = "./terminalDrawingOutput";
        private const string DefaultFileName = "defaultFileName";
        private string _fileName;
        private string FilePath => $"{DrawingDirectoryPath}/{_fileName}.txt";

        public TerminalDrawer() 
        {
            _fileName = DefaultFileName;
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
            Console.WriteLine("StartDrawingProcess");
        }
    }
}
