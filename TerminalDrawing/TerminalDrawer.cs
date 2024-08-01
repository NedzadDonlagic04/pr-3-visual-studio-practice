using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalDrawing
{
    internal class TerminalDrawer
    {
        private const string defaultFileName = "defaultFileName";

        public void Start() {
            PrintWelcomeMessage();

            Console.Write("Enter the name of the .txt file to which your work will be saved: ");
            string? filePath = Console.ReadLine() ?? defaultFileName;

            Console.WriteLine($"Entered file path {filePath}");
        }

        private static void PrintWelcomeMessage() {
            // Possibly expand welcome message as I have no idea
            // what more I could say to my imaginary friend testing this
            Console.WriteLine("Welcome to \"Termina Drawer\" an excersize to help me better understand C#");
        }
    }
}
