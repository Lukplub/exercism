public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter (this string text, string afterText)
    {
        return text.Substring(text.IndexOf(afterText) + afterText.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string text, string startText, string endText)
    {
        int start = text.IndexOf(startText) + startText.Length;
        int length = text.IndexOf(endText, start) - start;
        return text.Substring(start, length);
    }

    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message (this string text)
    {
        return text.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string text)
    {
        return text.SubstringBetween("[", "]");
    }
}