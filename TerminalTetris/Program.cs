using TerminalTetris.Classes;

namespace TerminalTetris
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenuScreen mainMenuScreen = new();

            mainMenuScreen.Display();
        }
    }
}
