using TerminalTetris.Interfaces;
using TetrisGameLogic.Classes;

namespace TerminalTetris.Classes
{
    public class HighScoresScreen : Screen
    {
        #region Fields and properties

        private readonly HighScoreManager _highScoreManager = new();

        #endregion

        #region Public methods

        public void Display()
        {
            ConsoleKeyInfo input;
            RefreshText();

            do
            {
                input = Console.ReadKey(true);
            } while (input.Key != ConsoleKey.Enter);
        }

        #endregion

        #region Private methods

        private void RefreshText()
        {
            Console.SetCursorPosition(0, 0);

            // https://manytools.org/hacker-tools/ascii-banner/
            Console.WriteLine("\t █████   █████  ███           █████          █████████                                              ");
            Console.WriteLine("\t░░███   ░░███  ░░░           ░░███          ███░░░░░███                                             ");
            Console.WriteLine("\t ░███    ░███  ████   ███████ ░███████     ░███    ░░░   ██████   ██████  ████████   ██████   █████ ");
            Console.WriteLine("\t ░███████████ ░░███  ███░░███ ░███░░███    ░░█████████  ███░░███ ███░░███░░███░░███ ███░░███ ███░░  ");
            Console.WriteLine("\t ░███░░░░░███  ░███ ░███ ░███ ░███ ░███     ░░░░░░░░███░███ ░░░ ░███ ░███ ░███ ░░░ ░███████ ░░█████ ");
            Console.WriteLine("\t ░███    ░███  ░███ ░███ ░███ ░███ ░███     ███    ░███░███  ███░███ ░███ ░███     ░███░░░   ░░░░███");
            Console.WriteLine("\t █████   █████ █████░░███████ ████ █████   ░░█████████ ░░██████ ░░██████  █████    ░░██████  ██████ ");
            Console.WriteLine("\t░░░░░   ░░░░░ ░░░░░  ░░░░░███░░░░ ░░░░░     ░░░░░░░░░   ░░░░░░   ░░░░░░  ░░░░░      ░░░░░░  ░░░░░░  ");
            Console.WriteLine("\t                     ███ ░███                                                                       ");
            Console.WriteLine("\t                    ░░██████                                                                        ");
            Console.WriteLine("\t                     ░░░░░░                                                                         ");
            Console.WriteLine();

            PrintScores();
            PrintOptions();
        }

        private void PrintScores()
        {
            var highScores = _highScoreManager.HighScores;
            for (int i = 0; i < highScores.Count; ++i)
            {
                string pos = (i + 1).ToString().PadLeft(2);
                string score = highScores[i].Score.ToString().PadLeft(15);
                string linesCleared = highScores[i].LinesCleared.ToString().PadLeft(8);
                DateTime dateTime = highScores[i].DateTime;

                if ((DateTime.Now - dateTime).Minutes <= 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("  New -> ");
                }
                else
                {
                    Console.Write("         ");
                }

                Console.WriteLine($"{pos} - Score: {score} | Lines cleared: {linesCleared} | " +
                $"Date and time: {dateTime:HH:mm:ss dd.MM.yyyy}");
                
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void PrintOptions()
        {
            Console.WriteLine("\t\t\t\t[>] Back to Main Menu");
        }

        #endregion
    }
}
