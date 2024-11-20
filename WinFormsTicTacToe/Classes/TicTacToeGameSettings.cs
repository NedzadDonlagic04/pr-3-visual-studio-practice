using System.Text.Json;
using System.Text.Json.Serialization;

using WinFormsTicTacToe.Enums;

namespace WinFormsTicTacToe.Classes
{
    /// <summary>
    ///     Class that represents settings for the 
    ///     tic tac toe game
    /// </summary>
    internal class TicTacToeGameSettings
    {
        #region Fields, constants and properties

        [JsonInclude]
        [JsonConverter(typeof(ColorJsonConverter))]
        public Color XColor { get; private set; }

        [JsonInclude]
        [JsonConverter(typeof(ColorJsonConverter))]
        public Color OColor { get; private set; }

        [JsonInclude]
        public BotDifficulty? BotDifficulty { get; private set; }

        [JsonInclude]
        public bool IsBotPlayingFirst { get; private set; }

        private static readonly TicTacToeGameSettings DefaultSettings = new(Color.Blue, Color.Red, null, false);

        #endregion

        #region Public methods

        /// <summary>
        ///     Constructs an instance of TicTacToeBoardSettings
        /// </summary>
        /// <param name="xColor"></param>
        /// <param name="oColor"></param>
        /// <param name="botDifficulty"></param>
        /// <param name="isBotPlayingFirst"></param>
        public TicTacToeGameSettings(Color xColor, Color oColor, BotDifficulty? botDifficulty, bool isBotPlayingFirst)
        {
            XColor = xColor;
            OColor = oColor;
            BotDifficulty = botDifficulty;
            IsBotPlayingFirst = isBotPlayingFirst;
        }

        #endregion

        #region Internal methods

        /// <summary>
        ///     Constructs an instance of TicTacToeBoardSettings
        ///     and assigns the default value to itself
        /// </summary>
        internal TicTacToeGameSettings() => Assign(DefaultSettings);

        /// <summary>
        ///     Assigns the given TicTacToeBoardSettings instance
        ///     to itself
        /// </summary>
        /// <param name="ticTacToeBoardSettings"></param>
        internal void Assign(TicTacToeGameSettings ticTacToeBoardSettings)
        {
            XColor = ticTacToeBoardSettings.XColor;
            OColor = ticTacToeBoardSettings.OColor;
            BotDifficulty = ticTacToeBoardSettings.BotDifficulty;
            IsBotPlayingFirst = ticTacToeBoardSettings.IsBotPlayingFirst;
        }

        /// <summary>
        ///     Loads the settings from a given file
        /// </summary>
        /// <param name="filePath"></param>
        /// <exception cref="Exception">
        ///     Thrown if something during the file reading process goes wrong
        /// </exception>
        /// <inheritdoc cref="File.ReadAllText"/>
        internal void LoadFromJSONFile(string filePath)
        {
            string pathExtension = Path.GetExtension(filePath) ?? "";
            if (pathExtension != ".json")
            {
                throw new Exception("Given file is not a JSON file");
            }

            // Assign default at the start in case an exception is thrown
            // so that the object can still be used
            Assign(DefaultSettings);
            
            if (!File.Exists(filePath))
            {
                throw new Exception($"\"{filePath}\" does not exist default settings have been loaded");
            }

            string content = File.ReadAllText(filePath);

            TicTacToeGameSettings? settings;

            try
            {
                settings = JsonSerializer.Deserialize<TicTacToeGameSettings>(content, 
                    new JsonSerializerOptions() { Converters = { new ColorJsonConverter() } }
                );
            }
            catch(JsonException ex)
            {
                throw new JsonException("Settings file is not valid, default settings have been loaded", ex.InnerException);
            }
            catch(Exception ex)
            {
                throw new Exception("An unexpected error occured while loading saved settings, default settings have been loaded", ex);
            }

            if (settings != null)
            {
                Assign(settings);
            }
        }

        /// <summary>
        ///     Saves the current settings to a given JSON file
        /// </summary>
        /// <param name="filePath"></param>
        /// <inheritdoc cref="JsonSerializer.Serialize"/>
        /// <inheritdoc cref="File.WriteAllText"/>
        internal void SaveToJSONFile(string filePath)
        {
            string pathExtension = Path.GetExtension(filePath) ?? "";
            if (pathExtension != ".json")
            {
                throw new FileFormatException(new Uri(filePath), "Given file is not a JSON file");
            }

            string settingsAsJson = JsonSerializer.Serialize(this);

            File.WriteAllText(filePath, settingsAsJson);
        }

        #endregion
    }
}
