namespace F;

using System.Text.RegularExpressions;
public class Strings
{
    /// <summary>
    /// Removes all non alphanumeric characters and returns a concatenated string of the result.
    /// </summary>
    /// <param name="phrase">The phrase to be stripped</param>
    /// <returns>a new concatenated string of all alphanumeric characters</returns>
    public static string OnlyAlphanumeric(this string phrase)
        => Regex.Replace(phrase, @"([^a-zA-Z0-9]+)", @"");


    /// <summary>
    /// Returns a new substring that immediately follows the provided phrase.
    /// </summary>
    /// <param name="text">The text to be extracted from</param>
    /// <param name="phrase">the single/multicharacter phrase to start the extraction from</param>
    /// <returns>a new substring starting after the provided phrase</returns>
    public static string After(this string text, string phrase)
    {
        int startIndex = text.IndexOf(phrase) + phrase.Length;
        return text.Substring(startIndex, str.Length - startIndex);
    }

    /// <summary>
    /// Returns a new substring that is between the first occurrance of startPhrase,
    /// and the next occurrance of endPhrase that follows startPhrase
    /// </summary>
    /// <param name="text">The text to be extracted from</param>
    /// <param name="startPhrase">The initial phrase to start extracting after</param>
    /// <param name="endPhrase">The end phrase to stop extraction when matched.</param>
    /// <returns>A new string containing the extracted text between (but not including) startPhrase and endPhrase</returns>
    public static string Between(this string text, string startPhrase, string endPhrase)
    {
        string substringStart = text.SubstringAfter(startPhrase);
        int endIndex = substringStart.IndexOf(endPhrase);

        return substringStart[..endIndex];
    }
}