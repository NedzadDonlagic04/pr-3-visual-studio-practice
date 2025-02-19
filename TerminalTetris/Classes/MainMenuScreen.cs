using TerminalTetris.Interfaces;

namespace TerminalTetris.Classes
{
    public class MainMenuScreen : Screen
    {
        #region Fields and properties

        private readonly List<string> _options = new()
        {
            "Play",
            "High scores",
            "Quit"
        };
        private int _optionIndex = 0;

        #endregion

        #region Public methods

        public void Display()
        {
            Console.CursorVisible = false;

            ConsoleKeyInfo input;
            RefreshText();

            do
            {
                input = Console.ReadKey(true);

                HandleKeyInput(input.Key);
            } while (input.Key != ConsoleKey.Enter || _optionIndex != _options.Count - 1);

            Console.CursorVisible = true;
        }

        #endregion

        #region Private methods

        private void HandleKeyInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    MoveOptionBack();
                    RefreshText();
                    break;
                case ConsoleKey.DownArrow:
                    MoveOptionForward();
                    RefreshText();
                    break;
                case ConsoleKey.Enter:
                    if (_optionIndex == _options.Count - 1)
                    {
                        break;
                    }
                    Console.Clear();
                    Screen screen = (_optionIndex == 0)? new PlayScreen() : new HighScoresScreen();
                    screen.Display();
                    Console.Clear();
                    RefreshText();
                    break;
            }
        }

        private void MoveOptionForward()
            => _optionIndex = Math.Clamp(_optionIndex + 1, 0, _options.Count - 1);

        private void MoveOptionBack()
            => _optionIndex = Math.Clamp(_optionIndex - 1, 0, _options.Count - 1);  

        private void RefreshText()
        {
            Console.SetCursorPosition(0, 0);

            // https://manytools.org/hacker-tools/ascii-banner/
            Console.WriteLine("\t████████╗███████╗████████╗██████╗ ██╗███████╗");
            Console.WriteLine("\t╚══██╔══╝██╔════╝╚══██╔══╝██╔══██╗██║██╔════╝");
            Console.WriteLine("\t   ██║   █████╗     ██║   ██████╔╝██║███████╗");
            Console.WriteLine("\t   ██║   ██╔══╝     ██║   ██╔══██╗██║╚════██║");
            Console.WriteLine("\t   ██║   ███████╗   ██║   ██║  ██║██║███████║");
            Console.WriteLine("\t   ╚═╝   ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝╚══════╝");
            Console.WriteLine();

            PrintOptions();
        }

        private void PrintOptions()
        {
            char selected;
            for (int i = 0; i < _options.Count; ++i)
            {
                selected = (i == _optionIndex) ? '>' : '\0';
                Console.WriteLine($"\t\t[{selected}] {_options[i]} ");
            }
        }

        #endregion
    }
}
