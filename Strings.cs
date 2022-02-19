namespace F;

using System.Text.RegularExpressions;
public class Strings
{
    public static string OnlyAlphaNumeric(string message)
        => Regex.Replace(message, @"([^a-zA-Z0-9]+)", @"");
}