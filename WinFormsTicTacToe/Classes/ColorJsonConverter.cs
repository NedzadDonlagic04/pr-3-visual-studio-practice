using System.Text.Json.Serialization;
using System.Text.Json;

namespace WinFormsTicTacToe.Classes
{
    /// <summary>
    ///     Converts hexadecimal color value to and from JSON
    /// </summary>
    internal class ColorJsonConverter : JsonConverter<Color>
    {
        #region Public methods

        /// <summary>
        ///     Reads and converts the JSON data to type Color
        /// </summary>
        /// <param name="reader">The reader</param>
        /// <param name="typeToConvert">The type to convert</param>
        /// <param name="options">An object that specifies serialization options to use</param>
        /// <returns>The converted value</returns>
        /// <inheritdoc cref="ColorTranslator.FromHtml"/>
        /// <inheritdoc cref="Utf8JsonReader.GetString"/>
        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => ColorTranslator.FromHtml(reader.GetString() ?? "");

        /// <summary>
        ///     Writes Color value as hex string as JSON
        /// </summary>
        /// <param name="writer">The writer to write to</param>
        /// <param name="color">Color to convert to JSON</param>
        /// <param name="options">An object that specifies serialization options to use</param>
        /// <inheritdoc cref="byte.ToString(string?)"/>
        /// <inheritdoc cref="Utf8JsonWriter.WriteStringValue"/>
        public override void Write(Utf8JsonWriter writer, Color color, JsonSerializerOptions options)
            => writer.WriteStringValue("#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2").ToLower());

        #endregion
    }
}
