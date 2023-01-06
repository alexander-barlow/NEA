using System.Text;
//function to remove spaces & punctuation
public static class StringExtension
{    public static string Strip(this string text)
    {
        var stringBuilder = new StringBuilder();
        foreach (char c in text)
        {
            if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
            {
                stringBuilder.Append(c);
            }
        }
        return stringBuilder.ToString();
    }

}
